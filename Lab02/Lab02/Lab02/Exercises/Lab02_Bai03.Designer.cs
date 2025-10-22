namespace Lab02
{
    partial class Lab02_Bai03
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
            this.btnRead = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.rtbNoiDung = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(40, 29);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(190, 91);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Đọc file";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(40, 141);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(190, 91);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Tính toán";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // rtbNoiDung
            // 
            this.rtbNoiDung.Location = new System.Drawing.Point(269, 29);
            this.rtbNoiDung.Name = "rtbNoiDung";
            this.rtbNoiDung.Size = new System.Drawing.Size(607, 627);
            this.rtbNoiDung.TabIndex = 2;
            this.rtbNoiDung.Text = "";
            // 
            // Lab02_Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 683);
            this.Controls.Add(this.rtbNoiDung);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnRead);
            this.Name = "Lab02_Bai03";
            this.Text = "Lab02_Bai03";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.RichTextBox rtbNoiDung;
    }
}