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

namespace KeoThaObject
    //SU DUNG FLowLayoutPanel
{
    public partial class Form1 : Form
    {
        string[] arrFile;
        Random rand = new Random();
        int imgSize = 90;
        int count = 0;
        Point p;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Dùng phím và chuột để di chuyển ảnh";
            arrFile = Directory.GetFiles(Application.StartupPath + @"\Images");
            addNewPicture();
        }
        private void addNewPicture()
        {
            PictureBox pic = new PictureBox();
            string file = arrFile[rand.Next(arrFile.Length)];
            Image img = Image.FromFile(file);
            pic.Image = img;
            pic.Location = new Point(0, 0);
            pic.Width = pic.Height = imgSize;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pic);
            //Su kien chuot
            pic.MouseDown += Pic_MD;
            pic.MouseUp += Pic_MU;
            pic.MouseMove += Pic_MM;
            //Sap xep anh vao 
            this.Controls.SetChildIndex(pnBound, this.Controls.Count - 1);
            //Dat ten cho pic moi khi tao anh
            count++;
            pic.Name = count.ToString();


        }

        private void Pic_MM(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                PictureBox pic = (PictureBox)sender;
                int dx = e.X - p.X;
                int dy = e.Y - p.Y;
                pic.Left += dx;
                pic.Top += dy;
            }
        }

        private void Pic_MU(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (pnBound.Bounds.Contains(pic.Bounds))
            {
                pnBound.Controls.Add(pic);
                addNewPicture();
            }
        }

        private void Pic_MD(object sender, MouseEventArgs e)
        {
            p = e.Location;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Control[] arrCtrl = this.Controls.Find(count.ToString(),false);
            PictureBox pic = (PictureBox)arrCtrl[0];
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (pic.Left > 0) pic.Left -= 5;
                    break;
                case Keys.Right :
                    if (pic.Right < ClientRectangle.Width) pic.Left+=5;
                    break;
                case Keys.Down:
                    if (pic.Bottom < ClientRectangle.Height) pic.Top += 20;
                    break;
                case Keys.Up:
                    if (pic.Top > 0) pic.Top -= 20;
                    break;
            }
            if (pnBound.Bounds.Contains(pic.Bounds))
            {
                pnBound.Controls.Add(pic);
                addNewPicture();
            }
        }

        private void pnBound_MouseDown(object sender, MouseEventArgs e)
        {
            p = e.Location;
        }

        private void pnBound_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - p.X;
                int dy = e.Y - p.Y;
                pnBound.Left += dx;
                pnBound.Top += dy;
            }
        }
    }
}
