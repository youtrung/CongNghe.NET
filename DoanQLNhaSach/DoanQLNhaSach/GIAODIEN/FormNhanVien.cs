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
            if (kt == null)
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
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // cần vô hiệu email 
            sua();
            loadnv();
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
    }
}
