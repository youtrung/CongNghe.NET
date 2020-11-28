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
    public partial class FormThuTien : Form
    {
        public FormThuTien()
        {
            InitializeComponent();
        }
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
        QLNSDataContext db = new QLNSDataContext();
     

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Tag.ToString().Equals("1"))
            {
                txtMaThu.Enabled = false;
                btnThem.Enabled = false;
                flag = 1;
                txtMaThu.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                btnSua.Tag = "2";
                btnSua.Text = "Hủy Sửa";
                
            }
            else
            {
                txtMaThu.Enabled = true;
                btnThem.Enabled = true;
                txtMaThu.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                flag = -1;
                btnSua.Tag = "1";
                btnSua.Text = "Sửa";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                InsertThu();
                loadPhieu();
                btnThem.Tag = "1";
                btnSua.Enabled = true;

                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                btnThem.Text = "Thêm";
                flag = -1;

            }
            else if (flag == 1)
            {
                EditPhu();
                MessageBox.Show("Editted", "Thông báo");
                loadPhieu();
               
                btnThem.Enabled = true;

                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                flag = -1;
                btnSua.Tag = "1";
                btnSua.Text = "Sửa";
            }
        }
        public void EditPhu()
        {
            var dt = db.PhieuThus.Where(r => r.MaPhieuThu == txtMaThu.Text).SingleOrDefault();
            if (dt!=null)
            {
                dt.MaKH = cbbMakh.Text;
                dt.NgayThu = dtpNgaythu.Value;
                dt.SoTienThu = Int32.Parse(txtTienThu.Text);
                db.SubmitChanges();
            }
        }
        public void InsertThu()
        {
            if ( txtMaThu.Text == "" || txtTienThu.Text == "" ||txtTienNo.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            if (IsNumber(txtTienThu.Text) == false)
            {
                MessageBox.Show("Số tiền thu phải là số và không được âm", "Thông báo");
                return;
            }
            string mapt = txtMaThu.Text;
            string makh =cbbMakh.Text;
           
            
            int sotien = Int32.Parse(txtTienThu.Text);
            if (sotien > Int32.Parse(txtTienNo.Text))
            {
                MessageBox.Show("Số tiền thu không được vượt quá tiền nợ của khách hàng");
                return;
            }
            var kt = db.PhieuThus.Where(r => r.MaPhieuThu == txtMaThu.Text).SingleOrDefault();
            if (kt!=null)
            {
                MessageBox.Show("Mã phiếu thu không được trùng");
                return;
            }
            PhieuThu pt = new PhieuThu();
            pt.MaKH = makh;
            pt.MaPhieuThu = mapt;
            pt.NgayThu = dtpNgaythu.Value;
            pt.SoTienThu = Int32.Parse(txtTienThu.Text);
            db.PhieuThus.InsertOnSubmit(pt);
            db.SubmitChanges();



        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Tag.ToString().Equals("1"))
            {
                btnSua.Enabled = false;

                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                flag = 0;
                 btnThem.Tag = "2";
                btnThem.Text = "Hủy Thêm ";
                
            }
            else
            {
                btnThem.Tag = "1";
                btnSua.Enabled = true;
                flag = -1;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                btnThem.Text = "Thêm";
              
            }
        }
        public void loadPhieu()
        {
            var query = from p in db.PhieuThus

                        select new
                        {
                            MaPhieu = p.MaPhieuThu,
                            MaKH = p.MaKH,
                            TenKH = p.KhachHang.HoTen,
                            DiaChi=p.KhachHang.DiaChi,
                            SoTienThu = p.SoTienThu,
                            Sdt = p.KhachHang.SDT,
                            Email = p.KhachHang.Email,
                            NgayThu = p.NgayThu,
                        };
            dgvDSHD.DataSource = query;

       
        }

        private void cbbMakh_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kh = db.KhachHangs.Where(r => r.MaKh == cbbMakh.Text).SingleOrDefault();
            if (kh !=null)
            {
                txtEmail.Text = kh.Email;
                txtDiaChi.Text = kh.DiaChi;
                txtSDT.Text = kh.SDT;
                txtTenKH.Text = kh.HoTen;
                txtTienNo.Text = kh.TongNo;
            }
       
            
        }

        private void FormThuTien_Load(object sender, EventArgs e)
        {

            cbbMakh.DisplayMember = "MAKH";
            cbbMakh.DataSource = db.KhachHangs;
            loadPhieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var dt = db.PhieuThus.Where(r => r.MaPhieuThu == txtMaThu.Text).SingleOrDefault();
            if (dt != null)
            {
                db.PhieuThus.DeleteOnSubmit(dt);
                db.SubmitChanges();
            }
            loadPhieu();
        }

        private void dgvDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dynamic sv = dgvDSHD.CurrentRow.DataBoundItem;


            txtMaThu.Text = sv.MaPhieu;
            txtDiaChi.Text = sv.DiaChi;
            txtSDT.Text = sv.Sdt;
            txtEmail.Text = sv.Email;
            
            txtTienThu.Text = sv.SoTienThu.ToString();
            cbbMakh.Text = sv.MaKH;
            txtTenKH.Text = sv.TenKH;

        }
    }
}
