using Lab01.Exercises;

namespace Lab01
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new Lab01_Bai01();
            f.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var f = new Lab01_Bai02();
            f.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var f = new Lab01_Bai03();
            f.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            var f = new Lab01_Bai03_1();
            f.ShowDialog();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            var f = new Lab01_Bai04();
            f.ShowDialog();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            var f = new Lab01_Bai05();
            f.ShowDialog();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            var f = new Lab01_Bai06();
            f.ShowDialog();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            var f = new Lab01_Bai07();
            f.ShowDialog();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            var f = new Lab01_Bai08();
            f.ShowDialog();
        }

    }
}
