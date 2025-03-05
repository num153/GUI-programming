using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeHocToan
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        String[] toanTu = { "+", "-", "x", ":" };
        int vitri = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btTiepTuc_Click(object sender, EventArgs e)
        {
            int so1 = 0, so2 = 0;
            do
            {
                so1 = rand.Next(10);
                so2 = rand.Next(10);
                vitri = rand.Next(4);
            } while (so2 == 0 && vitri == 3);
            lbSo1.Text = so1.ToString();
            lbSo2.Text = so2.ToString();
            lbToanTu.Text = toanTu[vitri];
            lbKetQua.Text = "";
            txtTraLoi.Text = "";
        }

        private void lbToanTu_Click(object sender, EventArgs e)
        {
           
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            int kq = 0;
            try
            {
                switch(vitri)
                {
                    case 0:
                        kq = int.Parse(lbSo1.Text) + int.Parse(lbSo2.Text);
                        break;
                    case 1:
                        kq = int.Parse(lbSo1.Text) - int.Parse(lbSo2.Text);
                        break;
                    case 2:
                        kq = int.Parse(lbSo1.Text) * int.Parse(lbSo2.Text);
                        break;
                    case 3:
                        kq = int.Parse(lbSo1.Text) / int.Parse(lbSo2.Text);
                        break;

                }
                int doan = int.Parse(txtTraLoi.Text);
                if (doan == kq)
                    lbKetQua.Text = "Đúng rồi!";
                else
                    lbKetQua.Text = "Sai rồi! Kết quả là " + kq.ToString();
            }
            catch(FormatException)
            {
                MessageBox.Show("Bạn phải nhập số!");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtTraLoi.Text == "")
                return;
            txtTraLoi.Text = txtTraLoi.Text.Substring(0, txtTraLoi.Text.Length - 1);
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtTraLoi.Text += bt.Text;
        }

        private void btDau_Click(object sender, EventArgs e)
        {
            if (txtTraLoi.Text != "")
                return;
            txtTraLoi.Text = "-";
        }
    }
}
