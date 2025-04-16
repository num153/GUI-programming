using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanh1_NHD
{
    public partial class FrmMain : Form
    {
        Random rand = new Random();
        int tien = 1000;
        string path;
        int chon;
        public FrmMain()
        {
            FrmDelay f = new FrmDelay();
            f.ShowDialog();
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            string[] str = { "Bầu", "Cá", "Cua", "Gà", "Nai", "Tôm" };
            cbChon.Items.AddRange(str);
            txtCuoc.Text = "100";
            lbTien.Text = tien.ToString();
            path = Application.StartupPath + @"\Hinh";
        }

        private void btQuay_Click(object sender, EventArgs e)
        {
            if (cbChon.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn!");
                return;
            }

            try
            {
                int cuoc = Convert.ToInt32(txtCuoc.Text);
                if (cuoc < 100 || cuoc % 100 != 0 || cuoc > tien)
                {
                    MessageBox.Show("Tiền cược không hợp lệ!");
                    return;
                }
                chon = cbChon.SelectedIndex;
                int s1 = rand.Next(0, 6);
                int s2 = rand.Next(0, 6);
                int s3 = rand.Next(0, 6);
                pic1.Image = Image.FromFile(path + @"\" + s1.ToString() + ".jpg");
                pic2.Image = Image.FromFile(path + @"\" + s2.ToString() + ".jpg");
                pic3.Image = Image.FromFile(path + @"\" + s3.ToString() + ".jpg");
                if (s1 != chon && s2 != chon && s3 != chon)
                {
                    tien -= cuoc;
                }
                else
                {
                    if (s1 == chon) tien += cuoc;
                    if (s2 == chon) tien += cuoc;
                    if (s3 == chon) tien += cuoc;
                }
                lbTien.Text = tien.ToString();
                if (tien <= 0) btQuay.Enabled = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn chưa đặt tiền cược");
            }
        }

        private void txtCuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng chương trình?","Chú ý!",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
                == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
