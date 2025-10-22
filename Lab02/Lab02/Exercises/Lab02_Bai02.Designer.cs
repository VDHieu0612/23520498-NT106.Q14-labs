namespace Lab02
{
    partial class Lab02_Bai02
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
            this.rtbNoiDung = new System.Windows.Forms.RichTextBox();
            this.lbFilename = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbSize = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbURL = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbLinecount = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lbWordcount = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblCharacterCount = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(44, 50);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(521, 57);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read from File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // rtbNoiDung
            // 
            this.rtbNoiDung.Location = new System.Drawing.Point(622, 50);
            this.rtbNoiDung.Name = "rtbNoiDung";
            this.rtbNoiDung.Size = new System.Drawing.Size(718, 701);
            this.rtbNoiDung.TabIndex = 1;
            this.rtbNoiDung.Text = "";
            // 
            // lbFilename
            // 
            this.lbFilename.AutoSize = true;
            this.lbFilename.Location = new System.Drawing.Point(39, 169);
            this.lbFilename.Name = "lbFilename";
            this.lbFilename.Size = new System.Drawing.Size(106, 25);
            this.lbFilename.TabIndex = 2;
            this.lbFilename.Text = "File name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(221, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(344, 31);
            this.textBox1.TabIndex = 3;
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(39, 258);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(54, 25);
            this.lbSize.TabIndex = 4;
            this.lbSize.Text = "Size";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(221, 258);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(344, 31);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(221, 347);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(344, 31);
            this.textBox3.TabIndex = 7;
            // 
            // lbURL
            // 
            this.lbURL.AutoSize = true;
            this.lbURL.Location = new System.Drawing.Point(39, 347);
            this.lbURL.Name = "lbURL";
            this.lbURL.Size = new System.Drawing.Size(54, 25);
            this.lbURL.TabIndex = 6;
            this.lbURL.Text = "URL";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(221, 429);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(344, 31);
            this.textBox4.TabIndex = 9;
            // 
            // lbLinecount
            // 
            this.lbLinecount.AutoSize = true;
            this.lbLinecount.Location = new System.Drawing.Point(39, 429);
            this.lbLinecount.Name = "lbLinecount";
            this.lbLinecount.Size = new System.Drawing.Size(112, 25);
            this.lbLinecount.TabIndex = 8;
            this.lbLinecount.Text = "Line count";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(221, 517);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(344, 31);
            this.textBox5.TabIndex = 11;
            // 
            // lbWordcount
            // 
            this.lbWordcount.AutoSize = true;
            this.lbWordcount.Location = new System.Drawing.Point(39, 517);
            this.lbWordcount.Name = "lbWordcount";
            this.lbWordcount.Size = new System.Drawing.Size(133, 25);
            this.lbWordcount.TabIndex = 10;
            this.lbWordcount.Text = "Words count";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(221, 615);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(344, 31);
            this.textBox6.TabIndex = 13;
            // 
            // lblCharacterCount
            // 
            this.lblCharacterCount.AutoSize = true;
            this.lblCharacterCount.Location = new System.Drawing.Point(39, 615);
            this.lblCharacterCount.Name = "lblCharacterCount";
            this.lblCharacterCount.Size = new System.Drawing.Size(165, 25);
            this.lblCharacterCount.TabIndex = 12;
            this.lblCharacterCount.Text = "Character count";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(44, 694);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(521, 57);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Lab02_Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 828);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.lblCharacterCount);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.lbWordcount);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lbLinecount);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lbURL);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbFilename);
            this.Controls.Add(this.rtbNoiDung);
            this.Controls.Add(this.btnRead);
            this.Name = "Lab02_Bai02";
            this.Text = "Lab02_Bai02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.RichTextBox rtbNoiDung;
        private System.Windows.Forms.Label lbFilename;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbURL;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbLinecount;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lbWordcount;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lblCharacterCount;
        private System.Windows.Forms.Button btnExit;
    }
}