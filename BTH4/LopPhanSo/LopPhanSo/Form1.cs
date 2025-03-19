using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LopPhanSo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PhanSo ps1, ps2;

        private void Form1_Load(object sender, EventArgs e)
        {
            //TAI SAO KHAI BAO TRONG NAY KHONG DUOC ????
            ps1 = new PhanSo();
            ps2 = new PhanSo();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {
                ps1.Tuso = int.Parse(txtTu1.Text);
                ps1.Mauso = int.Parse(txtMau1.Text);
                ps2.Tuso = int.Parse(txtTu2.Text);
                ps2.Mauso = int.Parse(txtMau2.Text);
                Button bt = (Button)sender;
                PhanSo kq = null;
                switch (bt.Text)
                {
                    case "+":
                        kq = ps1.Cong(ps2);
                        lbDau.Text = bt.Text;
                        break;
                    case "-":
                        kq = ps1.Tru(ps2);
                        lbDau.Text = bt.Text;
                        break;
                    case "*":
                        kq = ps1.Nhan(ps2);
                        lbDau.Text = bt.Text;
                        break;
                    case "/":
                        kq = ps1.Chia(ps2);
                        lbDau.Text = bt.Text;
                        break;
                }
                txtMau3.Text = kq.Mauso.ToString();
                txtTu3.Text = kq.Tuso.ToString();

            } catch (FormatException)
            {
                MessageBox.Show("Nhap dung gia tri pls");
            }
            catch
            {
                MessageBox.Show("Loi chia cho 0");
            }

        }
    }
}
