using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawShape
{
    public enum ShapeType
    {
        Rectangle,
        Triangle,
        Ellipse,
        Line
    }
    public partial class Form1 : Form
    {
        ArrayList arrShape = new ArrayList();
        ShapeType nShape;
        Color colorShape;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true; //Giam hien tuong nhap nhay
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colorShape = Color.Red;
            nShape = ShapeType.Line;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Shape s = new Shape();
            s.p1 = s.p2 = e.Location; //gan 2 poin = toa do ng dung an chuot
            s.colorShape = colorShape;
            s.nShape = nShape;
            arrShape.Add(s);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Shape s = (Shape)arrShape[arrShape.Count - 1];//lay shape cuoi trong ds
                s.p2 = e.Location;
                Invalidate(); // Paint
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Bitmap drawing = new Bitmap(this.Width, this.Height, e.Graphics);
            Graphics g = Graphics.FromImage(drawing);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            foreach (Shape s in arrShape)
            {
                s.Draw(g);
            }
            e.Graphics.DrawImage(drawing,0,0);
            g.Dispose(); //giai phong Graphic g
        }

        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOption f = new FormOption();
            f.cl = colorShape;
            f.st = nShape;
            if (f.ShowDialog() == DialogResult.OK)
            {
                //Cap nhat 2 gia tri cua Form1
                colorShape = f.cl;
                nShape = f.st;
            }
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arrShape.Clear();
            Invalidate();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
