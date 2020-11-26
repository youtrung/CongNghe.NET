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
    public partial class FormLogin : Form
    {
        public static string getTK { get; set; }
        public static int kiemtraQuyen { get; set; }
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using(QLNSDataContext db=new QLNSDataContext())
            {
                
                if (cbbQuyen.Text== "User")
                {
                    kiemtraQuyen = 1;
                    NhanVien nv = db.NhanViens.Where(r => r.HoTen == txtTaikhoan.Text && r.PassWord == txtMk.Text).SingleOrDefault();
                    if (nv == null)
                    {
                        MessageBox.Show("Bạn đã nhập sai tên tài khoản hoặc mật khẩu!", "Cảnh Báo");
                        return;
                    }
                    getTK = txtTaikhoan.Text;
                }
                else  if (cbbQuyen.Text=="Admin")
                {
                    kiemtraQuyen = 2;
                    Account ac = db.Accounts.Where(r => r.UserName == txtTaikhoan.Text && r.PassWord == txtMk.Text).SingleOrDefault();
                    if (ac==null)
                    {
                        MessageBox.Show("Bạn đã nhập sai tên tài khoản hoặc mật khẩu!", "Cảnh Báo");
                        return;
                    }
                    getTK = txtTaikhoan.Text;

                }
                else
                {
                    MessageBox.Show("Vui lòng chọn quyền");
                }
               
               
                
                
            }
           
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            cbbQuyen.Items.Add("Admin");
            cbbQuyen.Items.Add("User");
        }
    }
}
