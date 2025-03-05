using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiupBeHocToan
{
    public partial class Form1 : Form
    {
        //Khai Bao Cac Bien Can Thiet
        Random rand = new Random();
        string[] toantu = { "+", "-", "x", ":" };
        int pheptoan = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void TaoPhepToan()
        {
            int so1 = rand.Next(10);
            int so2 = rand.Next(10);
            pheptoan = rand.Next(4);
            lbSo1.Text = so1.ToString();
            lbSo2.Text = so2.ToString();
            lbToantu.Text = toantu[pheptoan];
            txtKetqua.Text = "";
            txtTraloi.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TaoPhepToan();
        }

        private void btnTieptuc_Click(object sender, EventArgs e)
        {
            int so1 = 0;
            int so2 = 0;
            do
            {
                so1 = rand.Next(10);
                so2 = rand.Next(10);
                pheptoan = rand.Next(4);
            } while (so2 == 0 && pheptoan == 3);
            lbSo1.Text = so1.ToString();
            lbSo2.Text = so2.ToString();
            lbToantu.Text = toantu[pheptoan];
            txtKetqua.Text = "";
            txtTraloi.Text = "";
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            int kq = 0;
            int a = int.Parse(lbSo1.Text);
            int b = int.Parse(lbSo2.Text);
            switch (pheptoan)
            {
                case 0:
                    kq = a + b;
                    break;
                case 1:
                    kq = a-b;
                    break;
                case 2:
                    kq = a * b;
                    break;
                case 3:
                    kq = a / b;
                    break;
            }
            //Xu ly neu khong nhap so
            try
            {
                int doan = int.Parse(txtTraloi.Text);
                if (doan == kq)
                {
                    txtKetqua.Text = "Correct!";
                }
                else
                {
                    txtKetqua.Text = "Wrong! Result: " + kq.ToString();
                }
            }catch(FormatException)
            {
                MessageBox.Show("Enter Number pls!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTraloi.Text == "") return;
            txtTraloi.Text = txtTraloi.Text.Substring(0, txtTraloi.Text.Length - 1);
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            if (txtTraloi.Text != "") return;
            txtTraloi.Text = "-";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtTraloi.Text += bt.Text;
        }
    }
}
