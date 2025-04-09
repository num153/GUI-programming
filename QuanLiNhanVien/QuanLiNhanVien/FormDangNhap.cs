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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        bool co = false;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text == "admin")
            {
                FormQuanLy.username = txtUsername.Text;
                co = true;
                this.Close(); //Dong form nay
            }
            else
            {
                MessageBox.Show("Sai thong tin dang nhap","Aleart",MessageBoxButtons.OK,MessageBoxIcon.Error);
                //Xu ly them neu qua 3 lan thi moi thoat ung dung
                
                Application.Exit();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Dong toan bo app
        }

        //Xu ly khi an thoat tren cua so
        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(co==false)
            {
                Application.Exit();
            }
        }
    }
}
