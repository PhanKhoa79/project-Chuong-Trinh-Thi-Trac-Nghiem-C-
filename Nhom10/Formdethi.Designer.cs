namespace Nhom10
{
    partial class Formdethi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_monthi = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_dsCh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_refresh = new System.Windows.Forms.Button();
            this.textBox_diem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_sua = new System.Windows.Forms.Button();
            this.button_them = new System.Windows.Forms.Button();
            this.numericUpDown_time = new System.Windows.Forms.NumericUpDown();
            this.textBox_tende = new System.Windows.Forms.TextBox();
            this.textBox_made = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_count = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView_cauhoi = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_solgcauhoi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_random = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dsCh)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_count)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cauhoi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Môn Thi: ";
            // 
            // comboBox_monthi
            // 
            this.comboBox_monthi.FormattingEnabled = true;
            this.comboBox_monthi.Location = new System.Drawing.Point(80, 15);
            this.comboBox_monthi.Name = "comboBox_monthi";
            this.comboBox_monthi.Size = new System.Drawing.Size(174, 21);
            this.comboBox_monthi.TabIndex = 2;
            this.comboBox_monthi.SelectedValueChanged += new System.EventHandler(this.comboBox_monthi_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_dsCh);
            this.groupBox1.Location = new System.Drawing.Point(25, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 149);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách đề thi";
            // 
            // dataGridView_dsCh
            // 
            this.dataGridView_dsCh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView_dsCh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_dsCh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dsCh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView_dsCh.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_dsCh.Name = "dataGridView_dsCh";
            this.dataGridView_dsCh.Size = new System.Drawing.Size(435, 130);
            this.dataGridView_dsCh.TabIndex = 0;
            this.dataGridView_dsCh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_dsCh_CellClick);
            this.dataGridView_dsCh.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_dsCh_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdDeThi";
            this.Column1.FillWeight = 80F;
            this.Column1.HeaderText = "Mã đề thi";
            this.Column1.Name = "Column1";
            this.Column1.Width = 77;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenDeThi";
            this.Column2.FillWeight = 150F;
            this.Column2.HeaderText = "Tên đề thi";
            this.Column2.Name = "Column2";
            this.Column2.Width = 81;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenMonThi";
            this.Column3.FillWeight = 120F;
            this.Column3.HeaderText = "Môn thi";
            this.Column3.Name = "Column3";
            this.Column3.Width = 67;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgayTao";
            this.Column4.HeaderText = "Ngày tạo";
            this.Column4.Name = "Column4";
            this.Column4.Width = 75;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DiemToiDa";
            this.Column5.FillWeight = 80F;
            this.Column5.HeaderText = "Điểm tối đa";
            this.Column5.Name = "Column5";
            this.Column5.Width = 86;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SoLuongCauHoi";
            this.Column6.FillWeight = 80F;
            this.Column6.HeaderText = "Số lượng câu";
            this.Column6.Name = "Column6";
            this.Column6.Width = 95;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ThoiGianThi";
            this.Column7.HeaderText = "Thời gian thi";
            this.Column7.Name = "Column7";
            this.Column7.Width = 90;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_refresh);
            this.groupBox2.Controls.Add(this.textBox_diem);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.button_xoa);
            this.groupBox2.Controls.Add(this.button_sua);
            this.groupBox2.Controls.Add(this.button_them);
            this.groupBox2.Controls.Add(this.numericUpDown_time);
            this.groupBox2.Controls.Add(this.textBox_tende);
            this.groupBox2.Controls.Add(this.textBox_made);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(30, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 231);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết đề thi";
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(325, 184);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(95, 23);
            this.button_refresh.TabIndex = 15;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // textBox_diem
            // 
            this.textBox_diem.Location = new System.Drawing.Point(89, 182);
            this.textBox_diem.Name = "textBox_diem";
            this.textBox_diem.Size = new System.Drawing.Size(121, 20);
            this.textBox_diem.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Điểm tối đa:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(89, 146);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(114, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // button_xoa
            // 
            this.button_xoa.Location = new System.Drawing.Point(325, 143);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(95, 23);
            this.button_xoa.TabIndex = 11;
            this.button_xoa.Text = "Xóa đề thi";
            this.button_xoa.UseVisualStyleBackColor = true;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_sua
            // 
            this.button_sua.Location = new System.Drawing.Point(325, 103);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(95, 23);
            this.button_sua.TabIndex = 10;
            this.button_sua.Text = "Sửa đề thi";
            this.button_sua.UseVisualStyleBackColor = true;
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // button_them
            // 
            this.button_them.Location = new System.Drawing.Point(325, 57);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(95, 23);
            this.button_them.TabIndex = 9;
            this.button_them.Text = "Thêm đề thi";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // numericUpDown_time
            // 
            this.numericUpDown_time.Location = new System.Drawing.Point(116, 109);
            this.numericUpDown_time.Name = "numericUpDown_time";
            this.numericUpDown_time.Size = new System.Drawing.Size(94, 20);
            this.numericUpDown_time.TabIndex = 7;
            // 
            // textBox_tende
            // 
            this.textBox_tende.Location = new System.Drawing.Point(79, 64);
            this.textBox_tende.Name = "textBox_tende";
            this.textBox_tende.Size = new System.Drawing.Size(194, 20);
            this.textBox_tende.TabIndex = 6;
            // 
            // textBox_made
            // 
            this.textBox_made.Location = new System.Drawing.Point(79, 28);
            this.textBox_made.Name = "textBox_made";
            this.textBox_made.Size = new System.Drawing.Size(194, 20);
            this.textBox_made.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày tạo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thời gian thi(phút):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên đề thi: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã đề thi: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số lượng câu hỏi: ";
            // 
            // numericUpDown_count
            // 
            this.numericUpDown_count.Location = new System.Drawing.Point(123, 28);
            this.numericUpDown_count.Name = "numericUpDown_count";
            this.numericUpDown_count.Size = new System.Drawing.Size(94, 20);
            this.numericUpDown_count.TabIndex = 8;
            this.numericUpDown_count.Tag = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dataGridView_cauhoi);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox_solgcauhoi);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.button_random);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.numericUpDown_count);
            this.groupBox3.Location = new System.Drawing.Point(498, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 419);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách câu hỏi";
            // 
            // dataGridView_cauhoi
            // 
            this.dataGridView_cauhoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_cauhoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cauhoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column8,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16});
            this.dataGridView_cauhoi.Location = new System.Drawing.Point(6, 115);
            this.dataGridView_cauhoi.Name = "dataGridView_cauhoi";
            this.dataGridView_cauhoi.Size = new System.Drawing.Size(453, 313);
            this.dataGridView_cauhoi.TabIndex = 13;
            this.dataGridView_cauhoi.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_cauhoi_CellValueChanged);
            this.dataGridView_cauhoi.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView_cauhoi_CurrentCellDirtyStateChanged);
            // 
            // Check
            // 
            this.Check.HeaderText = "Chọn câu hỏi";
            this.Check.Name = "Check";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "IdCauHoi";
            this.Column9.FillWeight = 70F;
            this.Column9.HeaderText = "Mã câu hỏi";
            this.Column9.Name = "Column9";
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column9.Width = 82;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "CauHoi";
            this.Column10.FillWeight = 150F;
            this.Column10.HeaderText = "Câu hỏi";
            this.Column10.Name = "Column10";
            this.Column10.Width = 82;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "TenMucDo";
            this.Column11.FillWeight = 80F;
            this.Column11.HeaderText = "Mức độ";
            this.Column11.Name = "Column11";
            this.Column11.Width = 82;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "TenChuong";
            this.Column12.HeaderText = "Chương";
            this.Column12.Name = "Column12";
            this.Column12.Width = 82;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 150F;
            this.Column8.HeaderText = "Đáp án A";
            this.Column8.Name = "Column8";
            // 
            // Column13
            // 
            this.Column13.FillWeight = 150F;
            this.Column13.HeaderText = "Đáp Án B";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.FillWeight = 150F;
            this.Column14.HeaderText = "Đáp án C";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.FillWeight = 150F;
            this.Column15.HeaderText = "Đáp án D";
            this.Column15.Name = "Column15";
            // 
            // Column16
            // 
            this.Column16.FillWeight = 70F;
            this.Column16.HeaderText = "Đáp án đúng";
            this.Column16.Name = "Column16";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "câu";
            // 
            // textBox_solgcauhoi
            // 
            this.textBox_solgcauhoi.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_solgcauhoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_solgcauhoi.Location = new System.Drawing.Point(75, 81);
            this.textBox_solgcauhoi.Name = "textBox_solgcauhoi";
            this.textBox_solgcauhoi.Size = new System.Drawing.Size(14, 13);
            this.textBox_solgcauhoi.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Đã chọn: ";
            // 
            // button_random
            // 
            this.button_random.Location = new System.Drawing.Point(274, 26);
            this.button_random.Name = "button_random";
            this.button_random.Size = new System.Drawing.Size(62, 21);
            this.button_random.TabIndex = 9;
            this.button_random.Text = "Random";
            this.button_random.UseVisualStyleBackColor = true;
            this.button_random.Click += new System.EventHandler(this.button_random_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(389, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Mã hoặc tên đề thi: ";
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(498, 16);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(194, 20);
            this.textBox_search.TabIndex = 15;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(709, 18);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(95, 23);
            this.button_search.TabIndex = 16;
            this.button_search.Text = "Tìm kiếm";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // Formdethi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 539);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox_monthi);
            this.Controls.Add(this.label1);
            this.Name = "Formdethi";
            this.Text = "Đề Thi";
            this.Load += new System.EventHandler(this.Formdethi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dsCh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_count)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cauhoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_monthi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_dsCh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_tende;
        private System.Windows.Forms.TextBox textBox_made;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_time;
        private System.Windows.Forms.NumericUpDown numericUpDown_count;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_diem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView_cauhoi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_solgcauhoi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_random;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_search;
    }
}