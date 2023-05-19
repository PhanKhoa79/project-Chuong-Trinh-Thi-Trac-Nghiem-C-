using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Nhom10
{
    public partial class fBaiThi : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-4O4HG3O2\\SQLEXPRESS;Initial Catalog=ThiTracNghiem;Integrated Security=True");
        public fBaiThi()
        {
            InitializeComponent();
        }

        private void fBaiThi_Load(object sender, System.EventArgs e)
        {
            loadMonThi();
        }
        private void loadMonThi()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("Select * from MONTHI", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            conn.Close();
            DataRow r = dt.NewRow();
            r["TenMonThi"] = "Chọn môn thi";
            dt.Rows.InsertAt(r, 0);
            comboBox_monthi.DataSource = dt;
            comboBox_monthi.DisplayMember = "TenMonThi";
            comboBox_monthi.ValueMember = "IdMonThi";
        }
        private void load_dethi()
        {
            flowLayoutPanel1.Controls.Clear();
            string monthi = comboBox_monthi.SelectedValue.ToString();

            // Lấy số lượng đề thi của môn thi đã chọn
            int countDeThi = soLuongDeThi(monthi);

            // Tạo và thêm ListBox vào FlowLayoutPanel theo số lượng đề thi
            for (int i = 0; i < countDeThi; i++)
            {
                ListBox listBox = new ListBox();
                // Thêm các thiết lập và thông tin cho ListBox nếu cần

                flowLayoutPanel1.Controls.Add(listBox);
            }
        }
        private int soLuongDeThi(string monthi)
        {
            int count = 0;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) from DETHI where IdMonThi = @IdMonThi", conn);
            cmd.Parameters.AddWithValue("@IdMonThi", monthi);
            count = (int)cmd.ExecuteScalar();
            cmd.Dispose();  
            conn.Close();
            return count;
        }

        private void comboBox_monthi_SelectedValueChanged(object sender, System.EventArgs e)
        {
            load_dethi();
        }
    }
}
