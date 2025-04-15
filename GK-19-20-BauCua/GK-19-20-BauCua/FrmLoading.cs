using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK_19_20_BauCua
{
    public partial class FrmLoading : Form
    {
        public FrmLoading()
        {
            InitializeComponent();
        }

        private void FrmLoading_Load(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
            Graphics g = Graphics.FromImage(bm);

            Font font = new Font("Arial", 44);
            StringFormat s = new StringFormat();
            SolidBrush br = new SolidBrush(Color.Red);
            s.Alignment = StringAlignment.Center;
            s.LineAlignment = StringAlignment.Center;
            g.DrawString("Nam Dang phuong", font, br, ClientRectangle, s);
            this.BackgroundImage = bm; //chu y khong duoc quen
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pic1.Left+=10;
            pic2.Left-=10;
            if(pic1.Right > pic2.Left)
            {
                timer1.Enabled = false;
                this.Close();
            }
        }
    }
}
