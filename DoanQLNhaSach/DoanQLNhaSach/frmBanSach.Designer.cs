namespace DoanQLNhaSach
{
    partial class frmBanSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaMoi = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtMaKH2 = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnMaSach = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenKH2 = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1572, 147);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(624, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "HÓA ĐƠN BÁN SÁCH ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtTenKH2);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtTenSach);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnMaSach);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtMaKH2);
            this.groupBox1.Controls.Add(this.txtMaSach);
            this.groupBox1.Controls.Add(this.txtMaMoi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1563, 491);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lập Hóa Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Hóa Đơn :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Sách (*):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã KH (*) : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 37);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số Lượng :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 37);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tổng Tiền :";
            // 
            // txtMaMoi
            // 
            this.txtMaMoi.Location = new System.Drawing.Point(260, 72);
            this.txtMaMoi.Name = "txtMaMoi";
            this.txtMaMoi.Size = new System.Drawing.Size(318, 44);
            this.txtMaMoi.TabIndex = 5;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(260, 137);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(318, 44);
            this.txtMaSach.TabIndex = 6;
            // 
            // txtMaKH2
            // 
            this.txtMaKH2.Location = new System.Drawing.Point(260, 208);
            this.txtMaKH2.Name = "txtMaKH2";
            this.txtMaKH2.Size = new System.Drawing.Size(318, 44);
            this.txtMaKH2.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(260, 299);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(318, 44);
            this.txtSoLuong.TabIndex = 8;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(260, 380);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(318, 44);
            this.txtTongTien.TabIndex = 9;
            // 
            // btnMaSach
            // 
            this.btnMaSach.Location = new System.Drawing.Point(610, 157);
            this.btnMaSach.Name = "btnMaSach";
            this.btnMaSach.Size = new System.Drawing.Size(75, 54);
            this.btnMaSach.TabIndex = 10;
            this.btnMaSach.Text = ">";
            this.btnMaSach.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(795, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 37);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tên Sách (*):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(802, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 37);
            this.label8.TabIndex = 12;
            this.label8.Text = "Đơn Gía (*):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(802, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 37);
            this.label9.TabIndex = 13;
            this.label9.Text = "Tên KH (*):";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(1054, 78);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(355, 44);
            this.txtTenSach.TabIndex = 14;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(1054, 179);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(355, 44);
            this.txtDonGia.TabIndex = 15;
            // 
            // txtTenKH2
            // 
            this.txtTenKH2.Location = new System.Drawing.Point(1054, 264);
            this.txtTenKH2.Name = "txtTenKH2";
            this.txtTenKH2.Size = new System.Drawing.Size(355, 44);
            this.txtTenKH2.TabIndex = 16;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(722, 380);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(152, 53);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "THÊM ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(921, 380);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(136, 53);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(1102, 380);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(147, 53);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(1289, 380);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(141, 53);
            this.btnLuu.TabIndex = 20;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(844, 769);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(324, 67);
            this.btnXuat.TabIndex = 21;
            this.btnXuat.Text = "XUẤT HÓA ĐƠN ";
            this.btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(1206, 769);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(195, 67);
            this.btnHuy.TabIndex = 22;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 769);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Danh sách hóa đơn: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaSach,
            this.TenSach,
            this.DonGia,
            this.SoLuong});
            this.dataGridView1.Location = new System.Drawing.Point(39, 858);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1516, 349);
            this.dataGridView1.TabIndex = 24;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // MaSach
            // 
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.Width = 150;
            // 
            // TenSach
            // 
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.Name = "TenSach";
            this.TenSach.Width = 150;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn Gía";
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 150;
            // 
            // frmBanSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 1245);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmBanSach";
            this.Text = "frmBanSach";
            this.Load += new System.EventHandler(this.frmBanSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenKH2;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMaSach;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtMaKH2;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtMaMoi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}