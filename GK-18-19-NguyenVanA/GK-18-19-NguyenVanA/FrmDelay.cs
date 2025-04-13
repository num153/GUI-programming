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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace GK_18_19_NguyenVanA
{
    public partial class FrmDelay : Form
    {
        public FrmDelay()
        {
            InitializeComponent();
        }
        int count = 10;

        private void FrmDelay_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush br = new LinearGradientBrush(ClientRectangle, Color.Yellow, Color.Red, 45);
            e.Graphics.FillRectangle(br, ClientRectangle);
            Font f = new Font("Arial", 45, FontStyle.Bold | FontStyle.Italic);
            HatchBrush hbr = new HatchBrush(HatchStyle.Horizontal,Color.White,Color.Blue);
            StringFormat s = new StringFormat();
            s.Alignment = StringAlignment.Center;   
            s.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString("Dang Phuong Nam", f, hbr,ClientRectangle,s);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count--;
            if (count <= 0)
            {
                timer1.Enabled = false;
                this.Close();
            }
        }
    }
}
