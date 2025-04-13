using System;
using System.Windows.Forms;

namespace MyWord
{
    public partial class SettingFrm : Form
    {
        public event EventHandler<string> ThemeChanged;

        public SettingFrm()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;//Light 
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }
       
        //Khi user lua chon giao dien
        public void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string giaodien = comboBox1.SelectedItem.ToString();
            if (ThemeChanged != null)
            {
                ThemeChanged(this, giaodien);
            }
        }
    }
}