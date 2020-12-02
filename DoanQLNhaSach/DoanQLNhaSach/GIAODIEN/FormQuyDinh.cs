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
    public partial class FormQuyDinh : Form
    {
        QLNSDataContext db = new QLNSDataContext();
        public FormQuyDinh()
        {
            InitializeComponent();
        }
        public static int qdSoluongton;
        public static int qdSoluongnhaps;
        public static int qdTonBantoithieu;
        public static int qdKhNotoithieu;
        private void FormQuyDinh_Load(object sender, EventArgs e)
        {
            if (kiemtraQuyen == 1)
            {
                btnUdp.Enabled = false;
            }
            loadqd();
        }
        public void loadqd()
        {
            var data = db.QuyDinhs.Where(t => t.MaQuyDinh == "1").SingleOrDefault();
            txtLuongSach.Text = data.NhapToiThieu;
            txtTon1.Text = data.TonNhapToiThieu;
            txtTon2.Text = data.TonBanToiThieu;
            txtNo.Text = data.KHNoToiThieu.ToString();
        }

        private void btnUdp_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLuongSach.Text == "" || txtNo.Text == ""|| txtTon1.Text == ""|| txtTon2.Text == "")
                {
                    MessageBox.Show("Bạn Khong duoc de trong du lieu ");
                    return;
                }

                string luongsach = txtLuongSach.Text;
                qdSoluongnhaps = Int32.Parse(luongsach);
                int KHno = Convert.ToInt32(txtNo.Text);
                qdKhNotoithieu = KHno;
                string tonNhap = txtTon1.Text;
                qdSoluongton= Int32.Parse(tonNhap);
                string tonBan = txtTon2.Text;
                qdTonBantoithieu = Int32.Parse(tonBan);

                var data = db.QuyDinhs.Where(t => t.MaQuyDinh == "1").SingleOrDefault();
                data.NhapToiThieu = luongsach;
                data.TonNhapToiThieu = tonNhap;
                data.TonBanToiThieu = tonBan;
                data.KHNoToiThieu = KHno;
                db.SubmitChanges();
                MessageBox.Show("Thay đổi thành công");
                loadqd();
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn phải nhập vào kiểu số.");
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Số không được âm");
                return;
            }

            

         
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
