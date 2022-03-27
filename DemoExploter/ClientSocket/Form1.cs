using DTOProj;
using MyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSocket
{
    public partial class Form1 : Form
    {
        private const int portNum = 5000;

        delegate void SetTextCallback(string text);

        TcpClient client;
        NetworkStream ns;
        Thread t = null;
        //bool cauHoiMoi= false;
        string cautraloi= "0";
        int gui = 0;

        private const string hostName = "localhost";
        public Form1()
        {
            InitializeComponent();

            client = new TcpClient(hostName, portNum);

            ns = client.GetStream();

            //String s = "connected";

            //int soluongthamgia = 1;

            //byte[] byteTime = Encoding.ASCII.GetBytes(s);
            //ns.Write(byteTime, 0, byteTime.Length);

            t = new Thread(DoWork);

            t.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Tick += Timer1_Tick;
            //timer1.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timeX_Tick(sender, e);
        }
        
        int OrigTime = 15;//15s
        void timeX_Tick(object sender, EventArgs e)
        {
            OrigTime--;
            lbcountdown.Text = OrigTime / 60 + ":" + ((OrigTime % 60) >= 10 ? (OrigTime % 60).ToString() : "0" + OrigTime % 60);
            if (OrigTime <= 0)//het 10s
            {
                timer1.Enabled = false;//tat timer
                //xet xem da gui cau tra loi chua
                if(gui==0)
                {
                    byte[] byteTime = Encoding.ASCII.GetBytes(cautraloi);
                    ns.Write(byteTime, 0, byteTime.Length);//gui "0"
                    cautraloi = "0";//set lai cau tra loi khi đã gửi
                }
                gui = 1;//da gui 
                //cauHoiMoi = false;
                OrigTime = 15;//khi chayj het set lại 15s để câu sau chạy
            }
        }

        private void button1_Click_1(object sender, EventArgs e)//btn chat
        {
            string s;
            if (string.IsNullOrEmpty(txtten.Text))
            {
               s = "#Guest: " + txtchat.Text;//ky tu # danh dau dau la cau chat
            }
            else
            {
                s = "#" + txtten.Text + " :" + txtchat.Text;
            }
            byte[] byteTime = Encoding.ASCII.GetBytes(s);
            ns.Write(byteTime, 0, byteTime.Length);
        }

        // This is run as a thread

        public void DoWork()
        {

            byte[] bytes = new byte[1024];
            
            while (true)
            {
                int bytesRead = ns.Read(bytes, 0, bytes.Length);
                Question question=(Question)Utils.ByteArrayToObject(bytes);
                if (question.loai == 1)//1 la chat
                {
                    this.SetTextchat(question.chat);
                }
                else//2la cau hoi
                {
                    //MessageBox.Show("nhan.");
                    this.SetText(question.Content);
                    this.SetTextanswerA(question.DanhSachCauTraLoi[0]);
                    this.SetTextanswerb(question.DanhSachCauTraLoi[1]);
                    this.SetTextanswerC(question.DanhSachCauTraLoi[2]);
                    this.SetTextanswerD(question.DanhSachCauTraLoi[3]);
                    gui = 0;
                }
                //MessageBox.Show(Encoding.ASCII.GetString(bytes, 0, bytesRead));
                
            }
        }
        private void SetTextchat(string text)
        {
            // InvokeRequired required compares the thread ID of the

            // calling thread to the thread ID of the creating thread.

            // If these threads are different, it returns true.

            if (this.textBox1.InvokeRequired)

            {

                SetTextCallback d = new SetTextCallback(SetTextchat);

                this.Invoke(d, new object[] { text });

            }

            else
            {
                this.txthienchat.Text = text;              
            }

        }
        private void SetText(string text)

        {

            // InvokeRequired required compares the thread ID of the

            // calling thread to the thread ID of the creating thread.

            // If these threads are different, it returns true.

            if (this.textBox1.InvokeRequired)

            {

                SetTextCallback d = new SetTextCallback(SetText);

                this.Invoke(d, new object[] { text });

            }

            else

            {

                this.textBox1.Text =  text;
                timer1.Enabled = true;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }

        }

        private void SetTextanswerA(string text)

        {

            // InvokeRequired required compares the thread ID of the

            // calling thread to the thread ID of the creating thread.

            // If these threads are different, it returns true.

            if (this.labelA.InvokeRequired)

            {

                SetTextCallback d = new SetTextCallback(SetTextanswerA);

                this.Invoke(d, new object[] { text });

            }

            else

            {
                
                this.labelA.Text = text;

            }

        }
        private void SetTextanswerC(string text)

        {

            // InvokeRequired required compares the thread ID of the

            // calling thread to the thread ID of the creating thread.

            // If these threads are different, it returns true.

            if (this.labelA.InvokeRequired)

            {

                SetTextCallback d = new SetTextCallback(SetTextanswerC);

                this.Invoke(d, new object[] { text });

            }

            else

            {

                this.labelC.Text = text;

            }

        }
        private void SetTextanswerD(string text)

        {

            // InvokeRequired required compares the thread ID of the

            // calling thread to the thread ID of the creating thread.

            // If these threads are different, it returns true.

            if (this.labelA.InvokeRequired)

            {

                SetTextCallback d = new SetTextCallback(SetTextanswerD);

                this.Invoke(d, new object[] { text });

            }

            else

            {

                this.labelD.Text = text;

            }

        }
        private void SetTextanswerb(string text)

        {

            // InvokeRequired required compares the thread ID of the

            // calling thread to the thread ID of the creating thread.

            // If these threads are different, it returns true.

            if (this.labelB.InvokeRequired)

            {

                SetTextCallback d = new SetTextCallback(SetTextanswerb);

                this.Invoke(d, new object[] { text });

            }

            else

            {
                this.labelB.Text = text;
            }

        }

        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //if (cauHoiMoi == false) return;
            RadioButton radio = sender as RadioButton;
            if (radio.Checked)
            {
                cautraloi = radio.Text; //khi click chọn đáp án              
            }
            //cauHoiMoi = false;
          
        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            if (gui == 0)
            {
                if (!string.IsNullOrEmpty(cautraloi))//chua het time và chưa chon đáp án mà click bừa->co click roi moi gửi
                {
                    byte[] byteTime = Encoding.ASCII.GetBytes(cautraloi);
                    ns.Write(byteTime, 0, byteTime.Length);//gửi đc
                    gui = 1;// khi nào gửi đc mới không gửi đc lần 2
                    cautraloi = "0";//set lai cau tra loi khi đã gửi
                    timer1.Enabled = false;
                    OrigTime = 15;
                    lbcountdown.Text = "00:00";
                }
            }
            else
                MessageBox.Show("Chỉ được gửi 1 lần", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Red, ButtonBorderStyle.Dotted);
        }
    }
}
