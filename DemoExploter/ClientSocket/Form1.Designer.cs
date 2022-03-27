namespace ClientSocket
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtchat = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbcountdown = new System.Windows.Forms.Label();
            this.btndongy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txthienchat = new System.Windows.Forms.RichTextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.labelC = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("VNI-Viettay", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(563, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Chat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtchat
            // 
            this.txtchat.Location = new System.Drawing.Point(388, 383);
            this.txtchat.Name = "txtchat";
            this.txtchat.Size = new System.Drawing.Size(396, 20);
            this.txtchat.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(572, 169);
            this.textBox1.TabIndex = 3;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(12, 221);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(36, 21);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "A";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(12, 256);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(36, 21);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "B";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.BackColor = System.Drawing.Color.Yellow;
            this.labelA.Location = new System.Drawing.Point(56, 223);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(16, 13);
            this.labelA.TabIndex = 11;
            this.labelA.Text = "...";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.BackColor = System.Drawing.Color.Yellow;
            this.labelB.Location = new System.Drawing.Point(56, 259);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(16, 13);
            this.labelB.TabIndex = 12;
            this.labelB.Text = "...";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // lbcountdown
            // 
            this.lbcountdown.AutoSize = true;
            this.lbcountdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbcountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcountdown.Location = new System.Drawing.Point(370, 7);
            this.lbcountdown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcountdown.Name = "lbcountdown";
            this.lbcountdown.Size = new System.Drawing.Size(67, 31);
            this.lbcountdown.TabIndex = 13;
            this.lbcountdown.Text = "0:00";
            // 
            // btndongy
            // 
            this.btndongy.BackColor = System.Drawing.Color.Red;
            this.btndongy.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndongy.ForeColor = System.Drawing.Color.Blue;
            this.btndongy.Location = new System.Drawing.Point(198, 256);
            this.btndongy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndongy.Name = "btndongy";
            this.btndongy.Size = new System.Drawing.Size(99, 63);
            this.btndongy.TabIndex = 14;
            this.btndongy.Text = "Gửi";
            this.btndongy.UseVisualStyleBackColor = false;
            this.btndongy.Click += new System.EventHandler(this.btndongy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 383);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tên:";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(160, 383);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(138, 20);
            this.txtten.TabIndex = 18;
            // 
            // txthienchat
            // 
            this.txthienchat.BackColor = System.Drawing.Color.MistyRose;
            this.txthienchat.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txthienchat.Location = new System.Drawing.Point(388, 241);
            this.txthienchat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txthienchat.Name = "txthienchat";
            this.txthienchat.Size = new System.Drawing.Size(396, 129);
            this.txthienchat.TabIndex = 19;
            this.txthienchat.Text = "";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(12, 292);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(36, 21);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "C";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(12, 324);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(37, 21);
            this.radioButton3.TabIndex = 21;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "D";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.BackColor = System.Drawing.Color.Yellow;
            this.labelC.Location = new System.Drawing.Point(56, 295);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(16, 13);
            this.labelC.TabIndex = 22;
            this.labelC.Text = "...";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.BackColor = System.Drawing.Color.Yellow;
            this.labelD.Location = new System.Drawing.Point(56, 324);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(16, 13);
            this.labelD.TabIndex = 23;
            this.labelD.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(391, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Chat:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ClientSocket.Properties.Resources.frnxxym1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(589, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 168);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.txthienchat);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndongy);
            this.Controls.Add(this.lbcountdown);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtchat);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtchat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbcountdown;
        private System.Windows.Forms.Button btndongy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.RichTextBox txthienchat;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

