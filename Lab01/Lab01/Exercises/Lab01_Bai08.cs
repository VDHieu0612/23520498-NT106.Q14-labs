using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab01.Exercises
{
    public partial class Lab01_Bai08 : Form
    {
        public Lab01_Bai08()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MonAn = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(MonAn))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn!");
                return;
            }

            // Kiểm tra món ăn không được chứa ký tự đặc biệt   
            if (!Regex.IsMatch(MonAn, @"^[a-zA-Z0-9À-ỹ\s]+$"))
            {
                MessageBox.Show("Tên món ăn chỉ được chứa chữ, số và khoảng trắng (không có ký tự đặc biệt)!");
                return;
            }

            // Kiểm tra món ăn đã tồn tại trong danh sách chưa
            if (listBox1.Items.Cast<string>().Any(x => x.Equals(MonAn, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Món ăn đã tồn tại trong danh sách!");
            }
            else
            {
                // Thêm món ăn vào listbox
                listBox1.Items.Add(MonAn);
            }

            // Xoá nội dung ô nhập sau khi thêm
            textBox1.Clear();
            textBox1.Focus();
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Danh sách món ăn trống, vui lòng thêm món trước!");
                return;
            }

            // Random 1 món trong listBox
            Random rnd = new Random();
            int index = rnd.Next(0, listBox1.Items.Count); // chọn ngẫu nhiên từ 0 -> Count-1
            string monAn = listBox1.Items[index].ToString();

            // Hiển thị ra textbox kết quả
            textBox2.Text = monAn;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                // Hỏi xác nhận trước khi xoá
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xoá món ăn này không?",
                    "Xác nhận xoá",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn món ăn cần xoá trong danh sách!");
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
