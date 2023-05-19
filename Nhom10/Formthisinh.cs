using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;



namespace Nhom10
{
    public partial class Formthisinh : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-4O4HG3O2\\SQLEXPRESS;Initial Catalog=ThiTracNghiem;Integrated Security=True");
        public Formthisinh()
        {
            InitializeComponent();
        }

        private void Formthisinh_Load(object sender, EventArgs e)
        {
            load_dtagrv();
            load_cbKhoa();
        }
        private void load_dtagrv()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("hienthi_sinhvienn", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            conn.Close();
            dataGridView_ttSv.DataSource = dt;
            dataGridView_ttSv.DataSource = dt;
            dataGridView_ttSv.Refresh();
        }
        private void load_cbKhoa()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from KHOA", conn);
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            d.Fill(dt);
            cmd.Dispose();
            conn.Close();
            DataRow r = dt.NewRow();
            r["TenKhoa"] = "---Chọn Khoa---";
            dt.Rows.InsertAt(r, 0);
            comboBox_khoa.DataSource = dt;
            comboBox_khoa.DisplayMember = "TenKhoa";
            comboBox_khoa.ValueMember = "IdKhoa";
        }

        private void comboBox_khoa_SelectedValueChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string makhoa = comboBox_khoa.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand("select * from LOP where IdKhoa = @IdKhoa", conn);
            cmd.Parameters.AddWithValue("@IdKhoa", makhoa);
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            d.Fill(dt);
            cmd.Dispose();
            conn.Close();
            DataRow r = dt.NewRow();
            r["TenLop"] = "---Chọn Lớp---";
            dt.Rows.InsertAt(r, 0);
            comboBox_lop.DataSource = dt;
            comboBox_lop.DisplayMember = "TenLop";
            comboBox_lop.ValueMember = "IdLop";
        }

        private void dataGridView_ttSv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView_ttSv.Rows.Count)
            {
                int i = e.RowIndex;
                textBox_msv.Text = dataGridView_ttSv.Rows[i].Cells[0].Value.ToString();
                textBox_hoten.Text = dataGridView_ttSv.Rows[i].Cells[1].Value.ToString();
                comboBox_khoa.Text = dataGridView_ttSv.Rows[i].Cells[3].Value.ToString();
                comboBox_lop.Text = dataGridView_ttSv.Rows[i].Cells[2].Value.ToString();
                dateTimePicker_ngaysinh.Value = (DateTime)dataGridView_ttSv.Rows[i].Cells[4].Value;
                textBox_sdt.Text = dataGridView_ttSv.Rows[i].Cells[6].Value.ToString();
                textBox_qq.Text = dataGridView_ttSv.Rows[i].Cells[7].Value.ToString();
                string gt = dataGridView_ttSv.Rows[i].Cells[5].Value.ToString();
                if (gt == "Nam")
                {
                    radioButton_nam.Checked = true;
                }
                else
                {
                    radioButton_nu.Checked = true;
                }
            }
        }
        private void comboBox_lop_SelectedValueChanged(object sender, EventArgs e)
        {
            string idlop = comboBox_lop.SelectedValue.ToString();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("hienthisv_lop", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdLop", SqlDbType.NVarChar, 20).Value = idlop;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmd.Dispose();
            conn.Close();
            dataGridView_ttSv.DataSource = dt;
            dataGridView_ttSv.Refresh();
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string msv = textBox_msv.Text;
            string sdt = textBox_sdt.Text;
            string khoa = comboBox_khoa.SelectedValue.ToString();
            string lop = comboBox_lop.SelectedValue.ToString();
            string ten = textBox_hoten.Text;
            int gt;
            if (radioButton_nam.Checked)
            {
                gt = 1;
            }
            else
            {
                gt = 0;
            }
            if (!checkttSV(msv, sdt))
            {
                DateTime ngaysinh = dateTimePicker_ngaysinh.Value;
                string quequan = textBox_qq.Text;
                SqlCommand cmd = new SqlCommand("add_sv1", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdSinhVien", SqlDbType.NVarChar, 20).Value = msv;
                cmd.Parameters.Add("@TenSinhVien", SqlDbType.NVarChar, 50).Value = ten;
                cmd.Parameters.Add("@IdLop", SqlDbType.NVarChar, 20).Value = lop;
                cmd.Parameters.Add("@IdKhoa", SqlDbType.NVarChar, 20).Value = khoa;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = ngaysinh;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = gt;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50).Value = quequan;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar, 10).Value = sdt;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                comboBox_lop_SelectedValueChanged(sender, e);
            }
            else
            {
                MessageBox.Show("Mã sinh viên hoặc SDT đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button_sua_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string msv = textBox_msv.Text;
            string sdt = textBox_sdt.Text;
            string khoa = comboBox_khoa.SelectedValue.ToString();
            string lop = comboBox_lop.SelectedValue.ToString();
            string ten = textBox_hoten.Text;
            int gt;
            if (radioButton_nam.Checked)
            {
                gt = 1;
            }
            else
            {
                gt = 0;
            }
            DateTime ngaysinh = dateTimePicker_ngaysinh.Value;
            string quequan = textBox_qq.Text;
            SqlCommand cmd = new SqlCommand("update_sv", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdSinhVien", SqlDbType.NVarChar, 20).Value = msv;
            cmd.Parameters.Add("@TenSinhVien", SqlDbType.NVarChar, 50).Value = ten;
            cmd.Parameters.Add("@IdLop", SqlDbType.NVarChar, 20).Value = lop;
            cmd.Parameters.Add("@IdKhoa", SqlDbType.NVarChar, 20).Value = khoa;
            cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = ngaysinh;
            cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = gt;
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50).Value = quequan;
            cmd.Parameters.Add("@SDT", SqlDbType.VarChar, 10).Value = sdt;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            comboBox_lop_SelectedValueChanged(sender, e);
        }
        private bool checkttSV(string msv, string sdt)
        {
            bool result = false;
            SqlCommand cmd = new SqlCommand("Select COUNT(*) from SINHVIEN WHERE IdSinhVien = @msv OR SDT = @sdt", conn);
            cmd.Parameters.AddWithValue("@msv", msv);
            cmd.Parameters.AddWithValue("@sdt", sdt);

            result = (int)cmd.ExecuteScalar() > 0;
            return result;
        }

        public void ExportExcel(DataTable dt, string sheetname)
        {
            //Tạo các đối tượng Excel
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;
            Microsoft.Office.Interop.Excel.Range xlRange;
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
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");
            head.MergeCells = true;
            head.Value2 = "Thông tin sinh viên";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã Sinh Viên";
            cl1.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Họ tên";
            cl2.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Lớp";
            cl3.ColumnWidth = 12.0;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Khoa";
            cl4.ColumnWidth = 20.0;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E50");
            cl5.Value2 = "Ngày Sinh";
            cl5.ColumnWidth = 25.0;
            cl5.NumberFormat = "dd/mm/yyyy";
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Giới Tính";
            cl6.ColumnWidth = 10.0;
            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G50");
            cl7.Value2 = "Số Điện Thoại";
            cl7.ColumnWidth = 15.0;
            cl7.NumberFormat = "0000000000";
            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "Quê Quán";
            cl8.ColumnWidth = 15.0;
            //Microsoft.Office.Interop.Excel.Range cl6_1 = oSheet.get_Range("F4", "F1000");
            //cl6_1.Columns.NumberFormat = "dd/mm/yyyy"
            //Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            //cl8.Value2 = "GHI CHÚ";
            //cl8.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "H3");
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
        private void button_xuatE_Click(object sender, EventArgs e)
        {
            string idlop = comboBox_lop.SelectedValue.ToString();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("hienthisv_lop", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdLop", SqlDbType.NVarChar, 20).Value = idlop;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmd.Dispose();
            conn.Close();
            ExportExcel(dt, "Danh sach sinh vien");
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            if (textBox_msv.Text != "" || textBox_hoten.Text != "" || textBox_qq.Text != "" || textBox_sdt.Text != "")
            {
                textBox_msv.Text = "";
                textBox_hoten.Text = "";
                textBox_qq.Text = "";
                textBox_sdt.Text = "";
            }
            if (radioButton_nam.Checked || radioButton_nu.Checked)
            {
                radioButton_nam.Checked = false;
                radioButton_nu.Checked = false;
            }
        }

        private void button_timkiem_Click(object sender, EventArgs e)
        {
            string tt_timkiem = textBox_timkiem.Text;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("timkiem_sv", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdSinhVien", tt_timkiem);
            cmd.Parameters.AddWithValue("@TenSinhVien", tt_timkiem);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            conn.Close();
            dataGridView_ttSv.DataSource = dt;
            dataGridView_ttSv.Refresh();
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string msv = textBox_msv.Text;
            DialogResult tb = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báp", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand("Delete from SINHVIEN Where IdSinhVien = @IdSinhVien", conn);
                cmd.Parameters.AddWithValue("@IdSinhVien", msv);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                MessageBox.Show("Xóa thành công", "Thông báo");
                comboBox_lop_SelectedValueChanged(sender, e);
            }
        }
    }
}
