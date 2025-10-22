using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Lab02_Bai01 : Form
    {
        public Lab02_Bai01()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "D:\\LTM\\LAB02\\Lab02\\Lab02\\Input-Output\\input12.txt";
                // Kiểm tra file có tồn tại không
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Không tìm thấy file input1.txt!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Đọc file
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (StreamReader sr = new StreamReader(fs))
                {
                    string content = sr.ReadToEnd();
                    rtbNoiDung.Text = content;
                }

                MessageBox.Show("Đọc file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "D:\\LTM\\LAB02\\Lab02\\Lab02\\Input-Output\\output12.txt";
                // Kiểm tra file có tồn tại không
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Không tìm thấy file output1.txt!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Lấy nội dung hiện có trong RichTextBox
                string content = rtbNoiDung.Text;
                // Kiểm tra nội dung ghi có trống không
                if (string.IsNullOrWhiteSpace(content))
                {
                    MessageBox.Show("Không có nội dung để ghi!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Chuyển đổi kí tự sang in hoa
                string upperContent = content.ToUpper();
                // Ghi file
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(upperContent);
                }    

                MessageBox.Show("Ghi file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
