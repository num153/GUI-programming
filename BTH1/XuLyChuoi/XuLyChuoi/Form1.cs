﻿using System;
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(txtVitri.Text);
            if (pos < 0 || pos > txtS1.Text.Length) return;
            int numchar = int.Parse(txtSoKiTu.Text);
            txtS2.Text = txtS1.Text.Substring(pos, numchar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbName.Text = "        CHƯƠNG TRÌNH MINH HỌA XỬ LÝ CHUỖI         ";
            txtS1.Text = " Khoa CNTT, Trường Đại Học Mở TP.HCM ";
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbName.Text = lbName.Text.Substring(lbName.Text.Length - 1) +
                lbName.Text.Substring(0, lbName.Text.Length - 1);
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(txtViTriChen.Text);
            if (pos < 0 || pos > txtS1.Text.Length)
                return;
            txtS1.Text = txtS1.Text.Insert(pos, txtS2.Text);
        }

        private void btReplace_Click(object sender, EventArgs e)
        {
            String s1 = txtS1.Text.ToLower();
            String s2 = txtS2.Text.ToLower();
            int index = s1.IndexOf(s2);
            while (index >= 0)
            {
                s1 = s1.Remove(index, s2.Length);
                s1 = s1.Insert(index, txtS3.Text);
                txtS1.Text = txtS1.Text.Remove(index, s2.Length);
                txtS1.Text = txtS1.Text.Insert(index, txtS3.Text);
                index = s1.IndexOf(s2);
            }
            
        }

        private void btReverse_Click(object sender, EventArgs e)
        {
            char[] token = { ' ', '\t' };
            string[] arr = txtS1.Text.Split(token, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(arr);
            txtS1.Text = String.Join(" ", arr);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {

        }

        private void btChuanHoa_Click(object sender, EventArgs e)
        {
            char[] token = { ' ', '\t' };
            string[] arr = txtS1.Text.Split(token, StringSplitOptions.RemoveEmptyEntries);
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i].Substring(0, 1).ToUpper() + arr[i].Substring(1).ToLower();
            }
            txtS1.Text = string.Join(" ", arr);
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtS1.Text =  " Khoa CNTT, Trường Đại Học Mở TP.HCM ";
        }
    }
}
