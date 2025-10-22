using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Lab02
{
    public partial class Lab02_Bai07 : Form
    {
        public Lab02_Bai07()
        {
            InitializeComponent();
            LoadDrives();
        }

        private void LoadDrives()
        {
            foreach (var drive in DriveInfo.GetDrives())
            {
                TreeNode node = new TreeNode(drive.Name);
                node.Tag = drive.Name;
                node.Nodes.Add("...");
                treeView1.Nodes.Add(node);
            }

            treeView1.BeforeExpand += TreeView1_BeforeExpand;
            treeView1.AfterSelect += TreeView1_AfterSelect;
        }

        private void TreeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            node.Nodes.Clear();
            string path = node.Tag.ToString();

            try
            {
                foreach (string dir in Directory.GetDirectories(path))
                {
                    TreeNode sub = new TreeNode(Path.GetFileName(dir));
                    sub.Tag = dir;
                    sub.Nodes.Add("...");
                    node.Nodes.Add(sub);
                }

                foreach (string file in Directory.GetFiles(path))
                {
                    TreeNode sub = new TreeNode(Path.GetFileName(file));
                    sub.Tag = file;
                    node.Nodes.Add(sub);
                }
            }
            catch { }
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = e.Node.Tag.ToString();

            groupBox1.Controls.Clear();

            if (File.Exists(path))
            {
                string ext = Path.GetExtension(path).ToLower();

                if (ext == ".jpg" || ext == ".png" || ext == ".bmp")
                {
                    PictureBox pic = new PictureBox();
                    pic.Dock = DockStyle.Fill;
                    pic.Image = Image.FromFile(path);
                    pic.SizeMode = PictureBoxSizeMode.Zoom;
                    groupBox1.Controls.Add(pic);
                }
                else if (ext == ".txt" || ext == ".cs" || ext == ".log")
                {
                    RichTextBox rtb = new RichTextBox();
                    rtb.Dock = DockStyle.Fill;
                    rtb.Text = File.ReadAllText(path);
                    groupBox1.Controls.Add(rtb);
                }
                else
                {
                    Label lbl = new Label();
                    lbl.Text = "Không thể hiển thị loại file này.";
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Dock = DockStyle.Fill;
                    groupBox1.Controls.Add(lbl);
                }
            }
        }
    }
}
