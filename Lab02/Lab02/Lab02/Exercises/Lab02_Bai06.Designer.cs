namespace Lab02
{
    partial class Lab02_Bai06
    {
        private System.ComponentModel.IContainer components = null;

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
            this.lblTenMon = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.lblNguoiDung = new System.Windows.Forms.Label();
            this.cbNguoiDung = new System.Windows.Forms.ComboBox();
            this.lblHinhAnh = new System.Windows.Forms.Label();
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.lvMonAn = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNguoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Location = new System.Drawing.Point(34, 35);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(132, 25);
            this.lblTenMon.TabIndex = 0;
            this.lblTenMon.Text = "Tên món ăn:";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(194, 32);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(300, 31);
            this.txtTenMon.TabIndex = 1;
            // 
            // lblNguoiDung
            // 
            this.lblNguoiDung.AutoSize = true;
            this.lblNguoiDung.Location = new System.Drawing.Point(34, 85);
            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.Size = new System.Drawing.Size(170, 25);
            this.lblNguoiDung.TabIndex = 2;
            this.lblNguoiDung.Text = "Người đóng góp:";
            // 
            // cbNguoiDung
            // 
            this.cbNguoiDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNguoiDung.FormattingEnabled = true;
            this.cbNguoiDung.Location = new System.Drawing.Point(210, 85);
            this.cbNguoiDung.Name = "cbNguoiDung";
            this.cbNguoiDung.Size = new System.Drawing.Size(276, 33);
            this.cbNguoiDung.TabIndex = 3;
            // 
            // lblHinhAnh
            // 
            this.lblHinhAnh.AutoSize = true;
            this.lblHinhAnh.Location = new System.Drawing.Point(34, 140);
            this.lblHinhAnh.Name = "lblHinhAnh";
            this.lblHinhAnh.Size = new System.Drawing.Size(104, 25);
            this.lblHinhAnh.TabIndex = 4;
            this.lblHinhAnh.Text = "Hình ảnh:";
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picHinhAnh.Location = new System.Drawing.Point(163, 140);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(180, 150);
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHinhAnh.TabIndex = 5;
            this.picHinhAnh.TabStop = false;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(350, 140);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(114, 43);
            this.btnChonAnh.TabIndex = 6;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(54, 320);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 50);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm món";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(366, 320);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(150, 50);
            this.btnRandom.TabIndex = 9;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // lvMonAn
            // 
            this.lvMonAn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colTenMon,
            this.colNguoi});
            this.lvMonAn.FullRowSelect = true;
            this.lvMonAn.GridLines = true;
            this.lvMonAn.HideSelection = false;
            this.lvMonAn.Location = new System.Drawing.Point(550, 32);
            this.lvMonAn.Name = "lvMonAn";
            this.lvMonAn.Size = new System.Drawing.Size(583, 413);
            this.lvMonAn.TabIndex = 10;
            this.lvMonAn.UseCompatibleStateImageBehavior = false;
            this.lvMonAn.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colID.Width = 50;
            // 
            // colTenMon
            // 
            this.colTenMon.Text = "Tên món ăn";
            this.colTenMon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTenMon.Width = 100;
            // 
            // colNguoi
            // 
            this.colNguoi.Text = "Người đóng góp";
            this.colNguoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNguoi.Width = 150;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(101, 400);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(304, 45);
            this.lblKetQua.TabIndex = 11;
            this.lblKetQua.Text = "Món ăn ngẫu nhiên:";
            // 
            // txtKetqua
            // 
            this.txtKetqua.Location = new System.Drawing.Point(109, 459);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.ReadOnly = true;
            this.txtKetqua.Size = new System.Drawing.Size(279, 31);
            this.txtKetqua.TabIndex = 12;
            this.txtKetqua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(210, 320);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 50);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Xoá món";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Lab02_Bai06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 556);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lvMonAn);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.picHinhAnh);
            this.Controls.Add(this.lblHinhAnh);
            this.Controls.Add(this.cbNguoiDung);
            this.Controls.Add(this.lblNguoiDung);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.lblTenMon);
            this.Name = "Lab02_Bai06";
            this.Text = "Lab02_Bai06";
            this.Load += new System.EventHandler(this.Lab02_Bai06_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label lblNguoiDung;
        private System.Windows.Forms.ComboBox cbNguoiDung;
        private System.Windows.Forms.Label lblHinhAnh;
        private System.Windows.Forms.PictureBox picHinhAnh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.ListView lvMonAn;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colTenMon;
        private System.Windows.Forms.ColumnHeader colNguoi;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.Button btnDelete;
    }
}
