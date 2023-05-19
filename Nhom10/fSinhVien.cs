using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace Nhom10
{
    public partial class fSinhVien : Form
    {
       
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-4O4HG3O2\\SQLEXPRESS;Initial Catalog=ThiTracNghiem;Integrated Security=True");
        public fSinhVien(string tk)
        {
            this.tk = tk;
            InitializeComponent();
        }
        private string tk;
        private Form cchildForm;
        private void openForm(Form childForm)
        {
            if (cchildForm != null)
            {
                cchildForm.Close();
            }
            cchildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btn_baiThi_Click(object sender, EventArgs e)
        {
            openForm(new fBaiThi());
            label1.Text = "Bài Thi";
        }

        private void button_ttTK_Click(object sender, EventArgs e)
        {
            openForm(new fThongTinTaiKhoan());
            label1.Text = "Thông Tin Tài Khoản";
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void fSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
        private string tenSv(string taikhoan)
        {
            string tensv = "";
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("Select TenSinhVien from SINHVIEN WHERE TaiKhoan = @TaiKhoan", conn);
            cmd.Parameters.AddWithValue("@TaiKhoan", taikhoan);
            SqlDataReader da = cmd.ExecuteReader();
            if (da.Read())
            {
                    tensv = da.GetString(0);
            }
            return tensv;
        }
        private void fSinhVien_Load(object sender, EventArgs e)
        {
            label1.Text = "Xin chào " + tenSv(tk);
        }
    }
}
