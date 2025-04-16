using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ontap_C2_BTVN
{
    public partial class Form1 : Form
    {
        string strChuoi1 = "khoa Công nghệ thông  tin   ,   đại  học MỞ THÀNH phố HỒ CHÍ MINH      ";
        String str = "                                    CHƯƠNG TRÌNH MINH HỌA XỬ LÝ CHUỖI                                      ";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbName.Text = str;
            txtChuoi1.Text = strChuoi1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbName.Text= lbName.Text.Substring(lbName.Text.Length - 1) +
                lbName.Text.Substring(0,lbName.Text.Length - 1);
        }

        private void btChen_Click(object sender, EventArgs e)
        {
            if (txtChuoi2.Text == "" || txtIndexChen.Text == "")
            {
                MessageBox.Show("Moi nhap du lieu."); return;
            }    
            int pos = int.Parse(txtIndexChen.Text);
            if (pos > txtChuoi1.TextLength || pos < 0)
            {
                MessageBox.Show("Vi tri chen khong hop le!"); return;
            }    
            txtChuoi1.Text = txtChuoi1.Text.Insert(pos, txtChuoi2.Text);
        }

        private void btReplace_Click(object sender, EventArgs e)
        {
            string s1 = txtChuoi1.Text.ToLower();
            string s2 = txtChuoi2.Text.ToLower();
            int index = s1.IndexOf(s2);
            while (index >=0)
            {
                s1 = s1.Remove(index, s2.Length);
                s1=s1.Insert(index, txtChuoi3.Text);
                txtChuoi1.Text = txtChuoi1.Text.Remove(index, s2.Length);
                txtChuoi1.Text = txtChuoi1.Text.Insert(index, txtChuoi3.Text);
                index = s1.IndexOf(s2);
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            string s1= txtChuoi1.Text.ToLower();
            string s2 = txtChuoi2.Text.ToLower();
            if (s2 == "") return;
            int index = s1.IndexOf(s2);
            while (index >=0)
            {
                s1=s1.Remove(index, s2.Length);
                txtChuoi1.Text=txtChuoi1.Text.Remove(index, s2.Length);
                index = s1.IndexOf(s2);
            }
        }

        private void btSub_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(txtIndexSub.Text);
            if (pos < 0 || pos > txtChuoi1.TextLength) return;
            int SoKt = int.Parse(txtCharSub.Text);
            txtChuoi3.Text=txtChuoi1.Text.Substring(pos, SoKt);
        }

        private void btReverse_Click(object sender, EventArgs e)
        {
            char[] token = { ' ', '\t' };
            string[] str = txtChuoi1.Text.Split(token,StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(str);
            txtChuoi1.Text = string.Join(" ", str);
        }

        private void btKhoiPhuc_Click(object sender, EventArgs e)
        {
            txtChuoi1.Text = strChuoi1;
        }

        private void btChuanHoa_Click(object sender, EventArgs e)
        {
            char[] token = {' ', '\t'};
            string[] arr = txtChuoi1.Text.Split(token,StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i].Substring(0,1).ToUpper() + arr[i].Substring(1).ToLower();
            }
            txtChuoi1.Text = string.Join(" ",arr);
        }
    }
}
