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
    public partial class FormPhieuNhap : Form
    {
        QLNSDataContext db = new QLNSDataContext();
        public FormPhieuNhap()
        {
            InitializeComponent();
        }

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {

            var data = from k in db.PhieuNhaps
                       select new
                       {
                           MAPN = k.MaPhieuNhap,
                           NGAYNHAP = k.NgayNhap,
                           TONGTIEN = k.TongTien
                       };
            // cho giá trị tông tiền mặc định là 0 nhưng khi them chi tiết phiếu nhập thức hiện 2 action thêm và upd

           
            dataPN.DataSource = data;
        }
    }
}
