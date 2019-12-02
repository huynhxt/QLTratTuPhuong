namespace QLTratTuPhuong
{
    partial class Form_DoiMatKhau
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
            this.textBox_MatKhauCu = new System.Windows.Forms.TextBox();
            this.label_MatKhauCu = new System.Windows.Forms.Label();
            this.label_MatKhauMoi = new System.Windows.Forms.Label();
            this.textBox_MatKhauMoi = new System.Windows.Forms.TextBox();
            this.textBox_XacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_XacNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_MatKhauCu
            // 
            this.textBox_MatKhauCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MatKhauCu.Location = new System.Drawing.Point(241, 60);
            this.textBox_MatKhauCu.Name = "textBox_MatKhauCu";
            this.textBox_MatKhauCu.Size = new System.Drawing.Size(219, 26);
            this.textBox_MatKhauCu.TabIndex = 0;
            // 
            // label_MatKhauCu
            // 
            this.label_MatKhauCu.AutoSize = true;
            this.label_MatKhauCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MatKhauCu.Location = new System.Drawing.Point(24, 60);
            this.label_MatKhauCu.Name = "label_MatKhauCu";
            this.label_MatKhauCu.Size = new System.Drawing.Size(96, 20);
            this.label_MatKhauCu.TabIndex = 1;
            this.label_MatKhauCu.Text = "Mật khẩu cũ";
            // 
            // label_MatKhauMoi
            // 
            this.label_MatKhauMoi.AutoSize = true;
            this.label_MatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MatKhauMoi.Location = new System.Drawing.Point(24, 181);
            this.label_MatKhauMoi.Name = "label_MatKhauMoi";
            this.label_MatKhauMoi.Size = new System.Drawing.Size(104, 20);
            this.label_MatKhauMoi.TabIndex = 2;
            this.label_MatKhauMoi.Text = "Mật khẩu mới";
            // 
            // textBox_MatKhauMoi
            // 
            this.textBox_MatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MatKhauMoi.Location = new System.Drawing.Point(241, 181);
            this.textBox_MatKhauMoi.Name = "textBox_MatKhauMoi";
            this.textBox_MatKhauMoi.Size = new System.Drawing.Size(219, 26);
            this.textBox_MatKhauMoi.TabIndex = 3;
            // 
            // textBox_XacNhanMatKhau
            // 
            this.textBox_XacNhanMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_XacNhanMatKhau.Location = new System.Drawing.Point(241, 118);
            this.textBox_XacNhanMatKhau.Name = "textBox_XacNhanMatKhau";
            this.textBox_XacNhanMatKhau.Size = new System.Drawing.Size(219, 26);
            this.textBox_XacNhanMatKhau.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Xác nhận mật khẩu ";
            // 
            // button_XacNhan
            // 
            this.button_XacNhan.Location = new System.Drawing.Point(360, 247);
            this.button_XacNhan.Name = "button_XacNhan";
            this.button_XacNhan.Size = new System.Drawing.Size(100, 37);
            this.button_XacNhan.TabIndex = 7;
            this.button_XacNhan.Text = "Xác nhận";
            this.button_XacNhan.UseVisualStyleBackColor = true;
            this.button_XacNhan.Click += new System.EventHandler(this.button1_XacNhan_Click);
            // 
            // Form_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 325);
            this.Controls.Add(this.button_XacNhan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_XacNhanMatKhau);
            this.Controls.Add(this.textBox_MatKhauMoi);
            this.Controls.Add(this.label_MatKhauMoi);
            this.Controls.Add(this.label_MatKhauCu);
            this.Controls.Add(this.textBox_MatKhauCu);
            this.Name = "Form_DoiMatKhau";
            this.Text = "Form_DoiMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_MatKhauCu;
        private System.Windows.Forms.Label label_MatKhauCu;
        private System.Windows.Forms.Label label_MatKhauMoi;
        private System.Windows.Forms.TextBox textBox_MatKhauMoi;
        private System.Windows.Forms.TextBox textBox_XacNhanMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_XacNhan;
    }
}