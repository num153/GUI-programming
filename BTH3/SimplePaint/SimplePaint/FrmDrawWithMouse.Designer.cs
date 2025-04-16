namespace SimplePaint
{
    partial class FrmDrawWithMouse
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
            this.SuspendLayout();
            // 
            // FrmDrawWithMouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.DoubleBuffered = true;
            this.Name = "FrmDrawWithMouse";
            this.Text = "FrmDrawWithMouse";
            this.Load += new System.EventHandler(this.FrmDrawWithMouse_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmDrawWithMouse_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmDrawWithMouse_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmDrawWithMouse_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmDrawWithMouse_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
    }
}