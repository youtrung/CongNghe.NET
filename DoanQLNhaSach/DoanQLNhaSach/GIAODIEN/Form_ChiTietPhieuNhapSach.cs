using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DoanQLNhaSach.GIAODIEN.FormQuyDinh;
using static DoanQLNhaSach.GIAODIEN.FormPhieuNhap;

namespace DoanQLNhaSach.GIAODIEN
{
    public partial class Form_ChiTietPhieuNhapSach : Form
    {
        public Form_ChiTietPhieuNhapSach()
        {
            InitializeComponent();
        }
        QLNSDataContext db = new QLNSDataContext();
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        public static int TongTienNhap;
        public static string getMS;
        int flag = -1;
        private void Form_ChiTietPhieuNhapSach_Load(object sender, EventArgs e)
        {
            loadDS();
            btnLuu.Enabled = false;
        }
        public void loadDS()
        {
     
            txtMaPN.Text = getMaPN;
            var query = from p in db.ChiTietPhieuNhaps
                        where p.MaPhieuNhap == txtMaPN.Text
                        select new
                        {
                            MaPN = p.MaPhieuNhap,
                            MaSachNhap = p.MaSach,
                            TenSach = p.Sach.TenSach,
                            DonGiaNhap = p.DonGia,
                            TongTien = p.TongTien,
                            SoLuongNhap = p.SoLuong
                        };
            dgvCTPN.DataSource = query;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            InsertCT();
            loadDS();
        }
        public void InsertCT()
        {
            if (txtMaPN.Text == "" || txtMaSach.Text == "" || txtDonGia.Text == "" || txtSLnhap.Text == "" || txtTongTien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (IsNumber(txtSLnhap.Text) == false)
            {
                MessageBox.Show("Số lượng phải là số và không được âm", "Thông báo");
                return;
            }
            if (IsNumber(txtDonGia.Text) == false)
            {
                MessageBox.Show("Đơn giá phải là số và không được âm", "Thông báo");
                return;
            }
            Sach s = db.Saches.Where(t => t.MaSach == txtMaSach.Text).SingleOrDefault();
            if (s == null) { MessageBox.Show("Khong ton tai ma sach nay"); return; }
            var qd = db.QuyDinhs.Where(t => t.MaQuyDinh == "1").SingleOrDefault();
            if (s.TonCuoi >Int32.Parse(qd.TonNhapToiThieu))
            {
                MessageBox.Show("Chỉ được nhập sách có số lượng tồn ít hơn " + qd.TonNhapToiThieu);
                return;
            }
            if (Int32.Parse(txtSLnhap.Text) < Int32.Parse(qd.NhapToiThieu))
            {
                MessageBox.Show("Số lượng nhập tối thiểu là " + qd.NhapToiThieu);
                return;
            }
            var kt = db.ChiTietPhieuNhaps.Where(r => r.MaPhieuNhap == txtMaPN.Text && r.MaSach == txtMaSach.Text).SingleOrDefault();
            if (kt != null)
            {
                MessageBox.Show("Sách này đã có trong phiếu nhập");
                return;
            }
            ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap();
            ctpn.MaPhieuNhap = txtMaPN.Text;
            ctpn.MaSach = txtMaSach.Text;
            ctpn.SoLuong = Int32.Parse(txtSLnhap.Text);
            ctpn.DonGia = Int32.Parse(txtDonGia.Text);
            ctpn.TongTien = Int32.Parse(txtTongTien.Text);
            db.ChiTietPhieuNhaps.InsertOnSubmit(ctpn);
            db.SubmitChanges();
            updatesoluongton();


        }
        public void updatesoluongton()
        {
            Sach s = db.Saches.Where(t => t.MaSach == txtMaSach.Text).SingleOrDefault();
            int check = s.TonCuoi + Int32.Parse(txtSLnhap.Text);
            int tn = Int32.Parse(s.TongNhap) + Int32.Parse(txtSLnhap.Text);
            int tongban = Int32.Parse(s.TongBan);
            int phatsinh = tn - tongban;

            int tondau = check - phatsinh;
            s.TongBan = tongban.ToString();
            s.TongNhap = tn.ToString();
            s.TonDau = tondau.ToString();
            s.TonCuoi = check;
            db.SubmitChanges();
        }
        public void UpdateSoLuongTon_Xoa_Sua()
        {
            // txtMaSach.Text = GetMaSach.getMaSach;
            Sach s = db.Saches.Where(t => t.MaSach == txtMaSach.Text).SingleOrDefault();
            int check = s.TonCuoi - Int32.Parse(txtSLnhap.Text);
            int tn = Int32.Parse(s.TongNhap) - Int32.Parse(txtSLnhap.Text);
            int tongban = Int32.Parse(s.TongBan);
            int phatsinh = tn - tongban;
            int tondau = check - phatsinh;
            s.TongBan = tongban.ToString();
            s.TongNhap = tn.ToString();
            s.TonDau = tondau.ToString();
            s.TonCuoi = check;
            db.SubmitChanges();


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var kt = db.ChiTietPhieuNhaps.Where(r => r.MaPhieuNhap == txtMaPN.Text && r.MaSach == txtMaSach.Text).SingleOrDefault();
            if (txtMaPN.Text == "" || txtMaSach.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (kt == null)
            {
                MessageBox.Show("Không tồn tại phiếu nhập ");
                return;
            }
            db.ChiTietPhieuNhaps.DeleteOnSubmit(kt);
            db.SubmitChanges();
            UpdateSoLuongTon_Xoa_Sua();
            loadDS();

        }

        private void dgvCTPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dynamic dt = dgvCTPN.CurrentRow.DataBoundItem;
            txtMaPN.Text = dt.MaPN;
            txtMaSach.Text = dt.MaSachNhap;
            txtSLnhap.Text = dt.SoLuongNhap.ToString();
            txtDonGia.Text = dt.DonGiaNhap.ToString();
            txtTenSach.Text = dt.TenSach;
            txtTongTien.Text = dt.TongTien.ToString();
        }

        private void btnMaSach_Click(object sender, EventArgs e)
        {
            FormSach frm = new FormSach();
            frm.ShowDialog();
            txtMaSach.Text = getMS;
        }

        private void txtMaSach_TextChanged(object sender, EventArgs e)
        {
            var s = db.Saches.Where(t => t.MaSach == getMS).SingleOrDefault();
            if (s!=null)
            {
                txtTenSach.Text = s.TenSach;
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Tag.ToString().Equals("1"))
            {
                txtMaPN.Enabled = false;
                txtMaSach.Enabled = false;
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
                txtMaSach.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;

                btnSua.Tag = "1";
                btnSua.Text = "Sửa";
            }
        }
        public void suaCTPN()
        {
            var qd = db.QuyDinhs.Where(t => t.MaQuyDinh == "1").SingleOrDefault();
            if (txtMaPN.Text == "" || txtMaSach.Text == "" || txtDonGia.Text == "" || txtSLnhap.Text == "" || txtTongTien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (IsNumber(txtSLnhap.Text) == false)
            {
                MessageBox.Show("Số lượng phải là số và không được âm", "Thông báo");
                return;
            }
            if (IsNumber(txtDonGia.Text) == false)
            {
                MessageBox.Show("Đơn giá phải là số và không được âm", "Thông báo");
                return;
            }

            if (Int32.Parse(txtSLnhap.Text) < Int32.Parse(qd.NhapToiThieu))
            {
                MessageBox.Show("Số lượng nhập tối thiểu là " + qd.NhapToiThieu);
                return;
            }
            var kt = db.ChiTietPhieuNhaps.Where(t => t.MaPhieuNhap == txtMaPN.Text && t.MaSach == txtMaSach.Text).SingleOrDefault();
            if (kt!=null)
            {
                kt.DonGia =Int32.Parse(txtDonGia.Text);
                kt.SoLuong = Int32.Parse(txtSLnhap.Text);
                kt.TongTien = Int32.Parse(txtTongTien.Text);
                db.SubmitChanges();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            suaCTPN();
            updatesoluongton();
            loadDS();
            txtMaPN.Enabled = true;
            btnThem.Enabled = true;
            txtMaSach.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;

            btnSua.Tag = "1";
            btnSua.Text = "Sửa";

        }

        private void txtSLnhap_TextChanged(object sender, EventArgs e)
        {
            int dg, sl,kq;
            if (txtDonGia.Text !="" && txtSLnhap.Text != "")
            {
                dg = Int32.Parse(txtDonGia.Text);
                sl = Int32.Parse(txtSLnhap.Text);
                kq = dg * sl;
                txtTongTien.Text = kq.ToString();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPhieuNhap frm = new FormPhieuNhap();
            frm.ShowDialog();
            
        }
    }
}
