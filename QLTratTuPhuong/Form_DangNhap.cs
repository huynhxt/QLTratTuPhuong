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
    public partial class Form_DangNhap : Form
    {
        private SqlConnection con; //= new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=QLP;Integrated Security=True");
        private NguoiQuanLy nguoiQuanLy;
        public Form_DangNhap()
        {
            InitializeComponent();
            
        }

        private void button_dangnhap_Click(object sender, EventArgs e)
        {
            
            //con.Open();
            if (Check_Account_NQL_Exist() == true)
            {
                MessageBox.Show("Tài khoản Quản lí đăng nhập thành công");
                NguoiQuanLy nguoiQuanLy = new NguoiQuanLy();
                nguoiQuanLy.Load_Account_Exist(textBox_taikhoan.Text, textBox_matkhau.Text);
                Form_Admin form = new Form_Admin(nguoiQuanLy);
                
                

                form.Show();
                this.Hide();
            }
            else
            {
                if(Check_Account_ND_Exist() == true)
                {
                    MessageBox.Show("Tài khoản Người dân đăng nhập thành công");
                    NguoiDan nguoiDan = new NguoiDan();
                    nguoiDan.Load_Account_Exist(textBox_taikhoan.Text, textBox_matkhau.Text);
                    Form_NguoiDan form = new Form_NguoiDan(nguoiDan);
                    form.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu chưa đúng");
                }
            }
            
            
        }


        private bool Check_Account_NQL_Exist()
        {
            con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=QLP;Integrated Security=True");
            con.Open();
            string username = textBox_taikhoan.Text;
            string password = textBox_matkhau.Text;
            SqlCommand cmd = new SqlCommand("SELECT * FROM NguoiQuanLy", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (username == (string)reader[2] && password == (string)reader[3])
                {
                    return true;
                }
            }
            reader.Close();
            
            con.Close();
            return false;
        }
        private bool Check_Account_ND_Exist()
        {
            con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=QLP;Integrated Security=True");
            con.Open();
            string username = textBox_taikhoan.Text;
            string password = textBox_matkhau.Text;
            SqlCommand cmd = new SqlCommand("SELECT * FROM NguoiDan", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (username == (string)reader[2] && password == (string)reader[3])
                {
                    return true;
                }
            }
            
            con.Close();
            return false;
        }
    }
}
