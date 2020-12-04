namespace DoanQLNhaSach.GIAODIEN
{
    partial class FormBaoCaoNo
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
            this.dgvBaoCaoNo = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhatSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoCuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoNo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "BÁO CÁO CÔNG NỢ ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Báo cáo công nợ :";
            // 
            // dgvBaoCaoNo
            // 
            this.dgvBaoCaoNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCaoNo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.Email,
            this.NoDau,
            this.PhatSinh,
            this.NoCuoi});
            this.dgvBaoCaoNo.Location = new System.Drawing.Point(50, 167);
            this.dgvBaoCaoNo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBaoCaoNo.Name = "dgvBaoCaoNo";
            this.dgvBaoCaoNo.RowTemplate.Height = 33;
            this.dgvBaoCaoNo.Size = new System.Drawing.Size(678, 152);
            this.dgvBaoCaoNo.TabIndex = 4;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKh";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.Name = "MaKH";
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên KH";
            this.TenKH.Name = "TenKH";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // NoDau
            // 
            this.NoDau.DataPropertyName = "NoDau";
            this.NoDau.HeaderText = "Nợ Đầu";
            this.NoDau.Name = "NoDau";
            // 
            // PhatSinh
            // 
            this.PhatSinh.DataPropertyName = "PhatSinh";
            this.PhatSinh.HeaderText = "Phát Sinh";
            this.PhatSinh.Name = "PhatSinh";
            // 
            // NoCuoi
            // 
            this.NoCuoi.DataPropertyName = "NoCuoi";
            this.NoCuoi.HeaderText = "Nợ Công ";
            this.NoCuoi.Name = "NoCuoi";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(646, 372);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(82, 31);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // FormBaoCaoNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvBaoCaoNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormBaoCaoNo";
            this.Text = "FormBaoCaoNo";
            this.Load += new System.EventHandler(this.FormBaoCaoNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBaoCaoNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhatSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoCuoi;
        private System.Windows.Forms.Button btnThoat;
    }
}