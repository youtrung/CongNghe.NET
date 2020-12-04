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
    public partial class FormChuongTrinh : Form
    {
        public FormChuongTrinh()
        {
            InitializeComponent();
        }

        private void DSSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSach frmSach = new FormSach();
            this.Hide();
            frmSach.ShowDialog();
            this.Show();
        }

        private void DSKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKhachHang  frmKH = new FormKhachHang();
            this.Hide();
            frmKH.ShowDialog();
            this.Show();
        }

        private void PhieuNhapSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPhieuNhap frmPN = new FormPhieuNhap();
            this.Hide();
            frmPN.ShowDialog();
            this.Show();
        }

        private void PhieuNhapHDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHoaDon frmHD = new FormHoaDon();
            this.Hide();
            frmHD.ShowDialog();
            this.Show();
        }

        private void PhieuThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThuTien frmTT = new FormThuTien();
            this.Hide();
            frmTT.ShowDialog();
            this.Show();
        }

        private void ThayDoiQDinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuyDinh frmQD = new FormQuyDinh();
            this.Hide();
            frmQD.ShowDialog();
            this.Show();
        }

        private void BaoCaoTonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBaoCaoTon frm = new FormBaoCaoTon();
            frm.Show();
        }

        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin frmLG = new FormLogin();
            frmLG.ShowDialog();
            if (this.Visible == true)
                this.Close();
        }

        private void DoiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                this.Hide();
                FormDoiMK frm = new FormDoiMK();
                frm.ShowDialog();
            
          
           

        }

        private void BaoCaoNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBaoCaoNo frm = new FormBaoCaoNo();
            frm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        
        }
    }
}
