using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoanQLNhaSach.GIAODIEN;

namespace DoanQLNhaSach.GIAODIEN
{
    public partial class FormBanSach : Form
    {
        QLNSDataContext db = new QLNSDataContext();
        public static string ktBtn;
        public FormBanSach()
        {
            InitializeComponent();
        }
        public static string getMaSach;
        public static int TongTienNhap;
        int flag = -1;
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        private void FormBanSach_Load(object sender, EventArgs e)
        {
            txtMaMoi.Text = FormHoaDon.getMaHD;
            txtMaKH2.Text = FormHoaDon.getMaKH;
            loadDS();
        }
        public void loadDS()
        {
            string ms = FormHoaDon.getMaHD;
            var dt = from k in db.PhieuBans
                     where k.MaPhieuBan == ms
                     select new
                     {
                         MaSach = k.MaSach,
                         MaHD=k.MaPhieuBan,
                         TenSach = k.Sach.TenSach,
                         DonGia = k.Sach.DonGia,
                         SoLuong = k.SoLuong
                     };
            dgvDSHD.DataSource = dt;
            var kh = db.KhachHangs.Where(t => t.MaKh == FormHoaDon.getMaKH).SingleOrDefault();
            txtTenKH2.Text = kh.HoTen;
        }
        public void hienthiSach()
        {
            var s = db.Saches.Where(t => t.MaSach == txtMaSach.Text).SingleOrDefault();
            txtTenSach.Text = s.TenSach;
            txtDonGia.Text = s.DonGia.ToString();

        }

        private void btnMaSach_Click(object sender, EventArgs e)
        {
            
            FormSach frm = new FormSach();
            FormSach.frag = "ok";
            frm.ShowDialog();
            txtMaSach.Text = getMaSach;
            hienthiSach();

        }

        private void btnThem_Click(object sender, EventArgs e)
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
            string mahd = txtMaMoi.Text;

            string masach = txtMaSach.Text;
            int soluong = Int32.Parse(txtSoLuong.Text);
            Sach s = db.Saches.Where(r => r.MaSach == masach).SingleOrDefault();
            int check = s.TonCuoi - soluong;
            KhachHang kh = db.KhachHangs.Where(r => r.MaKh == txtMaKH2.Text).SingleOrDefault();
            var kt = db.PhieuBans.Where(t => t.MaPhieuBan == mahd && t.MaSach == masach).SingleOrDefault();
            var qd = db.QuyDinhs.Where(t=>t.MaQuyDinh==1.ToString()).SingleOrDefault();
            if (check < Int32.Parse(qd.TonBanToiThieu))
            {
                MessageBox.Show("Số lượng tồn của sách này sau khi bán đã nhỏ hơn quy định");
                return;
            }
            if (Int32.Parse(kh.TongNo) > qd.KHNoToiThieu)
            {
                MessageBox.Show("Tiền nợ của khách hàng đã vượt quá quy định");
                return;
            }

            if (kt != null)
            {
                MessageBox.Show("Sách này đã có trong hoá đơn");
                return;
            }


            PhieuBan pb = new PhieuBan();
            pb.MaSach = masach;
            pb.MaPhieuBan = mahd;
            pb.SoLuong = Int32.Parse(txtSoLuong.Text);
            db.PhieuBans.InsertOnSubmit(pb);

            int check1 = s.TonCuoi - Int32.Parse(txtSoLuong.Text);
            int tb = Int32.Parse(s.TongBan) + Int32.Parse(txtSoLuong.Text);
            int tn = Int32.Parse(s.TongNhap);
            int phatsinh = tn - tb;
            int tondau = check - phatsinh;
            s.TongBan = tb.ToString();
            s.TongNhap = tn.ToString();
            s.TonDau = tondau.ToString();
            s.TonCuoi = check;
            HoaDon hd = db.HoaDons.Where(t => t.MaHD == txtMaMoi.Text).SingleOrDefault();
            TongTienNhap = (int)hd.TongTien + (Int32.Parse(txtDonGia.Text) * Int32.Parse(txtSoLuong.Text));
            hd.TongTien = TongTienNhap;
            db.SubmitChanges();
            MessageBox.Show("Thêm Thành công ");
            loadDS();

        }
        public void Insertbook()
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
            string mahd = txtMaMoi.Text;

            string masach = txtMaSach.Text;
            int soluong = Int32.Parse(txtSoLuong.Text);
            Sach s = db.Saches.Where(r => r.MaSach == masach).SingleOrDefault();
            int check = s.TonCuoi - soluong;
            KhachHang kh = db.KhachHangs.Where(r => r.MaKh == txtMaKH2.Text).SingleOrDefault();
            var kt = db.PhieuBans.Where(t => t.MaPhieuBan == mahd && t.MaSach == masach).SingleOrDefault();
            var qd = db.QuyDinhs.Where(t => t.MaQuyDinh == 1.ToString()).SingleOrDefault();
            if (check <Int32.Parse(qd.TonBanToiThieu))
            {
                MessageBox.Show("Số lượng tồn của sách này sau khi bán đã nhỏ hơn quy định");
                return;
            }
            if (Int32.Parse(kh.TongNo) > qd.KHNoToiThieu)
            {
                MessageBox.Show("Tiền nợ của khách hàng đã vượt quá quy định");
                return;
            }
        
