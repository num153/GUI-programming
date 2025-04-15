using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK_19_20_BauCua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            FrmLoading f = new FrmLoading();
            f.ShowDialog();
            InitializeComponent();
        }
        int tien = 1000;
        Random rand = new Random();
        String imgPath;
        private void Form1_Load(object sender, EventArgs e)
        {
            lbTienCon.Text = tien.ToString();
            textBox1.Text = "100";
            imgPath = Application.StartupPath+@"\Hinhxucxac";
        }

        private void btnQuay_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn!");
                return;
            }
            int chon = comboBox1.SelectedIndex +1 ;
            int tiencuoc = Convert.ToInt32(textBox1.Text);
            int f1 = rand.Next(1, 7);
            int f2 = rand.Next(1, 7);
            int f3 = rand.Next(1, 7);
            

            if (tiencuoc < 100 || tiencuoc % 100 != 0 || tiencuoc > tien)
            {
                MessageBox.Show("Tiền cược không hợp lệ!");
                return;
            }
            pictureBox1.Image = Image.FromFile(imgPath + @"\" + f1.ToString() + ".jpg");
            pictureBox2.Image = Image.FromFile(imgPath + @"\" + f2.ToString() + ".jpg");
            pictureBox3.Image = Image.FromFile(imgPath + @"\" + f3.ToString() + ".jpg");

            if(chon == f1 || chon == f2 || chon == f3)
            {
                tien += tiencuoc;
            }
            else
            {
                tien -=tiencuoc;
            }
            if(tien <=0 )
            {
                btnQuay.Enabled = false;
            }
            lbTienCon.Text = tien.ToString() ;
        }
    }
}
