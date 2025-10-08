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
    public partial class Lab01_Bai02 : Form
    {
        public Lab01_Bai02()
        {
            InitializeComponent();
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            double so1, so2, so3;

            // kiểm tra số thứ 1
            if (!double.TryParse(textBox1.Text, out so1))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho Số thứ nhất!");
                textBox1.Focus();
                return;
            }

            // kiểm tra số thứ 2
            if (!double.TryParse(textBox2.Text, out so2))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho Số thứ hai!");
                textBox2.Focus();
                return;
            }

            // kiểm tra số thứ 3
            if (!double.TryParse(textBox3.Text, out so3))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho Số thứ ba!");
                textBox3.Focus();
                return;
            }

            // Tìm số lớn nhất và số bé nhất
            double max = Math.Max(so1, Math.Max(so2, so3));
            double min = Math.Min(so1, Math.Min(so2, so3));

            // Hiển thị kết quả
            textBox4.Text = max.ToString();
            textBox5.Text = min.ToString();
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
                // Xoá nội dung các textbox
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();

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
