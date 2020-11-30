namespace DoanQLNhaSach.GIAODIEN
{
    partial class FormPhieuNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.dtpNgaynhap = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dataPN = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBoSung = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treePhieuNhap = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.dataPN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phiều Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng Tiền";
            // 
            // txtMaPN
            // 
            this.txtMaPN.Location = new System.Drawing.Point(235, 335);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(116, 20);
            this.txtMaPN.TabIndex = 3;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(663, 335);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(116, 20);
            this.txtTongTien.TabIndex = 4;
            // 
            // dtpNgaynhap
            // 
            this.dtpNgaynhap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaynhap.Location = new System.Drawing.Point(436, 332);
            this.dtpNgaynhap.Name = "dtpNgaynhap";
            this.dtpNgaynhap.Size = new System.Drawing.Size(116, 20);
            this.dtpNgaynhap.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(367, 375);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 25);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(480, 375);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 25);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(586, 375);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 25);
            this.btnSua.TabIndex = 8;
            this.btnSua.Tag = "1";
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(694, 375);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(85, 25);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(364, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 16);
            this.label12.TabIndex = 41;
            this.label12.Text = "Danh sách phiếu nhập:";
            // 
            // dataPN
            // 
            this.dataPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Ngaynhap,
            this.TONGTIEN});
            this.dataPN.Location = new System.Drawing.Point(367, 82);
            this.dataPN.Name = "dataPN";
            this.dataPN.Size = new System.Drawing.Size(412, 247);
            this.dataPN.TabIndex = 42;
            this.dataPN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPN_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAPN";
            this.Column1.HeaderText = "Mã Phiếu Nhập";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Ngaynhap
            // 
            this.Ngaynhap.DataPropertyName = "NGAYNHAP";
            this.Ngaynhap.HeaderText = "Ngày Nhập";
            this.Ngaynhap.Name = "Ngaynhap";
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.DataPropertyName = "TONGTIEN";
            this.TONGTIEN.HeaderText = "Tổng Tiền";
            this.TONGTIEN.Name = "TONGTIEN";
            this.TONGTIEN.Width = 120;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(212, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "PHIẾU NHẬP SÁCH";
            // 
            // btnBoSung
            // 
            this.btnBoSung.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBoSung.Location = new System.Drawing.Point(646, 17);
            this.btnBoSung.Name = "btnBoSung";
            this.btnBoSung.Size = new System.Drawing.Size(133, 59);
            this.btnBoSung.TabIndex = 44;
            this.btnBoSung.Text = "Xem Và Bổ Sung Chi Tiết Phiếu Nhập";
            this.btnBoSung.UseVisualStyleBackColor = true;
            this.btnBoSung.Click += new System.EventHandler(this.btnBoSung_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treePhieuNhap);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 282);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TreeView";
            // 
            // treePhieuNhap
            // 
            this.treePhieuNhap.Location = new System.Drawing.Point(1, 20);
            this.treePhieuNhap.Name = "treePhieuNhap";
            this.treePhieuNhap.Size = new System.Drawing.Size(315, 256);
            this.treePhieuNhap.TabIndex = 0;
            // 
            // FormPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBoSung);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataPN);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpNgaynhap);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtMaPN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPhieuNhap";
            this.Text = "FormPhieuNhap";
            this.Load += new System.EventHandler(this.FormPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.DateTimePicker dtpNgaynhap;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBoSung;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView treePhieuNhap;
    }
}