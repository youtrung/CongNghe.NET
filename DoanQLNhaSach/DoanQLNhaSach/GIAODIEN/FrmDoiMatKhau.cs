using QLNhaSach.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DoanQLNhaSach.frmLogin;

namespace QLNhaSach.GiaoDien
{
    public partial class frmDoiMatKhau : Form
    {
        

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        void DoiMatKhau()
        {
            
            string tk = txttaiKhoan.Text;
            string mkcu = txtmkCu.Text;
            string mkmoi = txtmkMoi.Text;
            string remkmoi = txtremkmoi.Text;
            if (tk == "" || mkcu == "" || mkmoi == "" || remkmoi == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (mkmoi != remkmoi)
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                TaiKhoanBUS.ChangeMK(tk, mkcu, mkmoi);
            }
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            DoiMatKhau();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txttaiKhoan.Text = GetTK.getTK;
        }
    }
}
