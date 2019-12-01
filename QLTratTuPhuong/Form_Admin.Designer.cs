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
            this.dateTimePicker_admin.Location = new System.Drawing.Point(177, 348);
            this.dateTimePicker_admin.Name = "dateTimePicker_admin";
            this.dateTimePicker_admin.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_admin.TabIndex = 4;
            this.dateTimePicker_admin.Value = new System.DateTime(2019, 12, 2, 0, 0, 0, 0);
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker_admin);
            this.Controls.Add(this.button_TaoDon);
            this.Controls.Add(this.richTextBox_NoiDungAdmin);
            this.Controls.Add(this.dataGridView_admin);
            this.Name = "Form_Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Form_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_admin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_admin;
        private System.Windows.Forms.RichTextBox richTextBox_NoiDungAdmin;
        private System.Windows.Forms.Button button_TaoDon;
        private System.Windows.Forms.DateTimePicker dateTimePicker_admin;
    }
}