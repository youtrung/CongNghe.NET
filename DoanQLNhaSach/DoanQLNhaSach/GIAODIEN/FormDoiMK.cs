using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DoanQLNhaSach.GIAODIEN.FormLogin;
namespace DoanQLNhaSach.GIAODIEN
{
    public partial class FormDoiMK : Form
    {
        public FormDoiMK()
        {
            InitializeComponent();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            if (kiemtraQuyen==2)
            {
                ThayDoiMatKhau();
            }
            else
            {
                ThayDoiMatKhauUser();
            }
          
        }
        public void ChangeMK(string tenDangnhap, string mkCu, string mkMoi)
        {
            using (QLNSDataContext db = new QLNSDataContext())
            {
                Account doimk = db.Accounts.SingleOrDefault(p => p.UserName ==
                 tenDangnhap);
                if ((doimk.PassWord == mkCu) && (doimk.PassWord != mkMoi || doimk.UserName != tenDangnhap))
                {
                    doimk.PassWord = mkMoi;
                    db.SubmitChanges();
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else if (doimk.PassWord == mkMoi)
                {
                    MessageBox.Show("Mật khẩu mới không được trùng mật khẩu cũ ", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không hợp lệ ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public void ChangeMKUser(string tenDangnhap, string mkCu, string mkMoi)
        {
            using (QLNSDataContext db = new QLNSDataContext())
            {
                var  doimk = db.NhanViens.SingleOrDefault(p => p.Email ==
                 tenDangnhap);
                if (doimk!=null)
                {
                    if ((doimk.PassWord == mkCu) && (doimk.PassWord != mkMoi || doimk.Email != tenDangnhap))
                    {
                        doimk.PassWord = mkMoi;
                        db.SubmitChanges();
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else if (doimk.PassWord == mkMoi)
                    {
                        MessageBox.Show("Mật khẩu mới không được trùng mật khẩu cũ ", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không hợp lệ ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu & Tài khoản không hợp lệ ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }
        public void ThayDoiMatKhau()
        {
            string tenDangNhap = txtTendangnhap.Text;
            string mkCu = txtmkCu.Text;
            string mkMoi = txtmkMoi.Text;
            string remkMoi = txtremkMoi.Text;
            if (tenDangNhap == "" || mkCu == "" || mkMoi == "" || remkMoi == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (mkMoi != remkMoi)
            {
                MessageBox.Show("Mật khẩu mới không được trùng mật khẩu cũ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                ChangeMK(tenDangNhap, mkCu, mkMoi);
            }
        }
        public void ThayDoiMatKhauUser()
        {
            string tenDangNhap = txtTendangnhap.Text;
            string mkCu = txtmkCu.Text;
            string mkMoi = txtmkMoi.Text;
            string remkMoi = txtremkMoi.Text;
            if (tenDangNhap == "" || mkCu == "" || mkMoi == "" || remkMoi == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (mkMoi != remkMoi)
            {
                MessageBox.Show("Mật khẩu mới không được trùng mật khẩu cũ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                ChangeMKUser(tenDangNhap, mkCu, mkMoi);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtmkCu.UseSystemPasswordChar = false;
                txtmkMoi.UseSystemPasswordChar = false;
            }
            else
            {
                txtmkCu.UseSystemPasswordChar = true;
                txtmkMoi.UseSystemPasswordChar = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDoiMK_Load(object sender, EventArgs e)
        {

        }
    }
}
