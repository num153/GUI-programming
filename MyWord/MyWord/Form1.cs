using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWord
{
    public partial class fm : Form
    {
        public fm()
        {
            InitializeComponent();
        }
        String filePath = "";

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTxtBox.Text = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            {
                //Hien thi file .txt
                ofd.Filter = "Text Document|*.txt";
                ofd.ValidateNames = true;
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(ofd.FileName);
                    {
                        filePath = ofd.FileName;
                        //Task<string> text = sr.ReadToEndAsync();
                        //richTxtBox.Text = text.Result;
                        string text = sr.ReadToEnd();
                        richTxtBox.Text = text;
                        
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Neu chua co filePath thi mo dialog de user chon Path
            if (string.IsNullOrEmpty(filePath))
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Text Document|*.txt";
                    sfd.ValidateNames = true;
                    //Tu dong dat ten theo nam-thang-ngay
                    string defaultFileName = "MyWordPad-" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt"; //2025-05-04.txt
                    sfd.FileName = defaultFileName;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (StreamWriter sw = new StreamWriter(sfd.FileName))
                            { sw.WriteLine(richTxtBox.Text); }
                            filePath = sfd.FileName;
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            //Neu da co filePath roi thi ghi de
            else
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(filePath))
                    { sw.WriteLine(richTxtBox.Text); }
                    MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void fm_Load(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khong can kiem tra null hay khong
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text Document|*.txt";
                sfd.ValidateNames = true;
                //Tu dong dat ten theo nam-thang-ngay
                string defaultFileName = "MyWordPad-" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt"; //2025-05-04.txt
                sfd.FileName = defaultFileName;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName))
                        { sw.WriteLine(richTxtBox.Text); }
                        filePath = sfd.FileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                PrintDocument printDocument = new PrintDocument();
                printDialog.Document = printDocument;
                printDocument.Print();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTxtBox.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTxtBox.Redo();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTxtBox.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTxtBox.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTxtBox.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTxtBox.SelectAll();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTxtBox.SelectedText = "";
        }

        private void fm_TextChanged(object sender, EventArgs e)
        {
            if (richTxtBox.Text.Length > 0)
            {
                cutToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
            }
            else
            {
                cutToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
            }
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            //Tat
            if (wordWrapToolStripMenuItem.Checked)
            {
                // Neu dang bat (Checked = true), nhan de tat
                wordWrapToolStripMenuItem.Checked = false;
                richTxtBox.WordWrap = false;
            }
            //Bat
            else
            {
                wordWrapToolStripMenuItem.Checked = true;
                richTxtBox.WordWrap = true;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowDialog();
           //Ap dung cho cac van ban dc boi den
            richTxtBox.SelectionFont = new Font(font.Font.FontFamily, font.Font.Size, font.Font.Style);
        }

        private void highlightTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTxtBox.SelectionLength > 0)
            {
                richTxtBox.SelectionBackColor = Color.Yellow;
            }
           
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog(); 
        }

        private void edfdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingFrm s = new SettingFrm();
            s.ShowDialog();
        }
    }
}
