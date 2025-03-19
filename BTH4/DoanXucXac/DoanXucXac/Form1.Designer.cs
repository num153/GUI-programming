namespace DoanXucXac
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.picChoose = new System.Windows.Forms.PictureBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbCount = new System.Windows.Forms.Label();
            this.lbWin = new System.Windows.Forms.Label();
            this.lbLose = new System.Windows.Forms.Label();
            this.lsResult = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChoose)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn6);
            this.groupBox1.Controls.Add(this.btn3);
            this.groupBox1.Controls.Add(this.btn5);
            this.groupBox1.Controls.Add(this.btn4);
            this.groupBox1.Controls.Add(this.btn2);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Controls.Add(this.picChoose);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Brown;
            this.groupBox1.Location = new System.Drawing.Point(15, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bạn Đoán Số:";
            // 
            // picChoose
            // 
            this.picChoose.Location = new System.Drawing.Point(64, 51);
            this.picChoose.Name = "picChoose";
            this.picChoose.Size = new System.Drawing.Size(112, 89);
            this.picChoose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChoose.TabIndex = 0;
            this.picChoose.TabStop = false;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(6, 41);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(36, 39);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.toolTip1.SetToolTip(this.btn1, "Chọn một nút để đoán số bro!");
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(6, 86);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(36, 39);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.toolTip1.SetToolTip(this.btn2, "Chọn một nút để đoán số bro!");
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(6, 131);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(36, 39);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "3";
            this.toolTip1.SetToolTip(this.btn3, "Chọn một nút để đoán số bro!");
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(196, 41);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(36, 39);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(196, 86);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(36, 39);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(196, 131);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(36, 39);
            this.btn6.TabIndex = 1;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnPlay);
            this.groupBox2.Controls.Add(this.picResult);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Brown;
            this.groupBox2.Location = new System.Drawing.Point(15, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 184);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quay Số (random):";
            // 
            // picResult
            // 
            this.picResult.Location = new System.Drawing.Point(64, 40);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(112, 89);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResult.TabIndex = 0;
            this.picResult.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(6, 146);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(95, 32);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Enter";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(157, 146);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 32);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Esc";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbLose);
            this.groupBox3.Controls.Add(this.lbWin);
            this.groupBox3.Controls.Add(this.lbCount);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox3.Location = new System.Drawing.Point(21, 447);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 124);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thống Kê:";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCount.ForeColor = System.Drawing.Color.Blue;
            this.lbCount.Location = new System.Drawing.Point(6, 36);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(117, 24);
            this.lbCount.TabIndex = 0;
            this.lbCount.Text = "Số lần đoán:";
            // 
            // lbWin
            // 
            this.lbWin.AutoSize = true;
            this.lbWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWin.ForeColor = System.Drawing.Color.Red;
            this.lbWin.Location = new System.Drawing.Point(6, 60);
            this.lbWin.Name = "lbWin";
            this.lbWin.Size = new System.Drawing.Size(98, 24);
            this.lbWin.TabIndex = 0;
            this.lbWin.Text = "Lần thắng:";
            // 
            // lbLose
            // 
            this.lbLose.AutoSize = true;
            this.lbLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLose.ForeColor = System.Drawing.Color.Black;
            this.lbLose.Location = new System.Drawing.Point(6, 84);
            this.lbLose.Name = "lbLose";
            this.lbLose.Size = new System.Drawing.Size(87, 24);
            this.lbLose.TabIndex = 0;
            this.lbLose.Text = "Lần thua:";
            // 
            // lsResult
            // 
            this.lsResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsResult.FormattingEnabled = true;
            this.lsResult.ItemHeight = 20;
            this.lsResult.Location = new System.Drawing.Point(373, 21);
            this.lsResult.Name = "lsResult";
            this.lsResult.Size = new System.Drawing.Size(316, 544);
            this.lsResult.TabIndex = 2;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Tooltip Đoán Số";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 583);
            this.Controls.Add(this.lsResult);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picChoose)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.PictureBox picChoose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label lbLose;
        private System.Windows.Forms.Label lbWin;
        private System.Windows.Forms.ListBox lsResult;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

