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
    public partial class Lab01_Bai01 : Form
    {
        public Lab01_Bai01()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int so1, so2;

            // kiểm tra số thứ 1
            if (!int.TryParse(textBox1.Text, out so1))
            {
                MessageBox.Show("Vui lòng nhập số nguyên cho Số thứ nhất!");
                textBox1.Focus();
                return;
            }

            // kiểm tra số thứ 2
            if (!int.TryParse(textBox2.Text, out so2))
            {
                MessageBox.Show("Vui lòng nhập số nguyên cho Số thứ hai!");
                textBox2.Focus();
                return;
            }

            // tính tổng và hiển thị
            long tong = so1 + so2;
            textBox3.Text = tong.ToString();
    }
    }
}
