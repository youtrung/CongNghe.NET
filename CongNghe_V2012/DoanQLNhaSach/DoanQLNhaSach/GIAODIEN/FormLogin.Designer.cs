namespace DoanQLNhaSach.GIAODIEN
{
    partial class FormLogin
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
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            this.txtMk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdHtmk = new System.Windows.Forms.RadioButton();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cbbQuyen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu :";
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.Location = new System.Drawing.Point(334, 164);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(150, 20);
            this.txtTaikhoan.TabIndex = 2;
            // 
            // txtMk
            // 
            this.txtMk.Location = new System.Drawing.Point(334, 219);
            this.txtMk.Name = "txtMk";
            this.txtMk.Size = new System.Drawing.Size(147, 20);
            this.txtMk.TabIndex = 3;
            this.txtMk.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(300, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đăng Nhập";
            // 
            // rdHtmk
            // 
            this.rdHtmk.AutoSize = true;
            this.rdHtmk.Location = new System.Drawing.Point(499, 219);
            this.rdHtmk.Name = "rdHtmk";
            this.rdHtmk.Size = new System.Drawing.Size(106, 17);
            this.rdHtmk.TabIndex = 5;
            this.rdHtmk.TabStop = true;
            this.rdHtmk.Text = "hiển thị mật khẩu";
            this.rdHtmk.UseVisualStyleBackColor = true;
            this.rdHtmk.CheckedChanged += new System.EventHandler(this.rdHtmk_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(334, 290);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cbbQuyen
            // 
            this.cbbQuyen.FormattingEnabled = true;
            this.cbbQuyen.Location = new System.Drawing.Point(334, 263);
            this.cbbQuyen.Name = "cbbQuyen";
            this.cbbQuyen.Size = new System.Drawing.Size(121, 21);
            this.cbbQuyen.TabIndex = 7;
            this.cbbQuyen.SelectedIndexChanged += new System.EventHandler(this.cbbQuyen_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quyền :";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 428);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbQuyen);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.rdHtmk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMk);
            this.Controls.Add(this.txtTaikhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaikhoan;
        private System.Windows.Forms.TextBox txtMk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdHtmk;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ComboBox cbbQuyen;
        private System.Windows.Forms.Label label4;
    }
}