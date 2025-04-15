using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XuLyChuoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string stin = "Khoa XYZT Nganh Cong nghe thon tin DHM";

        private void timer1_Tick(object sender, EventArgs e)
        {
            tieude.Text = tieude.Text.Substring(1)+tieude.Text.Substring(0, 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tieude.Text = "    CHUONG TRINH MINH HOA XU LY CHUOI     ";
            s1.Text = stin;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        
        //Bat su kien key preview cua form len de su dung keypress
        private void vitrichen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(vitrichen.Text);
            if (pos < 0 || pos > s1.Text.Length) return;
            s1.Text = s1.Text.Insert(pos, s2.Text);
            vitrichen.Text = "";
        }
        //Cai nay hay !
        private void vitrichen_TextChanged(object sender, EventArgs e)
        {
            if(vitrichen.Text == "")
            {
                btnChen.Enabled = false;
            }
            else
            {
                btnChen.Enabled = true;
            }
        }

        private void btnThaythe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(s2.Text)) return;
            if (s3.Text != "")
            {
                s2.Text = s2.Text.Replace(s2.Text, s3.Text);
            }
            else
            {
                MessageBox.Show("Nhap s3");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string string1 = s1.Text.ToLower();
            string string2 = s2.Text.ToLower();
            int index=string1.IndexOf(string2);

            while (index>=0)
            {
                    string1 = string1.Remove(index, string2.Length);
                    s1.Text = s1.Text.Remove(index,s2.Text.Length);
                    index = string1.IndexOf(string2);
            }
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            s1.Text = stin;
        }

        private void btnLay_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(tuvitri.Text);
            if (pos < 0 || pos > s1.Text.Length) return;
            int numChar = int.Parse(sokitu.Text);
            s2.Text = s1.Text.Substring(pos, numChar);
        }

        private void btnDao_Click(object sender, EventArgs e)
        {
            char[] token = { ' ', '\t' };
            string[] arr = s1.Text.Split(token, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(arr);
            s1.Text = string.Join(" ", arr);
        }

        private void btnChuan_Click(object sender, EventArgs e)
        {
            char[] token = { ' ', '\t' };
            string[] arr = s1.Text.Split(token, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i].Substring(0, 1).ToUpper() + arr[i].Substring(1).ToLower();
            }
            s1.Text = string.Join(" ", arr);
        }
    }
}
