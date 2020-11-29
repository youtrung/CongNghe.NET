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
    public partial class frmBanSach : Form
    {
        public frmBanSach()
        {
            InitializeComponent();
        }

        private void frmBanSach_Load(object sender, EventArgs e)
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
                                   DonGia = nxb.DonGia,
                                   
                               };
                dgvDSHD.DataSource = dataLinQ;
            }
        }
    }
}
