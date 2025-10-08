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
    public partial class Lab01_Bai03 : Form
    {
        public Lab01_Bai03()
        {
            InitializeComponent();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            int so1;

            // kiểm tra có phải số nguyên ?
            if (!int.TryParse(textBox1.Text, out so1))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                textBox1.Focus();
                return;
            }

            //kiểm tra có từ 0 đến 9 ?
            if (so1 < 0 || so1 > 9)
            {
                MessageBox.Show("Vui lòng nhập số nguyên từ 0 đến 9!");
                textBox1.Focus(); 
                return;
            }

            string CachDoc = "";
            switch (so1)
            {
                case 0: CachDoc = "Không"; break;
                case 1: CachDoc = "Một"; break;
                case 2: CachDoc = "Hai"; break;
                case 3: CachDoc = "Ba"; break;
                case 4: CachDoc = "Bốn"; break;
                case 5: CachDoc = "Năm"; break;
                case 6: CachDoc = "Sáu"; break;
                case 7: CachDoc = "Bảy"; break;
                case 8: CachDoc = "Tám"; break;
                case 9: CachDoc = "Chín"; break;
            }

            // hiển thị vào textbox2
            textBox2.Text = CachDoc;
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
