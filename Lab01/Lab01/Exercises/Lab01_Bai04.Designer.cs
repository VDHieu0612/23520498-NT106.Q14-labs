namespace Lab01.Exercises
{
    partial class Lab01_Bai04
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.ComboBox cbPhongChieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbChonPhim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbChonGhe;
        private System.Windows.Forms.Button btnA5;
        private System.Windows.Forms.Button btnA4;
        private System.Windows.Forms.Button btnA3;
        private System.Windows.Forms.Button btnA2;
        private System.Windows.Forms.Button btnA1;
        private System.Windows.Forms.Label lblScreen;
        private System.Windows.Forms.Button btnC5;
        private System.Windows.Forms.Button btnC4;
        private System.Windows.Forms.Button btnC3;
        private System.Windows.Forms.Button btnC2;
        private System.Windows.Forms.Button btnC1;
        private System.Windows.Forms.Button btnB5;
        private System.Windows.Forms.Button btnB4;
        private System.Windows.Forms.Button btnB3;
        private System.Windows.Forms.Button btnB2;
        private System.Windows.Forms.Button btnB1;
        private System.Windows.Forms.GroupBox gbThanhToan;
        private System.Windows.Forms.TextBox txtThongTin;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThanhToan;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            gbThongTin = new GroupBox();
            cbPhongChieu = new ComboBox();
            label3 = new Label();
            cbChonPhim = new ComboBox();
            label2 = new Label();
            txtHoTen = new TextBox();
            label1 = new Label();
            gbChonGhe = new GroupBox();
            lblScreen = new Label();
            btnC5 = new Button();
            btnC4 = new Button();
            btnC3 = new Button();
            btnC2 = new Button();
            btnC1 = new Button();
            btnB5 = new Button();
            btnB4 = new Button();
            btnB3 = new Button();
            btnB2 = new Button();
            btnB1 = new Button();
            btnA5 = new Button();
            btnA4 = new Button();
            btnA3 = new Button();
            btnA2 = new Button();
            btnA1 = new Button();
            gbThanhToan = new GroupBox();
            txtThongTin = new TextBox();
            btnHuy = new Button();
            btnThanhToan = new Button();
            gbThongTin.SuspendLayout();
            gbChonGhe.SuspendLayout();
            gbThanhToan.SuspendLayout();
            SuspendLayout();
            // 
            // gbThongTin
            // 
            gbThongTin.Controls.Add(cbPhongChieu);
            gbThongTin.Controls.Add(label3);
            gbThongTin.Controls.Add(label2);
            gbThongTin.Controls.Add(txtHoTen);
            gbThongTin.Controls.Add(label1);
            gbThongTin.Controls.Add(cbChonPhim);
            gbThongTin.Location = new Point(12, 12);
            gbThongTin.Name = "gbThongTin";
            gbThongTin.Size = new Size(437, 303);
            gbThongTin.TabIndex = 0;
            gbThongTin.TabStop = false;
            gbThongTin.Text = "Thông tin khách hàng";
            // 
            // cbPhongChieu
            // 
            cbPhongChieu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPhongChieu.FormattingEnabled = true;
            cbPhongChieu.Location = new Point(21, 238);
            cbPhongChieu.Name = "cbPhongChieu";
            cbPhongChieu.Size = new Size(395, 40);
            cbPhongChieu.TabIndex = 5;
            cbPhongChieu.SelectedIndexChanged += cbPhongChieu_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 194);
            label3.Name = "label3";
            label3.Size = new Size(218, 32);
            label3.TabIndex = 4;
            label3.Text = "Chọn phòng chiếu:";
            // 
            // cbChonPhim
            // 
            cbChonPhim.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChonPhim.FormattingEnabled = true;
            cbChonPhim.Location = new Point(21, 151);
            cbChonPhim.Name = "cbChonPhim";
            cbChonPhim.Size = new Size(395, 40);
            cbChonPhim.TabIndex = 3;
            cbChonPhim.SelectedIndexChanged += cbChonPhim_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 116);
            label2.Name = "label2";
            label2.Size = new Size(138, 32);
            label2.TabIndex = 2;
            label2.Text = "Chọn phim:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(21, 74);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(395, 39);
            txtHoTen.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 39);
            label1.Name = "label1";
            label1.Size = new Size(254, 32);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên khách hàng:";
            // 
            // gbChonGhe
            // 
            gbChonGhe.Controls.Add(lblScreen);
            gbChonGhe.Controls.Add(btnC5);
            gbChonGhe.Controls.Add(btnC4);
            gbChonGhe.Controls.Add(btnC3);
            gbChonGhe.Controls.Add(btnC2);
            gbChonGhe.Controls.Add(btnC1);
            gbChonGhe.Controls.Add(btnB5);
            gbChonGhe.Controls.Add(btnB4);
            gbChonGhe.Controls.Add(btnB3);
            gbChonGhe.Controls.Add(btnB2);
            gbChonGhe.Controls.Add(btnB1);
            gbChonGhe.Controls.Add(btnA5);
            gbChonGhe.Controls.Add(btnA4);
            gbChonGhe.Controls.Add(btnA3);
            gbChonGhe.Controls.Add(btnA2);
            gbChonGhe.Controls.Add(btnA1);
            gbChonGhe.Location = new Point(469, 12);
            gbChonGhe.Name = "gbChonGhe";
            gbChonGhe.Size = new Size(514, 303);
            gbChonGhe.TabIndex = 1;
            gbChonGhe.TabStop = false;
            gbChonGhe.Text = "Sơ đồ phòng chiếu";
            // 
            // lblScreen
            // 
            lblScreen.BackColor = SystemColors.ControlDark;
            lblScreen.BorderStyle = BorderStyle.FixedSingle;
            lblScreen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblScreen.Location = new Point(65, 51);
            lblScreen.Name = "lblScreen";
            lblScreen.Size = new Size(406, 43);
            lblScreen.TabIndex = 15;
            lblScreen.Text = "MÀN HÌNH";
            lblScreen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnC5
            // 
            btnC5.Location = new Point(405, 247);
            btnC5.Name = "btnC5";
            btnC5.Size = new Size(66, 44);
            btnC5.TabIndex = 14;
            btnC5.Text = "C5";
            btnC5.UseVisualStyleBackColor = true;
            // 
            // btnC4
            // 
            btnC4.Location = new Point(321, 247);
            btnC4.Name = "btnC4";
            btnC4.Size = new Size(66, 44);
            btnC4.TabIndex = 13;
            btnC4.Text = "C4";
            btnC4.UseVisualStyleBackColor = true;
            // 
            // btnC3
            // 
            btnC3.Location = new Point(236, 247);
            btnC3.Name = "btnC3";
            btnC3.Size = new Size(66, 44);
            btnC3.TabIndex = 12;
            btnC3.Text = "C3";
            btnC3.UseVisualStyleBackColor = true;
            // 
            // btnC2
            // 
            btnC2.Location = new Point(150, 247);
            btnC2.Name = "btnC2";
            btnC2.Size = new Size(66, 44);
            btnC2.TabIndex = 11;
            btnC2.Text = "C2";
            btnC2.UseVisualStyleBackColor = true;
            // 
            // btnC1
            // 
            btnC1.Location = new Point(65, 247);
            btnC1.Name = "btnC1";
            btnC1.Size = new Size(66, 44);
            btnC1.TabIndex = 10;
            btnC1.Text = "C1";
            btnC1.UseVisualStyleBackColor = true;
            // 
            // btnB5
            // 
            btnB5.Location = new Point(405, 197);
            btnB5.Name = "btnB5";
            btnB5.Size = new Size(66, 44);
            btnB5.TabIndex = 9;
            btnB5.Text = "B5";
            btnB5.UseVisualStyleBackColor = true;
            // 
            // btnB4
            // 
            btnB4.Location = new Point(321, 197);
            btnB4.Name = "btnB4";
            btnB4.Size = new Size(66, 44);
            btnB4.TabIndex = 8;
            btnB4.Text = "B4";
            btnB4.UseVisualStyleBackColor = true;
            // 
            // btnB3
            // 
            btnB3.Location = new Point(236, 197);
            btnB3.Name = "btnB3";
            btnB3.Size = new Size(66, 44);
            btnB3.TabIndex = 7;
            btnB3.Text = "B3";
            btnB3.UseVisualStyleBackColor = true;
            // 
            // btnB2
            // 
            btnB2.Location = new Point(150, 197);
            btnB2.Name = "btnB2";
            btnB2.Size = new Size(66, 44);
            btnB2.TabIndex = 6;
            btnB2.Text = "B2";
            btnB2.UseVisualStyleBackColor = true;
            // 
            // btnB1
            // 
            btnB1.Location = new Point(65, 197);
            btnB1.Name = "btnB1";
            btnB1.Size = new Size(66, 44);
            btnB1.TabIndex = 5;
            btnB1.Text = "B1";
            btnB1.UseVisualStyleBackColor = true;
            // 
            // btnA5
            // 
            btnA5.Location = new Point(405, 147);
            btnA5.Name = "btnA5";
            btnA5.Size = new Size(66, 44);
            btnA5.TabIndex = 4;
            btnA5.Text = "A5";
            btnA5.UseVisualStyleBackColor = true;
            // 
            // btnA4
            // 
            btnA4.Location = new Point(321, 147);
            btnA4.Name = "btnA4";
            btnA4.Size = new Size(66, 44);
            btnA4.TabIndex = 3;
            btnA4.Text = "A4";
            btnA4.UseVisualStyleBackColor = true;
            // 
            // btnA3
            // 
            btnA3.Location = new Point(236, 147);
            btnA3.Name = "btnA3";
            btnA3.Size = new Size(66, 44);
            btnA3.TabIndex = 2;
            btnA3.Text = "A3";
            btnA3.UseVisualStyleBackColor = true;
            // 
            // btnA2
            // 
            btnA2.Location = new Point(150, 147);
            btnA2.Name = "btnA2";
            btnA2.Size = new Size(66, 44);
            btnA2.TabIndex = 1;
            btnA2.Text = "A2";
            btnA2.UseVisualStyleBackColor = true;
            // 
            // btnA1
            // 
            btnA1.Location = new Point(65, 147);
            btnA1.Name = "btnA1";
            btnA1.Size = new Size(66, 44);
            btnA1.TabIndex = 0;
            btnA1.Text = "A1";
            btnA1.UseVisualStyleBackColor = true;
            // 
            // gbThanhToan
            // 
            gbThanhToan.Controls.Add(txtThongTin);
            gbThanhToan.Controls.Add(btnHuy);
            gbThanhToan.Controls.Add(btnThanhToan);
            gbThanhToan.Location = new Point(12, 321);
            gbThanhToan.Name = "gbThanhToan";
            gbThanhToan.Size = new Size(971, 403);
            gbThanhToan.TabIndex = 2;
            gbThanhToan.TabStop = false;
            gbThanhToan.Text = "Thông tin vé và thanh toán";
            // 
            // txtThongTin
            // 
            txtThongTin.Location = new Point(21, 38);
            txtThongTin.Multiline = true;
            txtThongTin.Name = "txtThongTin";
            txtThongTin.ReadOnly = true;
            txtThongTin.ScrollBars = ScrollBars.Vertical;
            txtThongTin.Size = new Size(696, 321);
            txtThongTin.TabIndex = 2;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(744, 110);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(203, 74);
            btnHuy.TabIndex = 1;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThanhToan.Location = new Point(744, 26);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(203, 78);
            btnThanhToan.TabIndex = 0;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // Lab01_Bai04
            // 
            ClientSize = new Size(1019, 765);
            Controls.Add(gbThanhToan);
            Controls.Add(gbChonGhe);
            Controls.Add(gbThongTin);
            Name = "Lab01_Bai04";
            Text = "Lab01_Bai04";
            Load += Lab01_Bai04_Load;
            gbThongTin.ResumeLayout(false);
            gbThongTin.PerformLayout();
            gbChonGhe.ResumeLayout(false);
            gbThanhToan.ResumeLayout(false);
            gbThanhToan.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
