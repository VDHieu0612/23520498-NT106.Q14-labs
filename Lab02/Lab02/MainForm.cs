using Lab02.Exercises;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            var f = new Lab02_Bai01();
            f.ShowDialog();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            var f = new Lab02_Bai02();
            f.ShowDialog();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            var f = new Lab02_Bai03();
            f.ShowDialog();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            var f = new Lab02_Bai04();
            f.ShowDialog();
        }

        private void btnBai5_Click(object sender, EventArgs e)
        {
            var f = new Lab02_Bai05();
            f.ShowDialog();
        }

        private void btnBai6_Click(object sender, EventArgs e)
        {
            var f = new Lab02_Bai06();
            f.ShowDialog();
        }

        private void btnBai7_Click(object sender, EventArgs e)
        {
            var f = new Lab02_Bai07();
            f.ShowDialog();
        }
    }
}
