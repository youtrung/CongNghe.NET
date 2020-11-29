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
            cbMaHD.DisplayMember = "MaHD";
            cbMaHD.DataSource = db.HoaDons;
            cbMaHD.SelectedIndex = 0;
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
                           Tongtien = k.TongTien,
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
<<<<<<< HEAD
            string makh = txtMaKH.Text;
=======
            string makh1 = txtMaKH1.Text;
>>>>>>> 25ada64a0ca9912e2f0a4cebfc11f346ab8849ef
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
                hd.MaKH = makh1;
                hd.TenKH = tenkh;
                hd.Ngaylap = ngaylaphoadon;
                hd.TongTien = tongtien;


                db.HoaDons.InsertOnSubmit(hd);
                db.SubmitChanges();
            }
            MessageBox.Show("Thêm hóa đơn thành công!");

        }

<<<<<<< HEAD
        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {

=======
        private void dtgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dynamic dy = dtgvHD.CurrentRow.DataBoundItem;
            txtMaHD.Text = dy.MaHD;
            txtTenKH.Text = dy.TenKH;
            txtMaKH1.Text= dy.MaKH1;
            dtpngaylaphoadon.Value= dy.NgaylapHD;
            txtTongtien.Text = dy.Tongtien.ToString();
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xoá hoá đơn này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (txtMaHD.Text == "")
                {
                    MessageBox.Show("Không được để trống Mã hóa đơn này ");
                    return;
                }
                string MaHD = txtMaHD.Text;
                var kt = db.HoaDons.Where(t => t.MaHD == MaHD).SingleOrDefault();
                db.HoaDons.DeleteOnSubmit(kt);
                db.SubmitChanges();
                Cleardata();
                MessageBox.Show("Xoá khách hàng thành công!");

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Tag.ToString().Equals("1"))
            {
                txtMaHD.Enabled = false;
                btnThem.Enabled = false;

                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                btnSua.Tag = "2";
                btnSua.Text = "Hủy Sửa";
                flag = 1;
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
        public void loadHoaDonTheoTheMaHD(string t)
        {
            var data = from k in db.HoaDons
                       where k.MaHD.Contains(t)
                       select new
                       {
                           MaHD = k.MaHD,
                           MaKH1 = k.MaKH,
                           TenKH = k.TenKH,
                           NgaylapHD = k.Ngaylap,
                           Tongtien = k.TongTien,
                       };
            if (data != null)
            {
                dtgvHD.DataSource = data;
            }
            else
                return;
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            loadHoaDon();
        }

        private void cbMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mahd = cbMaHD.Text.ToString();
            loadHoaDonTheoTheMaHD(mahd);
            Cleardata();

        }
        public void Cleardata()
        {
            txtMaKH1.Clear();
            txtTenKH.Clear();
            txtMaHD.Clear();
            txtTongtien.Clear();
>>>>>>> 25ada64a0ca9912e2f0a4cebfc11f346ab8849ef
        }
    }
}
