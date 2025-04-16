namespace Ontap_C2_BTVN
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChuoi1 = new System.Windows.Forms.TextBox();
            this.txtChuoi2 = new System.Windows.Forms.TextBox();
            this.txtChuoi3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btChen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIndexChen = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btSub = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCharSub = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIndexSub = new System.Windows.Forms.TextBox();
            this.btKhoiPhuc = new System.Windows.Forms.Button();
            this.btReplace = new System.Windows.Forms.Button();
            this.btReverse = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btChuanHoa = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(0, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(1161, 62);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Chương trình minh họa xử lý chuỗi";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(51, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chuỗi 1:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(51, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chuỗi 2:";
            // 
            // txtChuoi1
            // 
            this.txtChuoi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuoi1.Location = new System.Drawing.Point(162, 114);
            this.txtChuoi1.Name = "txtChuoi1";
            this.txtChuoi1.Size = new System.Drawing.Size(957, 41);
            this.txtChuoi1.TabIndex = 2;
            // 
            // txtChuoi2
            // 
            this.txtChuoi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuoi2.Location = new System.Drawing.Point(162, 204);
            this.txtChuoi2.Name = "txtChuoi2";
            this.txtChuoi2.Size = new System.Drawing.Size(385, 41);
            this.txtChuoi2.TabIndex = 2;
            // 
            // txtChuoi3
            // 
            this.txtChuoi3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuoi3.Location = new System.Drawing.Point(734, 204);
            this.txtChuoi3.Name = "txtChuoi3";
            this.txtChuoi3.Size = new System.Drawing.Size(385, 41);
            this.txtChuoi3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(602, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 33);
            this.label5.TabIndex = 1;
            this.label5.Text = "Chuỗi 3:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btChen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIndexChen);
            this.groupBox1.Location = new System.Drawing.Point(56, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 108);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chèn chuỗi s2 vào s1";
            // 
            // btChen
            // 
            this.btChen.Location = new System.Drawing.Point(305, 38);
            this.btChen.Name = "btChen";
            this.btChen.Size = new System.Drawing.Size(112, 41);
            this.btChen.TabIndex = 3;
            this.btChen.Text = "Chèn";
            this.btChen.UseVisualStyleBackColor = true;
            this.btChen.Click += new System.EventHandler(this.btChen_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(29, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 33);
            this.label4.TabIndex = 1;
            this.label4.Text = "Vị trí chèn:";
            // 
            // txtIndexChen
            // 
            this.txtIndexChen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndexChen.Location = new System.Drawing.Point(149, 42);
            this.txtIndexChen.Name = "txtIndexChen";
            this.txtIndexChen.Size = new System.Drawing.Size(112, 41);
            this.txtIndexChen.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btSub);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCharSub);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtIndexSub);
            this.groupBox2.Location = new System.Drawing.Point(56, 449);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(709, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lấy chuỗi con trong s1";
            // 
            // btSub
            // 
            this.btSub.Location = new System.Drawing.Point(470, 37);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(181, 41);
            this.btSub.TabIndex = 3;
            this.btSub.Text = "Lấy chuỗi con";
            this.btSub.UseVisualStyleBackColor = true;
            this.btSub.Click += new System.EventHandler(this.btSub_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(223, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 33);
            this.label7.TabIndex = 1;
            this.label7.Text = "Số ký tự:";
            // 
            // txtCharSub
            // 
            this.txtCharSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharSub.Location = new System.Drawing.Point(325, 37);
            this.txtCharSub.Name = "txtCharSub";
            this.txtCharSub.Size = new System.Drawing.Size(88, 41);
            this.txtCharSub.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(19, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 33);
            this.label6.TabIndex = 1;
            this.label6.Text = "Từ vị trí:";
            // 
            // txtIndexSub
            // 
            this.txtIndexSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndexSub.Location = new System.Drawing.Point(106, 37);
            this.txtIndexSub.Name = "txtIndexSub";
            this.txtIndexSub.Size = new System.Drawing.Size(88, 41);
            this.txtIndexSub.TabIndex = 2;
            // 
            // btKhoiPhuc
            // 
            this.btKhoiPhuc.Location = new System.Drawing.Point(879, 466);
            this.btKhoiPhuc.Name = "btKhoiPhuc";
            this.btKhoiPhuc.Size = new System.Drawing.Size(182, 67);
            this.btKhoiPhuc.TabIndex = 3;
            this.btKhoiPhuc.Text = "Khôi phục";
            this.btKhoiPhuc.UseVisualStyleBackColor = true;
            this.btKhoiPhuc.Click += new System.EventHandler(this.btKhoiPhuc_Click);
            // 
            // btReplace
            // 
            this.btReplace.Location = new System.Drawing.Point(597, 296);
            this.btReplace.Name = "btReplace";
            this.btReplace.Size = new System.Drawing.Size(225, 41);
            this.btReplace.TabIndex = 3;
            this.btReplace.Text = "Thay thế s2 bằng s3";
            this.btReplace.UseVisualStyleBackColor = true;
            this.btReplace.Click += new System.EventHandler(this.btReplace_Click);
            // 
            // btReverse
            // 
            this.btReverse.Location = new System.Drawing.Point(879, 296);
            this.btReverse.Name = "btReverse";
            this.btReverse.Size = new System.Drawing.Size(225, 41);
            this.btReverse.TabIndex = 3;
            this.btReverse.Text = "Đảo từ trong s1";
            this.btReverse.UseVisualStyleBackColor = true;
            this.btReverse.Click += new System.EventHandler(this.btReverse_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(597, 365);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(225, 41);
            this.btDel.TabIndex = 3;
            this.btDel.Text = "Xóa s2 trong s1";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btChuanHoa
            // 
            this.btChuanHoa.Location = new System.Drawing.Point(879, 365);
            this.btChuanHoa.Name = "btChuanHoa";
            this.btChuanHoa.Size = new System.Drawing.Size(225, 41);
            this.btChuanHoa.TabIndex = 3;
            this.btChuanHoa.Text = "Chuẩn hóa chuỗi";
            this.btChuanHoa.UseVisualStyleBackColor = true;
            this.btChuanHoa.Click += new System.EventHandler(this.btChuanHoa_Click);
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
            this.ClientSize = new System.Drawing.Size(1161, 618);
            this.Controls.Add(this.btReverse);
            this.Controls.Add(this.btChuanHoa);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btReplace);
            this.Controls.Add(this.btKhoiPhuc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtChuoi3);
            this.Controls.Add(this.txtChuoi2);
            this.Controls.Add(this.txtChuoi1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xử lý chuỗi";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChuoi1;
        private System.Windows.Forms.TextBox txtChuoi2;
        private System.Windows.Forms.TextBox txtChuoi3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btChen;
        private System.Windows.Forms.TextBox txtIndexChen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIndexSub;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCharSub;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Button btKhoiPhuc;
        private System.Windows.Forms.Button btReplace;
        private System.Windows.Forms.Button btReverse;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btChuanHoa;
        private System.Windows.Forms.Timer timer1;
    }
}

