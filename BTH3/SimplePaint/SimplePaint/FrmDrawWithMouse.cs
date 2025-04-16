using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class FrmDrawWithMouse : Form
    {
        Color color;
        int penWidth;
        Point pOld; 
        Bitmap bmpTemp;
        public FrmDrawWithMouse()
        {
            InitializeComponent();
        }
        private void FrmDrawWithMouse_KeyDown(object sender, KeyEventArgs e)
        {

        }


        private void FrmDrawWithMouse_Load(object sender, EventArgs e)
        {
            color = Color.Red;
            penWidth = 1;
            bmpTemp= new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            //Width la x, Height y 
        }
        private void FrmDrawWithMouse_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Pen pen = new Pen(color, penWidth);
                Graphics g = Graphics.FromImage(bmpTemp);
                g.DrawLine(pen, pOld, e.Location);
                pOld = e.Location;
                Invalidate();// goi ham paint
            }

          
        }

        private void FrmDrawWithMouse_MouseDown(object sender, MouseEventArgs e)
        {
            pOld = e.Location;
        }

        private void FrmDrawWithMouse_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmpTemp, 0,0);
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch(keyData)
            {
                    case Keys.R: color = Color.Red; break;
                    case Keys.G: color = Color.Green; break;
                    case Keys.B: color = Color.Blue; break;
                case Keys.Up:
                    if (penWidth < 50) penWidth++;
                    break;
                    case Keys.Down:
                    if(penWidth >1) penWidth--;
                    break;

            }

            return base.ProcessDialogKey(keyData);
        }
    }
}
