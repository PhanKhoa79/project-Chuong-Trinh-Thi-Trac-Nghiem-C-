using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Nhom10
{
    public partial class DangKi : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-4O4HG3O2\\SQLEXPRESS;Initial Catalog=ThiTracNghiem;Integrated Security=True");
        public DangKi()
        {
            InitializeComponent();
        }
        private void DangKi_Load(object sender, EventArgs e)
        {
            pc_nhan.Visible = false;
            pc_tich.Visible = false;
        }
        private void txt_MatKhau_TextChanged(object sender, EventArgs e)
        {
            txt_MatKhau.PasswordChar = '*';
            if (txt_cfMk.Text == txt_MatKhau.Text)
            {
                pc_tich.Visible = true;
                pc_nhan.Visible = false;
            }
            else
            {
                pc_nhan.Visible = true;
                pc_tich.Visible = false;
            }

        }
        private void txt_cfMk_TextChanged(object sender, EventArgs e)
        {
            txt_cfMk.PasswordChar = '*';
            if (txt_cfMk.Text == txt_MatKhau.Text)
            {
                pc_tich.Visible = true;
                pc_nhan.Visible = false;
            }
            else
            {
                pc_nhan.Visible = true;
                pc_tich.Visible = false;
            }

        }
        private void btn_DK_Click(object sender, EventArgs e)
        {
            string tk = txt_TaiKhoan.Text;
            string mk = txt_MatKhau.Text;
            string email = txtEmail.Text;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            if (txt_MatKhau.Text.Length >= 8)
            {
                if (txt_MatKhau.Text == txt_cfMk.Text)
                {
                    string sql = "INSERT INTO TAI_KHOAN (TaiKhoan, MatKhau, Email) VALUES (@TaiKhoan, @MatKhau, @Email)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@TaiKhoan", tk);
                    cmd.Parameters.AddWithValue("@MatKhau", mk);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();
                    DialogResult tb = MessageBox.Show("Đăng kí thành công", "Thông báo", MessageBoxButtons.OK);
                    if (tb == DialogResult.OK)
                    {
                        this.Hide();
                        Login login = new Login();
                        login.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng xác nhận đúng mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cbx_hienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_hienthi.Checked)
            {
                txt_MatKhau.PasswordChar = '\0';
                txt_cfMk.PasswordChar = '\0';
            }
            else
            {
                txt_MatKhau.PasswordChar = '*';
                txt_cfMk.PasswordChar = '*';
            }
        }
        private void txt_TaiKhoan_TextChanged(object sender, EventArgs e)
        {
            string tk = txt_TaiKhoan.Text;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = "SELECT COUNT(*) FROM TAI_KHOAN WHERE TaiKhoan = @TaiKhoan";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TaiKhoan", tk);
            int count = (int)cmd.ExecuteScalar();
            if (count > 0)
            {
                label_hienthi.Text = "Tài khoản đã tồn tại";
            }
            else
            {
                label_hienthi.Text = "";
            }
            conn.Close();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = "SELECT COUNT(*) FROM TAI_KHOAN WHERE Email = @Email";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Email", email);
            int count = (int)cmd.ExecuteScalar();
            if (count > 0)
            {
                label8.Text = "Email đã tồn tại";
            }
            else
            {
                label8.Text = "";
            }
            conn.Close();
        }
    }
}
