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
    public partial class FormKhachHang : Form
    {
        QLNSDataContext db = new QLNSDataContext();
        public FormKhachHang()
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
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            cbMaKH.DisplayMember = "MaKh";
            cbMaKH.DataSource = db.KhachHangs;
            cbMaKH.SelectedIndex = 0;
            btnLuu.Enabled = false;
            loadKhachHang();
        }
        public void loadKhachHang()
        {
            var data = from k in db.KhachHangs
                       select new
                       {
                           MaKH = k.MaKh,
                           TenKH = k.HoTen,
                           DiaChi = k.DiaChi,
                           Email = k.Email,
                           SoDienThoai = k.SDT,
                           TongNo = k.TongNo,
                       };
            dtgvKH.DataSource = data;
        }
        public void EditKhachHang()
        {
            if (txtMaKH.Text == "" || txtTenKH.Text == "" || txtEmail.Text == "" || txtDiaChi.Text == "" || txtDienthoai.Text == "" || txtTongno.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            string MaKH = txtMaKH.Text;
            string TenKH = txtTenKH.Text;
            string Email = txtEmail.Text;
            string DiaChi = txtDiaChi.Text;
            string SoDienThoai = txtDienthoai.Text;
            string TongNo = txtTongno.Text;
            var kt = db.KhachHangs.Where(t => t.MaKh == MaKH).SingleOrDefault();
            if (kt != null)
            {
                kt.MaKh = MaKH;
                kt.HoTen = TenKH;
                kt.Email = Email;
                kt.DiaChi = DiaChi;
                kt.SDT = SoDienThoai;
                kt.TongNo = TongNo;
            }
            else
                MessageBox.Show("Không tồn tại mã khách hàng này ");

            db.SubmitChanges();
        }
        public void InsertKhachHang()
        {
            if (txtMaKH.Text == "" || txtTenKH.Text == "" || txtEmail.Text == "" || txtDiaChi.Text == "" || txtDienthoai.Text == "" || txtTongno.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            string MaKH = txtMaKH.Text;
            string TenKH = txtTenKH.Text;
            string Email = txtEmail.Text;
            string DiaChi = txtDiaChi.Text;
            string SoDienThoai = txtDienthoai.Text;
            string TongNo = txtTongno.Text;
            var kt = db.KhachHangs.Where(t => t.MaKh == MaKH).SingleOrDefault();
            if (kt != null)
            {
                MessageBox.Show("Mã khách hàng không được trùng");
                return;
            }
            else
            {
                KhachHang kh = new KhachHang();
                kh.MaKh = MaKH;
                kh.HoTen = TenKH;
                kh.Email = Email;
                kh.DiaChi = DiaChi;
                kh.SDT = SoDienThoai;
                kh.TongNo = TongNo;

                db.KhachHangs.InsertOnSubmit(kh);
                db.SubmitChanges();
            }
            MessageBox.Show("Thêm sách thành công!");
        }

        private void dtgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dynamic dy = dtgvKH.CurrentRow.DataBoundItem;
            txtMaKH.Text = dy.MaKH;
            txtTenKH.Text = dy.TenKH;
            txtEmail.Text = dy.Email;
            txtDiaChi.Text = dy.DiaChi;
            txtDienthoai.Text = dy.SoDienThoai;
            txtTongno.Text = dy.TongNo;
        }
        public void loadKhachHangTheoTheMaKH(string t)
        {
            var data = from k in db.KhachHangs
                       where k.MaKh.Contains(t)
                       select new
                       {
                           MaKH = k.MaKh,
                           TenKH = k.HoTen,
                           DiaChi = k.DiaChi,
                           Email = k.Email,
                           SoDienThoai = k.SDT,
                           TongNo = k.TongNo,
                       };
            if (data != null)
            {
                dtgvKH.DataSource = data;
            }
            else
                return;
        }
        public void loadKhachHangTheoTheoTenKH(string t)
        {
            var data = from k in db.KhachHangs
                       where k.HoTen.Contains(t)
                       select new
                       {
                           MaKH = k.MaKh,
                           TenKH = k.HoTen,
                           DiaChi = k.DiaChi,
                           Email = k.Email,
                           SoDienThoai = k.SDT,
                           TongNo = k.TongNo,
                       };
            if (data != null)
            {
                dtgvKH.DataSource = data;
            }
            else
                return;
        }
        public void Cleardata()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            txtDienthoai.Clear();
            txtTongno.Clear();

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

            if (MessageBox.Show("Bạn có chắc muốn xoá khách hàng này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (txtMaKH.Text == "")
                {
                    MessageBox.Show("Không được để trống Mã Khách hàng ");
                    return;
                }
                string Makh = txtMaKH.Text;
                var kt = db.KhachHangs.Where(t => t.MaKh == Makh).SingleOrDefault();
                db.KhachHangs.DeleteOnSubmit(kt);
                db.SubmitChanges();
                MessageBox.Show("Xoá khách hàng thành công!");

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Tag.ToString().Equals("1"))
            {
                txtMaKH.Enabled = false;
                btnThem.Enabled = false;

                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                btnSua.Tag = "2";
                btnSua.Text = "Hủy Sửa";
                flag = 1;
            }
            else
            {
                txtMaKH.Enabled = true;
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
                InsertKhachHang();
                loadKhachHang();
                btnThem.Tag = "1";
                btnSua.Enabled = true;

                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                btnThem.Text = "Thêm";
                flag = -1;

            }
            else if (flag == 1)
            {
                EditKhachHang();
                MessageBox.Show("Editted", "Thông báo");
                loadKhachHang();
                txtMaKH.Enabled = true;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                flag = -1;
                btnSua.Tag = "1";
                btnSua.Text = "Sửa";
                txtMaKH.Enabled = true;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            loadKhachHang();

        }

        private void cbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string makh = cbMaKH.Text.ToString();
                loadKhachHangTheoTheMaKH(makh);
                Cleardata();
            }
        }

        private void txtSearchTenKhach_TextChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                string tenkh = txtSearchTenKhach.Text;
                loadKhachHangTheoTheoTenKH(tenkh);
                Cleardata();

            }
            
        }

        private void txtSearchTenKhach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioButton2.Checked)
            {
                string tenkh = txtSearchTenKhach.Text;
                loadKhachHangTheoTheoTenKH(tenkh);
                Cleardata();

            }
        }
    }
}
