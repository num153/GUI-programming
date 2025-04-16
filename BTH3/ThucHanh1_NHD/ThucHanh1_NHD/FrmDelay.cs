using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanh1_NHD
{
    public partial class FrmDelay : Form
    {
        Random rand = new Random();
        Bitmap bitmap;
        public FrmDelay()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pic1.Left++;
            pic2.Left--;
            if (pic1.Right > pic2.Left)
            {
                timer1.Enabled = false;
                this.Close();
            }
        }

        

        private void FrmDelay_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
            Draw();
        }
        private void Draw()
        {
            Graphics g = Graphics.FromImage(bitmap);
            for (int i=0; i <= 500; i++)
            {
                int x = rand.Next(0, ClientRectangle.Width);
                int y = rand.Next(0, ClientRectangle.Height);
                int w = rand.Next(1, 5);
                g.FillEllipse(Brushes.Red, x, y, w, w);
            }

            Font font = new Font("Arial", 36);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            g.DrawString("2351050022-NguyenHungDung", font, Brushes.Blue, ClientRectangle, format);

            Pen pen = new Pen(Color.Red, 4);
            g.DrawRectangle(pen, ClientRectangle);
        }
        private void FrmDelay_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
