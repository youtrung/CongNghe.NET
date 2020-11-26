using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoanQLNhaSach
{
    public partial class frmBanSach : Form
    {
        public frmBanSach()
        {
            InitializeComponent();
        }
        int flag = -1;
        public static string makh;
        public static int TongTienNhap;
        void LoadDS()
        {

            List<BanSachDTO> dsHD = BanSachBUS.GetDSHoaDon(txtMaMoi.Text);
            dgvDSHD.DataSource = dsHD;

            for (int i = 0; i < dgvDSHD.Rows.Count; i++)
            {
                dgvDSHD.Rows[i].Cells[0].Value = i + 1;
            }
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
        }
        void InsertHoaDon()
        {
            if (txtMaKH2.Text == "" || txtMaMoi.Text == "" || txtMaSach.Text == "" || txtSoLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (IsNumber(txtSoLuong.Text) == false)
            {
                MessageBox.Show("Số lượng phải là số và không được âm", "Thông báo");
                return;
            }
            string mahd = txtMaMoi.Text;

            string masach = txtMaSach.Text;
            int soluong = Int32.Parse(txtSoLuong.Text);

            Sach s = TimSachBUS.getThongTinSach(masach);
            QuyDinh qd = QuyDinhBUS.GetQD();
            int check = s.TonCuoi - soluong;
            if (check < Int32.Parse(qd.TonBanToiThieu))
            {
                MessageBox.Show("Số lượng tồn của sách này sau khi bán đã nhỏ hơn quy định");
                return;
            }
            KhachHang kh = KhachHangBUS.GetTenKH(txtMaKH2.Text);
            if (Int32.Parse(kh.TongNo) > qd.KHNoToiThieu)
            {
                MessageBox.Show("Tiền nợ của khách hàng đã vượt quá quy định");
                return;
            }
            if (BanSachBUS.checkTrung(txtMaMoi.Text, txtMaSach.Text) == false)
            {
                MessageBox.Show("Sách này đã có trong hoá đơn");
                return;
            }
            BanSachBUS.InsertHoaDon(mahd, masach, soluong);
            UpdateSoLuongTon();
            UpdateTongTien();
            MessageBox.Show("Thêm hoá đơn thành công!");
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            InsertHoaDon();
            LoadDS();
        }

        private void frmBanSach_Load(object sender, EventArgs e)
        {
            txtMaKH2.Text = GetMaKH.getMaKH;
            txtMaMoi.Text = GetMaHD.getMaHD;
            KhachHang kh = KhachHangBUS.GetTenKH(txtMaKH2.Text);
            txtTenKH2.Text = kh.HoTen;

            LoadDS();
        }
    }
}
