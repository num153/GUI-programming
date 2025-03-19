using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TangBong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dx = 10, dy = 13;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(picMeo.Left <0 || picMeo.Right > ClientRectangle.Width)
            {
                dx = -dx;
            }
            if(picMeo.Top < 0 || picMeo.Bottom > ClientRectangle.Height)
            {
                dy = -dy;
            }
            picMeo.Left += dx;
            picMeo.Top += dy;

        }
    }
}
