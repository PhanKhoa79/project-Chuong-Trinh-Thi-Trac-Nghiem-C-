using System;
using System.Windows.Forms;

namespace Nhom10
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }
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
        private void button_qlTK_Click(object sender, EventArgs e)
        {
            openForm(new fQuanLyTaiKhoan());
            label1.Text = "Tài Khoản Người Dùng";
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void fAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
