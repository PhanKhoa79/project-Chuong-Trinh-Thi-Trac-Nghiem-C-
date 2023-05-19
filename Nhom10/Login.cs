using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Nhom10
{
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-4O4HG3O2\\SQLEXPRESS;Initial Catalog=ThiTracNghiem;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {


        }

        private void txt_MK_TextChanged(object sender, EventArgs e)
        {
            txt_MK.PasswordChar = '*';
        }


        private void btn_DN_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string tk = txt_TK.Text;
            string mk = txt_MK.Text;
            string sql = "select TaiKhoan, MatKhau from TAI_KHOAN where TaiKhoan = @tk and MatKhau = @mk";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@tk", tk);
            cmd.Parameters.Add("@mk", mk);
            int loaiTK = phanQuyen(tk);
            SqlDataReader dta = cmd.ExecuteReader();
            if (dta.Read() == true)
            {
                if (loaiTK == 1)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    this.Hide();
                   fSinhVien lbt = new fSinhVien(tk);
                    lbt.ShowDialog();
                }
                if (loaiTK == 2)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    this.Hide();
                    fGiangVien gv = new fGiangVien();
                    gv.ShowDialog();
                }
                if (loaiTK == 3)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    this.Hide();
                    fAdmin admin = new fAdmin();
                    admin.ShowDialog();
                }
            }
            else
            {
                dta.Close();
                label_checkMk.Text = "Sai tài khoản hoặc mật khẩu!";
            }
            txt_MK_TextChanged(sender, e);
            conn.Close();
        }

        private void cbx_hienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_hienthi.Checked)
            {
                txt_MK.PasswordChar = '\0';
            }
            else
            {
                txt_MK.PasswordChar = '*';
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void link_Dki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DangKi dangki = new DangKi();
            dangki.Show();
        }

        private void txt_TK_TextChanged(object sender, EventArgs e)
        {
            label_checkMk.Text = "";
        }

        private int phanQuyen(string username)
        {
            int loai_TK = 0;
            string sql = "select ID_PhanQuyen from TAI_KHOAN Where TaiKhoan = @Username";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                using (SqlDataReader da = cmd.ExecuteReader())
                {
                    if (da.Read())
                    {
                        if (!da.IsDBNull(0))
                        {
                            loai_TK = da.GetInt32(0);
                        }
                        else
                        {
                            MessageBox.Show("khoong biet");
                        }
                    }
                }
            }
            return loai_TK;
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
