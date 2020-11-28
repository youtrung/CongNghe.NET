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
    public partial class FormSach : Form
    {
        QLNSDataContext db = new QLNSDataContext();
        public FormSach()
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
        private void FormSach_Load(object sender, EventArgs e)
        {
            loadSach();
            btnLuu.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Tag.ToString().Equals("1"))
            {
                btnSua.Enabled = false;
                
                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                txtLuongton.Text = "0";
                btnThem.Tag = "2";
                btnThem.Text = "Hủy Thêm ";
                flag = 0;
            }
            else
            {
                btnThem.Tag = "1";
                btnSua.Enabled = true;
                
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                btnThem.Text = "Thêm";
                flag = -1;
            }
               
        }
        public void loadSach()
        {
            var data = from k in db.Saches
                       select new
                       {
                           MaSach = k.MaSach,
                           TenSach = k.TenSach,
                           TheLoai=k.TheLoai,
                           TacGia = k.TacGia,
                           DonGia = k.DonGia,
                           LuongTon = k.TonCuoi,
                       };
            dataSach.DataSource = data;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                InsertSach();
                loadSach();

            }
            else if (flag == 1)
            {
                EditSach();
                MessageBox.Show("Editted", "Thông báo");
                loadSach();
                txtMaSach.Enabled = true;
            }
        }
        public void EditSach()
        {
            if (IsNumber(txtLuongton.Text) == false)
            {
                MessageBox.Show("Số lượng tồn phải là số và không được âm", "Thông báo");
                return;
            }
            if (IsNumber(txtDonGia.Text) == false)
            {
                MessageBox.Show("Đơn giá phải là số và không được âm", "Thông báo");
                return;
            }
           

            if (txtMaSach.Text == "" || txtTenSach.Text == "" || txtTheLoai.Text == "" || txtTacGia.Text == "" || txtDonGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            string masach = txtMaSach.Text;
            string tensach = txtTenSach.Text;
            string theloai = txtTheLoai.Text;
            string tacgia = txtTacGia.Text;
            int dongia = Int32.Parse(txtDonGia.Text);
            var kt = db.Saches.Where(t => t.MaSach == masach).SingleOrDefault();
            if (kt !=null )
            {
                kt.MaSach = masach;
                kt.TenSach = tensach;
                kt.TheLoai = theloai;
                kt.TacGia = tacgia;
                kt.DonGia = dongia;
            }
            else
                MessageBox.Show("Không tồn tại mã sách này ");


            db.SubmitChanges();
        }
            public void InsertSach()
        {
            if (IsNumber(txtLuongton.Text) == false)
            {
                MessageBox.Show("Số lượng tồn phải là số và không được âm", "Thông báo");
                return;
            }
            if (IsNumber(txtDonGia.Text) == false)
            {
                MessageBox.Show("Đơn giá phải là số và không được âm", "Thông báo");
                return;
            }
          

            if (txtMaSach.Text == "" || txtTenSach.Text == "" || txtTheLoai.Text == "" || txtTacGia.Text == "" || txtDonGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            string masach = txtMaSach.Text;
            string tensach = txtTenSach.Text;
            string theloai = txtTheLoai.Text;
            string tacgia = txtTacGia.Text;
            int dongia = Int32.Parse(txtDonGia.Text);
            var kt = db.Saches.Where(t => t.MaSach == masach).SingleOrDefault();
            if (kt!=null)
            {
                MessageBox.Show("Mã sách không được trùng");
                return;
            }
            else
            {
<<<<<<< HEAD
                
=======
>>>>>>> 8862b469ab471492bde9e73abede639a45296b58
                Sach s = new Sach();
                s.MaSach = masach;
                s.TenSach = tensach;
                s.TheLoai = theloai;
                s.TacGia = tacgia;
                s.DonGia = dongia;
                s.TonDau = "0";
                s.TongBan = "0";
                s.TongNhap = "0";
                s.PhatSinh = "0";
              
                db.Saches.InsertOnSubmit(s);
                db.SubmitChanges();
            }
            MessageBox.Show("Thêm sách thành công!");

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Tag.ToString().Equals("1"))
            {
                txtMaSach.Enabled = false;
                btnThem.Enabled = false;
               
                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                btnSua.Tag = "2";
                btnSua.Text = "Hủy Sửa";
                flag = 1;
            }
            else
            {
                txtMaSach.Enabled = true;
                btnThem.Enabled = true;
               
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                flag = -1;
                btnSua.Tag = "1";
                btnSua.Text = "Sửa";
            }
               

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xoá sách này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (txtMaSach.Text == "")
                {
                    MessageBox.Show("Không được để trống Mã Khách hàng ");
                    return;
                }
                string masach = txtMaSach.Text;
                var kt = db.Saches.Where(t => t.MaSach == masach).SingleOrDefault();
                db.Saches.DeleteOnSubmit(kt);
                db.SubmitChanges();
                MessageBox.Show("Xoá sách thành công!");
                
            }
        }

        private void dataSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dynamic sv = dataSach.CurrentRow.DataBoundItem;


            txtMaSach.Text = sv.MaSach;
            txtTenSach.Text = sv.TenSach;
            txtTacGia.Text = sv.TacGia;
            txtDonGia.Text = sv.DonGia.ToString();
            txtLuongton.Text = sv.LuongTon.ToString();
            txtTheLoai.Text = sv.TheLoai;



        }
<<<<<<< HEAD

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTimTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radTatCa_CheckedChanged(object sender, EventArgs e)
        {

        }
=======
>>>>>>> 8862b469ab471492bde9e73abede639a45296b58
    }
}
