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
    public partial class Form_NguoiDan : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=QLP;Integrated Security=True");
        private NguoiDan nguoiDan;
        private int MaDonNguoiDan;
        
        public Form_NguoiDan(NguoiDan nguoiDan)
        {
            InitializeComponent();
            this.nguoiDan = nguoiDan;
        }

        private void Form_NguoiDan_Load(object sender, EventArgs e)
        {
            loaddata();
            
        }

        
        private void loaddata()
        {
            //SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=QLP;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT DonNguoiDan.MaDonNguoiDan, DonNguoiDan.TrangThai, DonNguoiDan.NgayGuiDonNguoiDan, DonNguoiDan.NoiDung, NoiDungDonGiaiQuyet FROM DonNguoiDan WHERE MaNguoiDan = '"+nguoiDan.MaNguoiDangetset+"'", con);
            //select MaDon, NoiDung, NgayGui from DonGiaiQuyet
            //SELECT DonGiaiQuyet.MaDon, DonGiaiQuyet.NoiDung, DonGiaiQuyet.NgayGui, DonNguoiDan.TrangThai, DonNguoiDan.NgayGui FROM DonGiaiQuyet FULL OUTER JOIN DonNguoiDan ON DonGiaiQuyet.MaDonNguoiDan=DonNguoiDan.MaDonNguoiDan
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Tải dữ liệu lên dataGridView
            dataGridView_NguoiDan.DataSource = dt;
        }

        private void dataGridView_NguoiDan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                richTextBox_NoiDung.Text = dataGridView_NguoiDan.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
            if(e.ColumnIndex == 4)
            {
                richTextBox_NoiDung.Text = dataGridView_NguoiDan.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }

        private void button_GuiDon_Click(object sender, EventArgs e)
        {
            //int lastRowIndex = dataGridView_admin.Rows.Count - 1;
            int dem = DemSoRecordDonNguoiDan();
            dem = dem + 1;
            //string nulll = "NULL";
            DateTime dateTime = new DateTime(dateTimePicker_NguoiDan.Value.Year, dateTimePicker_NguoiDan.Value.Month, dateTimePicker_NguoiDan.Value.Day);
            //SqlCommand cmd = new SqlCommand("INSERT INTO DonGiaiQuyet VALUES (DGQ" + dem+1 + ", " + richTextBox_NoiDungAdmin.Text + ")", con);
            SqlCommand cmd = new SqlCommand("INSERT INTO DonNguoiDan VALUES ('DND" + dem + "', '" + dateTime.ToString() + "', 'chuagiaiquyet' , '"+richTextBox_NoiDung.Text+"', '"+nguoiDan.MaNguoiDangetset+"', null)", con);
            //SqlDataReader reader = cmd.ExecuteReader();
            if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Them thanh cong");
            else MessageBox.Show("Không thành công");
            //while (reader.Read())
            //{

            //}
        }
        private int Int32ParseMaSo(string Ma)
        {
            string[] delimiterChars = { "ND", "DGQ", "NQL", "DND", "KP" };
            String[] Maarr = Ma.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);
            return Int32.Parse(Maarr[0]);
        }
        private int DemSoRecordDonNguoiDan()
        {
            //con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=QLP;Integrated Security=True");
            con.Open();
            int count = 0;
            SqlCommand cmd = new SqlCommand("SELECT COUNT(MaDonNguoiDan) FROM DonNguoiDan", con);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                count = Int32.Parse(reader[0].ToString());
            }
            reader.Close();
            return count;
        }

        private void button_XemThongTinCaNhan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mã số: "+nguoiDan.MaNguoiDangetset+"\n"+
                            "Họ và tên: "+nguoiDan.HoTengetset+"\n"+
                            "Username: "+nguoiDan.Usernamegetset+"\n"+
                            "Khu phố: "+nguoiDan.MaKhuPhogetset+"\n"+
                            "Địa chỉ: "+nguoiDan.DiaChigetset+"\n");
        }

        private void button_DoiMatKhau_Click(object sender, EventArgs e)
        {
            Form form = new Form_DoiMatKhau(this.nguoiDan);
            form.Show();

        }

        private void button_LamMoi_Click(object sender, EventArgs e)
        {
            dataGridView_NguoiDan.DataSource = null;
            loaddata();
        }
    }
}
