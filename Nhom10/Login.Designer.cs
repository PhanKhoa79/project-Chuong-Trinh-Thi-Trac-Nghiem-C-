namespace Nhom10
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lb_DN = new System.Windows.Forms.Label();
            this.lb_DNTK = new System.Windows.Forms.Label();
            this.lb_DNMK = new System.Windows.Forms.Label();
            this.link_Dki = new System.Windows.Forms.LinkLabel();
            this.btn_DN = new System.Windows.Forms.Button();
            this.txt_TK = new System.Windows.Forms.TextBox();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.cbx_hienthi = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_checkMk = new System.Windows.Forms.Label();
            this.lb_dkitk = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_DN
            // 
            this.lb_DN.AutoSize = true;
            this.lb_DN.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DN.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_DN.Location = new System.Drawing.Point(54, 27);
            this.lb_DN.Name = "lb_DN";
            this.lb_DN.Size = new System.Drawing.Size(110, 23);
            this.lb_DN.TabIndex = 0;
            this.lb_DN.Text = "Đăng Nhập";
            this.lb_DN.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_DNTK
            // 
            this.lb_DNTK.AutoSize = true;
            this.lb_DNTK.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DNTK.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_DNTK.Location = new System.Drawing.Point(54, 99);
            this.lb_DNTK.Name = "lb_DNTK";
            this.lb_DNTK.Size = new System.Drawing.Size(81, 19);
            this.lb_DNTK.TabIndex = 0;
            this.lb_DNTK.Text = "Tài Khoản";
            // 
            // lb_DNMK
            // 
            this.lb_DNMK.AutoSize = true;
            this.lb_DNMK.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DNMK.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_DNMK.Location = new System.Drawing.Point(58, 172);
            this.lb_DNMK.Name = "lb_DNMK";
            this.lb_DNMK.Size = new System.Drawing.Size(78, 19);
            this.lb_DNMK.TabIndex = 0;
            this.lb_DNMK.Text = "Mật Khẩu";
            // 
            // link_Dki
            // 
            this.link_Dki.AutoSize = true;
            this.link_Dki.BackColor = System.Drawing.Color.White;
            this.link_Dki.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_Dki.ForeColor = System.Drawing.Color.DarkBlue;
            this.link_Dki.LinkColor = System.Drawing.Color.DarkBlue;
            this.link_Dki.Location = new System.Drawing.Point(188, 386);
            this.link_Dki.Name = "link_Dki";
            this.link_Dki.Size = new System.Drawing.Size(71, 19);
            this.link_Dki.TabIndex = 5;
            this.link_Dki.TabStop = true;
            this.link_Dki.Text = "Đăng Kí";
            this.link_Dki.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_Dki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Dki_LinkClicked);
            // 
            // btn_DN
            // 
            this.btn_DN.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_DN.FlatAppearance.BorderSize = 0;
            this.btn_DN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DN.ForeColor = System.Drawing.Color.White;
            this.btn_DN.Location = new System.Drawing.Point(110, 302);
            this.btn_DN.Margin = new System.Windows.Forms.Padding(0);
            this.btn_DN.Name = "btn_DN";
            this.btn_DN.Size = new System.Drawing.Size(220, 35);
            this.btn_DN.TabIndex = 4;
            this.btn_DN.Text = "Đăng Nhập";
            this.btn_DN.UseVisualStyleBackColor = false;
            this.btn_DN.Click += new System.EventHandler(this.btn_DN_Click);
            // 
            // txt_TK
            // 
            this.txt_TK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_TK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TK.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txt_TK.Location = new System.Drawing.Point(0, 0);
            this.txt_TK.Multiline = true;
            this.txt_TK.Name = "txt_TK";
            this.txt_TK.Size = new System.Drawing.Size(325, 27);
            this.txt_TK.TabIndex = 1;
            this.txt_TK.TextChanged += new System.EventHandler(this.txt_TK_TextChanged);
            // 
            // txt_MK
            // 
            this.txt_MK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_MK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_MK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MK.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txt_MK.Location = new System.Drawing.Point(0, 0);
            this.txt_MK.Multiline = true;
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.Size = new System.Drawing.Size(325, 27);
            this.txt_MK.TabIndex = 2;
            this.txt_MK.TextChanged += new System.EventHandler(this.txt_MK_TextChanged);
            // 
            // cbx_hienthi
            // 
            this.cbx_hienthi.AutoSize = true;
            this.cbx_hienthi.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_hienthi.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cbx_hienthi.Location = new System.Drawing.Point(61, 267);
            this.cbx_hienthi.Name = "cbx_hienthi";
            this.cbx_hienthi.Size = new System.Drawing.Size(164, 23);
            this.cbx_hienthi.TabIndex = 3;
            this.cbx_hienthi.Text = "Hiển Thị Mật Khẩu";
            this.cbx_hienthi.UseVisualStyleBackColor = true;
            this.cbx_hienthi.CheckedChanged += new System.EventHandler(this.cbx_hienthi_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-9, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 450);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 46);
            this.label5.TabIndex = 0;
            this.label5.Text = "                      Đại Học \r\nCông Nghệ Giao Thông Vận Tải";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(101, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "72DCHT21";
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label_checkMk);
            this.panel2.Controls.Add(this.lb_dkitk);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lb_DNTK);
            this.panel2.Controls.Add(this.cbx_hienthi);
            this.panel2.Controls.Add(this.btn_DN);
            this.panel2.Controls.Add(this.link_Dki);
            this.panel2.Controls.Add(this.lb_DNMK);
            this.panel2.Controls.Add(this.lb_DN);
            this.panel2.Location = new System.Drawing.Point(292, -8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 438);
            this.panel2.TabIndex = 0;
            // 
            // label_checkMk
            // 
            this.label_checkMk.AutoSize = true;
            this.label_checkMk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_checkMk.ForeColor = System.Drawing.Color.Red;
            this.label_checkMk.Location = new System.Drawing.Point(63, 234);
            this.label_checkMk.Name = "label_checkMk";
            this.label_checkMk.Size = new System.Drawing.Size(0, 19);
            this.label_checkMk.TabIndex = 6;
            // 
            // lb_dkitk
            // 
            this.lb_dkitk.AutoSize = true;
            this.lb_dkitk.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dkitk.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_dkitk.Location = new System.Drawing.Point(137, 357);
            this.lb_dkitk.Name = "lb_dkitk";
            this.lb_dkitk.Size = new System.Drawing.Size(176, 19);
            this.lb_dkitk.TabIndex = 0;
            this.lb_dkitk.Text = "Bạn chưa có tài khoản ?";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Controls.Add(this.txt_MK);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(62, 194);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel4.Size = new System.Drawing.Size(325, 30);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.txt_TK);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(61, 121);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel3.Size = new System.Drawing.Size(325, 30);
            this.panel3.TabIndex = 1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Login";
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_DN;
        private System.Windows.Forms.Label lb_DNTK;
        private System.Windows.Forms.Label lb_DNMK;
        private System.Windows.Forms.LinkLabel link_Dki;
        private System.Windows.Forms.Button btn_DN;
        private System.Windows.Forms.TextBox txt_TK;
        private System.Windows.Forms.TextBox txt_MK;
        private System.Windows.Forms.CheckBox cbx_hienthi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_dkitk;
        private System.Windows.Forms.Label label_checkMk;
    }
}