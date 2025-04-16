using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK_18_19_NguyenVanA
{
    public partial class FrmList : Form
    {
        public FrmList()
        {
            InitializeComponent();
        }

        private void FrmList_Load(object sender, EventArgs e)
        {
            listView1.Columns[0].Width = (int)(listView1.Width * 0.5);
            listView1.Columns[1].Width = (int)(listView1.Width * 0.5);
            listView1.FullRowSelect = true;
            listView1.MultiSelect = true;


        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(txtTenSach.Text) || string.IsNullOrEmpty(txtTenTacGia.Text))
            {
                MessageBox.Show("Nhap thong tin");
                return;
            }
            ListViewItem item = listView1.Items.Add(txtTenSach.Text);
            item.SubItems.Add(txtTenTacGia.Text);
            item.ImageIndex = 0;
            txtTenSach.Text = "";
            txtTenTacGia.Text = "";
            txtTenSach.Focus();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //xoa 1
            //listView1.Items.Remove(listView1.SelectedItems[0]);
            //xoa nhieu
            if(listView1.Items.Count > 0)
            {
                foreach (ListViewItem i in listView1.SelectedItems)
                {
                    listView1.Items.Remove(i);
                }
            }
            else
            {
                MessageBox.Show("Chon it nhat 1","canh bao",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
