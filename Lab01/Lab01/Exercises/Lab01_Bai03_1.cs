using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab01.Exercises
{
    public partial class Lab01_Bai03_1 : Form
    {
        public Lab01_Bai03_1()
        {
            InitializeComponent();
        }

        private string[] donVi = { "", "nghìn", "triệu", "tỷ" };
        private string[] soChu = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };

        private string DocBaSo(int n)
        {
            int tram = n / 100;
            int chuc = (n / 10) % 10;
            int donvi = n % 10;

            string kq = "";

            if (tram > 0)
            {
                kq += soChu[tram] + " trăm";
                if (chuc == 0 && donvi > 0) kq += " linh";
            }

            if (chuc > 0)
            {
                if (chuc == 1) kq += " mười";
                else kq += " " + soChu[chuc] + " mươi";
            }

            if (donvi > 0)
            {
                if (chuc == 0 && tram == 0) kq += soChu[donvi];
                else if (donvi == 1 && chuc > 1) kq += " mốt";
                else if (donvi == 5 && chuc > 0) kq += " lăm";
                else kq += " " + soChu[donvi];
            }

            return kq.Trim();
        }

        private string DocSoLon(string so)
        {
            // Chia thành nhóm 3 số từ phải sang trái
            so = so.PadLeft(12, '0'); // đảm bảo đủ 12 chữ số
            string kq = "";
            int nhom = 0;

            for (int i = so.Length; i > 0; i -= 3)
            {
                int baSo = int.Parse(so.Substring(i - 3, 3));
                if (baSo > 0)
                {
                    kq = DocBaSo(baSo) + " " + donVi[nhom] + " " + kq;
                }
                nhom++;
            }

            return kq.Trim();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            string soNhap = textBox1.Text.Trim();

            if (!long.TryParse(soNhap, out long n))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
                return;
            }

            if (soNhap.Length > 12)
            {
                MessageBox.Show("Chỉ nhập tối đa 12 chữ số!");
                return;
            }

            textBox2.Text = DocSoLon(soNhap);
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
