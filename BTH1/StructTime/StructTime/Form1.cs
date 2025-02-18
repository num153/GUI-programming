using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StructTime
{
    public partial class Form1 : Form
    {
        struct Time
        {
            int gio, phut, giay;
            public int Hour { 
                get {  return gio; }
                set { gio = value; } 
            }
            public int Min
            {
                get { return phut; }
                set { phut = value; }
            }
            public int Sec
            {
                get { return giay; }
                set { giay = value; }
            }
            public Time(int h, int m, int s)
            {
                gio = h;
                phut = m;
                giay = s;

            }
            public void ChuanHoa()
            {
                int t = giay / 60;
                giay=giay % 60;
                phut = phut + t;
                t=phut / 60;
                phut=phut % 60;
                gio = gio + t;
                gio = (gio >= 24 ? gio % 24 : gio);
            }
            public String showTime()
            {
                ChuanHoa();
                return String.Format("{0} : {1:00} : {2:00}",gio,phut, giay);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Time time = new Time(int.Parse(txtHour.Text),
                                    int.Parse(txtMin.Text),
                                    int.Parse(txtSec.Text));
            lbShow.Text = time.showTime();
        }
    }
}
