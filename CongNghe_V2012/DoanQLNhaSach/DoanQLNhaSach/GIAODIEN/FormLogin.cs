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
                    NhanVien nv = db.NhanViens.Where(r => r.Email == txtTaikhoan.Text && r.PassWord == txtMk.Text).SingleOrDefault();
                    if (nv == null)
                    {
                        MessageBox.Show("Bạn đã nhập sai tên tài khoản hoặc mật khẩu!", "Cảnh Báo");
                        return;
                    }
                    getTK = txtTaikhoan.Text;
                    this.Hide();
                    FormChuongTrinh frm = new FormChuongTrinh();
                    frm.ShowDialog();
                    this.Close();
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
                    this.Hide();
                    FormChuongTrinh frm = new FormChuongTrinh();
                    frm.ShowDialog();
                    this.Close();
                   

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

        private void rdHtmk_CheckedChanged(object sender, EventArgs e)
        {
            if (rdHtmk.Checked)
            {
                txtMk.UseSystemPasswordChar = false;
            }
            else
            {
                txtMk.UseSystemPasswordChar = true;
            }
        }

        private void cbbQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
