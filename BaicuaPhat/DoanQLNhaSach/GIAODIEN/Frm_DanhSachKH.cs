﻿using System;
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
    public partial class Frm_DanhSachKH : Form
    {
        QLNSDataContext db = new QLNSDataContext();
        public Frm_DanhSachKH()
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
        public void loadKhachHang()
        {
            var data = from k in db.KhachHangs
                       select new
                       {
                           MaKH = k.MaKh,
                           TenKH = k.HoTen,
                           DiaChi = k.DiaChi,
                           Email = k.Email,
                           SoDienThoai = k.SDT,
                           TongNo = k.TongNo,
                       };
            dtgvKH.DataSource = data;
        }

        private void Frm_DanhSachKH_Load(object sender, EventArgs e)
        {
            loadKhachHang();
            btnLuu.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                InsertKhachHang();
                loadKhachHang();

            }
            else if (flag == 1)
            {
                EditKhachHang();
                MessageBox.Show("Editted", "Thông báo");
                loadKhachHang();
                txtMaKH.Enabled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Tag.ToString().Equals("1"))
            {
                btnSua.Enabled = false;

                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
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
        public void EditKhachHang()
        {
            if (txtMaKH.Text == "" || txtTenKH.Text == "" || txtEmail.Text == "" || txtDiaChi.Text == "" || txtDienthoai.Text == "" || txtTongno.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            string MaKH = txtMaKH.Text;
            string TenKH = txtTenKH.Text;
            string Email = txtEmail.Text;
            string DiaChi = txtDiaChi.Text;
            string SoDienThoai = txtDienthoai.Text;
            string TongNo = txtTongno.Text;
            var kt = db.KhachHangs.Where(t => t.MaKh == MaKH).SingleOrDefault();
            if (kt != null)
            {
                kt.MaKh = MaKH;
                kt.HoTen = TenKH;
                kt.Email = Email;
                kt.DiaChi = DiaChi;
                kt.SDT = SoDienThoai;
                kt.TongNo = TongNo;
            }
            else
                MessageBox.Show("Không tồn tại mã khách hàng này ");

            db.SubmitChanges();
        }
        public void InsertKhachHang()
        {
            if (txtMaKH.Text == "" || txtTenKH.Text == "" || txtEmail.Text == "" || txtDiaChi.Text == "" || txtDienthoai.Text == "" || txtTongno.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            string MaKH = txtMaKH.Text;
            string TenKH = txtTenKH.Text;
            string Email = txtEmail.Text;
            string DiaChi = txtDiaChi.Text;
            string SoDienThoai = txtDienthoai.Text;
            string TongNo = txtTongno.Text;
            var kt = db.KhachHangs.Where(t => t.MaKh == MaKH).SingleOrDefault();
            if (kt != null)
            {
                MessageBox.Show("Mã khách hàng không được trùng");
                return;
            }
            else
            {
                KhachHang kh = new KhachHang();
                kh.MaKh = MaKH;
                kh.HoTen = TenKH;
                kh.Email = Email;
                kh.DiaChi = DiaChi;
                kh.SDT = SoDienThoai;
                kh.TongNo = TongNo;

                db.KhachHangs.InsertOnSubmit(kh);
                db.SubmitChanges();
            }
            MessageBox.Show("Thêm sách thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Tag.ToString().Equals("1"))
            {
                txtMaKH.Enabled = false;
                btnThem.Enabled = false;

                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                btnSua.Tag = "2";
                btnSua.Text = "Hủy Sửa";
                flag = 1;
            }
            else
            {
                txtMaKH.Enabled = true;
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
            if (MessageBox.Show("Bạn có chắc muốn xoá khách hàng này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (txtMaKH.Text == "")
                {
                    MessageBox.Show("Không được để trống Mã Khách hàng ");
                    return;
                }
                string Makh = txtMaKH.Text;
                var kt = db.KhachHangs.Where(t => t.MaKh == Makh).SingleOrDefault();
                db.KhachHangs.DeleteOnSubmit(kt);
                db.SubmitChanges();
                MessageBox.Show("Xoá khách hàng thành công!");

            }
        }

        private void dtgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dynamic dy = dtgvKH.CurrentRow.DataBoundItem;
            txtMaKH.Text=dy.MaKH;
            txtTenKH.Text = dy.TenKH ;
            txtEmail.Text = dy.Email;
            txtDiaChi.Text = dy.DiaChi;
            txtDienthoai.Text = dy.SoDienThoai;
            txtTongno.Text = dy.TongNo;
        }

        private void dtgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
