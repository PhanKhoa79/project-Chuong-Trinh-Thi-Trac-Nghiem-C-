using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom10
{
    public partial class fChiTietDeThi : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-4O4HG3O2\\SQLEXPRESS;Initial Catalog=ThiTracNghiem;Integrated Security=True");
        public fChiTietDeThi(string made, string monthi)
        {
            this.made = made;
            this.monthi = monthi;
            InitializeComponent();
        }
        private string made;
        private string monthi;

        private void fChiTietDeThi_Load(object sender, EventArgs e)
        {
            textBox2.Text = made;
            textBox1.Text = monthi;
            load_cauhoi();
        }
        private void load_cauhoi()
        {
              if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("hienthi_question", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdDeThi", made);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            conn.Close();
            dataGridView_cauhoi.DataSource = dt;
            dataGridView_cauhoi.Refresh();
        }
        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
