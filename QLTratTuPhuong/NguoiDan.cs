using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTratTuPhuong
{
    public class NguoiDan
    {
        private string MaNguoiDan;
        private string HoTen;
        private string username;
        private string password;
        private string MaKhuPho;
        private string DiaChi;

        public string MaNguoiDangetset { get => MaNguoiDan; set => MaNguoiDan = value; }
        public string HoTengetset { get => HoTen; set => HoTen = value; }
        public string Usernamegetset { get => username; set => username = value; }
        public string Passwordgetset { get => password; set => password = value; }
        public string MaKhuPhogetset { get => MaKhuPho; set => MaKhuPho = value; }
        public string DiaChigetset { get => DiaChi; set => DiaChi = value; }

        public NguoiDan()
        {

        }
        public NguoiDan Load_Account_Exist(string username, string password)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=QLP;Integrated Security=True");
            con.Open();
            //string username = textBox_taikhoan.Text;
            //string password = textBox_matkhau.Text;
            SqlCommand cmd = new SqlCommand("SELECT * FROM NguoiDan", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (username == (string)reader[2] && password == (string)reader[3])
                {

                    MaNguoiDangetset = (string)reader[0];
                    HoTengetset = (string)reader[1];
                    Usernamegetset = (string)reader[2];
                    Passwordgetset = (string)reader[3];
                    MaKhuPhogetset = (string)reader[4];
                    DiaChigetset = (string)reader[5];
                }
            }
            return null;
        }
    }
}
