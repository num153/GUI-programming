using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoanXucXac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String imgPath;
        int nChon, nSolan, nWin, nLose;

        private void btn1_Click(object sender, EventArgs e)
        {
            Choose(sender);
        }
        private void Choose(object sender)
        {
            Button bt = (Button)sender;
            nChon = int.Parse(bt.Text);
            picChoose.Image = Image.FromFile(imgPath + bt.Text + ".jpg");
        }

        Random rand = new Random();

        private void btnReset_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imgPath = Application.StartupPath + @"\hinhxucxac\"; //Duong dan den hinh xuc xac
            Init(); //KHoi tao truoc khi choi
        }
        private void Init()
        {
            nSolan = nWin = nLose = 0;
            nChon = 1;
            picChoose.Image = Image.FromFile(imgPath + "1.jpg");
            picResult.Image = null;
            lbCount.Text = lbLose.Text = lbWin.Text = "";
            lsResult.Items.Clear();
        }
        private void Play()
        {
            nSolan++;
            //n = so dice ma may tinh random
            int n = rand.Next(1, 7);
            //In hinh xuc xac random ra picBox
            picResult.Image = Image.FromFile(imgPath + n.ToString() + ".jpg");
            string kq = "";
            if(nChon == n)
            {
                nWin++;
                kq = "Thắng";
            }else
            {
                nLose++;
                kq = "Thua";
            }
            //In thong ke ra cac label
            lbCount.Text = String.Format("Lần đoán: {0}", nSolan);
            lbWin.Text = String.Format("Lần thắng: {0} ({1:0.##}%)", nWin, (double)nWin * 100 / nSolan);
            lbLose.Text = String.Format("Lần thua: {0} ({1:0.##}%)", nLose, (double)nLose * 100 / nSolan);
            lsResult.Items.Add(String.Format("{0}. {1} (Đoán {2} ra {3})", nSolan, kq, nChon, n));
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter: Play(); break;
                case Keys.Escape: Init(); break;
                case Keys.D1: case Keys.NumPad1: Choose(btn1); break;
                case Keys.D2: case Keys.NumPad2: Choose(btn2); break;
                case Keys.D3: case Keys.NumPad3: Choose(btn3); break;
                case Keys.D4: case Keys.NumPad4: Choose(btn4); break;
                case Keys.D5: case Keys.NumPad5: Choose(btn5); break;
                case Keys.D6: case Keys.NumPad6: Choose(btn6); break;
            }
            return base.ProcessDialogKey(keyData);

        }

    }
}
