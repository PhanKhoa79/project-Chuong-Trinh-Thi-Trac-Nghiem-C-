using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nhom10
{
    public partial class Formdethi : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-4O4HG3O2\\SQLEXPRESS;Initial Catalog=ThiTracNghiem;Integrated Security=True");
        public Formdethi()
        {
            InitializeComponent();
        }

        private void Formdethi_Load(object sender, EventArgs e)
        {
            load_cb();
        }
        private void load_dtagv(string idmonthi)
        {
            SqlCommand cmd = new SqlCommand("display_dethi", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdMonThi", SqlDbType.NVarChar, 20).Value = idmonthi;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView_dsCh.DataSource = dt;
            dataGridView_dsCh.Refresh();
        }
        private void load_cb()
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
        private void comboBox_monthi_SelectedValueChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
           string  selectedMonThi = comboBox_monthi.SelectedValue.ToString();
            dataGridView_cauhoi.Rows.Clear();
            SqlCommand cmd2 = new SqlCommand("hienthi_cauhoi_1", conn);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@monthi", selectedMonThi);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            load_dtagv(selectedMonThi);
            cmd2.Dispose();
            conn.Close();
            foreach (DataRow item in dt2.Rows)
            {
                int n = dataGridView_cauhoi.Rows.Add();
                dataGridView_cauhoi.Rows[n].Cells[1].Value = item[0].ToString();
                dataGridView_cauhoi.Rows[n].Cells[2].Value = item[1].ToString();
                dataGridView_cauhoi.Rows[n].Cells[3].Value = item[8].ToString();
                dataGridView_cauhoi.Rows[n].Cells[4].Value = item[9].ToString();
                dataGridView_cauhoi.Rows[n].Cells[5].Value = item[2].ToString();
                dataGridView_cauhoi.Rows[n].Cells[6].Value = item[3].ToString();
                dataGridView_cauhoi.Rows[n].Cells[7].Value = item[4].ToString();
                dataGridView_cauhoi.Rows[n].Cells[8].Value = item[5].ToString();
                dataGridView_cauhoi.Rows[n].Cells[9].Value = item[6].ToString();
            }
        }
        private void dataGridView_dsCh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= dataGridView_cauhoi.Rows.Count)
            {
                string made = dataGridView_dsCh.Rows[e.RowIndex].Cells[0].Value.ToString();
                string monthi = comboBox_monthi.Text;
                fChiTietDeThi ctdt = new fChiTietDeThi(made, monthi);
                ctdt.Show();
            }
        }
        private void button_random_Click(object sender, EventArgs e)
        {
            int selectedCount = 0;
            int randomCount = (int)numericUpDown_count.Value;

            // Lặp qua tất cả các hàng trong DataGridView
            foreach (DataGridViewRow row in dataGridView_cauhoi.Rows)
            {
                // Nếu ô checkbox được chọn thì tăng biến đếm
                if (row.Cells["Check"].Value != null && (bool)row.Cells["Check"].Value)
                {
                    selectedCount++;
                }
            }

            // Nếu đã chọn đủ số câu hỏi cần lấy thì không cần làm gì thêm
            if (selectedCount >= randomCount)
            {
                return;
            }

            // Nếu chưa đủ số câu hỏi thì tiếp tục chọn ngẫu nhiên
            Random rand = new Random();
            while (selectedCount < randomCount)
            {
                int rowIndex = rand.Next(dataGridView_cauhoi.Rows.Count - 1);
                DataGridViewRow row = dataGridView_cauhoi.Rows[rowIndex];
                // Nếu ô checkbox chưa được chọn thì chọn nó
                if (row.Cells["Check"].Value == null || !(bool)row.Cells["Check"].Value)
                {
                    row.Cells["Check"].Value = true;
                    selectedCount++;
                }
            }
        }

        private void dataGridView_cauhoi_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_cauhoi.Columns[e.ColumnIndex].Name == "Check")
            {

                int selectedCount = 0;
                foreach (DataGridViewRow row in dataGridView_cauhoi.Rows)
                {
                    if (row.Cells["Check"].Value != null && (bool)row.Cells["Check"].Value)
                    {
                        selectedCount++;
                    }
                }
                if (selectedCount <= numericUpDown_count.Value)
                {
                    textBox_solgcauhoi.Text = selectedCount.ToString();
                } else
                {
                    dataGridView_cauhoi.EndEdit();
                    MessageBox.Show("Số lượng câu hỏi đã chọn vượt quá số lượng cho phép!");
                    ((DataGridViewCheckBoxCell)dataGridView_cauhoi.Rows[e.RowIndex].Cells["Check"]).Value = false;
                }
            }
        }
        //thay doi gia tri lien quan ngay lap tuc khi thay doi gia tri cua o checkbox
        private void dataGridView_cauhoi_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView_cauhoi.CurrentCell is DataGridViewCheckBoxCell)
            {
                dataGridView_cauhoi.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            string monthi = comboBox_monthi.SelectedValue.ToString();
            string made = textBox_made.Text;
            string tende = textBox_tende.Text;
            int tgthi = int.Parse(numericUpDown_time.Value.ToString());
            DateTime ngaytao = dateTimePicker1.Value;
            int diem = int.Parse(textBox_diem.Text);
            int count_ch = int.Parse(numericUpDown_count.Value.ToString());
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd1 = new SqlCommand("add_dethi", conn);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.Add("@IdDeThi", SqlDbType.NVarChar, 20).Value = made;
            cmd1.Parameters.Add("@TenDeThi", SqlDbType.NVarChar, 50).Value = tende;
            cmd1.Parameters.Add("@NgayTao", SqlDbType.Date).Value = ngaytao;
            cmd1.Parameters.Add("@DiemToiDa", SqlDbType.Int).Value = diem;
            cmd1.Parameters.Add("@IdMonThi", SqlDbType.NVarChar, 20).Value = monthi;
            cmd1.Parameters.Add("@SoLuongCauHoi", SqlDbType.Int).Value = count_ch;
            cmd1.Parameters.Add("@ThoiGianThi", SqlDbType.Int).Value = tgthi;
            cmd1.ExecuteNonQuery();
            cmd1.Dispose();
            foreach (DataGridViewRow row in dataGridView_cauhoi.Rows)
            {
                if (row.Cells["Check"].Value != null && (bool)row.Cells["Check"].Value)
                {
                    string idCauHoi = row.Cells[1].Value.ToString();
                    SqlCommand cmd2 = new SqlCommand("INSERT INTO ChiTietDeThi VALUES(@made, @idcauhoi)", conn);
                    cmd2.Parameters.AddWithValue("@made", made);
                    cmd2.Parameters.AddWithValue("@idcauhoi", idCauHoi);
                    cmd2.ExecuteNonQuery();
                    cmd2.Dispose();
                }
            }
            load_dtagv(monthi);
            conn.Close();
            MessageBox.Show("Thêm thành công", "Thông báo");
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_cauhoi.Rows)
            {
                DataGridViewCheckBoxCell checkBox = (DataGridViewCheckBoxCell)row.Cells["Check"];
                checkBox.Value = false;

            }
            if (textBox_made.Text != "" || textBox_tende.Text != "" || textBox_diem.Text != "")
            {
                textBox_made.Text = "";
                textBox_tende.Text = "";
                textBox_diem.Text = "";
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string tt_search = textBox_search.Text.Trim();
            int tt_search1;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("search_dethi", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (int.TryParse(tt_search, out tt_search1))
            {
                cmd.Parameters.Add("@IdDeThi", SqlDbType.Int).Value = tt_search1;
                cmd.Parameters.Add("@TenDeThi", SqlDbType.NVarChar, 50).Value = DBNull.Value; // Giá trị null cho tham số này
            }
            else
            {
                cmd.Parameters.Add("@IdDeThi", SqlDbType.Int).Value = DBNull.Value; // Giá trị null cho tham số này
                cmd.Parameters.Add("@TenDeThi", SqlDbType.NVarChar, 50).Value = tt_search;
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            conn.Close();
            dataGridView_dsCh.DataSource = dt;
            dataGridView_dsCh.Refresh();
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView_dsCh.SelectedRows.Count > 0)
            {
                string monthi = comboBox_monthi.SelectedValue.ToString();
                string made = dataGridView_dsCh.SelectedRows[0].Cells[0].Value.ToString();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("DELETE FROM DETHI WHERE IdDeThi = @IdDeThi", conn);
                cmd.Parameters.AddWithValue("@IdDeThi", made);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                MessageBox.Show("Xóa thành công", "Thông báo");
                load_dtagv(monthi);
            } else
            {
                MessageBox.Show("Mã đề thi không tồn tại", "Thông báo");
            }
        }
        List<int> danhsachCauHoi = new List<int>();
        private void dataGridView_dsCh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= dataGridView_dsCh.Rows.Count)
            {
                 comboBox_monthi_SelectedValueChanged(sender, e);
                int i = e.RowIndex;
                textBox_made.Text = dataGridView_dsCh.Rows[i].Cells[0].Value.ToString();
                textBox_tende.Text = dataGridView_dsCh.Rows[i].Cells[1].Value.ToString();
                numericUpDown_time.Value = Convert.ToInt32(dataGridView_dsCh.Rows[i].Cells[6].Value);
                dateTimePicker1.Value = (DateTime)dataGridView_dsCh.Rows[i].Cells[2].Value;
                textBox_diem.Text = dataGridView_dsCh.Rows[i].Cells[3].Value.ToString();
                numericUpDown_count.Value = Convert.ToInt32(dataGridView_dsCh.Rows[i].Cells[5].Value);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                danhsachCauHoi = layDsCauHoi(textBox_made.Text);
                conn.Close();
                CapNhatCheckBoxCauHoi(danhsachCauHoi);
            }
            danhsachCauHoi.Clear();
        }
        private void CapNhatCheckBoxCauHoi(List<int> danhSachCauHoi)
        {
            foreach (DataGridViewRow row in dataGridView_cauhoi.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    int cauhoi = Convert.ToInt32(row.Cells[1].Value.ToString());
                    DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["Check"];
                    if (danhSachCauHoi.Contains(cauhoi))
                    {
                        checkBoxCell.Value = true;
                    }
                    else
                    {
                        checkBoxCell.Value = false;
                    }
                }
            }
        }
        private List<int> layDsCauHoi(string idDeThi)
        {
            List<int> list_ch = new List<int>();
            SqlCommand cmd = new SqlCommand("Select IdCauHoi from ChiTietDeThi where IdDeThi = @IdDeThi", conn);
            cmd.Parameters.AddWithValue("@IdDeThi", idDeThi);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int idcauhoi = reader.GetInt32(0);
                list_ch.Add(idcauhoi);
            }
            reader.Close();
            return list_ch;
        }
        //sua cau hoi trong de thi
        private void updateCauHoi(string idDeThi)
        {
            SqlCommand deleteCmd = new SqlCommand("DELETE FROM ChiTietDeThi WHERE IdDeThi = @IdDeThi", conn);
            deleteCmd.Parameters.AddWithValue("@IdDeThi", idDeThi);
            deleteCmd.ExecuteNonQuery();
            deleteCmd.Dispose();

            // Thêm các câu hỏi mới vào đề thi
            foreach (DataGridViewRow row in dataGridView_cauhoi.Rows)
            {
                if (row.Cells["Check"].Value != null && (bool)row.Cells["Check"].Value)
                {
                    string idCauHoi = row.Cells[1].Value.ToString();
                    SqlCommand insertCmd = new SqlCommand("INSERT INTO ChiTietDeThi (IdDeThi, IdCauHoi) VALUES (@IdDeThi, @IdCauHoi)", conn);
                    insertCmd.Parameters.AddWithValue("@IdDeThi", idDeThi);
                    insertCmd.Parameters.AddWithValue("@IdCauHoi", idCauHoi);
                    insertCmd.ExecuteNonQuery();
                    insertCmd.Dispose();
                }
            }
        } 

        private void button_sua_Click(object sender, EventArgs e)
        {
            string monthi = comboBox_monthi.SelectedValue.ToString();
            string made = textBox_made.Text;
            string tende = textBox_tende.Text;
            int tgthi = int.Parse(numericUpDown_time.Value.ToString());
            DateTime ngaytao = dateTimePicker1.Value;
            int diem = int.Parse(textBox_diem.Text);
            int count_ch = int.Parse(numericUpDown_count.Value.ToString());
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd1 = new SqlCommand("update_dethi", conn);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.Add("@IdDeThi", SqlDbType.NVarChar, 20).Value = made;
            cmd1.Parameters.Add("@TenDeThi", SqlDbType.NVarChar, 50).Value = tende;
            cmd1.Parameters.Add("@NgayTao", SqlDbType.Date).Value = ngaytao;
            cmd1.Parameters.Add("@DiemToiDa", SqlDbType.Int).Value = diem;
            cmd1.Parameters.Add("@IdMonThi", SqlDbType.NVarChar, 20).Value = monthi;
            cmd1.Parameters.Add("@SoLuongCauHoi", SqlDbType.Int).Value = count_ch;
            cmd1.Parameters.Add("@ThoiGianThi", SqlDbType.Int).Value = tgthi;
            cmd1.ExecuteNonQuery();
            cmd1.Dispose();
            updateCauHoi(made);
            conn.Close();
            load_dtagv(monthi);
            MessageBox.Show("Sửa thành công", "Thông báo");
        }
    }
}

