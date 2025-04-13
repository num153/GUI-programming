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
    //Nam ngoai class cung dc
    enum Direction
    {
        LEFT, RIGHT, UP, DOWN
    }
    public partial class FrmImg : Form
    {
        Direction direction;
        public FrmImg()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (direction)
            {
                case Direction.LEFT:
                    picBox.Left -= 10;
                    if (picBox.Right <= 0)
                    {
                        picBox.Left = ClientRectangle.Width;
                    }
                    break;
                case Direction.RIGHT:
                    picBox.Left += 10;
                    if (picBox.Left >= ClientRectangle.Width)
                    {
                        picBox.Left = -picBox.Width;
                    }
                    break;
                case Direction.UP:
                    picBox.Top -= 10;
                    if (picBox.Bottom <= 0)
                    {
                        picBox.Top = ClientRectangle.Height;
                    }
                    break;
                case Direction.DOWN:
                    picBox.Top += 10;
                    if (picBox.Top >= ClientRectangle.Height)
                    {
                        picBox.Top = -picBox.Height;
                    }
                    break;
            }
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left: direction = Direction.LEFT; break;
                case Keys.Right: direction = Direction.RIGHT; break;
                case Keys.Up: direction = Direction.UP; break;
                case Keys.Down: direction = Direction.DOWN; break;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void FrmImg_Load(object sender, EventArgs e)
        {
            direction = Direction.LEFT;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Chon anh|*.png;*.jpg|All files|*.*";
            o.Multiselect = false;
            if(o.ShowDialog()==DialogResult.OK) { 
                picBox.Image = Image.FromFile(o.FileName);
            }
        }
    }
}
