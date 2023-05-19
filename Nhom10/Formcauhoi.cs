using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Nhom10
{
    public partial class Formcauhoi : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-4O4HG3O2\\SQLEXPRESS;Initial Catalog=ThiTracNghiem;Integrated Security=True");
        public Formcauhoi()
        {
            InitializeComponent();
        }

        private void Formcauhoi_Load(object sender, EventArgs e)
        {
            loadMonThi();
            loadmucdo();
            if (comboBox_chuong.Text == "")
            {
                comboBox_chuong.Text = "Chọn Chương";
            }
        }
        private void load_dtagrv(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("hienthi_cauhoi", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            dataGridView_cauhoi.DataSource = dt;
            dataGridView_cauhoi.Refresh();

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
            r["IdMonThi"] = "";
            r["TenMonThi"] = "Chọn môn thi";
            dt.Rows.InsertAt(r, 0);
            comboBox_monthi.DataSource = dt;
            comboBox_monthi.DisplayMember = "TenMonThi";
            comboBox_monthi.ValueMember = "IdMonThi";
        }
        private void loadmucdo()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("Select * from MUCDO", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            conn.Close();
            DataRow r = dt.NewRow();
            r["IdMucDo"] = "";
            r["TenMucDo"] = "Chọn Mức Độ";
            dt.Rows.InsertAt(r, 0);
            comboBox_mucdo.DataSource = dt;
            comboBox_mucdo.DisplayMember = "TenMucDo";
            comboBox_mucdo.ValueMember = "IdMucDo";

        }
        int id_cauhoi = 0;
        private void dataGridView_cauhoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView_cauhoi.Rows.Count)
            {
                int i = e.RowIndex;
                id_cauhoi = int.Parse(dataGridView_cauhoi.Rows[i].Cells[0].Value.ToString());
                textBox_cauhoi.Text = dataGridView_cauhoi.Rows[i].Cells[1].Value.ToString();
                textBox_daA.Text = dataGridView_cauhoi.Rows[i].Cells[2].Value.ToString();
                textBox_daB.Text = dataGridView_cauhoi.Rows[i].Cells[3].Value.ToString();
                textBox_daC.Text = dataGridView_cauhoi.Rows[i].Cells[4].Value.ToString();
                textBox_daD.Text = dataGridView_cauhoi.Rows[i].Cells[5].Value.ToString();
                textBox_daDung.Text = dataGridView_cauhoi.Rows[i].Cells[6].Value.ToString();
                comboBox_mucdo.Text = dataGridView_cauhoi.Rows[i].Cells[8].Value.ToString();
                comboBox_chuong.Text = dataGridView_cauhoi.Rows[i].Cells[9].Value.ToString();
            }
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string cauhoi = textBox_cauhoi.Text;
            string dapana = textBox_daA.Text;
            string dapanb = textBox_daB.Text;
            string dapanc = textBox_daC.Text;
            string dapand = textBox_daD.Text;
            string dapandung = textBox_daDung.Text;
            string monthi = comboBox_monthi.SelectedValue.ToString();
            string mucdo = comboBox_mucdo.SelectedValue.ToString();
            string chuong = comboBox_chuong.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand("up_cauhoii", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CauHoi", SqlDbType.NVarChar, 200).Value = cauhoi;
            cmd.Parameters.Add("@Dap_An_A", SqlDbType.NVarChar, 100).Value = dapana;
            cmd.Parameters.Add("@Dap_An_B", SqlDbType.NVarChar, 100).Value = dapanb;
            cmd.Parameters.Add("@Dap_An_C", SqlDbType.NVarChar, 100).Value = dapanc;
            cmd.Parameters.Add("@Dap_An_D", SqlDbType.NVarChar, 100).Value = dapand;
            cmd.Parameters.Add("@DapAnDung", SqlDbType.NVarChar, 100).Value = dapandung;
            cmd.Parameters.Add("IdMonThi", SqlDbType.NVarChar, 20).Value = monthi;
            cmd.Parameters.Add("@IdMucDo", SqlDbType.NVarChar, 20).Value = mucdo;
            cmd.Parameters.Add("IdChuong", SqlDbType.NVarChar, 20).Value = chuong;
            if (!check_ch(cauhoi))
            {
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                hienThiTheoMon();
                conn.Close();
                MessageBox.Show("Thêm thành công", "Thông báo");
            } else
            {
                MessageBox.Show("Câu hỏi đã tồn tại", "Thông báo", MessageBoxButtons.OK);
            }  
        }
        private bool check_ch(string cauhoi)
        {
            bool result = false;
            SqlCommand cmd = new SqlCommand("Select COUNT(*) from CAUHOI WHERE CauHoi = @CauHoi", conn);
            cmd.Parameters.AddWithValue("@CauHoi", cauhoi);
            result = (int)cmd.ExecuteScalar() > 0;
            return result;
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            string nd_cauHoi = textBox_cauhoi.Text;
            string monthi = comboBox_monthi.SelectedValue.ToString();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("xoa_cauHoii", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@cauhoi", SqlDbType.NVarChar, 200).Value = nd_cauHoi;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            hienThiTheoMon();
            MessageBox.Show("Xóa thành công", "Thông báo");
        }
        private void hienThiTheoMon()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string chonMonThi = comboBox_monthi.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand("hienthi_cauhoi_1", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@monthi", chonMonThi);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            dataGridView_cauhoi.DataSource = dt;
            dataGridView_cauhoi.Refresh();
            conn.Close();
        }
        private void button_refresh_Click(object sender, EventArgs e)
        {
            if (textBox_cauhoi.Text != "")
            {
                textBox_cauhoi.Text = "";
            }
            if (textBox_daA.Text != "")
            {
                textBox_daA.Text = "";
            }
            if (textBox_daC.Text != "")
            {
                textBox_daB.Text = "";
            }
            if (textBox_daC.Text != "")
            {
                textBox_daC.Text = "";
            }
            if (textBox_daD.Text != "")
            {
                textBox_daD.Text = "";
            }
            if (textBox_daDung.Text != "")
            {
                textBox_daDung.Text = "";
            }
            if (comboBox_chuong.Text != "")
            {
                comboBox_chuong.Text = "Chọn Chương";
            }
            if (comboBox_mucdo.Text != "")
            {
                comboBox_mucdo.Text = "Chọn Mức Độ";
            }
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string cauhoi = textBox_cauhoi.Text;
            string dapana = textBox_daA.Text;
            string dapanb = textBox_daB.Text;
            string dapanc = textBox_daC.Text;
            string dapand = textBox_daD.Text;
            string dapandung = textBox_daDung.Text;
            string monthi = comboBox_monthi.SelectedValue.ToString();
            string mucdo = comboBox_mucdo.SelectedValue.ToString();
            string chuong = comboBox_chuong.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand("update_CauHoii", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdCauHoi", SqlDbType.Int).Value = id_cauhoi;
            cmd.Parameters.Add("@CauHoi", SqlDbType.NVarChar, 200).Value = cauhoi;
            cmd.Parameters.Add("@Dap_An_A", SqlDbType.NVarChar, 100).Value = dapana;
            cmd.Parameters.Add("@Dap_An_B", SqlDbType.NVarChar, 100).Value = dapanb;
            cmd.Parameters.Add("@Dap_An_C", SqlDbType.NVarChar, 100).Value = dapanc;
            cmd.Parameters.Add("@Dap_An_D", SqlDbType.NVarChar, 100).Value = dapand;
            cmd.Parameters.Add("@DapAnDung", SqlDbType.NVarChar, 100).Value = dapandung;
            cmd.Parameters.Add("IdMonThi", SqlDbType.NVarChar, 20).Value = monthi;
            cmd.Parameters.Add("@IdMucDo", SqlDbType.NVarChar, 20).Value = mucdo;
            cmd.Parameters.Add("IdChuong", SqlDbType.NVarChar, 20).Value = chuong;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            hienThiTheoMon();
            conn.Close();
            MessageBox.Show("Sửa thành công", "Thông báo");
        }
        private void comboBox_monthi_SelectedValueChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string chonMonThi = comboBox_monthi.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Chuong WHERE IdMonThi = @monthi", conn);
            cmd.Parameters.AddWithValue("@monthi", chonMonThi);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow r = dt.NewRow();
            r["IdChuong"] = "";
            r["TenChuong"] = "Chọn chương";
            comboBox_chuong.DataSource = dt;
            comboBox_chuong.DisplayMember = "TenChuong";
            comboBox_chuong.ValueMember = "IdChuong";
            if (comboBox_monthi.Text != "Chọn môn thi"
)
            {
                SqlCommand cmd2 = new SqlCommand("hienthi_cauhoi_1", conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@monthi", chonMonThi);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                cmd2.Dispose();
                dataGridView_cauhoi.DataSource = dt2;
                dataGridView_cauhoi.Refresh();
            }
            else
            {
                load_dtagrv(sender, e);
            }
            button_refresh_Click(sender, e);
            conn.Close();
        }
        private void comboBox_chuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string idchuong = comboBox_chuong.SelectedValue.ToString();
            string monthi = comboBox_monthi.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand("hienthi_cauhoi_3", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@chuong", idchuong);
            cmd.Parameters.AddWithValue("@monthi", monthi);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            conn.Close();
            dataGridView_cauhoi.DataSource = dt;
            dataGridView_cauhoi.Refresh();
        }
        private void button_timKiem_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string ndCauHoi = textBox_cauhoi.Text;
            SqlCommand cmd = new SqlCommand("timkiem_CauHoii", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@cauhoi", SqlDbType.NVarChar, 200).Value = ndCauHoi;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            conn.Close();
            if (dt.Rows.Count > 0)
            {
                dataGridView_cauhoi.DataSource = dt;
                dataGridView_cauhoi.Refresh();
            }
            else
            {
                MessageBox.Show("Câu hỏi không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void ExportExcel(DataTable dt, string sheetname)
        {
            //Tạo các đối tượng Excel
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;
            //Tạo mới một Excel WorkBook 
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetname;
            // Tạo phần đầu nếu muốn
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "J1");
            head.MergeCells = true;
            head.Value2 = "Danh sách câu hỏi";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã câu hỏi";
            cl1.ColumnWidth = 10.0;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Câu hỏi";

            cl2.ColumnWidth = 40.0;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Đáp án A";
            cl3.ColumnWidth = 30.0;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Đáp án B";
            cl4.ColumnWidth = 30.0;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Đáp án C";
            cl5.ColumnWidth = 30.0;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Đáp án D";
            cl6.ColumnWidth = 30.0;
            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Đáp án đúng ";
            cl7.ColumnWidth = 10.0;
            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "Môn thi";
            cl8.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");
            cl9.Value2 = "Mức độ";
            cl9.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J3", "J3");
            cl10.Value2 = "Chương";
            cl10.ColumnWidth = 15.0;
            //Microsoft.Office.Interop.Excel.Range cl6_1 = oSheet.get_Range("F4", "F1000");
            //cl6_1.Columns.NumberFormat = "dd/mm/yyyy"
            //Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            //cl8.Value2 = "GHI CHÚ";
            //cl8.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "J3");
            rowHead.Font.Bold = true;
            // Kẻ viền
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Tạo mảng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];
            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                DataRow dr = dt.Rows[r];
                for (int c = 0; c < dt.Columns.Count; c++)

                {
                    arr[r, c] = dr[c];
                }
            }
            //Thiết lập vùng điền dữ liệu
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + dt.Rows.Count - 1;
            int columnEnd = dt.Columns.Count;
            // Ô bắt đầu điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];
            // Ô kết thúc điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];
            // Lấy về vùng điền dữ liệu
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);
            //Điền dữ liệu vào vùng đã thiết lập
            range.Value2 = arr;
            // Kẻ viền
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Căn giữa cột STT
            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];
            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);
            oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }
        private void button_xuatEx_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string chonMonThi = comboBox_monthi.SelectedValue.ToString();
            if (comboBox_monthi.Text != "Chọn môn thi")
            {
                SqlCommand cmd2 = new SqlCommand("hienthi_cauhoi_1", conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@monthi", chonMonThi);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                cmd2.Dispose();
                ExportExcel(dt2, "DS Cau Hoi");
            }
        }
    }
}
