using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTratTuPhuong
{
    public partial class Form_DangNhap : Form
    {
        public Form_DangNhap()
        {
            InitializeComponent();
        }

        private void button_dangnhap_Click(object sender, EventArgs e)
        {
            Form_Admin form = new Form_Admin();
            form.Show();
        }
    }
}
