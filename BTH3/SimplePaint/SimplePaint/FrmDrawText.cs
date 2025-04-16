using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SimplePaint
{
    public partial class FrmDrawText : Form
    {
        public FrmDrawText()
        {
            InitializeComponent();
        }

        private void FrmDrawText_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font ("Arial", 40, FontStyle.Bold);
            StringFormat fm = new StringFormat ();
            fm.Alignment = StringAlignment.Far;
            e.Graphics.DrawString("CONMEO",font,Brushes.Green, ClientRectangle,fm);
            //
            Image img = Image.FromFile("R.png");
            TextureBrush tbr= new TextureBrush(img);
            fm.Alignment = StringAlignment.Near;
            fm.LineAlignment = StringAlignment.Far;
            e.Graphics.DrawString("CONMEO", font, tbr, ClientRectangle, fm);
            /// 
            HatchBrush hbr = new HatchBrush(HatchStyle.DarkVertical, Color.Beige, Color.Yellow);
            fm.FormatFlags = StringFormatFlags.DirectionVertical;
            fm.LineAlignment = StringAlignment.Near;

            e.Graphics.DrawString("CONMEO", font, hbr, ClientRectangle, fm);
            ////
            LinearGradientBrush lbr = new LinearGradientBrush(new Rectangle(0, 0, 30, 30), Color.Blue, Color.White, 45);
            fm.LineAlignment = StringAlignment.Far;
            fm.Alignment = StringAlignment.Far;
            e.Graphics.DrawString("CONMEO", font, lbr, ClientRectangle, fm);


        }

        private void FrmDrawText_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();// goi lai Simple Paint
        }
    }
}
