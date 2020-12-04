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
    public partial class FormHoaDon : Form
    {
        QLNSDataContext db = new QLNSDataContext();
        public FormHoaDon()
        {
            InitializeComponent();
        }
        public static string getMaHD, getMaKH;
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
        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            txtMaKH.DisplayMember = "MAKH";
            txtMaKH.DataSource = db.KhachHangs;
            loadHoaDon();
            btnLuu.Enabled = false;
        }
        public void loadHoaDon()
        {
            var data = from k in db.HoaDons
                       select new
                       {
                           MaHD = k.MaHD,
                           MaKH = k.MaKH,
                           TenKH = k.TenKH,
                           Ngaylap = k.Ngaylap,
                           TongTien = k.TongTien,
                       };
            dtgvHD.DataSource = data;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Tag.ToString().Equals("1"))
            {
                btnSua.Enabled = false;

                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
             
               
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var kt = db.HoaDons.Where(t => t.MaHD == txtMaHD.Text).SingleOrDefault();
            if (kt!=null)
            {
                db.HoaDons.DeleteOnSubmit(kt);
                db.SubmitChanges();
                loadHoaDon();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Tag.ToString().Equals("1"))
            {
                txtMaHD.Enabled = false;
                btnThem.Enabled = false;
                flag = 1;
                
                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                btnSua.Tag = "2";
                btnSua.Text = "Hủy Sửa";

            }
            else
            {
                txtMaHD.Enabled = true;
                btnThem.Enabled = true;
                
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                flag = -1;
                btnSua.Tag = "1";
                btnSua.Text = "Sửa";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                InsertHoaDon();
                loadHoaDon();
                flag = -1;
                btnThem.Tag = "1";
                btnSua.Enabled = true;

                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                btnThem.Text = "Thêm";
               


            }
            else if (flag == 1)
            {
                EditHoaDon();
                MessageBox.Show("Editted", "Thông báo");
                loadHoaDon();
                txtMaHD.Enabled = true;
                flag = -1;
                txtMaHD.Enabled = true;
                btnThem.Enabled = true;

                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
            
                btnSua.Tag = "1";
                btnSua.Text = "Sửa";
            }
        }
        public void InsertHoaDon()
        {
            if (IsNumber(txtTongtien.Text) == false)
            {
                MessageBox.Show("Tong tien phải là số và không được âm", "Thông báo");
                return;
            }
            if (txtMaHD.Text == "" || txtTenKH.Text == "" || txtMaKH.Text == "" || txtTongtien.Text == "" || dtpngaylaphoadon.Value.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            string mahd = txtMaHD.Text;
            string makh = txtMaKH.Text;
            string tenkh = txtTenKH.Text;
            
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
                hd.MaKH = makh;
                hd.TenKH = txtTenKH.Text;
                hd.Ngaylap = dtpngaylaphoadon.Value;
                hd.TongTien = tongtien;


                db.HoaDons.InsertOnSubmit(hd);
                db.SubmitChanges();
                MessageBox.Show("Thêm hóa đơn thành công!");
            }
            
        }
        public void EditHoaDon()
        {
            if (IsNumber(txtTongtien.Text) == false)
            {
                MessageBox.Show("Tong tien phải là số và không được âm", "Thông báo");
                return;
            }
            if (txtMaHD.Text == "" || txtTenKH.Text == "" || txtMaKH.Text == "" || txtTongtien.Text == "" || dtpngaylaphoadon.Value.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            string mahd = txtMaHD.Text;
            string makh1 = txtMaKH.Text;
            string tenkh = txtTenKH.Text;
            int tongtien =Int32.Parse(txtTongtien.Text);
          

            var kt = db.HoaDons.Where(t => t.MaHD == mahd).SingleOrDefault();
            if (kt != null)
            {
                kt.MaHD = mahd;
                kt.MaKH = makh1;
                kt.TenKH = tenkh;
                kt.TongTien = tongtien;
                kt.Ngaylap =dtpngaylaphoadon.Value;
                db.SubmitChanges();
            }
            else
                MessageBox.Show("Không tồn tại mã hóa đơn  này ");


           
        }

  

       

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadHoaDon();
        }

        private void dtgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dynamic  hd =dtgvHD.CurrentRow.DataBoundItem;
            txtMaHD.Text = hd.MaHD;

            txtMaKH.Text = hd.MaKH;
            txtTenKH.Text = hd.TenKH;
            dtpngaylaphoadon.Value = hd.Ngaylap;
            txtTongtien.Text = hd.TongTien.ToString();

        }

        private void btnReloadd_Click(object sender, EventArgs e)
        {
            loadHoaDon();
        }

        private void btnbsct_Click(object sender, EventArgs e)
        {
            if(txtMaHD.Text=="")
            {
                MessageBox.Show("Xin hãy chọn hóa đơn muốn thêm vào");
                return;
            }
            getMaHD = txtMaHD.Text;
            getMaKH = txtMaKH.Text;
            FormBanSach frm = new FormBanSach();
            frm.ShowDialog();

        }
    }
}