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
            //nguoiQuanLy = new NguoiQuanLy();
        }

        private void button_dangnhap_Click(object sender, EventArgs e)
        {
            
            //con.Open();
            if (Check_Account_Exist() == true)
            {
                NguoiQuanLy nguoiQuanLy = new NguoiQuanLy();
                nguoiQuanLy.Load_Account_Exist(textBox_taikhoan.Text, textBox_matkhau.Text);
                Form_Admin form = new Form_Admin(nguoiQuanLy);
                
                MessageBox.Show(nguoiQuanLy.HoTengetset);

                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tai khoan khong ton tai");
            }
            
        }

        private NguoiQuanLy Load_Account_Exist()
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
                    
                    nguoiQuanLy.MaNguoiQuanLygetset = (string)reader[0];
                    nguoiQuanLy.HoTengetset = (string)reader[1];
                    nguoiQuanLy.Usernamegetset = (string)reader[2];
                    nguoiQuanLy.Passwordgetset = (string)reader[3];
                }
            }
            con.Close();
            return null;
        }
        private bool Check_Account_Exist()
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
            con.Close();
            return false;
        }

    }
}
