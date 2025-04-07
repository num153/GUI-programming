using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawShape
{
    public partial class FormOption : Form
    {
        public FormOption()
        {
            InitializeComponent();
        }
        public ShapeType st;
        public Color cl;

        private void FormOption_Load(object sender, EventArgs e)
        {
            pnColorPreview.BackColor = cl;
            if (st == ShapeType.Rectangle)
                rdRec.Checked = true;
            else if (st == ShapeType.Ellipse)
                rdEll.Checked = true;
            else if ( st ==ShapeType.Triangle)
                rdTri.Checked = true;
            else
                rdLine.Checked = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
