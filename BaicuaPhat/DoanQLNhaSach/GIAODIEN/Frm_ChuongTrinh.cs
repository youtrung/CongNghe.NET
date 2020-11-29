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
    public partial class Frm_ChuongTrinh : Form
    {
        QLNSDataContext db = new QLNSDataContext();
        public Frm_ChuongTrinh()
        {
            InitializeComponent();
        }
        private void Frm_ChuongTrinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Visible == true)
            {

                if (MessageBox.Show("Bạn có muốn thoát phải không?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK && this.Visible == true)
                {
                    e.Cancel = true;
                }
            }
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
            Frm_DanhSachKH frmKH = new Frm_DanhSachKH();
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
            Frm_DachSachHD frmHD = new Frm_DachSachHD();
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

        private void DanhSachNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhanVien frmNV = new FormNhanVien();
            this.Hide();
            frmNV.ShowDialog();
            this.Show();
        }

        private void Frm_ChuongTrinh_Load(object sender, EventArgs e)
        {
            FormLogin frmLG = new FormLogin();
            
            //int flag = kiemtraQuyen.flag;
            //if (flag == 1)
            //{

            //    DanhSachNVToolStripMenuItem.Visible = false;
            //}
        }

        private void DoiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DoiMatKhau frmDMK = new Frm_DoiMatKhau();
            frmDMK.ShowDialog();
        }

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Visible == true)
                Application.Exit();
        }

        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin frmLG = new FormLogin();
            frmLG.ShowDialog();
            if (this.Visible == true)
                this.Close();
        }

        private void ThongKeBCToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BaoCaoTonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BaoCaoNoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
