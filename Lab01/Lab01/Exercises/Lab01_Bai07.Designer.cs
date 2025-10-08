namespace Lab01.Exercises
{
    partial class Lab01_Bai07
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
            btnXuat = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            groupBox1 = new GroupBox();
            txtKetQua = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(743, 47);
            label1.Name = "label1";
            label1.Size = new Size(240, 50);
            label1.TabIndex = 0;
            label1.Text = "Quản lý điểm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 145);
            label2.Name = "label2";
            label2.Size = new Size(432, 45);
            label2.TabIndex = 1;
            label2.Text = "Nhập tên và danh sách điểm:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(451, 151);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1179, 39);
            textBox1.TabIndex = 2;
            // 
            // btnXuat
            // 
            btnXuat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXuat.Location = new Point(1100, 219);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(150, 60);
            btnXuat.TabIndex = 3;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(1285, 219);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 60);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(1480, 219);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 60);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseCompatibleTextRendering = true;
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtKetQua);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(63, 311);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1626, 757);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kết quả";
            // 
            // txtKetQua
            // 
            txtKetQua.Dock = DockStyle.Fill;
            txtKetQua.Font = new Font("Consolas", 12F);
            txtKetQua.Location = new Point(3, 46);
            txtKetQua.Multiline = true;
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.ScrollBars = ScrollBars.Vertical;
            txtKetQua.Size = new Size(1620, 708);
            txtKetQua.TabIndex = 0;
            // 
            // Lab01_Bai07
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1742, 1096);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnXuat);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Lab01_Bai07";
            Text = "Lab01_Bai07";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button btnXuat;
        private Button btnXoa;
        private Button btnThoat;
        private GroupBox groupBox1;
        private TextBox txtKetqua;
        private TextBox txtKetQua;
    }
}