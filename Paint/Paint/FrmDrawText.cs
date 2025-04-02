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

namespace Paint
{
    public partial class FrmDrawText : Form
    {
        public FrmDrawText()
        {
            InitializeComponent();
        }

        private void FrmDrawText_Load(object sender, EventArgs e)
        {

        }

        private void FrmDrawText_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font("Arial", 60, FontStyle.Bold);
            StringFormat fm = new StringFormat();
            fm.Alignment = StringAlignment.Far;
            e.Graphics.DrawString("NAMTHUI", font, Brushes.Green, ClientRectangle,fm);
            //
            Image img = Image.FromFile("hoatim.png");
            TextureBrush tbr = new TextureBrush(img);
            fm.Alignment = StringAlignment.Near;
            fm.LineAlignment = StringAlignment.Far;
            e.Graphics.DrawString("NAMTHUI", font, tbr, ClientRectangle, fm);

        }
    }
}
