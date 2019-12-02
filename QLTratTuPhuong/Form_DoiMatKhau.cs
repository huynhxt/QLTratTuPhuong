using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTratTuPhuong
{
    public partial class Form_DoiMatKhau : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=QLP;Integrated Security=True");
        private NguoiQuanLy nguoiQuanLy;
        private NguoiDan nguoiDan;
        private string matKhauMoi;
        public Form_DoiMatKhau(NguoiQuanLy nguoiQuanLy)
        {
            InitializeComponent();
            this.nguoiQuanLy = nguoiQuanLy;
            //this.matKhauMoi = matKhauMoi;
        }
        public Form_DoiMatKhau(NguoiDan nguoiDan)
        {
            InitializeComponent();
            this.nguoiDan = nguoiDan;
            
        }

        /*private void button_Click(object sender, EventArgs e)
        {
            
        }
        */
        private bool check_error()
        {
            if(textBox_XacNhanMatKhau.Text != textBox_MatKhauCu.Text)
            {
                MessageBox.Show("Mật khẩu chưa khớp vui lòng nhập lại");
                return false;
            }
            return true;
        }
        private void Update_Password(NguoiDan nguoiDan, string newPassword)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE NguoiDan SET Password = '"+newPassword+"' WHERE MaNguoiDan = '"+nguoiDan.MaNguoiDangetset+"'",con);

            if(cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Cập nhật mật khấu mới thành công");
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi");
            }
        }
        private void Update_Password(NguoiQuanLy nguoiQuanLy, string newPassword)
        {
            SqlCommand cmd = new SqlCommand("UPDATE NguoiDan SET Password = '" + newPassword + "' WHERE MaNguoiDan = '" + nguoiQuanLy.MaNguoiQuanLygetset + "'");
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Cập nhật mật khấu mới thành công");
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi");
            }
        }

        private void button1_XacNhan_Click(object sender, EventArgs e)
        {
            if (check_error())
            {
                if(nguoiDan != null )Update_Password(nguoiDan, textBox_MatKhauMoi.Text);
                if(nguoiQuanLy != null) Update_Password(nguoiQuanLy, textBox_MatKhauMoi.Text);

            }
        }
    }
}
