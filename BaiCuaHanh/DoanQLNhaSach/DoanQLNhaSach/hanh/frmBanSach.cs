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

        private void dgvDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dgvDSHD.CurrentRow.Index; //dòng chọn

                txtMaSach.Text = dgvDSHD.Rows[index].Cells[1].Value.ToString();//1
                txtTenSach.Text = dgvDSHD.Rows[index].Cells[2].Value.ToString();
                txtDonGia.Text = dgvDSHD.Rows[index].Cells[3].Value.ToString();
                txtSoLuong.Text = dgvDSHD.Rows[index].Cells[4].Value.ToString();
                int tongtien = Int32.Parse(txtSoLuong.Text) * Int32.Parse(txtDonGia.Text);
                txtTongTien.Text = tongtien.ToString("###,###,###' 'VNĐ");
            }
            catch
            {

            }
            //Sach nxb = dgvDSHD.CurrentRow.DataBoundItem as Sach;
            //dynamic nxb = dgvDSHD.CurrentRow.DataBoundItem;
            //txtMaSach.Text = nxb.MaSach;
            //txtTenSach.Text = nxb.TenSach;
            //txtDonGia.Text = nxb.DonGia;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (QLNhaSachDataContext db = new QLNhaSachDataContext())
            {
                if (txtMaKH2.Text == "" || txtMaMoi.Text == "" || txtMaSach.Text == "" || txtSoLuong.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
                if (IsNumber(txtSoLuong.Text) == false)
                {
                    MessageBox.Show("Số lượng phải là số và không được âm", "Thông báo");
                    return;
                }
                int soluong = Int32.Parse(txtSoLuong.Text);


                string mahd = txtMaMoi.Text;
                Sach nxb = new Sach();
                nxb.MaSach = txtMaSach.Text;
                nxb.TenSach = txtTenSach.Text;
                //nxb.DonGia = txtDonGia.ToString();
                db.Saches.InsertOnSubmit(nxb);
                db.SubmitChanges();
                loadDuLieu();
                int check = nxb.TonCuoi - soluong;
                //if (check < Int32.Parse(qd.TonBanToiThieu))
                //{
                //    MessageBox.Show("Số lượng tồn của sách này sau khi bán đã nhỏ hơn quy định");
                //    return;
                //}
            }
        }

        private bool IsNumber(string p)
        {
            throw new NotImplementedException();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }



    }
}
