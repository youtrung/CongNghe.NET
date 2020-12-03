namespace DoanQLNhaSach.GIAODIEN
{
    partial class FormBaoCaoTon
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
            this.dgvBaoCaoTon = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TonDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhatSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TonCuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoTon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(309, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "BÁO CÁO TỒN KHO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Báo cáo tồn kho :";
            // 
            // dgvBaoCaoTon
            // 
            this.dgvBaoCaoTon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCaoTon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.TonDau,
            this.TongNhap,
            this.TongBan,
            this.PhatSinh,
            this.TonCuoi});
            this.dgvBaoCaoTon.Location = new System.Drawing.Point(90, 207);
            this.dgvBaoCaoTon.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBaoCaoTon.Name = "dgvBaoCaoTon";
            this.dgvBaoCaoTon.RowTemplate.Height = 33;
            this.dgvBaoCaoTon.Size = new System.Drawing.Size(594, 161);
            this.dgvBaoCaoTon.TabIndex = 4;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.Name = "MaSach";
            // 
            // TenSach
            // 
            this.TenSach.HeaderText = "Tên Sách ";
            this.TenSach.Name = "TenSach";
            // 
            // TonDau
            // 
            this.TonDau.DataPropertyName = "TonDau";
            this.TonDau.HeaderText = "Tồn Đầu";
            this.TonDau.Name = "TonDau";
            // 
            // TongNhap
            // 
            this.TongNhap.DataPropertyName = "TongNhap";
            this.TongNhap.HeaderText = "Tổng nhập";
            this.TongNhap.Name = "TongNhap";
            // 
            // TongBan
            // 
            this.TongBan.DataPropertyName = "TongBan";
            this.TongBan.HeaderText = "Tổng bán";
            this.TongBan.Name = "TongBan";
            // 
            // PhatSinh
            // 
            this.PhatSinh.DataPropertyName = "PhatSinh";
            this.PhatSinh.HeaderText = "Phát sinh";
            this.PhatSinh.Name = "PhatSinh";
            // 
            // TonCuoi
            // 
            this.TonCuoi.DataPropertyName = "TonCuoi";
            this.TonCuoi.HeaderText = "Tồn Cuối";
            this.TonCuoi.Name = "TonCuoi";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(616, 383);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 56);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // FormBaoCaoTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvBaoCaoTon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormBaoCaoTon";
            this.Text = "FormBaoCaoTon";
            this.Load += new System.EventHandler(this.FormBaoCaoTon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoTon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBaoCaoTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TonDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhatSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TonCuoi;
        private System.Windows.Forms.Button btnThoat;
    }
}