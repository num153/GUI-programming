namespace PhotoAlbum
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeFolder = new System.Windows.Forms.TreeView();
            this.picView = new System.Windows.Forms.PictureBox();
            this.pnThum = new System.Windows.Forms.FlowLayoutPanel();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picView)).BeginInit();
            this.SuspendLayout();
            // 
            // treeFolder
            // 
            this.treeFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeFolder.ImageIndex = 0;
            this.treeFolder.ImageList = this.imgList;
            this.treeFolder.Location = new System.Drawing.Point(12, 21);
            this.treeFolder.Name = "treeFolder";
            this.treeFolder.SelectedImageIndex = 0;
            this.treeFolder.Size = new System.Drawing.Size(289, 471);
            this.treeFolder.TabIndex = 0;
            this.treeFolder.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.treeFolder_AfterCollapse);
            this.treeFolder.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeFolder_BeforeExpand);
            this.treeFolder.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeFolder_AfterExpand);
            this.treeFolder.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeFolder_AfterSelect);
            // 
            // picView
            // 
            this.picView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picView.Location = new System.Drawing.Point(308, 33);
            this.picView.Name = "picView";
            this.picView.Size = new System.Drawing.Size(436, 294);
            this.picView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picView.TabIndex = 1;
            this.picView.TabStop = false;
            // 
            // pnThum
            // 
            this.pnThum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnThum.AutoScroll = true;
            this.pnThum.BackColor = System.Drawing.SystemColors.Info;
            this.pnThum.Location = new System.Drawing.Point(307, 333);
            this.pnThum.Name = "pnThum";
            this.pnThum.Size = new System.Drawing.Size(436, 159);
            this.pnThum.TabIndex = 2;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "disk.png");
            this.imgList.Images.SetKeyName(1, "folder.png");
            this.imgList.Images.SetKeyName(2, "open.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 516);
            this.Controls.Add(this.pnThum);
            this.Controls.Add(this.picView);
            this.Controls.Add(this.treeFolder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeFolder;
        private System.Windows.Forms.PictureBox picView;
        private System.Windows.Forms.FlowLayoutPanel pnThum;
        private System.Windows.Forms.ImageList imgList;
    }
}

