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
using static System.Windows.Forms.MonthCalendar;

namespace MyWord
{
    public partial class fm : Form
    {
        public fm()
        {
            InitializeComponent();
        }
        String filePath = "";
        private bool isTextChanged = false;
        private bool isExit= false;
        private const string unSaveFileName = "Untitled.txt";
        private void UpdateFormTitle()
        {
            if (string.IsNullOrEmpty(richTxtBox.Text) && string.IsNullOrEmpty(filePath) && isTextChanged)
            {
                this.Text = "MyWordPad";
                return;
            }
            string fileName = string.IsNullOrEmpty(filePath) ? unSaveFileName : Path.GetFileName(filePath);
            string title = $"MyWordPad - {fileName}";
            if (isTextChanged==true)
            {
                title += "*"; // Thêm dấu * nếu có thay đổi chưa lưu
            }
            this.Text = title;


        }
        private bool PromptSaveChanges(string message, object sender, EventArgs e)
        {
            if (isTextChanged && !string.IsNullOrEmpty(richTxtBox.Text))
            {
                var result = MessageBox.Show(message, "Save changes",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                    return !isTextChanged; //Cap nhat ve false
                }
                else if (result == DialogResult.Cancel)
                {
                    return false; //Cancel
                }
            }
            return true; // text k thay doi, user chon No, da luu file, tiep tuc chuong trinh ma k luu
        }
        private void UpdateStatusBar()
        {
            if (!sttBar.Visible) return; //stt an thi thoi

            // lay vi tri con tro cua toan bo van ban
            int vtStart = richTxtBox.SelectionStart;
            //lay vt nhung k cho biet dong nao nen lai line
            int line = richTxtBox.GetLineFromCharIndex(vtStart) + 1; //bat tu la Ln 1

            //vt con tro tru di vt dau dong
            int column = vtStart - richTxtBox.GetFirstCharIndexOfCurrentLine() + 1; 
            sttBarContent.Text = $"Ln {line}, Col {column}";

            /*nam --> vsT = 3 sau chu m,
                line = 0 +1
                col = 3 - 0 + 1
             
             */
        }
        private void fm_Load(object sender, EventArgs e)
        {
            ApplyTheme("Light");

            richTxtBox.WordWrap = wordWrapToolStripMenuItem.Checked;
            richTxtBox.ScrollBars = wordWrapToolStripMenuItem.Checked ?
            RichTextBoxScrollBars.None : RichTextBoxScrollBars.ForcedHorizontal;
            if (sttBar.Visible==true)
            {
                UpdateStatusBar();
            }
            //theo doi con tro
            richTxtBox.TextChanged += richTxtBox_TextChanged;
            richTxtBox.SelectionChanged += richTxtBox_SelectionChanged;

        }

        private void richTxtBox_SelectionChanged(object sender, EventArgs e)
        {
            UpdateStatusBar();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PromptSaveChanges("Do you want to save before Create new file?", sender, e))
            {
                return; //Neu chon cacel
            }
            richTxtBox.Text = "";
            filePath = "";
            isTextChanged = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DK: neu khong tiep tuc (cancel) thi return --> su dung !
            if (!PromptSaveChanges("Do you want to save before Open?", sender, e))
            {
                return; //Neu chon cacel thi ksao
            }

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

                        string text = sr.ReadToEnd();
                        richTxtBox.TextChanged -= richTxtBox_TextChanged; //go su kien de bo dau *
                        richTxtBox.Text = text;
                        isTextChanged = false;

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
                            isTextChanged = false;
                            UpdateFormTitle(); //cap nhat tieu de
                            MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
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
                    isTextChanged = false;
                    UpdateFormTitle(); //cap nhat tieu de
                    MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                        isTextChanged = false;
                        UpdateFormTitle(); //cap nhat tieu de
                        MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            isExit= true;
            if (!PromptSaveChanges("Do you want to save before exit?", sender, e))
            {
                isExit = false;
                return;
            }
            this.Close(); //Thoat neu true (tuc la k cancel)

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
            UpdateFormTitle();
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wordWrapToolStripMenuItem.Checked = !wordWrapToolStripMenuItem.Checked; // Đảo trạng thái
            richTxtBox.WordWrap = wordWrapToolStripMenuItem.Checked;
            //bat
            if (wordWrapToolStripMenuItem.Checked)
            {
                richTxtBox.ScrollBars = RichTextBoxScrollBars.None; 
                sttBar.Visible = true; 
                UpdateStatusBar();
            }
            //tat
            else
            {
                richTxtBox.ScrollBars = RichTextBoxScrollBars.ForcedHorizontal; 
                sttBar.Visible = false; 
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
            s.ThemeChanged += thaydoi;
            s.ShowDialog();
        }
        private void thaydoi(object sender, string theme)
        {
            ApplyTheme(theme);
        }

        private void richTxtBox_Layout(object sender, LayoutEventArgs e)
        {
            
        }

        private void richTxtBox_TextChanged(object sender, EventArgs e)
        {
            UpdateFormTitle();
            isTextChanged = true;
            UpdateStatusBar();
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



        private void fm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                return; //Dong
            }
            if (!PromptSaveChanges("Do you want to save before close?", sender, e))
            {
                e.Cancel = true; //Neu ng dung chon cancel, khong dong app
            }
        }

        private void ApplyTheme(string theme)
        {
            if (theme == "Light")
            {
                // Giao diện sáng
                this.BackColor = Color.White;
                richTxtBox.BackColor = Color.White;
                richTxtBox.ForeColor = Color.Black;
                menuStrip1.BackColor = Color.White;
                menuStrip1.ForeColor = Color.Black;
                sttBar.BackColor = Color.White;
                sttBar.ForeColor = Color.Black;
            }
            else if (theme == "Dark")
            {
                // Giao diện tối
                this.BackColor = Color.FromArgb(30, 30, 30);
                richTxtBox.BackColor = Color.FromArgb(45, 45, 45);
                richTxtBox.ForeColor = Color.White;
                menuStrip1.BackColor = Color.FromArgb(30, 30, 30);
                menuStrip1.ForeColor = Color.White;
                sttBar.BackColor = Color.FromArgb(30, 30, 30);
                sttBar.ForeColor = Color.White;
            }
        }
    }
}
