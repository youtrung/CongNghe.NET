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
    public partial class Frm_DoiMatKhau : Form
    {
        QLNSDataContext db = new QLNSDataContext();
        public Frm_DoiMatKhau()
        {
            InitializeComponent();
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

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            ThayDoiMatKhau();
        }

        private void Frm_DoiMatKhau_Load(object sender, EventArgs e)
        {
           
           
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtTendangnhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
