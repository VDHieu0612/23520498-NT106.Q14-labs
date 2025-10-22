using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Lab02_Bai02 : Form
    {
        public Lab02_Bai02()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Chọn file cần đọc";
                ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Mở file bằng FileStream
                    using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        // Đọc toàn bộ nội dung file
                        string content = sr.ReadToEnd();
                        rtbNoiDung.Text = content;

                        // --- Thông tin file ---
                        string Name = ofd.SafeFileName;
                        string URL = fs.Name;
                        long Size = fs.Length;

                        // --- Tính số dòng, số từ, số ký tự ---
                        string[] line = content.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                        int LineCount = line.Length;
                        int WordCount = content.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
                        int CharacterCount = content.Length;

                        // --- Hiển thị kết quả ---
                        textBox1.Text = Name;
                        textBox2.Text = Size.ToString() + " bytes";
                        textBox3.Text = URL;
                        textBox4.Text = LineCount.ToString();
                        textBox5.Text = WordCount.ToString();
                        textBox6.Text = CharacterCount.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Bạn có chắc chắn muốn thoát chương trình không?",
               "Xác nhận thoát",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning
           );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
