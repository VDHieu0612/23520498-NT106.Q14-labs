namespace Lab01.Exercises
{
    partial class Lab01_Bai05
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            btnTinh = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            groupBox1 = new GroupBox();
            txtKetqua = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 90);
            label1.Name = "label1";
            label1.Size = new Size(127, 45);
            label1.TabIndex = 0;
            label1.Text = "Nhập A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(594, 91);
            label2.Name = "label2";
            label2.Size = new Size(124, 45);
            label2.TabIndex = 1;
            label2.Text = "Nhập B";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(243, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 39);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(749, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(270, 39);
            textBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bảng cửu chương", "Tính toán giá trị" });
            comboBox1.Location = new Point(454, 204);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(291, 53);
            comboBox1.TabIndex = 4;
            // 
            // btnTinh
            // 
            btnTinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTinh.Location = new Point(180, 300);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(249, 61);
            btnTinh.TabIndex = 5;
            btnTinh.Text = "Tính các giá trị";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(469, 300);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(249, 61);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(770, 300);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(249, 61);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // groupBox1
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(62, 383);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1074, 600);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kết quả";
            //
            // Thêm TextBox đa dòng vào groupBox1
            TextBox txtKetQua = new TextBox();
            txtKetQua.Multiline = true;
            txtKetQua.ScrollBars = ScrollBars.Vertical;
            txtKetQua.Dock = DockStyle.Fill;
            txtKetQua.ReadOnly = true;
            txtKetQua.Font = new Font("Consolas", 12);
            groupBox1.Controls.Add(txtKetQua);
            // 
            // Lab01_Bai05
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 1000);
            Controls.Add(groupBox1);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnTinh);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lab01_Bai05";
            Text = "Lab01_Bai05";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Button btnTinh;
        private Button btnXoa;
        private Button btnThoat;
        private GroupBox groupBox1;
        private TextBox txtKetqua;
    }
}