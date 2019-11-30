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
            MaDonNguoiDan = Int32.Parse(a);
            richTextBox_NoiDungAdmin.Text = dataGridView_admin.Rows[e.RowIndex].Cells["NoiDung"].Value.ToString();
            
        }

        private void button_TaoDon_Click(object sender, EventArgs e)
        {
            int lastRowIndex = dataGridView_admin.Rows.Count - 1;
            SqlCommand cmd = new SqlCommand("INSERT INTO DonGiaiQuyet VALUE(DGQ"+lastRowIndex + 1+")", con);
            
        }
    }
}