            if (kt!=null)
            {
                MessageBox.Show("Sách này đã có trong hoá đơn");
                return;
            }
                PhieuBan pb = new PhieuBan();
                pb.MaSach = masach;
                pb.MaPhieuBan = mahd;
                pb.SoLuong = Int32.Parse(txtSoLuong.Text);
                db.PhieuBans.InsertOnSubmit(pb);
        }
          public  void UpdateSoLuongTon()
        {
            // txtMaSach.Text = GetMaSach.getMaSach;
            Sach s = db.Saches.Where(t => t.MaSach == txtMaSach.Text).SingleOrDefault();
            int check = s.TonCuoi - Int32.Parse(txtSoLuong.Text);
            int tb = Int32.Parse(s.TongBan) + Int32.Parse(txtSoLuong.Text);
            int tn = Int32.Parse(s.TongNhap);
            int phatsinh = tn - tb;
            int tondau = check - phatsinh;
            s.TongBan = tb.ToString();
            s.TongNhap = tn.ToString();
            s.TonDau = tondau.ToString();
            s.TonCuoi = check;
            db.SubmitChanges();
        }

        public void UpdateTongTien()
        {
            // txtMaPN.Text = GetMaPN.getMaPN;
            HoaDon hd = db.HoaDons.Where(t => t.MaHD == txtMaMoi.Text).SingleOrDefault();
            TongTienNhap = (int)hd.TongTien + (Int32.Parse(txtDonGia.Text) * Int32.Parse(txtSoLuong.Text));
            hd.TongTien = TongTienNhap;
            db.SubmitChanges();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "")
            {
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xoá hoá đơn này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                xoahd();
                MessageBox.Show("Xoá hoá đơn thành công!");
                UpdateSoLuongTon_Xoa_Sua();
                UpdateTongTien_Xoa_Sua();
                loadDS();
            }
        }
        public void xoahd()
        {
            var hd = db.PhieuBans.Where(t => t.MaPhieuBan == txtMaMoi.Text && t.MaSach == txtMaSach.Text).SingleOrDefault();
            db.PhieuBans.DeleteOnSubmit(hd);
            db.SubmitChanges();
        }
        public void UpdateSoLuongTon_Xoa_Sua()
        {
            Sach s = db.Saches.Where(t => t.MaSach == txtMaSach.Text).SingleOrDefault();
            int check = s.TonCuoi + Int32.Parse(txtSoLuong.Text);
            int tb = Int32.Parse(s.TongBan) - Int32.Parse(txtSoLuong.Text);
            int tn = Int32.Parse(s.TongNhap);
            int phatsinh = tn - tb;
            int tondau = check - phatsinh;
            s.TongBan = tb.ToString();
            s.TongNhap = tn.ToString();
            s.TonDau = tondau.ToString();
            s.TonCuoi = check;
            db.SubmitChanges();

        }
        public void UpdateTongTien_Xoa_Sua()
        {
            HoaDon hd = db.HoaDons.Where(t => t.MaHD == txtMaMoi.Text).SingleOrDefault();
            TongTienNhap = (int)hd.TongTien - (Int32.Parse(txtDonGia.Text) * Int32.Parse(txtSoLuong.Text));
            hd.TongTien = TongTienNhap;
            db.SubmitChanges();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text != "")
            {
                
                flag = 1;
                txtMaMoi.Enabled = false;
                btnThem.Enabled = false;
                btnLuu.Enabled = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {

                UpdateHoaDon();
                UpdateSoLuongTon_Xoa_Sua();
                UpdateTongTien_Xoa_Sua();
                loadDS();
                txtMaMoi.Enabled = true;
                btnThem.Enabled = true;
                btnLuu.Enabled = false;
            }
        }
        public void UpdateHoaDon()
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
            string mahd = txtMaMoi.Text;
            // string makh = txtMaKH2.Text;
            string masach = txtMaSach.Text;
            int soluong = Int32.Parse(txtSoLuong.Text);
            Sach s = db.Saches.Where(r => r.MaSach == masach).SingleOrDefault();
            var qd = db.QuyDinhs.Where(t => t.MaQuyDinh == 1.ToString()).SingleOrDefault();
            int check = s.TonCuoi - soluong;
            if (check < Int32.Parse(qd.TonBanToiThieu))
            {
                MessageBox.Show("Số lượng tồn của sách này sau khi bán đã nhỏ hơn quy định");
                return;
            }
            KhachHang kh = db.KhachHangs.Where(r => r.MaKh == txtMaKH2.Text).SingleOrDefault();
            if (Int32.Parse(kh.TongNo) > qd.KHNoToiThieu)
            {
                MessageBox.Show("Tiền nợ của khách hàng đã vượt quá quy định");
                return;
            }
            var kt = db.PhieuBans.Where(t => t.MaPhieuBan == mahd && t.MaSach == masach).SingleOrDefault();
            if (kt != null)
            {
                kt.MaSach = masach;
                kt.SoLuong = soluong;
                db.SubmitChanges();
            }


        }

        private void dgvDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dynamic dy = dgvDSHD.CurrentRow.DataBoundItem;


            txtMaSach.Text = dy.MaSach;
            txtTenSach.Text = dy.TenSach;
            txtMaMoi.Text = dy.MaHD;
            txtDonGia.Text = dy.DonGia.ToString();
            txtSoLuong.Text = dy.SoLuong.ToString();
            

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
   
}
