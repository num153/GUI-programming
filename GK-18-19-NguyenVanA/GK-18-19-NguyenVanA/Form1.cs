using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK_18_19_NguyenVanA
{

    public partial class Form1 : Form
    {
        private int count = 3;
        public Form1()
        {
            FrmDelay f = new FrmDelay();
            f.ShowDialog();
            InitializeComponent();
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmImg f = new FrmImg();
            f.ShowDialog();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmList f = new FrmList();
            f.ShowDialog();
        }
    }
}
