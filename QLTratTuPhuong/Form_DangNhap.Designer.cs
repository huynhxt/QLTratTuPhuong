namespace QLTratTuPhuong
{
    partial class Form_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DangNhap));
            this.label_title = new System.Windows.Forms.Label();
            this.button_dangnhap = new System.Windows.Forms.Button();
            this.textBox_taikhoan = new System.Windows.Forms.TextBox();
            this.textBox_matkhau = new System.Windows.Forms.TextBox();
            this.label_taikhoan = new System.Windows.Forms.Label();
            this.label_matkhau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(174, 59);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(512, 31);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Phần mềm Quản lí trật tự/ an ninh phường";
            // 
            // button_dangnhap
            // 
            this.button_dangnhap.Location = new System.Drawing.Point(297, 306);
            this.button_dangnhap.Name = "button_dangnhap";
            this.button_dangnhap.Size = new System.Drawing.Size(197, 60);
            this.button_dangnhap.TabIndex = 1;
            this.button_dangnhap.Text = "Đăng nhập";
            this.button_dangnhap.UseVisualStyleBackColor = true;
            this.button_dangnhap.Click += new System.EventHandler(this.button_dangnhap_Click);
            // 
            // textBox_taikhoan
            // 
            this.textBox_taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_taikhoan.Location = new System.Drawing.Point(242, 186);
            this.textBox_taikhoan.Name = "textBox_taikhoan";
            this.textBox_taikhoan.Size = new System.Drawing.Size(340, 26);
            this.textBox_taikhoan.TabIndex = 2;
            // 
            // textBox_matkhau
            // 
            this.textBox_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_matkhau.Location = new System.Drawing.Point(242, 246);
            this.textBox_matkhau.Name = "textBox_matkhau";
            this.textBox_matkhau.PasswordChar = '*';
            this.textBox_matkhau.Size = new System.Drawing.Size(340, 26);
            this.textBox_matkhau.TabIndex = 3;
            // 
            // label_taikhoan
            // 
            this.label_taikhoan.AutoSize = true;
            this.label_taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_taikhoan.Location = new System.Drawing.Point(111, 186);
            this.label_taikhoan.Name = "label_taikhoan";
            this.label_taikhoan.Size = new System.Drawing.Size(78, 20);
            this.label_taikhoan.TabIndex = 4;
            this.label_taikhoan.Text = "Tài khoản";
            // 
            // label_matkhau
            // 
            this.label_matkhau.AutoSize = true;
            this.label_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_matkhau.Location = new System.Drawing.Point(114, 246);
            this.label_matkhau.Name = "label_matkhau";
            this.label_matkhau.Size = new System.Drawing.Size(75, 20);
            this.label_matkhau.TabIndex = 5;
            this.label_matkhau.Text = "Mật khẩu";
            // 
            // Form_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_matkhau);
            this.Controls.Add(this.label_taikhoan);
            this.Controls.Add(this.textBox_matkhau);
            this.Controls.Add(this.textBox_taikhoan);
            this.Controls.Add(this.button_dangnhap);
            this.Controls.Add(this.label_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_DangNhap";
            this.Text = "Quản lí trật tự/an ninh phường";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_dangnhap;
        private System.Windows.Forms.TextBox textBox_taikhoan;
        private System.Windows.Forms.TextBox textBox_matkhau;
        private System.Windows.Forms.Label label_taikhoan;
        private System.Windows.Forms.Label label_matkhau;
    }
}

