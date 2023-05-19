using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Nhom10
{
    public partial class fQuanLyTaiKhoan : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-4O4HG3O2\\SQLEXPRESS;Initial Catalog=ThiTracNghiem;Integrated Security=True");
        public fQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void fQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            load_dtagv();
            loadcb_phanQuyen();
        }
        private void load_dtagv()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("hienthi_TK2", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            conn.Close();
            dataGridView_ttTK.DataSource = dt;
            dataGridView_ttTK.Refresh();
        }
        private void loadcb_phanQuyen()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("Select *  from PHANQUYEN", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            conn.Close();
            DataRow row = dt.NewRow();
            row["Ten_PhanQuyen"] = "-Chọn Quyền-";
            dt.Rows.InsertAt(row, 0);
            comboBox_phanQuyen.DataSource = dt;
            comboBox_phanQuyen.DisplayMember = "Ten_PhanQuyen";
            comboBox_phanQuyen.ValueMember = "ID_PhanQuyen";
        }
        int id_tk = 0;
        private void dataGridView_ttTk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView_ttTK.Rows.Count)
            {
                int i = e.RowIndex;
                textBox_tenDN.Text = dataGridView_ttTK.Rows[i].Cells[0].Value.ToString();
                textBox_MK.Text = dataGridView_ttTK.Rows[i].Cells[1].Value.ToString();
                textBox_Email.Text = dataGridView_ttTK.Rows[i].Cells[2].Value.ToString();
                comboBox_phanQuyen.Text = dataGridView_ttTK.Rows[i].Cells[3].Value.ToString();
            }
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            string taikhoan = textBox_tenDN.Text;
            string matkhau = textBox_MK.Text;
            string email = textBox_Email.Text;
            int loaitk = int.Parse(comboBox_phanQuyen.SelectedValue.ToString());
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            if (textBox_MK.Text.Length < 8)
            {
                MessageBox.Show("Mật khẩu phải đủ 8 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sql = "SELECT COUNT(*) FROM TAI_KHOAN WHERE TaiKhoan = @TaiKhoan OR Email = @Email";
                SqlCommand cmd1 = new SqlCommand(sql, conn);
                cmd1.Parameters.AddWithValue("@TaiKhoan", taikhoan);
                cmd1.Parameters.AddWithValue("@Email", email);
                int count = (int)cmd1.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Tài khoản hoặc email đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("them_TK1", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@TaiKhoan", SqlDbType.NVarChar, 50).Value = taikhoan;
                    cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar, 50).Value = matkhau;
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 100).Value = email;
                    cmd.Parameters.Add("@ID_PhanQuyen", SqlDbType.Int).Value = loaitk;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();
                    load_dtagv();
                    MessageBox.Show("Thêm Tài Khoản Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        } 


        private void button_timkiem_Click(object sender, EventArgs e)
        {
            string taikhoan = textBox_tenDN.Text;
            string email = textBox_Email.Text;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            if (textBox_tenDN.Text != "" || textBox_Email.Text != "")
            {
                SqlCommand cmd = new SqlCommand("timkiem_TK", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TaiKhoan", SqlDbType.NVarChar, 50).Value = taikhoan;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 100).Value = email;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmd.Dispose();
                conn.Close();
                dataGridView_ttTK.DataSource = dt;
                dataGridView_ttTK.Refresh();
            }
            else
            {
                load_dtagv();
            }
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            string tendn = textBox_tenDN.Text;
            string matkhau = textBox_MK.Text;
            string email = textBox_Email.Text;
            int id_pq = int.Parse(comboBox_phanQuyen.SelectedValue.ToString());
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("update_TK", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TaiKhoan", SqlDbType.NVarChar, 50).Value = tendn;
            cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar, 50).Value = matkhau;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 100).Value = email;
            cmd.Parameters.Add("@ID_PhanQuyen", SqlDbType.Int).Value = id_pq;
            cmd.Parameters.Add("@ID_TK", SqlDbType.Int).Value = id_tk;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            load_dtagv();
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string taikhoan = textBox_tenDN.Text;
            try
            {
                DialogResult tb = MessageBox.Show("Bạn có đồng ý xóa hay không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (tb == DialogResult.OK)
                {
                    SqlCommand cmd = new SqlCommand("delete_TK", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@TaiKhoan", SqlDbType.NVarChar, 50).Value = taikhoan;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();
                    load_dtagv();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa bản ghi.\nLỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {

        }
    }
}