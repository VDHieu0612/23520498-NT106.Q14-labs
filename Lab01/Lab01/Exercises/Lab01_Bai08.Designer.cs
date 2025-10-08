namespace Lab01.Exercises
{
    partial class Lab01_Bai08
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
            label3 = new Label();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            btnTim = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            textBox2 = new TextBox();
            btnThem = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(503, 32);
            label1.Name = "label1";
            label1.Size = new Size(288, 50);
            label1.TabIndex = 0;
            label1.Text = "Hôm nay ăn gì ?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 133);
            label2.Name = "label2";
            label2.Size = new Size(214, 45);
            label2.TabIndex = 1;
            label2.Text = "Nhập món ăn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(503, 613);
            label3.Name = "label3";
            label3.Size = new Size(301, 45);
            label3.TabIndex = 2;
            label3.Text = "Món ăn hôm nay là:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(277, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(360, 39);
            textBox1.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(700, 133);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(485, 356);
            listBox1.TabIndex = 5;
            // 
            // btnTim
            // 
            btnTim.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTim.Location = new Point(170, 529);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(230, 57);
            btnTim.TabIndex = 6;
            btnTim.Text = "Tìm món ăn";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(534, 529);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(230, 57);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(921, 529);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(230, 57);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(478, 684);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(360, 39);
            textBox2.TabIndex = 9;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(478, 209);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(159, 52);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // Lab01_Bai08
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 802);
            Controls.Add(btnThem);
            Controls.Add(textBox2);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnTim);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lab01_Bai08";
            Text = "Lab01_Bai08";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private ListBox listBox1;
        private Button btnTim;
        private Button btnXoa;
        private Button btnThoat;
        private TextBox textBox2;
        private Button btnThem;
    }
}