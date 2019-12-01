using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTratTuPhuong
{
    public class NguoiQuanLy
    {
        private string MaNguoiQuanLy;
        private string HoTen;
        private string username;
        private string password;

        public string MaNguoiQuanLygetset { get => MaNguoiQuanLy; set => MaNguoiQuanLy = value; }
        public string HoTengetset { get => HoTen; set => HoTen = value; }
        public string Usernamegetset { get => username; set => username = value; }
        public string Passwordgetset { get => password; set => password = value; }

        public NguoiQuanLy(string MaNguoiQuanLy, string HoTen, string username, string password)
        {
            this.MaNguoiQuanLygetset = MaNguoiQuanLy;
            this.HoTengetset = HoTen;
            this.Usernamegetset = username;
            this.Passwordgetset = password;
        }
        public NguoiQuanLy()
        {

        }

        public NguoiQuanLy Load_Account_Exist(string username, string password)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=QLP;Integrated Security=True");
            con.Open();
            //string username = textBox_taikhoan.Text;
            //string password = textBox_matkhau.Text;
            SqlCommand cmd = new SqlCommand("SELECT * FROM NguoiQuanLy", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (username == (string)reader[2] && password == (string)reader[3])
                {

                    MaNguoiQuanLygetset = (string)reader[0];
                    HoTengetset = (string)reader[1];
                    Usernamegetset = (string)reader[2];
                    Passwordgetset = (string)reader[3];
                }
            }
            con.Close();
            return null;
        }


    }
}
