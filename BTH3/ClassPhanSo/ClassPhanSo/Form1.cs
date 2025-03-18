using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassPhanSo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            lbDau.Text = btnCong.Text;

            try
            {
                PhanSo ps1 = new PhanSo(int.Parse(txtTuSo1.Text), int.Parse(txtMauSo1.Text));
                PhanSo ps2 = new PhanSo(int.Parse(txtTuSo2.Text), int.Parse(txtMauSo2.Text));
                PhanSo kq = ps1.Cong(ps2);
                txtTuSo3.Text = kq.Tuso.ToString();
                txtMauSo3.Text = kq.Mauso.ToString();
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            lbDau.Text = btnTru.Text;

            try
            {
                PhanSo ps1 = new PhanSo(int.Parse(txtTuSo1.Text), int.Parse(txtMauSo1.Text));
                PhanSo ps2 = new PhanSo(int.Parse(txtTuSo2.Text), int.Parse(txtMauSo2.Text));
                PhanSo kq = ps1.Tru(ps2);
                txtTuSo3.Text = kq.Tuso.ToString();
                txtMauSo3.Text = kq.Mauso.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            lbDau.Text = btnNhan.Text;

            try
            {
                PhanSo ps1 = new PhanSo(int.Parse(txtTuSo1.Text), int.Parse(txtMauSo1.Text));
                PhanSo ps2 = new PhanSo(int.Parse(txtTuSo2.Text), int.Parse(txtMauSo2.Text));
                PhanSo kq = ps1.Nhan(ps2);
                txtTuSo3.Text = kq.Tuso.ToString();
                txtMauSo3.Text = kq.Mauso.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            lbDau.Text = btnChia.Text;

            try
            {
                PhanSo ps1 = new PhanSo(int.Parse(txtTuSo1.Text), int.Parse(txtMauSo1.Text));
                PhanSo ps2 = new PhanSo(int.Parse(txtTuSo2.Text), int.Parse(txtMauSo2.Text));
                PhanSo kq = ps1.Chia(ps2);
                txtTuSo3.Text = kq.Tuso.ToString();
                txtMauSo3.Text = kq.Mauso.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Tieu de: Loi",MessageBoxButtons.OK);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTuSo1.Clear();
            txtMauSo1.Clear();
            txtTuSo2.Clear();
            txtMauSo2.Clear();
            txtTuSo3.Clear();
            txtMauSo3.Clear();
        }
    }
}
