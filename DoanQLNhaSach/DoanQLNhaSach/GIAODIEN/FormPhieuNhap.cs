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
                      // join t in db.ChiTietPhieuNhaps on k.MaPhieuNhap equals t.MaPhieuNhap
                       //into ps from t in ps.DefaultIfEmpty()

                       select new
                       {
                           MAPN = k.MaPhieuNhap,
                           NGAYNHAP =k.NgayNhap,
                           //TONGTIEN=t==null?"<null>":t.TongTien.ToString()
                           TONGTIEN =db.ChiTietPhieuNhaps.Where(r => r.MaPhieuNhap == k.MaPhieuNhap).Select(qwe => qwe.SoLuong * qwe.DonGia).Sum()==null?"0": db.ChiTietPhieuNhaps.Where(r => r.MaPhieuNhap == k.MaPhieuNhap).Select(qwe => qwe.SoLuong * qwe.DonGia).Sum().ToString()
                       };
            // cho giá trị tông tiền mặc định là 0 nhưng khi them chi tiết phiếu nhập thức hiện 2 action thêm và upd


            dataPN.DataSource = data;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them();
            loadData();
        }
        public void them ()
        {
            if (txtMaPN.Text == ""  )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            var kt = db.PhieuNhaps.Where(t => t.MaPhieuNhap == txtMaPN.Text).SingleOrDefault();
                if (kt !=null)
            {
                MessageBox.Show("Mã phiếu nhập không được trùng");
                return;
            }
            PhieuNhap pn = new PhieuNhap();
            pn.MaPhieuNhap = txtMaPN.Text;
            pn.NgayNhap = dtpNgaynhap.Value;
            pn.TongTien = 0;
            db.PhieuNhaps.InsertOnSubmit(pn);
            db.SubmitChanges();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var kt = db.PhieuNhaps.Where(t => t.MaPhieuNhap == txtMaPN.Text).SingleOrDefault();
            if (txtTongTien.Text == "0")
            {
                if (MessageBox.Show("Bạn có chắc muốn xoá phiếu nhập này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    db.PhieuNhaps.DeleteOnSubmit(kt);
                    db.SubmitChanges();
                    MessageBox.Show("Xoá thành công!");
                    loadData();
                    
                }
                    
                
            }
            else
            {
                MessageBox.Show("Vui lòng xoá hết sách ra khỏi phiếu nhập.");
            }
               
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
          
            if (btnSua.Tag.ToString().Equals("1"))
            {
                txtMaPN.Enabled = false;
                btnThem.Enabled = false;

                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                btnSua.Tag = "2";
                btnSua.Text = "Hủy Sửa";

            }
            else
            {
                txtMaPN.Enabled = true;
                btnThem.Enabled = true;

                btnXoa.Enabled = true;
                btnLuu.Enabled = false;

                btnSua.Tag = "1";
                btnSua.Text = "Sửa";
            }
         
        }
        public void sua()
        {
            if (txtMaPN.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            var kt = db.PhieuNhaps.Where(t => t.MaPhieuNhap == txtMaPN.Text).SingleOrDefault();
            kt.NgayNhap = dtpNgaynhap.Value;
            db.SubmitChanges();

            MessageBox.Show("Sửa thông tin thành công");
        }

        private void dataPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
       
            dynamic  sv =dataPN.CurrentRow.DataBoundItem;

           
            txtMaPN.Text = sv.MAPN;

            dtpNgaynhap.Value = sv.NGAYNHAP;
            txtTongTien.Text = sv.TONGTIEN;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            sua();
            loadData();
            txtMaPN.Enabled = true;
            btnThem.Enabled = true;

            btnXoa.Enabled = true;
            btnLuu.Enabled = false;

            btnSua.Tag = "1";
            btnSua.Text = "Sửa";
        }
    }
}
