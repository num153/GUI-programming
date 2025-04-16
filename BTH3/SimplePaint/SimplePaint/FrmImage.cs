using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class FrmImage : Form
    {
        public FrmImage()
        {
            InitializeComponent();
        }

        private void FrmImage_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rc1= new Rectangle(0,0,ClientRectangle.Width/2,ClientRectangle.Height/2);
            Rectangle rc2 = new Rectangle(0, ClientRectangle.Height / 2, ClientRectangle.Width / 2, ClientRectangle.Height / 2);
            Rectangle rc3 = new Rectangle( ClientRectangle.Width / 2,0, ClientRectangle.Width / 2, ClientRectangle.Height);
            DrawImage(e.Graphics, rc1);
            DrawText(e.Graphics, rc2);
            DrawPolygon(e.Graphics, rc3);


            Pen pen = new Pen(Color.Blue, 3);
            e.Graphics.DrawRectangles(pen, new Rectangle[] { rc1, rc2, rc3 });

        }
        void DrawImage(Graphics g, Rectangle rc)
        {
            Image img = Image.FromFile("meo.jpg");
            g.DrawImage(img, rc);
            Color color = Color.FromArgb(100, 255, 255, 0);
            Font font = new Font("Arial",30, FontStyle.Bold);
            StringFormat  fm = new StringFormat();
            fm.LineAlignment = StringAlignment.Far;
            g.DrawString("MEO", font, new SolidBrush(color), rc,fm);
        }
        void DrawText(Graphics g, Rectangle rc)
        {
            LinearGradientBrush br1= new LinearGradientBrush(rc, Color.Black, Color.White,LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(br1, rc);
            LinearGradientBrush br2 = new LinearGradientBrush(rc, Color.Red, Color.Yellow, 45);

            Font font = new Font("Arial", 30, FontStyle.Bold | FontStyle.Italic);
            StringFormat fm = new StringFormat();
            fm.LineAlignment = StringAlignment.Center;
            fm.Alignment = StringAlignment.Center;
            g.DrawString("MIMII", font, br2, rc, fm);


        }
        void DrawPolygon(Graphics g, Rectangle rc)
        {
            Point[] arrP =
            {
                new Point(rc.Left, rc.Height/4),
                new Point(rc.Left+ rc.Width/2, rc.Top),
                new Point (rc.Left+rc.Width,rc.Height/4 ),
                new Point(rc.Left+rc.Width/2, rc.Height)


            }; 
            GraphicsPath path = new GraphicsPath();
            path.AddPolygon(arrP);
            PathGradientBrush br = new PathGradientBrush(path);
            br.CenterColor = Color.White;
            br.SurroundColors= new Color[] { Color.Yellow, Color.Green, Color.Cyan, Color.Red };
            g.FillPolygon(br, arrP);
          //  g.FillPath(br, path);


        }

        private void FrmImage_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
