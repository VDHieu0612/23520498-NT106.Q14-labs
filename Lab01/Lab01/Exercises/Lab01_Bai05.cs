using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01.Exercises
{
    public partial class Lab01_Bai05 : Form
    {
        public Lab01_Bai05()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int A, B;

            // Kiểm tra số nguyên A hợp lệ
            if (!int.TryParse(textBox1.Text, out A))
            {
                MessageBox.Show("Vui lòng nhập số nguyên A hợp lệ!");
                return;
            }

            // Kiểm tra số nguyên A hợp lệ
            if (!int.TryParse(textBox2.Text, out B))
            {
                MessageBox.Show("Vui lòng nhập số nguyên B hợp lệ!");
                return;
            }


            // Lấy TextBox trong groupBox1
            TextBox txtKetQua = groupBox1.Controls[0] as TextBox;
            txtKetQua.Clear();

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn chức năng!");
                return;
            }

            if (comboBox1.SelectedIndex == 0) // Bảng cửu chương (B - A)
            {
                int hieu = B - A;
                if (hieu < 1 || hieu > 9)
                {
                    MessageBox.Show("Hiệu của B và A chỉ được nằm trong [1;9]");
                    return;
                }    
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Bảng cửu chương của {hieu}:");
                sb.AppendLine();

                for (int i = 1; i <= 10; i++)
                {
                    sb.AppendLine($"{hieu} x {i} = {hieu * i}");
                }

                txtKetQua.Text = sb.ToString();
            }
            else if (comboBox1.SelectedIndex == 1) // Tính toán giá trị
            {
                StringBuilder sb = new StringBuilder();

                int hieu = A - B;
                if (hieu < 0)
                {
                    sb.AppendLine("(A - B)! không xác định vì A < B!");
                }
                else
                {
                    sb.AppendLine($"(A - B)! = {GiaiThua(hieu)}");
                }
                if (B < 1)
                {
                    sb.AppendLine("B phải lớn hơn hoặc bằng 1!");
                }
                else
                {
                    sb.AppendLine($"Tổng S = {TinhTong(A, B)}");
                }
                txtKetQua.Text = sb.ToString();
            }
        }

        // Hàm tính giai thừa
        private long GiaiThua(int n)
        {
            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        // Hàm tính tổng S = A^1 + A^2 + ... + A^B
        private long TinhTong(int A, int B)
        {
            long sum = 0;
            for (int i = 1; i <= B; i++)
            {
                sum += (long)Math.Pow(A, i);
            }
            return sum;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xoá dữ liệu không?",
                "Xác nhận xoá",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Xoá nội dung các textbox nhập
                textBox1.Clear();
                textBox2.Clear();

                // Xoá nội dung kết quả trong groupBox
                foreach (Control control in groupBox1.Controls)
                {
                    if (control is TextBox txtKetQua)
                    {
                        txtKetQua.Clear();
                    }
                }

                // Đưa con trỏ về ô nhập đầu tiên
                textBox1.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
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
