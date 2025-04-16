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
    public partial class Form2 : Form
    {
        Random random = new Random();
        int[] arrInt;
        int[] arrTang;
        int[] arrGiam;
        int[] arrDao;
        int[] arrHonHop;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            txtBanDau.Text = "";
            txtTang.Text = "";
            txtGiam.Text = "";
            txtDao.Text = "";
            txtHonHop.Text = "";
            try
            {
                int soPt = Int32.Parse(txtSopt.Text);
                arrInt = new int[soPt];
                for (int i = 0; i < soPt; i++)
                {
                    arrInt[i] = random.Next(100);
                }
                ShowArray(arrInt, txtBanDau);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowArray(int[] arr, TextBox txt)
        {
            txt.Text= String.Empty;
            for (int i = 0;i < arr.Length; i++)
            {
                txt.Text += arr[i].ToString() + ",";
            }
            txt.Text = txt.Text.TrimEnd(',');
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            if (txtBanDau.Text=="")
            {
                MessageBox.Show("Mang chua co du lieu!");
                return;
            }
            Sort();
            SortSpecial();
        }

        private void Sort()
        {
            arrTang= new int[arrInt.Length];
            arrGiam= new int[arrInt.Length];
            arrDao= new int[arrInt.Length];
            try
            {
                Array.Copy(arrInt, arrTang, arrInt.Length);
                Array.Sort(arrTang);
                ShowArray(arrTang, txtTang);
                Array.Copy(arrTang, arrGiam, arrInt.Length);
                Array.Reverse(arrGiam);
                ShowArray(arrGiam, txtGiam);
                Array.Copy(arrInt, arrDao, arrInt.Length);
                Array.Reverse(arrDao);
                ShowArray(arrDao, txtDao);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SortSpecial()
        {
            arrHonHop= new int[arrInt.Length];
            Array.Copy(arrInt,arrHonHop, arrInt.Length);
            int i = 0;
            int j = arrHonHop.Length - 1;
            while (i < j)
            {
                if (arrHonHop[i] % 2 == 0)
                {
                    i++;
                }
                if (arrHonHop[j] % 2 != 0)
                {
                    j--;
                }
                if (i < j)
                {
                    if (arrHonHop[i] % 2 != 0 && arrHonHop[j] %2 == 0)
                    {
                        swap(ref arrHonHop[i], ref arrHonHop[j]);
                        i++;
                        j--;
                    }
                }   
            }
            int mid = arrHonHop[i] % 2 != 0 ? i - 1 : i;
            for(i = 0; i< mid; i++)
            {
                for(j=i+1; j< mid + 1; j++)
                {
                    if (arrHonHop[i] > arrHonHop[j])
                        swap(ref arrHonHop[i], ref arrHonHop[j]);
                }
            }

            for (i = mid +1; i < arrHonHop.Length-1; i++)
            {
                for (j = i + 1; j < arrHonHop.Length; j++)
                {
                    if (arrHonHop[i] < arrHonHop[j])
                        swap(ref arrHonHop[i], ref arrHonHop[j]);
                }
            }
            ShowArray(arrHonHop, txtHonHop);
        }

        private void swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
    }
}
