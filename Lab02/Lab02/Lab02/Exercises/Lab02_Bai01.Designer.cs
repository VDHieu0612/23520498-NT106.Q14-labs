namespace Lab02
{
    partial class Lab02_Bai01
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
            this.btnWrite = new System.Windows.Forms.Button();
            this.rtbNoiDung = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(50, 82);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(217, 103);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Đọc File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite.Location = new System.Drawing.Point(50, 237);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(217, 103);
            this.btnWrite.TabIndex = 1;
            this.btnWrite.Text = "Ghi File";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // rtbNoiDung
            // 
            this.rtbNoiDung.Location = new System.Drawing.Point(326, 82);
            this.rtbNoiDung.Name = "rtbNoiDung";
            this.rtbNoiDung.Size = new System.Drawing.Size(660, 463);
            this.rtbNoiDung.TabIndex = 2;
            this.rtbNoiDung.Text = "";
            // 
            // Lab02_Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 655);
            this.Controls.Add(this.rtbNoiDung);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnRead);
            this.Name = "Lab02_Bai01";
            this.Text = "Lab02_Bai01";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.RichTextBox rtbNoiDung;
    }
}