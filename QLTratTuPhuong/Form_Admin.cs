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
    public partial class Form_Admin : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=QLP;Integrated Security=True");
        private int MaDonNguoiDan;
        public NguoiQuanLy nguoiQuanLy;
        public Form_Admin(NguoiQuanLy nguoiQuanLy)
        {
            InitializeComponent();
            this.nguoiQuanLy = nguoiQuanLy;
            MessageBox.Show(nguoiQuanLy.HoTengetset);
        }
        public Form_Admin()
        {
            InitializeComponent();
            
        }
        private void Form_Admin_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void loaddata()
        {
            //SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=QLP;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT DonNguoiDan.MaDonNguoiDan, DonNguoiDan.TrangThai, DonNguoiDan.NgayGuiDonNguoiDan, DonNguoiDan.NoiDung FROM DonNguoiDan", con);
            //select MaDon, NoiDung, NgayGui from DonGiaiQuyet
            //SELECT DonGiaiQuyet.MaDon, DonGiaiQuyet.NoiDung, DonGiaiQuyet.NgayGui, DonNguoiDan.TrangThai, DonNguoiDan.NgayGui FROM DonGiaiQuyet FULL OUTER JOIN DonNguoiDan ON DonGiaiQuyet.MaDonNguoiDan=DonNguoiDan.MaDonNguoiDan
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Tải dữ liệu lên dataGridView
            dataGridView_admin.DataSource = dt;
        }

        private void dataGridView_admin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string a = dataGridView_admin.Rows[e.RowIndex].Cells[0].Value.ToString();
            Int32ParseMaSo(a);
            MaDonNguoiDan = Int32ParseMaSo(a);
            richTextBox_NoiDungAdmin.Text = dataGridView_admin.Rows[e.RowIndex].Cells["NoiDung"].Value.ToString();
            
        }

        private void button_TaoDon_Click(object sender, EventArgs e)
        {
            //int lastRowIndex = dataGridView_admin.Rows.Count - 1;
            int dem = DemSoRecordDonGiaiQuyet();
            dem = dem + 1;
            //string nulll = "NULL";
            DateTime dateTime = new DateTime(dateTimePicker_admin.Value.Year,dateTimePicker_admin.Value.Month,dateTimePicker_admin.Value.Day);
            //SqlCommand cmd = new SqlCommand("INSERT INTO DonGiaiQuyet VALUES (DGQ" + dem+1 + ", " + richTextBox_NoiDungAdmin.Text + ")", con);
            SqlCommand cmd = new SqlCommand("INSERT INTO DonGiaiQuyet VALUES ('DGQ" + dem +"', '"+richTextBox_NoiDungAdmin.Text+"', '"+dateTime.ToString()+"', '"+nguoiQuanLy.MaNguoiQuanLygetset+"', 'DND"+this.MaDonNguoiDan+"')", con);
            //SqlDataReader reader = cmd.ExecuteReader();
            if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Them thanh cong");
            else MessageBox.Show("Không thành công");
            //while (reader.Read())
            //{

            //}
        }
        private int Int32ParseMaSo(string Ma)
        {
            string[] delimiterChars = {"ND", "DGQ", "NQL", "DND", "KP"};
            String[] Maarr = Ma.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);
            return Int32.Parse(Maarr[0]);
        }
        public int DemSoRecordDonGiaiQuyet()
        {
            con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=QLP;Integrated Security=True");
            con.Open();
            int count=0;
            SqlCommand cmd = new SqlCommand("SELECT COUNT(MaDonGiaiQuyet) FROM DonGiaiQuyet", con);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                count = Int32.Parse(reader[0].ToString());
            }
            reader.Close();
            return count;
        }

        private void button_GuiDGQ_Click(object sender, EventArgs e)
        {
            con.Open();
            string NoiDung = richTextBox_NoiDungAdmin.Text;
            SqlCommand cmd = new SqlCommand("UPDATE DonNguoiDan SET TrangThai = 'dagiaiquyet', NoiDungDonGiaiQuyet = '"+NoiDung+"' WHERE MaDonNguoiDan = 'DND"+MaDonNguoiDan+"'",con);
            if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Gửi thành công");
            else MessageBox.Show("Không thành công");

        }

        private void button_Lammoi_Click(object sender, EventArgs e)
        {
            dataGridView_admin.DataSource = null;
            loaddata();
        }
    }
}