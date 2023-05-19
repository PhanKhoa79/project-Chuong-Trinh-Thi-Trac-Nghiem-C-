namespace Nhom10
{
    partial class Formthisinh
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
            this.dataGridView_ttSv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_khoa = new System.Windows.Forms.ComboBox();
            this.comboBox_lop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_msv = new System.Windows.Forms.TextBox();
            this.textBox_hoten = new System.Windows.Forms.TextBox();
            this.radioButton_nam = new System.Windows.Forms.RadioButton();
            this.radioButton_nu = new System.Windows.Forms.RadioButton();
            this.textBox_sdt = new System.Windows.Forms.TextBox();
            this.textBox_qq = new System.Windows.Forms.TextBox();
            this.dateTimePicker_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_xuatE = new System.Windows.Forms.Button();
            this.button_nhapE = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_timkiem = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_sua = new System.Windows.Forms.Button();
            this.button_them = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_timkiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ttSv)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_ttSv
            // 
            this.dataGridView_ttSv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ttSv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ttSv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView_ttSv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_ttSv.Location = new System.Drawing.Point(0, 329);
            this.dataGridView_ttSv.Name = "dataGridView_ttSv";
            this.dataGridView_ttSv.Size = new System.Drawing.Size(876, 174);
            this.dataGridView_ttSv.TabIndex = 0;
            this.dataGridView_ttSv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ttSv_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdSinhVien";
            this.Column1.HeaderText = "Mã Sinh Viên";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenSinhVien";
            this.Column2.HeaderText = "Họ và tên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenLop";
            this.Column3.HeaderText = "Lớp";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TenKhoa";
            this.Column4.FillWeight = 120F;
            this.Column4.HeaderText = "Khoa";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgaySinh";
            this.Column5.HeaderText = "Ngày sinh";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "GioiTinh";
            this.Column6.FillWeight = 80F;
            this.Column6.HeaderText = "Giới Tính";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "SDT";
            this.Column7.HeaderText = "Số Điện Thoại";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "DiaChi";
            this.Column8.HeaderText = "Quê Quán";
            this.Column8.Name = "Column8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khoa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lớp:";
            // 
            // comboBox_khoa
            // 
            this.comboBox_khoa.FormattingEnabled = true;
            this.comboBox_khoa.Location = new System.Drawing.Point(88, 6);
            this.comboBox_khoa.Name = "comboBox_khoa";
            this.comboBox_khoa.Size = new System.Drawing.Size(131, 21);
            this.comboBox_khoa.TabIndex = 3;
            this.comboBox_khoa.SelectedValueChanged += new System.EventHandler(this.comboBox_khoa_SelectedValueChanged);
            // 
            // comboBox_lop
            // 
            this.comboBox_lop.FormattingEnabled = true;
            this.comboBox_lop.Location = new System.Drawing.Point(317, 6);
            this.comboBox_lop.Name = "comboBox_lop";
            this.comboBox_lop.Size = new System.Drawing.Size(131, 21);
            this.comboBox_lop.TabIndex = 4;
            this.comboBox_lop.SelectedValueChanged += new System.EventHandler(this.comboBox_lop_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã sinh viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Họ và tên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Giới tính: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ngày sinh:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Quê Quán:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Số điện thoại:";
            // 
            // textBox_msv
            // 
            this.textBox_msv.Location = new System.Drawing.Point(119, 55);
            this.textBox_msv.Name = "textBox_msv";
            this.textBox_msv.Size = new System.Drawing.Size(209, 20);
            this.textBox_msv.TabIndex = 11;
            // 
            // textBox_hoten
            // 
            this.textBox_hoten.Location = new System.Drawing.Point(119, 110);
            this.textBox_hoten.Name = "textBox_hoten";
            this.textBox_hoten.Size = new System.Drawing.Size(209, 20);
            this.textBox_hoten.TabIndex = 12;
            // 
            // radioButton_nam
            // 
            this.radioButton_nam.AutoSize = true;
            this.radioButton_nam.Location = new System.Drawing.Point(119, 146);
            this.radioButton_nam.Name = "radioButton_nam";
            this.radioButton_nam.Size = new System.Drawing.Size(47, 17);
            this.radioButton_nam.TabIndex = 13;
            this.radioButton_nam.TabStop = true;
            this.radioButton_nam.Text = "Nam";
            this.radioButton_nam.UseVisualStyleBackColor = true;
            // 
            // radioButton_nu
            // 
            this.radioButton_nu.AutoSize = true;
            this.radioButton_nu.Location = new System.Drawing.Point(229, 148);
            this.radioButton_nu.Name = "radioButton_nu";
            this.radioButton_nu.Size = new System.Drawing.Size(39, 17);
            this.radioButton_nu.TabIndex = 14;
            this.radioButton_nu.TabStop = true;
            this.radioButton_nu.Text = "Nữ";
            this.radioButton_nu.UseVisualStyleBackColor = true;
            // 
            // textBox_sdt
            // 
            this.textBox_sdt.Location = new System.Drawing.Point(119, 235);
            this.textBox_sdt.Name = "textBox_sdt";
            this.textBox_sdt.Size = new System.Drawing.Size(209, 20);
            this.textBox_sdt.TabIndex = 15;
            // 
            // textBox_qq
            // 
            this.textBox_qq.Location = new System.Drawing.Point(119, 275);
            this.textBox_qq.Name = "textBox_qq";
            this.textBox_qq.Size = new System.Drawing.Size(209, 20);
            this.textBox_qq.TabIndex = 16;
            // 
            // dateTimePicker_ngaysinh
            // 
            this.dateTimePicker_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_ngaysinh.Location = new System.Drawing.Point(119, 192);
            this.dateTimePicker_ngaysinh.Name = "dateTimePicker_ngaysinh";
            this.dateTimePicker_ngaysinh.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker_ngaysinh.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_xuatE);
            this.panel1.Controls.Add(this.button_nhapE);
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.button_timkiem);
            this.panel1.Controls.Add(this.button_xoa);
            this.panel1.Controls.Add(this.button_sua);
            this.panel1.Controls.Add(this.button_them);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(669, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 329);
            this.panel1.TabIndex = 25;
            // 
            // button_xuatE
            // 
            this.button_xuatE.Location = new System.Drawing.Point(127, 153);
            this.button_xuatE.Name = "button_xuatE";
            this.button_xuatE.Size = new System.Drawing.Size(65, 48);
            this.button_xuatE.TabIndex = 31;
            this.button_xuatE.Text = "Xuất Excel";
            this.button_xuatE.UseVisualStyleBackColor = true;
            this.button_xuatE.Click += new System.EventHandler(this.button_xuatE_Click);
            // 
            // button_nhapE
            // 
            this.button_nhapE.Location = new System.Drawing.Point(20, 153);
            this.button_nhapE.Name = "button_nhapE";
            this.button_nhapE.Size = new System.Drawing.Size(65, 48);
            this.button_nhapE.TabIndex = 30;
            this.button_nhapE.Text = "Nhập Excel";
            this.button_nhapE.UseVisualStyleBackColor = true;
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(20, 223);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(65, 48);
            this.button_refresh.TabIndex = 29;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_timkiem
            // 
            this.button_timkiem.Location = new System.Drawing.Point(127, 16);
            this.button_timkiem.Name = "button_timkiem";
            this.button_timkiem.Size = new System.Drawing.Size(65, 48);
            this.button_timkiem.TabIndex = 28;
            this.button_timkiem.Text = "Tìm Kiếm";
            this.button_timkiem.UseVisualStyleBackColor = true;
            this.button_timkiem.Click += new System.EventHandler(this.button_timkiem_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.Location = new System.Drawing.Point(127, 89);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(65, 48);
            this.button_xoa.TabIndex = 27;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = true;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_sua
            // 
            this.button_sua.Location = new System.Drawing.Point(20, 89);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(65, 48);
            this.button_sua.TabIndex = 26;
            this.button_sua.Text = "Sửa";
            this.button_sua.UseVisualStyleBackColor = true;
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // button_them
            // 
            this.button_them.Location = new System.Drawing.Point(20, 16);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(65, 48);
            this.button_them.TabIndex = 25;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dateTimePicker_ngaysinh);
            this.panel2.Controls.Add(this.comboBox_khoa);
            this.panel2.Controls.Add(this.textBox_qq);
            this.panel2.Controls.Add(this.comboBox_lop);
            this.panel2.Controls.Add(this.textBox_sdt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.radioButton_nu);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.radioButton_nam);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox_hoten);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBox_msv);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 329);
            this.panel2.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(472, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tìm Kiếm: ";
            // 
            // textBox_timkiem
            // 
            this.textBox_timkiem.Location = new System.Drawing.Point(534, 7);
            this.textBox_timkiem.Name = "textBox_timkiem";
            this.textBox_timkiem.Size = new System.Drawing.Size(118, 20);
            this.textBox_timkiem.TabIndex = 18;
            // 
            // Formthisinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 503);
            this.Controls.Add(this.textBox_timkiem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_ttSv);
            this.Name = "Formthisinh";
            this.Text = "Thí Sinh";
            this.Load += new System.EventHandler(this.Formthisinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ttSv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ttSv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_khoa;
        private System.Windows.Forms.ComboBox comboBox_lop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_msv;
        private System.Windows.Forms.TextBox textBox_hoten;
        private System.Windows.Forms.RadioButton radioButton_nam;
        private System.Windows.Forms.RadioButton radioButton_nu;
        private System.Windows.Forms.TextBox textBox_sdt;
        private System.Windows.Forms.TextBox textBox_qq;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngaysinh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_xuatE;
        private System.Windows.Forms.Button button_nhapE;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_timkiem;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_timkiem;
    }
}