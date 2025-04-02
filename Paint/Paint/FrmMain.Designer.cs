namespace Paint
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDrawWithMose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDrawText = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDrawImage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDrawWithMose,
            this.menuDrawText,
            this.menuDrawImage,
            this.menuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuDrawWithMose
            // 
            this.menuDrawWithMose.Name = "menuDrawWithMose";
            this.menuDrawWithMose.Size = new System.Drawing.Size(166, 22);
            this.menuDrawWithMose.Text = "Draw with Mouse";
            this.menuDrawWithMose.Click += new System.EventHandler(this.menuDrawWithMose_Click);
            // 
            // menuDrawText
            // 
            this.menuDrawText.Name = "menuDrawText";
            this.menuDrawText.Size = new System.Drawing.Size(166, 22);
            this.menuDrawText.Text = "Draw Text";
            this.menuDrawText.Click += new System.EventHandler(this.menuDrawText_Click);
            // 
            // menuDrawImage
            // 
            this.menuDrawImage.Name = "menuDrawImage";
            this.menuDrawImage.Size = new System.Drawing.Size(166, 22);
            this.menuDrawImage.Text = "Draw Image";
            this.menuDrawImage.Click += new System.EventHandler(this.menuDrawImage_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menuExit.Size = new System.Drawing.Size(166, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 492);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDrawWithMose;
        private System.Windows.Forms.ToolStripMenuItem menuDrawText;
        private System.Windows.Forms.ToolStripMenuItem menuDrawImage;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
    }
}

