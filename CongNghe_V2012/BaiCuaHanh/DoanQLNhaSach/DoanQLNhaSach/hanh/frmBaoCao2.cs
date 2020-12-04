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
    public partial class frmBaoCao2 : Form
    {
        public frmBaoCao2()
        {
            InitializeComponent();
        }

        private void frmBaoCao2_Load(object sender, EventArgs e)
        {
            loadDuLieu();
        }
        private void loadDuLieu()
        {
            using (QLNhaSachDataContext db = new QLNhaSachDataContext())
            {

                var dataLinQ = from nxb in db.KhachHangs

                               //select nxb;
                               select new
                               {

                                   MaKh = nxb.MaKh,
                                   TenKH = nxb.HoTen,
                                   Email = nxb.Email,
                                   NoDau = nxb.NoDau,
                                    
                                   PhatSinh = nxb.PhatSinh,
                                   

                               };
                dgvBaoCaoNo.DataSource = dataLinQ;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
