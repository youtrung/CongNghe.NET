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
    public partial class FormBaoCaoNo : Form
    {
        public FormBaoCaoNo()
        {
            InitializeComponent();
        }

        private void FormBaoCaoNo_Load(object sender, EventArgs e)
        {
            loadDuLieu();
        }
        private void loadDuLieu()
        {
            using (QLNSDataContext db = new QLNSDataContext())
            {
                   
                var dataLinQ = from nxb in db.KhachHangs

                                   //select nxb;
                               select new
                               {

                                   MaKh = nxb.MaKh,
                                   TenKH = nxb.HoTen,
                                   Email = nxb.Email,
                                   NoDau = nxb.NoDau,
                                   NoCuoi=nxb.TongNo,
                                   PhatSinh = nxb.PhatSinh,
                                   


                               };
                dgvBaoCaoNo.DataSource = dataLinQ;
             
            }
        }
        private void baocaoNo()
        {
            using (QLNSDataContext db = new QLNSDataContext())
            {
                var dataLinQ = from nxb in db.KhachHangs select nxb;
                CrystalReportNo report = new CrystalReportNo();
               
                crytalBaocaono.ReportSource = report;
            }
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            baocaoNo();
        }
    }
}
