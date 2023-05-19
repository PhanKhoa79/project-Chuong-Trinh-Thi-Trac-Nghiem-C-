namespace Nhom10
{
    partial class fSinhVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_dangxuat = new System.Windows.Forms.Button();
            this.btn_baiThi = new System.Windows.Forms.Button();
            this.button_ttTK = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.btn_dangxuat);
            this.panel1.Controls.Add(this.btn_baiThi);
            this.panel1.Controls.Add(this.button_ttTK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 493);
            this.panel1.TabIndex = 0;
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.Location = new System.Drawing.Point(24, 261);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(104, 58);
            this.btn_dangxuat.TabIndex = 2;
            this.btn_dangxuat.Text = "Đăng Xuất";
            this.btn_dangxuat.UseVisualStyleBackColor = true;
            this.btn_dangxuat.Click += new System.EventHandler(this.button_thoat_Click);
            // 
            // btn_baiThi
            // 
            this.btn_baiThi.Location = new System.Drawing.Point(24, 70);
            this.btn_baiThi.Name = "btn_baiThi";
            this.btn_baiThi.Size = new System.Drawing.Size(104, 58);
            this.btn_baiThi.TabIndex = 1;
            this.btn_baiThi.Text = "Bài Thi";
            this.btn_baiThi.UseVisualStyleBackColor = true;
            this.btn_baiThi.Click += new System.EventHandler(this.btn_baiThi_Click);
            // 
            // button_ttTK
            // 
            this.button_ttTK.Location = new System.Drawing.Point(24, 166);
            this.button_ttTK.Name = "button_ttTK";
            this.button_ttTK.Size = new System.Drawing.Size(104, 58);
            this.button_ttTK.TabIndex = 0;
            this.button_ttTK.Text = "Thông Tin Tài Khoản";
            this.button_ttTK.UseVisualStyleBackColor = true;
            this.button_ttTK.Click += new System.EventHandler(this.button_ttTK_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(153, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 56);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // panel_body
            // 
            this.panel_body.BackColor = System.Drawing.Color.White;
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(153, 56);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(737, 437);
            this.panel_body.TabIndex = 2;
            // 
            // fSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 493);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fSinhVien";
            this.Text = "Làm Bài Thi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fSinhVien_FormClosing);
            this.Load += new System.EventHandler(this.fSinhVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_ttTK;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Button btn_dangxuat;
        private System.Windows.Forms.Button btn_baiThi;
        private System.Windows.Forms.Label label1;
    }
}