using System;
using System.Windows.Forms;

namespace Nhom10
{
    public partial class fGiangVien : Form
    {
        public fGiangVien()
        {
            InitializeComponent();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {

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

        private void btn_cauhoi_Click(object sender, EventArgs e)
        {
            openForm(new Formcauhoi());
            label_home.Text = btn_cauhoi.Text;
        }

        private void btn_monthi_Click(object sender, EventArgs e)
        {
            openForm(new Formmonthi());
            label_home.Text = btn_monthi.Text;
        }

        private void btn_dethi_Click(object sender, EventArgs e)
        {
            openForm(new Formdethi());
            label_home.Text = btn_dethi.Text;
        }

        private void btn_thisinh_Click(object sender, EventArgs e)
        {
            openForm(new Formthisinh());
            label_home.Text = btn_thisinh.Text;
        }

        private void btn_lichthi_Click(object sender, EventArgs e)
        {
            openForm(new Formlichthi());
            label_home.Text = btn_lichthi.Text;
        }

        private void btn_ketqua_Click(object sender, EventArgs e)
        {
            openForm(new Formketqua());
            label_home.Text = btn_ketqua.Text;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (cchildForm != null)
            {
                cchildForm.Close();
            }
            label_home.Text = "Trang Chủ";
        }

        private void fGiangVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
