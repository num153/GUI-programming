using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PhotoAlbum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitTree();
        }
        private void InitTree()
        {
            //lay ds o dia
            string[] disk = Directory.GetLogicalDrives();
            TreeNode node = null;
            foreach(string d in disk)
            {
                node = new TreeNode(d);
                treeFolder.Nodes.Add(node);
                node.Nodes.Add("temp");
            }
        }

        private void treeFolder_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode selectedNote = e.Node;
            selectedNote.Nodes.Clear();
            string[] arrDir = Directory.GetDirectories(selectedNote.FullPath);
            TreeNode node = null;
            foreach (string dir in arrDir)
            {
                node = new TreeNode(Path.GetFileName(dir));
                node.Nodes.Add("temp");
                node.ImageIndex = 1;
                selectedNote.Nodes.Add(node);
            }

        }

        private void treeFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                pnThum.Controls.Clear();
                TreeNode selectNode = e.Node;//node dang chon
                string[] arrFile = Directory.GetFiles(selectNode.FullPath);// lay ten
                foreach (string file in arrFile)
                {
                    if (file.ToLower().EndsWith("jpg") ||
                        file.ToLower().EndsWith("png") ||
                        file.ToLower().EndsWith("gif") ||
                        file.ToLower().EndsWith("ico") ||
                        file.ToLower().EndsWith("bmp"))
                    {
                        Image img = Image.FromFile(file);
                        PictureBox pic = new PictureBox();
                        pic.Image = img;
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Height = pnThum.Height - 5;
                        pic.Width = 5 * pic.Height / 4;
                        pic.Click += Pic_Click;
                        pic.Cursor = Cursors.Hand;
                        pnThum.Controls.Add(pic);
                    }
                }
            }
            catch
            {

            }
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            picView.Image = pic.Image;
        }

        private void treeFolder_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level > 0)
            {
                e.Node.ImageIndex = 2;
                e.Node.SelectedImageIndex = 2;
            }
        }

        private void treeFolder_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level > 0)
            {
                e.Node.ImageIndex = 1;
                e.Node.SelectedImageIndex = 1;
            }
        }
    }
}
