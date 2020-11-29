using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoanQLNhaSach.GIAODIEN
{
    public partial class Frm_DachSachHD : Form
    {
        QLNSDataContext db = new QLNSDataContext();
        public Frm_DachSachHD()
        {
            InitializeComponent();
        }
        int flag = -1;
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void Frm_DachSachHD_Load(object sender, EventArgs e)
        {
            loadHoaDon();
            btnLuu.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Tag.ToString().Equals("1"))
            {
                btnSua.Enabled = false;

                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                txtTongtien.Text = "0";
                txtMaHD.Text = null; 
                btnThem.Tag = "2";
                btnThem.Text = "Hủy Thêm ";
                flag = 0;
            }
            else
            {
                btnThem.Tag = "1";
                btnSua.Enabled = true;

                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                btnThem.Text = "Thêm";
                flag = -1;
            }
        }
        public void loadHoaDon()
        {
            var data = from k in db.HoaDons
                       select new
                       {
                           MaHD = k.MaHD,
                           MaKH1 = k.MaKH,
                           TenKH = k.TenKH,
                           NgaylapHD = k.Ngaylap,
                           TongTien = k.TongTien,
                       };
            dtgvHD.DataSource = data;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                InsertHoaDon();
                loadHoaDon();

            }
            else if (flag == 1)
            {
                EditHoaDon();
                MessageBox.Show("Editted", "Thông báo");
                loadHoaDon();
                txtMaHD.Enabled = true;
            }
        }
        public void EditHoaDon()
        {
            if (IsNumber(txtTongtien.Text) == false)
            {
                MessageBox.Show("Tong tien phải là số và không được âm", "Thông báo");
                return;
            }
            if (txtMaHD.Text == "" || txtTenKH.Text == "" || txtMaKH1.Text == "" || txtTongtien.Text == "" || dtpngaylaphoadon.Value.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            string mahd = txtMaHD.Text;
            string makh1 = txtMaKH1.Text;
            string tenkh = txtTenKH.Text;
            int tongtien = 0;
            DateTime ngaylaphoadon = dtpngaylaphoadon.Value.Date;

            var kt = db.HoaDons.Where(t => t.MaHD == mahd).SingleOrDefault();
            if (kt != null)
            {
                kt.MaHD = mahd;
                kt.MaKH = makh1;
                kt.TenKH = tenkh;
                kt.TongTien = tongtien;
                kt.Ngaylap = ngaylaphoadon;
            }
            else
                MessageBox.Show("Không tồn tại mã hóa đơn  này ");


            db.SubmitChanges();
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {

        }
        public void InsertHoaDon()
        {
            if (IsNumber(txtTongtien.Text) == false)
            {
                MessageBox.Show("Tong tien phải là số và không được âm", "Thông báo");
                return;
            }
            if (txtMaHD.Text == "" || txtTenKH.Text == "" || txtMaKH1.Text == "" || txtTongtien.Text == "" || dtpngaylaphoadon.Value.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            string mahd = txtMaHD.Text;
            string makh = txtMaKH.Text;
            string tenkh = txtTenKH.Text;
            DateTime ngaylaphoadon = dtpngaylaphoadon.Value.Date;
            int tongtien = Int32.Parse(txtTongtien.Text);
            var kt = db.HoaDons.Where(t => t.MaHD == mahd).SingleOrDefault();
            if (kt != null)
            {
                MessageBox.Show("Mã hóa đơn không được trùng");
                return;
            }
            else
            {

                HoaDon hd = new HoaDon();
                hd.MaHD = mahd;
                hd.MaHD = makh1;
                hd.TenKH = tenkh;
                hd.Ngaylap = ngaylaphoadon;
                hd.TongTien = tongtien;


                db.HoaDons.InsertOnSubmit(hd);
                db.SubmitChanges();
            }
            MessageBox.Show("Thêm hóa đơn thành công!");

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }
    }
}
