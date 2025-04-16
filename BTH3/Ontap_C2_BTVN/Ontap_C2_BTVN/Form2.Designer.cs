namespace Ontap_C2_BTVN
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSopt = new System.Windows.Forms.TextBox();
            this.btCreate = new System.Windows.Forms.Button();
            this.btSort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHonHop = new System.Windows.Forms.TextBox();
            this.txtDao = new System.Windows.Forms.TextBox();
            this.txtGiam = new System.Windows.Forms.TextBox();
            this.txtTang = new System.Windows.Forms.TextBox();
            this.txtBanDau = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(85, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phần tử:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSopt
            // 
            this.txtSopt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSopt.Location = new System.Drawing.Point(229, 24);
            this.txtSopt.Name = "txtSopt";
            this.txtSopt.Size = new System.Drawing.Size(114, 41);
            this.txtSopt.TabIndex = 1;
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(455, 23);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(234, 43);
            this.btCreate.TabIndex = 2;
            this.btCreate.Text = "Tạo mảng ngẫu nhiên";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // btSort
            // 
            this.btSort.Location = new System.Drawing.Point(730, 23);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(203, 43);
            this.btSort.TabIndex = 2;
            this.btSort.Text = "Sắp xếp";
            this.btSort.UseVisualStyleBackColor = true;
            this.btSort.Click += new System.EventHandler(this.btSort_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(27, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mảng ban đầu:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(27, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mảng tăng:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(27, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mảng giảm:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(27, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mảng đảo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(27, 530);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 36);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mảng chẵn tăng, lẻ giảm:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHonHop
            // 
            this.txtHonHop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHonHop.Location = new System.Drawing.Point(270, 528);
            this.txtHonHop.Name = "txtHonHop";
            this.txtHonHop.Size = new System.Drawing.Size(660, 41);
            this.txtHonHop.TabIndex = 1;
            // 
            // txtDao
            // 
            this.txtDao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDao.Location = new System.Drawing.Point(270, 420);
            this.txtDao.Name = "txtDao";
            this.txtDao.Size = new System.Drawing.Size(660, 41);
            this.txtDao.TabIndex = 1;
            // 
            // txtGiam
            // 
            this.txtGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiam.Location = new System.Drawing.Point(270, 312);
            this.txtGiam.Name = "txtGiam";
            this.txtGiam.Size = new System.Drawing.Size(660, 41);
            this.txtGiam.TabIndex = 1;
            // 
            // txtTang
            // 
            this.txtTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTang.Location = new System.Drawing.Point(270, 204);
            this.txtTang.Name = "txtTang";
            this.txtTang.Size = new System.Drawing.Size(660, 41);
            this.txtTang.TabIndex = 1;
            // 
            // txtBanDau
            // 
            this.txtBanDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanDau.Location = new System.Drawing.Point(270, 96);
            this.txtBanDau.Name = "txtBanDau";
            this.txtBanDau.Size = new System.Drawing.Size(660, 41);
            this.txtBanDau.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.btSort);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.txtBanDau);
            this.Controls.Add(this.txtTang);
            this.Controls.Add(this.txtGiam);
            this.Controls.Add(this.txtDao);
            this.Controls.Add(this.txtHonHop);
            this.Controls.Add(this.txtSopt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "     Sắp xếp mảng";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSopt;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Button btSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHonHop;
        private System.Windows.Forms.TextBox txtDao;
        private System.Windows.Forms.TextBox txtGiam;
        private System.Windows.Forms.TextBox txtTang;
        private System.Windows.Forms.TextBox txtBanDau;
    }
}