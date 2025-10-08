using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01.Exercises
{
    public partial class Lab01_Bai07 : Form
    {
        public Lab01_Bai07()
        {
            InitializeComponent();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            txtKetQua.Clear();
            string input = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!");
                return;
            }

            // Tách họ tên và danh sách điểm
            string[] parts = input.Split(',');
            if (parts.Length < 2)
            {
                MessageBox.Show("Sai định dạng! Phải nhập: Họ tên, điểm1, điểm2, ...");
                return;
            }

            string hoTen = parts[0].Trim();
            // Kiểm tra họ tên
            if (!Regex.IsMatch(hoTen, @"^[a-zA-ZÀ-ỹ\s]+$"))
            {
                MessageBox.Show("Họ tên chỉ được chứa chữ cái và khoảng trắng, không chứa số hoặc ký tự đặc biệt!");
                return;
            }
            double[] diem;

            try
            {
                diem = parts.Skip(1).Select(x => double.Parse(x.Trim())).ToArray();
                if (diem.Any(d => d < 0 || d > 10))
                {
                    MessageBox.Show("Điểm phải nằm trong khoảng 0 đến 10!");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Sai định dạng điểm!");
                return;
            }

            // Xuất kết quả
            txtKetQua.AppendText($"Họ và tên: {hoTen}\r\n");
            txtKetQua.AppendText("Danh sách môn học và điểm:\r\n");

            for (int i = 0; i < diem.Length; i++)
            {
                txtKetQua.AppendText($"Môn {i + 1}: {diem[i]} đ\t");
                // Sau mỗi 5 môn thì xuống dòng
                if ((i + 1) % 5 == 0)
                    txtKetQua.AppendText("\r\n");
            }
                txtKetQua.AppendText("\r\n\r\n");

            // Tính toán
            double dtb = diem.Average();
            double max = diem.Max();
            double min = diem.Min();
            int soMonDau = diem.Count(x => x >= 5);
            int soMonRot = diem.Length - soMonDau;

            txtKetQua.AppendText($"Điểm trung bình: {dtb:F2}\r\n");
            txtKetQua.AppendText($"Môn có điểm cao nhất: {max} đ\r\n");
            txtKetQua.AppendText($"Môn có điểm thấp nhất: {min} đ\r\n");
            txtKetQua.AppendText($"Số môn đậu: {soMonDau}\r\n");
            txtKetQua.AppendText($"Số môn không đậu: {soMonRot}\r\n");

            // Xếp loại
            string xepLoai;
            if (dtb >= 8 && diem.All(d => d >= 6.5))
                xepLoai = "Giỏi";
            else if (dtb >= 6.5 && diem.All(d => d >= 5))
                xepLoai = "Khá";
            else if (dtb >= 5 && diem.All(d => d >= 3.5))
                xepLoai = "TB";
            else if (dtb >= 3.5 && diem.All(d => d >= 2))
                xepLoai = "Yếu";
            else
                xepLoai = "Kém";

            txtKetQua.AppendText($"Xếp loại học lực: {xepLoai}");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Dữ liệu trống!");
                return;
            }
            DialogResult result = MessageBox.Show(
                "Bạn có muốn xoá kết quả?",
                "Xác nhận xoá",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                textBox1.Clear();
                txtKetQua.Clear();
                textBox1.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}

