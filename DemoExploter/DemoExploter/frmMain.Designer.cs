namespace DemoExploter
{
    partial class frmMain
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
            this.rtbNoiDung = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbcountdownsv = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbketqua = new System.Windows.Forms.Label();
            this.labellive = new System.Windows.Forms.Label();
            this.timerreal = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxChat = new System.Windows.Forms.TextBox();
            this.btnchat = new System.Windows.Forms.Button();
            this.txthienchat = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.thongkeclick = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbNoiDung
            // 
            this.rtbNoiDung.BackColor = System.Drawing.Color.PaleTurquoise;
            this.rtbNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNoiDung.Location = new System.Drawing.Point(10, 188);
            this.rtbNoiDung.Name = "rtbNoiDung";
            this.rtbNoiDung.ReadOnly = true;
            this.rtbNoiDung.Size = new System.Drawing.Size(557, 133);
            this.rtbNoiDung.TabIndex = 0;
            this.rtbNoiDung.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox2.Location = new System.Drawing.Point(10, 416);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(559, 103);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(129, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(293, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 48);
            this.button2.TabIndex = 7;
            this.button2.Text = "Hint";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(10, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 48);
            this.button3.TabIndex = 8;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox3.Location = new System.Drawing.Point(583, 41);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(387, 140);
            this.textBox3.TabIndex = 12;
            // 
            // lbcountdownsv
            // 
            this.lbcountdownsv.AutoSize = true;
            this.lbcountdownsv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbcountdownsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcountdownsv.Location = new System.Drawing.Point(428, 133);
            this.lbcountdownsv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcountdownsv.Name = "lbcountdownsv";
            this.lbcountdownsv.Size = new System.Drawing.Size(80, 37);
            this.lbcountdownsv.TabIndex = 14;
            this.lbcountdownsv.Text = "0:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Fuchsia;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(439, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Time";
            // 
            // lbketqua
            // 
            this.lbketqua.AutoSize = true;
            this.lbketqua.BackColor = System.Drawing.Color.Fuchsia;
            this.lbketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbketqua.Location = new System.Drawing.Point(9, 323);
            this.lbketqua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbketqua.Name = "lbketqua";
            this.lbketqua.Size = new System.Drawing.Size(70, 24);
            this.lbketqua.TabIndex = 17;
            this.lbketqua.Text = "Đáp án";
            // 
            // labellive
            // 
            this.labellive.AutoSize = true;
            this.labellive.BackColor = System.Drawing.Color.Red;
            this.labellive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellive.Location = new System.Drawing.Point(10, 168);
            this.labellive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labellive.Name = "labellive";
            this.labellive.Size = new System.Drawing.Size(42, 17);
            this.labellive.TabIndex = 18;
            this.labellive.Text = "Live: ";
            this.labellive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerreal
            // 
            this.timerreal.Interval = 500;
            this.timerreal.Tick += new System.EventHandler(this.timerreal_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::DemoExploter.Properties.Resources.avt;
            this.pictureBox1.Location = new System.Drawing.Point(164, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 181);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(410, 362);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 48);
            this.button5.TabIndex = 21;
            this.button5.Text = "End Game";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBoxChat
            // 
            this.textBoxChat.Location = new System.Drawing.Point(583, 416);
            this.textBoxChat.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxChat.Name = "textBoxChat";
            this.textBoxChat.Size = new System.Drawing.Size(385, 20);
            this.textBoxChat.TabIndex = 22;
            // 
            // btnchat
            // 
            this.btnchat.BackColor = System.Drawing.Color.Yellow;
            this.btnchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchat.Location = new System.Drawing.Point(690, 448);
            this.btnchat.Name = "btnchat";
            this.btnchat.Size = new System.Drawing.Size(149, 33);
            this.btnchat.TabIndex = 23;
            this.btnchat.Text = "Chat";
            this.btnchat.UseVisualStyleBackColor = false;
            this.btnchat.Click += new System.EventHandler(this.btnchat_Click);
            // 
            // txthienchat
            // 
            this.txthienchat.BackColor = System.Drawing.Color.MistyRose;
            this.txthienchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthienchat.Location = new System.Drawing.Point(583, 188);
            this.txthienchat.Name = "txthienchat";
            this.txthienchat.ReadOnly = true;
            this.txthienchat.Size = new System.Drawing.Size(385, 216);
            this.txthienchat.TabIndex = 24;
            this.txthienchat.Text = "";
            this.txthienchat.TextChanged += new System.EventHandler(this.txthienchat_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Fuchsia;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(580, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Thống kê:";
            // 
            // thongkeclick
            // 
            this.thongkeclick.Location = new System.Drawing.Point(678, 12);
            this.thongkeclick.Name = "thongkeclick";
            this.thongkeclick.Size = new System.Drawing.Size(75, 23);
            this.thongkeclick.TabIndex = 26;
            this.thongkeclick.Text = "thong kecli";
            this.thongkeclick.UseVisualStyleBackColor = true;
            //this.thongkeclick.Click += new System.EventHandler(this.thongkeclick_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(976, 529);
            this.Controls.Add(this.thongkeclick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txthienchat);
            this.Controls.Add(this.btnchat);
            this.Controls.Add(this.textBoxChat);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labellive);
            this.Controls.Add(this.lbketqua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbcountdownsv);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.rtbNoiDung);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbNoiDung;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbcountdownsv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbketqua;
        private System.Windows.Forms.Label labellive;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerreal;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBoxChat;
        private System.Windows.Forms.Button btnchat;
        private System.Windows.Forms.RichTextBox txthienchat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button thongkeclick;
    }
}