using Lab01.Exercises;

namespace Lab01
{
    partial class FrmMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(100, 101);
            button1.Name = "button1";
            button1.Size = new Size(250, 75);
            button1.TabIndex = 3;
            button1.Text = "Bài 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(100, 220);
            button2.Name = "button2";
            button2.Size = new Size(250, 75);
            button2.TabIndex = 1;
            button2.Text = "Bài 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(100, 347);
            button3.Name = "button3";
            button3.Size = new Size(250, 75);
            button3.TabIndex = 3;
            button3.Text = "Bài 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(475, 101);
            button4.Name = "button4";
            button4.Size = new Size(250, 75);
            button4.TabIndex = 3;
            button4.Text = "Bài 3.1";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(475, 220);
            button5.Name = "button5";
            button5.Size = new Size(250, 75);
            button5.TabIndex = 3;
            button5.Text = "Bài 4";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(475, 347);
            button6.Name = "button6";
            button6.Size = new Size(250, 75);
            button6.TabIndex = 3;
            button6.Text = "Bài 5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(850, 101);
            button7.Name = "button7";
            button7.Size = new Size(250, 75);
            button7.TabIndex = 3;
            button7.Text = "Bài 6";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(850, 220);
            button8.Name = "button8";
            button8.Size = new Size(250, 75);
            button8.TabIndex = 3;
            button8.Text = "Bài 7";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(850, 347);
            button9.Name = "button9";
            button9.Size = new Size(250, 75);
            button9.TabIndex = 3;
            button9.Text = "Bài 8";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // FrmMainMenu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 540);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FrmMainMenu";
            Text = "Lab 1";
            Load += FrmMainMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}
