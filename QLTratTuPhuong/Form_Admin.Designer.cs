namespace QLTratTuPhuong
{
    partial class Form_Admin
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
            this.dataGridView_admin = new System.Windows.Forms.DataGridView();
            this.richTextBox_NoiDungAdmin = new System.Windows.Forms.RichTextBox();
            this.button_TaoDon = new System.Windows.Forms.Button();
            this.dateTimePicker_admin = new System.Windows.Forms.DateTimePicker();
            this.button_GuiDGQ = new System.Windows.Forms.Button();
            this.button_Lammoi = new System.Windows.Forms.Button();
            this.button_XemThongTinCaNhan = new System.Windows.Forms.Button();
            this.button_DoiMatKhau = new System.Windows.Forms.Button();
            this.label_NoiDungDon = new System.Windows.Forms.Label();
            this.label_DanhSach = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_admin
            // 
            this.dataGridView_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_admin.Location = new System.Drawing.Point(457, 92);
            this.dataGridView_admin.Name = "dataGridView_admin";
            this.dataGridView_admin.Size = new System.Drawing.Size(306, 218);
            this.dataGridView_admin.TabIndex = 0;
            this.dataGridView_admin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_admin_CellClick);
            // 
            // richTextBox_NoiDungAdmin
            // 
            this.richTextBox_NoiDungAdmin.Location = new System.Drawing.Point(42, 92);
            this.richTextBox_NoiDungAdmin.Name = "richTextBox_NoiDungAdmin";
            this.richTextBox_NoiDungAdmin.Size = new System.Drawing.Size(335, 218);
            this.richTextBox_NoiDungAdmin.TabIndex = 1;
            this.richTextBox_NoiDungAdmin.Text = "\n";
            // 
            // button_TaoDon
            // 
            this.button_TaoDon.Location = new System.Drawing.Point(42, 348);
            this.button_TaoDon.Name = "button_TaoDon";
            this.button_TaoDon.Size = new System.Drawing.Size(107, 35);
            this.button_TaoDon.TabIndex = 2;
            this.button_TaoDon.Text = "Tạo Đơn giải quyết";
            this.button_TaoDon.UseVisualStyleBackColor = true;
            this.button_TaoDon.Click += new System.EventHandler(this.button_TaoDon_Click);
            // 
            // dateTimePicker_admin
            // 
            this.dateTimePicker_admin.Enabled = false;
            this.dateTimePicker_admin.Location = new System.Drawing.Point(177, 348);
            this.dateTimePicker_admin.Name = "dateTimePicker_admin";
            this.dateTimePicker_admin.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_admin.TabIndex = 4;
            this.dateTimePicker_admin.Value = new System.DateTime(2019, 12, 2, 0, 0, 0, 0);
            // 
            // button_GuiDGQ
            // 
            this.button_GuiDGQ.Location = new System.Drawing.Point(42, 389);
            this.button_GuiDGQ.Name = "button_GuiDGQ";
            this.button_GuiDGQ.Size = new System.Drawing.Size(107, 35);
            this.button_GuiDGQ.TabIndex = 5;
            this.button_GuiDGQ.Text = "Gửi Đơn giải quyết";
            this.button_GuiDGQ.UseVisualStyleBackColor = true;
            this.button_GuiDGQ.Click += new System.EventHandler(this.button_GuiDGQ_Click);
            // 
            // button_Lammoi
            // 
            this.button_Lammoi.Location = new System.Drawing.Point(177, 389);
            this.button_Lammoi.Name = "button_Lammoi";
            this.button_Lammoi.Size = new System.Drawing.Size(103, 35);
            this.button_Lammoi.TabIndex = 6;
            this.button_Lammoi.Text = "Làm mới";
            this.button_Lammoi.UseVisualStyleBackColor = true;
            this.button_Lammoi.Click += new System.EventHandler(this.button_Lammoi_Click);
            // 
            // button_XemThongTinCaNhan
            // 
            this.button_XemThongTinCaNhan.Location = new System.Drawing.Point(457, 348);
            this.button_XemThongTinCaNhan.Name = "button_XemThongTinCaNhan";
            this.button_XemThongTinCaNhan.Size = new System.Drawing.Size(107, 35);
            this.button_XemThongTinCaNhan.TabIndex = 7;
            this.button_XemThongTinCaNhan.Text = "Xem thông tin cá nhân";
            this.button_XemThongTinCaNhan.UseVisualStyleBackColor = true;
            this.button_XemThongTinCaNhan.Click += new System.EventHandler(this.button_XemThongTinCaNhan_Click);
            // 
            // button_DoiMatKhau
            // 
            this.button_DoiMatKhau.Location = new System.Drawing.Point(656, 348);
            this.button_DoiMatKhau.Name = "button_DoiMatKhau";
            this.button_DoiMatKhau.Size = new System.Drawing.Size(107, 35);
            this.button_DoiMatKhau.TabIndex = 8;
            this.button_DoiMatKhau.Text = "Đổi mật khẩu";
            this.button_DoiMatKhau.UseVisualStyleBackColor = true;
            this.button_DoiMatKhau.Click += new System.EventHandler(this.button_DoiMatKhau_Click);
            // 
            // label_NoiDungDon
            // 
            this.label_NoiDungDon.AutoSize = true;
            this.label_NoiDungDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NoiDungDon.Location = new System.Drawing.Point(38, 53);
            this.label_NoiDungDon.Name = "label_NoiDungDon";
            this.label_NoiDungDon.Size = new System.Drawing.Size(103, 20);
            this.label_NoiDungDon.TabIndex = 9;
            this.label_NoiDungDon.Text = "Nội dung đơn";
            // 
            // label_DanhSach
            // 
            this.label_DanhSach.AutoSize = true;
            this.label_DanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DanhSach.Location = new System.Drawing.Point(453, 53);
            this.label_DanhSach.Name = "label_DanhSach";
            this.label_DanhSach.Size = new System.Drawing.Size(191, 20);
            this.label_DanhSach.TabIndex = 10;
            this.label_DanhSach.Text = "Danh sách đơn người dân";
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_DanhSach);
            this.Controls.Add(this.label_NoiDungDon);
            this.Controls.Add(this.button_DoiMatKhau);
            this.Controls.Add(this.button_XemThongTinCaNhan);
            this.Controls.Add(this.button_Lammoi);
            this.Controls.Add(this.button_GuiDGQ);
            this.Controls.Add(this.dateTimePicker_admin);
            this.Controls.Add(this.button_TaoDon);
            this.Controls.Add(this.richTextBox_NoiDungAdmin);
            this.Controls.Add(this.dataGridView_admin);
            this.Name = "Form_Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Form_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_admin;
        private System.Windows.Forms.RichTextBox richTextBox_NoiDungAdmin;
        private System.Windows.Forms.Button button_TaoDon;
        private System.Windows.Forms.DateTimePicker dateTimePicker_admin;
        private System.Windows.Forms.Button button_GuiDGQ;
        private System.Windows.Forms.Button button_Lammoi;
        private System.Windows.Forms.Button button_XemThongTinCaNhan;
        private System.Windows.Forms.Button button_DoiMatKhau;
        private System.Windows.Forms.Label label_NoiDungDon;
        private System.Windows.Forms.Label label_DanhSach;
    }
}