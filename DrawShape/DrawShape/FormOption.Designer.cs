namespace DrawShape
{
    partial class FormOption
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdEll = new System.Windows.Forms.RadioButton();
            this.rdTri = new System.Windows.Forms.RadioButton();
            this.rdRec = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pnColorPreview = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rdLine = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdLine);
            this.groupBox1.Controls.Add(this.rdEll);
            this.groupBox1.Controls.Add(this.rdTri);
            this.groupBox1.Controls.Add(this.rdRec);
            this.groupBox1.Location = new System.Drawing.Point(98, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shape";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdEll
            // 
            this.rdEll.AutoSize = true;
            this.rdEll.Location = new System.Drawing.Point(36, 117);
            this.rdEll.Name = "rdEll";
            this.rdEll.Size = new System.Drawing.Size(69, 20);
            this.rdEll.TabIndex = 0;
            this.rdEll.TabStop = true;
            this.rdEll.Text = "Ellipse";
            this.rdEll.UseVisualStyleBackColor = true;
            // 
            // rdTri
            // 
            this.rdTri.AutoSize = true;
            this.rdTri.Location = new System.Drawing.Point(36, 79);
            this.rdTri.Name = "rdTri";
            this.rdTri.Size = new System.Drawing.Size(78, 20);
            this.rdTri.TabIndex = 0;
            this.rdTri.TabStop = true;
            this.rdTri.Text = "Triangle";
            this.rdTri.UseVisualStyleBackColor = true;
            // 
            // rdRec
            // 
            this.rdRec.AutoSize = true;
            this.rdRec.Location = new System.Drawing.Point(36, 40);
            this.rdRec.Name = "rdRec";
            this.rdRec.Size = new System.Drawing.Size(90, 20);
            this.rdRec.TabIndex = 0;
            this.rdRec.TabStop = true;
            this.rdRec.Text = "Rectangle";
            this.rdRec.UseVisualStyleBackColor = true;
            // 
            // pnColorPreview
            // 
            this.pnColorPreview.Location = new System.Drawing.Point(63, 251);
            this.pnColorPreview.Name = "pnColorPreview";
            this.pnColorPreview.Size = new System.Drawing.Size(472, 31);
            this.pnColorPreview.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(104, 322);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(136, 42);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(301, 322);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 42);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // rdLine
            // 
            this.rdLine.AutoSize = true;
            this.rdLine.Location = new System.Drawing.Point(36, 157);
            this.rdLine.Name = "rdLine";
            this.rdLine.Size = new System.Drawing.Size(53, 20);
            this.rdLine.TabIndex = 0;
            this.rdLine.TabStop = true;
            this.rdLine.Text = "Line";
            this.rdLine.UseVisualStyleBackColor = true;
            // 
            // FormOption
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(598, 395);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pnColorPreview);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormOption";
            this.Text = "FormOption";
            this.Load += new System.EventHandler(this.FormOption_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdEll;
        private System.Windows.Forms.RadioButton rdTri;
        private System.Windows.Forms.RadioButton rdRec;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel pnColorPreview;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rdLine;
    }
}