namespace QLTratTuPhuong
{
    partial class Form_NguoiDan
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
            this.dataGridView_NguoiDan = new System.Windows.Forms.DataGridView();
            this.richTextBox_NoiDung = new System.Windows.Forms.RichTextBox();
            this.button_GuiDon = new System.Windows.Forms.Button();
            this.dateTimePicker_NguoiDan = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_XemThongTinCaNhan = new System.Windows.Forms.Button();
            this.button_DoiMatKhau = new System.Windows.Forms.Button();
            this.button_LamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NguoiDan)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_NguoiDan
            // 
            this.dataGridView_NguoiDan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NguoiDan.Location = new System.Drawing.Point(435, 78);
            this.dataGridView_NguoiDan.Name = "dataGridView_NguoiDan";
            this.dataGridView_NguoiDan.Size = new System.Drawing.Size(352, 186);
            this.dataGridView_NguoiDan.TabIndex = 0;
            this.dataGridView_NguoiDan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_NguoiDan_CellClick);
            // 
            // richTextBox_NoiDung
            // 
            this.richTextBox_NoiDung.Location = new System.Drawing.Point(31, 78);
            this.richTextBox_NoiDung.Name = "richTextBox_NoiDung";
            this.richTextBox_NoiDung.Size = new System.Drawing.Size(347, 186);
            this.richTextBox_NoiDung.TabIndex = 1;
            this.richTextBox_NoiDung.Text = "";
            // 
            // button_GuiDon
            // 
            this.button_GuiDon.Location = new System.Drawing.Point(31, 313);
            this.button_GuiDon.Name = "button_GuiDon";
            this.button_GuiDon.Size = new System.Drawing.Size(119, 46);
            this.button_GuiDon.TabIndex = 2;
            this.button_GuiDon.Text = "Tạo và gửi đơn";
            this.button_GuiDon.UseVisualStyleBackColor = true;
            this.button_GuiDon.Click += new System.EventHandler(this.button_GuiDon_Click);
            // 
            // dateTimePicker_NguoiDan
            // 
            this.dateTimePicker_NguoiDan.Location = new System.Drawing.Point(178, 313);
            this.dateTimePicker_NguoiDan.Name = "dateTimePicker_NguoiDan";
            this.dateTimePicker_NguoiDan.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_NguoiDan.TabIndex = 3;
            this.dateTimePicker_NguoiDan.Value = new System.DateTime(2019, 12, 2, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nội dung đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Danh sách đơn đã gửi";
            // 
            // button_XemThongTinCaNhan
            // 
            this.button_XemThongTinCaNhan.Location = new System.Drawing.Point(435, 313);
            this.button_XemThongTinCaNhan.Name = "button_XemThongTinCaNhan";
            this.button_XemThongTinCaNhan.Size = new System.Drawing.Size(119, 46);
            this.button_XemThongTinCaNhan.TabIndex = 6;
            this.button_XemThongTinCaNhan.Text = "Xem thông tin cá nhân";
            this.button_XemThongTinCaNhan.UseVisualStyleBackColor = true;
            this.button_XemThongTinCaNhan.Click += new System.EventHandler(this.button_XemThongTinCaNhan_Click);
            // 
            // button_DoiMatKhau
            // 
            this.button_DoiMatKhau.Location = new System.Drawing.Point(596, 313);
            this.button_DoiMatKhau.Name = "button_DoiMatKhau";
            this.button_DoiMatKhau.Size = new System.Drawing.Size(119, 46);
            this.button_DoiMatKhau.TabIndex = 7;
            this.button_DoiMatKhau.Text = "Đổi mật khẩu";
            this.button_DoiMatKhau.UseVisualStyleBackColor = true;
            this.button_DoiMatKhau.Click += new System.EventHandler(this.button_DoiMatKhau_Click);
            // 
            // button_LamMoi
            // 
            this.button_LamMoi.Location = new System.Drawing.Point(31, 383);
            this.button_LamMoi.Name = "button_LamMoi";
            this.button_LamMoi.Size = new System.Drawing.Size(119, 46);
            this.button_LamMoi.TabIndex = 8;
            this.button_LamMoi.Text = "Làm Mới";
            this.button_LamMoi.UseVisualStyleBackColor = true;
            this.button_LamMoi.Click += new System.EventHandler(this.button_LamMoi_Click);
            // 
            // Form_NguoiDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_LamMoi);
            this.Controls.Add(this.button_DoiMatKhau);
            this.Controls.Add(this.button_XemThongTinCaNhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_NguoiDan);
            this.Controls.Add(this.button_GuiDon);
            this.Controls.Add(this.richTextBox_NoiDung);
            this.Controls.Add(this.dataGridView_NguoiDan);
            this.Name = "Form_NguoiDan";
            this.Text = "Form_NguoiDan";
            this.Load += new System.EventHandler(this.Form_NguoiDan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NguoiDan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_NguoiDan;
        private System.Windows.Forms.RichTextBox richTextBox_NoiDung;
        private System.Windows.Forms.Button button_GuiDon;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NguoiDan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_XemThongTinCaNhan;
        private System.Windows.Forms.Button button_DoiMatKhau;
        private System.Windows.Forms.Button button_LamMoi;
    }
}