using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoanQLNhaSach.hanh
{
    public partial class frmBaoCao1 : Form
    {
        public frmBaoCao1()
        {
            InitializeComponent();
        }

        private void frmBaoCao1_Load(object sender, EventArgs e)
        {
            loadDuLieu();
        }
        private void loadDuLieu()
        {
            using (QLNhaSachDataContext db = new QLNhaSachDataContext())
            {

                var dataLinQ = from nxb in db.Saches

                               //select nxb;
                               select new
                               {

                                   MaSach = nxb.MaSach,
                                   TenSach = nxb.TenSach,
                                   TonDau = nxb.TonDau,
                                   TongNhap = nxb.TongNhap,
                                   TongBan = nxb.TongBan,
                                   PhatSinh = nxb.PhatSinh,
                                   TonCuoi = nxb.TonCuoi

                               };
                dgvBaoCaoTon.DataSource = dataLinQ;
            }
        }
    }
}
