using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhanVien
{
    public partial class FormQuanLy : Form
    {
        public static string username = "";
        public FormQuanLy()
        {
            FormDangNhap f = new FormDangNhap();
            f.ShowDialog();
            InitializeComponent();
        }

        private void FormQuanLy_Load(object sender, EventArgs e)
        {
            txtHienThiUsername.Text = username;
            lsvNhanVien.Columns[0].Width = (int)(lsvNhanVien.Width*0.5);
            lsvNhanVien.Columns[1].Width = (int)(lsvNhanVien.Width * 0.25);
            lsvNhanVien.Columns[2].Width = (int)(lsvNhanVien.Width * 0.25);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem item;
            //can than nho khai bao dung cu phap
            if (txtHoTen.Text != "")
            {
                item = new ListViewItem(txtHoTen.Text); //cot ho ten
                item.SubItems.Add(dateNgaySinh.Value.ToString("dd/MM/yyyy"));
                item.SubItems.Add(rdNam.Checked ? "Nam" : "Nữ");
                item.ImageIndex = rdNam.Checked? 0 : 1;
                lsvNhanVien.Items.Add(item);
                txtHoTen.Text = "";
                txtHoTen.Focus();
            }
        }
        //Chinh full row select de co the chon nguyen dong
        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach( ListViewItem i in lsvNhanVien.SelectedItems)
                {
                    lsvNhanVien.Items.Remove(i);
                }
        }
    }
}
