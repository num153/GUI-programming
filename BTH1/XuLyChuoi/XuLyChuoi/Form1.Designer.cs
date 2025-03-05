namespace XuLyChuoi
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
            this.lbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtS1 = new System.Windows.Forms.TextBox();
            this.txtS2 = new System.Windows.Forms.TextBox();
            this.txtS3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btInsert = new System.Windows.Forms.Button();
            this.txtViTriChen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btSubString = new System.Windows.Forms.Button();
            this.txtSoKiTu = new System.Windows.Forms.TextBox();
            this.txtVitri = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btReplace = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btReverse = new System.Windows.Forms.Button();
            this.btChuanHoa = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.MediumPurple;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbName.Location = new System.Drawing.Point(0, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(863, 63);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "CHƯƠNG TRÌNH MINH HỌA XỬ LÝ CHUỖI";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chuỗi s1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chuỗi s2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chuỗi s3:";
            // 
            // txtS1
            // 
            this.txtS1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtS1.Location = new System.Drawing.Point(132, 96);
            this.txtS1.Name = "txtS1";
            this.txtS1.Size = new System.Drawing.Size(641, 31);
            this.txtS1.TabIndex = 2;
            // 
            // txtS2
            // 
            this.txtS2.Location = new System.Drawing.Point(132, 143);
            this.txtS2.Name = "txtS2";
            this.txtS2.Size = new System.Drawing.Size(295, 31);
            this.txtS2.TabIndex = 3;
            // 
            // txtS3
            // 
            this.txtS3.Location = new System.Drawing.Point(542, 140);
            this.txtS3.Name = "txtS3";
            this.txtS3.Size = new System.Drawing.Size(309, 31);
            this.txtS3.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btInsert);
            this.groupBox1.Controls.Add(this.txtViTriChen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(31, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 83);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chèn chuỗi s2 vào s1";
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(196, 34);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(84, 35);
            this.btInsert.TabIndex = 2;
            this.btInsert.Text = "chèn";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // txtViTriChen
            // 
            this.txtViTriChen.Location = new System.Drawing.Point(117, 38);
            this.txtViTriChen.Name = "txtViTriChen";
            this.txtViTriChen.Size = new System.Drawing.Size(59, 31);
            this.txtViTriChen.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Vị trí chèn:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btSubString);
            this.groupBox2.Controls.Add(this.txtSoKiTu);
            this.groupBox2.Controls.Add(this.txtVitri);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(31, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 87);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lấy chuỗi con trong s1";
            // 
            // btSubString
            // 
            this.btSubString.Location = new System.Drawing.Point(331, 42);
            this.btSubString.Name = "btSubString";
            this.btSubString.Size = new System.Drawing.Size(193, 35);
            this.btSubString.TabIndex = 2;
            this.btSubString.Text = "Lấy chuỗi con";
            this.btSubString.UseVisualStyleBackColor = true;
            this.btSubString.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtSoKiTu
            // 
            this.txtSoKiTu.Location = new System.Drawing.Point(261, 47);
            this.txtSoKiTu.Name = "txtSoKiTu";
            this.txtSoKiTu.Size = new System.Drawing.Size(50, 31);
            this.txtSoKiTu.TabIndex = 1;
            this.txtSoKiTu.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtVitri
            // 
            this.txtVitri.Location = new System.Drawing.Point(101, 47);
            this.txtVitri.Name = "txtVitri";
            this.txtVitri.Size = new System.Drawing.Size(52, 31);
            this.txtVitri.TabIndex = 1;
            this.txtVitri.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số ký tự:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Từ vị trí:";
            // 
            // btReplace
            // 
            this.btReplace.Location = new System.Drawing.Point(374, 240);
            this.btReplace.Name = "btReplace";
            this.btReplace.Size = new System.Drawing.Size(222, 35);
            this.btReplace.TabIndex = 8;
            this.btReplace.Text = "Thay thế s2 bằng s3";
            this.btReplace.UseVisualStyleBackColor = true;
            this.btReplace.Click += new System.EventHandler(this.btReplace_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(374, 299);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(215, 35);
            this.btDelete.TabIndex = 8;
            this.btDelete.Text = "Xóa s2 trong s1";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btReverse
            // 
            this.btReverse.Location = new System.Drawing.Point(624, 241);
            this.btReverse.Name = "btReverse";
            this.btReverse.Size = new System.Drawing.Size(215, 35);
            this.btReverse.TabIndex = 8;
            this.btReverse.Text = "Đảo từ trong s1";
            this.btReverse.UseVisualStyleBackColor = true;
            this.btReverse.Click += new System.EventHandler(this.btReverse_Click);
            // 
            // btChuanHoa
            // 
            this.btChuanHoa.Location = new System.Drawing.Point(624, 299);
            this.btChuanHoa.Name = "btChuanHoa";
            this.btChuanHoa.Size = new System.Drawing.Size(215, 35);
            this.btChuanHoa.TabIndex = 8;
            this.btChuanHoa.Text = "Chuẩn hóa chuỗi";
            this.btChuanHoa.UseVisualStyleBackColor = true;
            this.btChuanHoa.Click += new System.EventHandler(this.btChuanHoa_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(624, 377);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(145, 35);
            this.btReset.TabIndex = 8;
            this.btReset.Text = "Khôi phục";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 490);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btChuanHoa);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btReverse);
            this.Controls.Add(this.btReplace);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtS3);
            this.Controls.Add(this.txtS2);
            this.Controls.Add(this.txtS1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtS1;
        private System.Windows.Forms.TextBox txtS2;
        private System.Windows.Forms.TextBox txtS3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.TextBox txtViTriChen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSoKiTu;
        private System.Windows.Forms.TextBox txtVitri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btSubString;
        private System.Windows.Forms.Button btReplace;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btReverse;
        private System.Windows.Forms.Button btChuanHoa;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Timer timer1;
    }
}

