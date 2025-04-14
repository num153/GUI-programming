using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK_19_20
{
    public partial class Form1 : Form
    {
        String imgPath;
        Random rand = new Random();
        int dice1=1,dice2=1,dice3 = 1;
        int tienUser = 1000;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            imgPath = Application.StartupPath + @"\hinhxucxac\";
            //Init();
            lbTiencon.Text = tienUser.ToString();

        }
        private void Init()
        {
            pictureBox1.Image = Image.FromFile(imgPath + "1.jpg");
            pictureBox2.Image = Image.FromFile(imgPath + "3.jpg");
            pictureBox3.Image = Image.FromFile(imgPath + "1.jpg");
        }
        private void HienThi()
        {
            if (checkBox1.Checked)
            {
                pictureBox1.Image = Image.FromFile(imgPath + dice1.ToString() + ".jpg");
                pictureBox2.Image = Image.FromFile(imgPath + dice2.ToString() + ".jpg");
                pictureBox3.Image = Image.FromFile(imgPath + dice3.ToString() + ".jpg");
                lb1.Visible = false;
                lb2.Visible = false;
                lb3.Visible = false;
            }
            else
            {
                lb1.Text = dice1.ToString();
                lb2.Text = dice2.ToString();
                lb3.Text = dice3.ToString();
                //pictureBox1.Image = null;
                //pictureBox2.Image = null;
                //pictureBox3.Image = null;
                lb1.Visible = true;
                lb2.Visible = true;
                lb3.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Play();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Thoat nha", "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void Play()
        {
            //Xu ly hien thi
            dice1 = rand.Next(1, 7);
            dice2 = rand.Next(1, 7);
            dice3 = rand.Next(1, 7);
            HienThi();

            //Xu ly tro choi
            int tongso = dice1 + dice2 + dice3;
            MessageBox.Show($"Tong xuc sac {tongso}");
            bool chan = tongso % 2 == 0;
            bool khoangtrai = tongso >= 3 && tongso <= 10;
            int tienCuocChanLe = int.Parse(comboBox1.SelectedItem.ToString());
            int tienCuocTongSo = int.Parse(comboBox2.SelectedItem.ToString());
            int tienUser = int.Parse(lbTiencon.Text);
            if((tienCuocChanLe+tienCuocTongSo) > tienUser)
            {
                MessageBox.Show("Ban khong du tien");
            }
            if(chan && rdChan.Checked)
            {
                tienUser += tienCuocChanLe;

            }
            else if(!chan && rdLe.Checked)
            {
                tienUser += tienCuocChanLe;
            }
            else
            {
                tienUser -= tienCuocChanLe;
            }

            //Xu ly tong so
            if (khoangtrai && rd310.Checked)
            {
                tienUser += tienCuocTongSo;

            }
            else if (!khoangtrai && rd1118.Checked)
            {
                tienUser += tienCuocTongSo;
            }
            else
            {
                tienUser -= tienCuocTongSo;
            }


            lbTiencon.Text = tienUser.ToString();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Hien thi ngay lap tuc khi checkbox thay doi so/hinh
            HienThi();
        }
    }
}
