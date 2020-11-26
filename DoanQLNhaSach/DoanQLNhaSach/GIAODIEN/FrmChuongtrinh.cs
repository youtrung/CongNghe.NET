using DoanQLNhaSach.GIAODIEN;
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

namespace QLNhaSach
{
    public partial class frmChuongtrinh : Form
    {
        public frmChuongtrinh()
        {
            InitializeComponent();
            
        }

        private void giaoDienToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void danhMucToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void nghiepVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void tkBaoCaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void cnAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void quanLyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void dsSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSach frmSach = new frmSach();
            this.Hide();
            frmSach.ShowDialog();
            this.Show();
        }

        private void dsKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
                 frmKhachHang frmKH = new frmKhachHang();
            this.Hide();
            frmKH.ShowDialog();
            this.Show();
        }

        private void phieunhapSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuNhap frmPN = new frmPhieuNhap();
            this.Hide();
            frmPN.ShowDialog();
            this.Show();
        }

        private void hoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon frmHD = new frmHoaDon();
            this.Hide();
            frmHD.ShowDialog();
            this.Show();
        }

       

        private void baocaoTonToolStripMenuItem_Click(object sender, EventArgs e)
        {
                frmBaoCao1 frmBC1 = new frmBaoCao1();
            this.Hide();
            frmBC1.ShowDialog();
            this.Show();
        }

        private void baocaoNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
                 frmBaoCao2 frmBC2 = new frmBaoCao2();
            this.Hide();
            frmBC2.ShowDialog();
            this.Show();
        }

        private void thaydoiQDiToolStripMenuItem_Click(object sender, EventArgs e)
        {
                frmQuyDinh frmQD = new frmQuyDinh();
            this.Hide();
            frmQD.ShowDialog();
            this.Show();
        }

        private void qlNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
                 frmNhanVien frmNV = new frmNhanVien();
            this.Hide();
            frmNV.ShowDialog();
            this.Show();
        }

        private void doiMKToolStripMenuItem_Click(object sender, EventArgs e)
        {
             frmDoiMatKhau frmDMK = new frmDoiMatKhau();
            frmDMK.ShowDialog();
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
           
            frmLogin frmLG = new frmLogin();
            
            frmLG.ShowDialog();
            if (this.Visible == true)
                this.Close();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
                 if (this.Visible == true)
                Application.Exit();
        }

        private void thanhToanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThuTien frmTT = new frmThuTien();
            this.Hide();
            frmTT.ShowDialog();
            this.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void frmChuongtrinh_Load(object sender, EventArgs e)
        {
              frmLogin frmLG = new frmLogin();

            int flag = CheckQuyen.flag;
            if (flag == 1)
            {
                
                qlNhanVienToolStripMenuItem.Visible = false;
            }
        }

        private void frmChuongtrinh_FormClosing(object sender, FormClosingEventArgs e)
        {
             if (this.Visible == true)
            {

                if (MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK && this.Visible == true)
                {
                    e.Cancel = true;
                }
            }
        }
        



       
    }
}
