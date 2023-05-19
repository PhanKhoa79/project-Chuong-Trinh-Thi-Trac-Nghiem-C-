using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Nhom10
{
    public partial class Formmonthi : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-4O4HG3O2\\SQLEXPRESS;Initial Catalog=ThiTracNghiem;Integrated Security=True");
        public Formmonthi()
        {
            InitializeComponent();
        }

        private void Formmonthi_Load(object sender, EventArgs e)
        {
            loadMonThi();
        }
        private void loadMonThi()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = "Select * from MONTHI";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            conn.Close();
            dataGridView_monthi.DataSource = dt;
            dataGridView_monthi.Refresh();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string monthi = txt_monthi.Text.Trim();
            string mamonthi = txt_mmt.Text.Trim();
            DateTime ngaythi = dateTimePicker1.Value;
            SqlCommand cmd = new SqlCommand("Them_MonThi", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdMonThi", SqlDbType.NVarChar, 20).Value = mamonthi;
            cmd.Parameters.Add("@TenMonThi", SqlDbType.NVarChar, 20).Value = monthi;
            cmd.Parameters.Add("@NgayThi", SqlDbType.Date).Value = ngaythi;
            if (txt_monthi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên môn", "Thông báo");
                txt_monthi.Focus();
            }
            else
            {
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                loadMonThi();
                MessageBox.Show("Thêm Thành Công", "Thông báo");
            }
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string monthi = txt_monthi.Text.Trim();
            string mamonthi = txt_mmt.Text.Trim();
            DateTime ngaythi = dateTimePicker1.Value;
            SqlCommand cmd = new SqlCommand("Sua_MonThi", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdMonThi", SqlDbType.NVarChar, 20).Value = mamonthi;
            cmd.Parameters.Add("@TenMonThi", SqlDbType.NVarChar, 20).Value = monthi;
            cmd.Parameters.Add("@NgayThi", SqlDbType.Date).Value = ngaythi;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            loadMonThi();
            MessageBox.Show("Sửa Thành Công", "Thông báo");
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string mamonthi = txt_mmt.Text.Trim();
            SqlCommand cmd = new SqlCommand("Xoa_MonThi", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdMonThi", SqlDbType.NVarChar, 20).Value = mamonthi;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            loadMonThi();
            MessageBox.Show("Xóa Thành Công", "Thông báo");
        }
        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            if (txt_mmt.Text != "")
            {
                txt_mmt.Text = "";
            }
            if (txt_monthi.Text != "")
            {
                txt_monthi.Text = "";
            }
        }

        private void dataGridView_monthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView_monthi.Rows.Count)
            {
                int i = e.RowIndex;
                txt_monthi.Text = dataGridView_monthi.Rows[i].Cells[1].Value.ToString();
                txt_mmt.Text = dataGridView_monthi.Rows[i].Cells[0].Value.ToString();
                dateTimePicker1.Value = (DateTime)dataGridView_monthi.Rows[i].Cells[2].Value;
            } 
        }
    }
}
