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
    public partial class Lab01_Bai06 : Form
    {
        public Lab01_Bai06()
        {
            InitializeComponent();
        }

        private bool KiemTraNgayThang(int ngay, int thang, int nam)
        {
            // Kiểm tra năm hợp lệ
            if (nam < 1) return false;
            // Kiểm tra tháng hợp lệ
            if (thang < 1 || thang > 12) return false;

            // Kiểm tra năm nhuận
            bool lanamnhuan = (nam % 400 == 0) || (nam % 4 == 0 && nam % 100 != 0);

            // Số ngày tối đa của từng tháng
            int[] soNgayTrongThang = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // Nếu là năm nhuận thì tháng 2 có 29 ngày
            soNgayTrongThang[1] = 29;

            // Kiểm tra ngày hợp lệ theo tháng
            return (ngay >= 1 && ngay <= soNgayTrongThang[thang - 1]);
        }

        private string TimCungHoangDao(int ngay, int thang)
        {
            switch (thang)
            {
                case 1: return (ngay <= 19) ? "Ma Kết" : "Bảo Bình";
                case 2: return (ngay <= 18) ? "Bảo Bình" : "Song Ngư";
                case 3: return (ngay <= 20) ? "Song Ngư" : "Bạch Dương";
                case 4: return (ngay <= 20) ? "Bạch Dương" : "Kim Ngưu";
                case 5: return (ngay <= 21) ? "Kim Ngưu" : "Song Tử";
                case 6: return (ngay <= 21) ? "Song Tử" : "Cự Giải";
                case 7: return (ngay <= 22) ? "Cự Giải" : "Sư Tử";
                case 8: return (ngay <= 22) ? "Sư Tử" : "Xử Nữ";
                case 9: return (ngay <= 23) ? "Xử Nữ" : "Thiên Bình";
                case 10: return (ngay <= 23) ? "Thiên Bình" : "Thần Nông";
                case 11: return (ngay <= 22) ? "Thần Nông" : "Nhân Mã";
                case 12: return (ngay <= 21) ? "Nhân Mã" : "Ma Kết";
                default: return "Không xác định";
            }
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            int ngay, thang, nam;

            // kiểm tra input
            if (!int.TryParse(textBox1.Text, out ngay))
            {
                MessageBox.Show("Vui lòng nhập ngày hợp lệ!");
                textBox1.Focus();
                return;
            }

            if (!int.TryParse(textBox2.Text, out thang))
            {
                MessageBox.Show("Vui lòng nhập tháng hợp lệ!");
                textBox2.Focus();
                return;
            }

            if (!int.TryParse(textBox3.Text, out nam))
            {
                MessageBox.Show("Vui lòng nhập năm hợp lệ!");
                textBox2.Focus();
                return;
            }

            // kiểm tra ngày tháng năm
            if (!KiemTraNgayThang(ngay, thang, nam))
            {
                MessageBox.Show("Ngày tháng năm không hợp lệ!");
                return;
            }

            // Nếu hợp lệ thì tiếp tục xác định cung hoàng đạo
            string cung = TimCungHoangDao(ngay, thang);
            textBox4.Text = cung;
        }
    }
}
