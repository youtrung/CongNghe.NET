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
    public partial class FormNhanVien : Form
    {
        QLNSDataContext db = new QLNSDataContext();
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            loadnv();
            btnLuu.Enabled = false;
        }
        public void loadnv()
        {
            using (QLNSDataContext db=new QLNSDataContext())
            {
                var query = from p in db.NhanViens
                            select new
                            {
                                HOVATEN = p.HoTen,
                                DIACHI = p.DiaChi,
                                PHONE = p.SDT,
                                EMAIL = p.Email,
                                MATKHAU = p.PassWord
                            };
                dataNhanVien.DataSource = query;

            }
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themNV();
            loadnv();
            MessageBox.Show("Thêm Thành Công ", "Thông báo");
        }
        public void themNV()
        {
            long check;
            try
            {
                check = Int64.Parse(txtPhone.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Điện thoại phải điền vào số", "Thông báo");
                return;
            }
            if (txtEmail.Text == "" || txtName.Text == "" || txtDC.Text == "" || txtPhone.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy dủ thông tin.");
                return;
            }
            var kt=db.NhanViens.Where(r => r.Email == txtEmail.Text).SingleOrDefault();
            if (kt != null)
            {
                MessageBox.Show("Email nhân viên này đã tồn tại ");
                return;
            }
            NhanVien nv = new NhanVien();
            nv.Email = txtEmail.Text;
            nv.HoTen = txtName.Text;
            nv.DiaChi = txtDC.Text;
            nv.PassWord = txtPass.Text;
            nv.SDT = txtPhone.Text;
            db.NhanViens.InsertOnSubmit(nv);
            db.SubmitChanges();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text=="")
            {
                MessageBox.Show("Email không  được để trống  !");
                return;
            }
            xoa();
            MessageBox.Show("Xoá nhân viên thành công!");
            loadnv();
        }
        public void xoa()
        {
            var kt = db.NhanViens.Where(r => r.Email == txtEmail.Text).SingleOrDefault();
            if (kt != null)
            {
                db.NhanViens.DeleteOnSubmit(kt);
                db.SubmitChanges();
            }
            else
            {
                MessageBox.Show("Email không tìm được !");
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Tag.ToString().Equals("1"))
            {
                txtEmail.Enabled = false;
                btnThem.Enabled = false;

                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                btnSua.Tag = "2";
                btnSua.Text = "Hủy Sửa";
               
            }
            else
            {
                txtEmail.Enabled = true;
                btnThem.Enabled = true;

                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
              
                btnSua.Tag = "1";
                btnSua.Text = "Sửa";
            }

        }
        public void sua()
        {
            var kt = db.NhanViens.Where(r => r.Email == txtEmail.Text).SingleOrDefault();
            if (kt != null)
            {
                kt.DiaChi = txtDC.Text;
                kt.HoTen = txtName.Text;
                kt.PassWord = txtPass.Text;
                kt.SDT = txtPhone.Text;
                db.SubmitChanges();
                MessageBox.Show("Sửa thành công ");
            }
            else
            {
                MessageBox.Show("Email không tìm được !");
                txtEmail.Enabled = true;
                btnThem.Enabled = true;

                btnXoa.Enabled = true;
                btnLuu.Enabled = false;

                btnSua.Tag = "1";
                btnSua.Text = "Sửa";
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dynamic sv = dataNhanVien.CurrentRow.DataBoundItem;
            txtEmail.Text = sv.EMAIL;
            txtName.Text = sv.HOVATEN;
            txtDC.Text = sv.DIACHI;
            txtPhone.Text = sv.PHONE;
            txtPass.Text = sv.MATKHAU;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            sua();
            loadnv();
        }
    }
}
