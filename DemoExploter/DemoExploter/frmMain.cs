using DTOProj;
using MyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace DemoExploter
{
    public enum GAMESHOW_STATE
    {
        GAMESHOW_START,
        GAMESHOW_INPROCESS,
        GAMESHOW_PENDING,
        GAMESHOW_END
    }
    public partial class frmMain : Form
    {
        delegate void SetTextCallback(string text);
        TcpListener listener;
        TcpClient[] client = new TcpClient[50];
        NetworkStream[] ns = new NetworkStream[50];
        static int hangclient1 = 0, hangclient2 = 0, hangclient3 = 0,
        hangclientIndex1 = -1, hangclientIndex2 = -1, hangclientIndex3 = -1;

        int countListClient = -1, countListNetworkStream = -1;
        //thong ke
        static int tongA = 0, tongB = 0,tongC = 0,tongD = 0, tong0 = 0, countAswer = 0, cauHoiHientai = -1;
        static string chatuser ;
        string allchat;

        Question curQuestion = null;
        int questionNum = -1;

        Thread t = null;
        public frmMain()
        {
            InitializeComponent();
           // this.Paint += new PaintEventHandler(UserControl1_Paint);
            //this.Resize += new EventHandler(UserControl1_Resize);

        }


        string duongDan = "D:\\ds.txt";

        static List<Question> lstQuestions = new List<Question>();
        private void LayDanhSachCauHoi()
        {
            StreamReader sr = new StreamReader(duongDan);

            string line = null;
            Question cauHoi = null;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.StartsWith("@"))
                {
                    cauHoi = new Question();
                    cauHoi.Content = line.Substring(1);
                    cauHoi.loai = 2;
                    cauHoi.chat = "";
                }
                if (line.StartsWith("&"))
                {
                    cauHoi.DanhSachCauTraLoi.Add(line.Substring(1));
                }
                if (line.StartsWith("#"))
                {
                    cauHoi.Answer = line.Substring(1);

                    //lstQuestions.Add(cauHoi);
                }
                if (line.StartsWith("!"))
                {
                    cauHoi.hint = line.Substring(1);
                    lstQuestions.Add(cauHoi);
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            t = new Thread(DoWork);
            t.Start();
            timerreal.Start();
            LayDanhSachCauHoi();
        }

        public void DoWork()
        {
            byte[] bytes1 = new byte[1024];
            listener = new TcpListener(IPAddress.Any, 5000);
            listener.Start();

            while (true)
            {            
                countListClient++;
                countListNetworkStream++;
                // hangClient[countListClient] = 0;
                client[countListClient] = listener.AcceptTcpClient();
                HandleClinet clientThead = new HandleClinet();
                ns[countListNetworkStream] = client[countListClient].GetStream();
                clientThead.StartClient(client[countListClient], ns[countListNetworkStream],
                    ref tongA, ref tongB,ref tongC,ref tongD, ref tong0,ref hangclient1, ref hangclient2, ref hangclient3,
                    ref hangclientIndex1, ref hangclientIndex2, ref hangclientIndex3, ref countAswer,
                    countListClient + 1,ref chatuser);
            }
            //clientSocket.Close();
            //serverSocket.Stop();
        }
       
        public class HandleClinet
        {
            TcpClient clientSocket;

            public void StartClient(TcpClient inClientSocket, NetworkStream idNetworkStream, ref int tongA,
                ref int tongB,ref int tongC,ref int tongD, ref int tong0,ref int hangclient1, ref int hangclient2, ref int hangclient3,
                ref int hangclientIndex1, ref int hangclientIndex2, ref int hangclientIndex3, ref int countAswer,
                int numberClient,ref string chatuser)//lưu vô chatuser là ok
            {
                this.clientSocket = inClientSocket;
                
                Thread t = new Thread(() =>
                {
                    DoChatRead(idNetworkStream, numberClient);
                });
                t.Start();
            }
            public void DoChatRead(NetworkStream idNetworkStream, int number)
            {
                
                byte[] bytes = new byte[1024];
                NetworkStream ns1 = idNetworkStream;
                int hangclientSelf = 0;
                int NOclient = number;
                while (true)
                {
                    try
                    {
                        int bytesRead = ns1.Read(bytes, 0, bytes.Length);
                        if (Encoding.ASCII.GetString(bytes, 0, bytesRead)[0] == 'A' || 
                            Encoding.ASCII.GetString(bytes, 0, bytesRead)[0] == 'B' ||
                            Encoding.ASCII.GetString(bytes, 0, bytesRead)[0] == 'C' ||
                            Encoding.ASCII.GetString(bytes, 0, bytesRead)[0] == 'D' ||
                            Encoding.ASCII.GetString(bytes, 0, bytesRead)[0] == '0')
                        {
                            countAswer++;
                            // xu ly khi nhan cau tra loi

                            if (Encoding.ASCII.GetString(bytes, 0, bytesRead)[0] == 'A')
                            {
                                tongA++;
                                if (lstQuestions[cauHoiHientai].Answer == lstQuestions[cauHoiHientai].DanhSachCauTraLoi[0])
                                    hangclientSelf++;
                            }
                            else if (Encoding.ASCII.GetString(bytes, 0, bytesRead)[0] == 'B')
                            {
                                tongB++;
                                if (lstQuestions[cauHoiHientai].Answer == lstQuestions[cauHoiHientai].DanhSachCauTraLoi[1])
                                    hangclientSelf++;
                            }
                            else if (Encoding.ASCII.GetString(bytes, 0, bytesRead)[0] == 'C')
                            {
                                tongC++;
                                if (lstQuestions[cauHoiHientai].Answer == lstQuestions[cauHoiHientai].DanhSachCauTraLoi[2])
                                    hangclientSelf++;
                            }
                            else if (Encoding.ASCII.GetString(bytes, 0, bytesRead)[0] == 'D')
                            {
                                tongD++;
                                if (lstQuestions[cauHoiHientai].Answer == lstQuestions[cauHoiHientai].DanhSachCauTraLoi[3])
                                    hangclientSelf++;
                            }
                            else if (Encoding.ASCII.GetString(bytes, 0, bytesRead)[0] == '0')
                            {
                                tong0++;
                            }
                            
                            // xet hang 
                            //1st
                            if (hangclientSelf > hangclient1)
                            {
                                if (NOclient != hangclientIndex1)
                                {
                                    if (hangclientIndex2 == NOclient)
                                    {
                                        hangclientIndex2 = hangclientIndex1;
                                        hangclient2 = hangclient1;

                                        hangclient1 = hangclientSelf;
                                        hangclientIndex1 = NOclient;
                                    }
                                    else if (hangclientIndex3 == NOclient)
                                    {
                                        hangclient3 = hangclient1;
                                        hangclientIndex3 = hangclientIndex1;

                                        hangclient1 = hangclientSelf;
                                        hangclientIndex1 = NOclient;
                                    }
                                    else
                                    {
                                        hangclient3 = hangclient2;
                                        hangclientIndex3 = hangclientIndex2;

                                        hangclientIndex2 = hangclientIndex1;
                                        hangclient2 = hangclient1;

                                        hangclient1 = hangclientSelf;
                                        hangclientIndex1 = NOclient;
                                    }
                                }
                                else
                                {
                                    hangclient1 = hangclientSelf;
                                }
                            }
                            //2sd
                            else if (hangclientSelf > hangclient2)
                            {
                                if (NOclient != hangclientIndex1)
                                {
                                    if (NOclient != hangclientIndex2)
                                    {

                                        hangclient3 = hangclient2;
                                        hangclientIndex3 = hangclientIndex2;

                                        hangclient2 = hangclientSelf;
                                        hangclientIndex2 = NOclient;
                                    }
                                    else
                                    {
                                        hangclient2 = hangclientSelf;
                                    }
                                }
                            }
                            //3st
                            else if (hangclientSelf > hangclient3)
                            {
                                if (NOclient != hangclientIndex1 && NOclient != hangclientIndex2)
                                {
                                    if (NOclient != hangclientIndex3)
                                    {
                                        hangclient3 = hangclientSelf;
                                        hangclientIndex3 = NOclient;
                                    }
                                    else
                                    {
                                        hangclient3 = hangclientSelf;
                                    }
                                }
                            }
                        }
                        else if(Encoding.ASCII.GetString(bytes, 0, bytesRead)[0] == '#')
                        {
                            chatuser= Encoding.ASCII.GetString(bytes, 0, bytesRead).Substring(1);//xu lý ở đây câu chAt của user
                            // MessageBox.Show(chatuser);
                            
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(" >> " + ex.ToString());
                    }
                }
            }
        }


        //private void SetText(string text)
        //{

        //    // InvokeRequired required compares the thread ID of the

        //    // calling thread to the thread ID of the creating thread.

        //    // If these threads are different, it returns true.

        //    if (this.txthienchat.InvokeRequired)
        //    {

        //        SetTextCallback d = new SetTextCallback(SetText);

        //        this.Invoke(d, new object[] { text });

        //    }

        //    else

        //    {

        //       // this.txthienchat.Text = this.txthienchat.Text+enter + text;

        //    }

        //}

        private void button4_Click(object sender, EventArgs e)//click sta thống kê
        {
            textBox3.Text = "tong A:" + tongA + space + "tong B:" + tongB + space + "tong C:" + tongC+
                space + "tong D:" + tongD+ space + "tong 0: " + tong0 + space;
            if (hangclientIndex1 != -1)
                textBox3.Text += "1st client " + "No." + hangclientIndex1 + space;
            if (hangclientIndex2 != -1 && hangclientIndex2 != hangclientIndex1)
                textBox3.Text += "2st client " + "No." + hangclientIndex2 + space;
            if (hangclientIndex3 != -1)
                textBox3.Text += "3st client " + "No." + hangclientIndex3;
        }

        private void timerreal_Tick(object sender, EventArgs e)//check real time
        {
            labellive.Text = "Live: " + countListClient.ToString();
            if (!string.IsNullOrEmpty(chatuser))
            {
                if (string.IsNullOrEmpty(allchat))//user chat trước ko bị xuống dòng
                {
                    allchat = chatuser;
                    chatuser = null;
                }
                else
                {
                    allchat = allchat + enter + chatuser;
                    chatuser = null;
                }
                txthienchat.Text = allchat;
            }

            textBox3.Text = "tong A:" + tongA + space + "tong B:" + tongB + space + "tong C:" + tongC +
                space + "tong D:" + tongD + space + "tong 0: " + tong0 + space;
            if (hangclientIndex1 != -1)
                textBox3.Text += "1st client " + "No." + hangclientIndex1 + space;
            if (hangclientIndex2 != -1 && hangclientIndex2 != hangclientIndex1)
                textBox3.Text += "2st client " + "No." + hangclientIndex2 + space;
            if (hangclientIndex3 != -1)
                textBox3.Text += "3st client " + "No." + hangclientIndex3;
            // this.Refresh();
        }





        private void button1_Click(object sender, EventArgs e)//next
        {
            if (questionNum != -1)
            {
                cauHoiHientai++;
                if (cauHoiHientai == lstQuestions.Count())// dung khi het cau hoi trong list.
                {
                    //byte[]  byteTime1 = Encoding.ASCII.GetBytes("E");
                    //for (int i = 0; i < countListClient; i++)
                    //{
                    //    ns[i].Write(byteTime1, 0, byteTime1.Length);
                    //}
                    MessageBox.Show("end show :))");
                    return;
                }
               
                questionNum++;
                lstQuestions[questionNum].loai = 2;
                curQuestion = lstQuestions[questionNum];
                HienThiCauHoi(curQuestion);
                byte[] byteTime = Utils.ObjectToByteArray(curQuestion);
                for (int i = 0; i < countListClient; i++)
                {
                    ns[i].Write(byteTime, 0, byteTime.Length);
                }

                textBox3.Text = "";
                tongA = 0;
                tongB = 0;
                tongC = 0;
                tongD = 0;
                tong0 = 0;
                countAswer = 0;
            }
        }

      

        private void button5_Click(object sender, EventArgs e)//end game
        {
                      
        }
        
        private void btnchat_Click(object sender, EventArgs e)//gui chat
        {
            string host = "Admin: " + textBoxChat.Text;
            if (string.IsNullOrEmpty(txthienchat.Text))//fix admin chat đầu tiên sẽ bị enter
            {
                allchat =host;
            }
            else
            {
                allchat = txthienchat.Text + enter + host;
            }
            txthienchat.Text = allchat;
        }

        private void txthienchat_TextChanged(object sender, EventArgs e)//gui user1 qua host roi update cho user2 thấy
        {
            allchat = txthienchat.Text;
            lstQuestions[questionNum].loai = 1;

           lstQuestions[questionNum].chat=allchat; //lỗi->k biết sửa phần tử của list có đúng ko?
            curQuestion = lstQuestions[questionNum];   
            byte[] byteTime = Utils.ObjectToByteArray(curQuestion);
            for (int i = 0; i < countListClient; i++)
            {
                ns[i].Write(byteTime, 0, byteTime.Length);
            }

        }

        public void ThongKe(ref int tongA, ref int tongB, ref int tong0, ref int countAswer)
        {

            //while (countAswer != countListClient)
            //{

            //}
            // MessageBox.Show("tong a = " + tongA + "tong b " + tongB);
            /*
            textBox3.Text = "tong a:" + tongA + space + "tong b:" + tongB + space + "tong 0: " + tong0 + space;
            if (hangclientIndex1 != -1)
                textBox3.Text += "1st client " + "No." + hangclientIndex1 + space;
            if (hangclientIndex2 != -1 && hangclientIndex2 != hangclientIndex1)
                textBox3.Text += "2st client " + "No." + hangclientIndex2 + space;
            if (hangclientIndex3 != -1)
                textBox3.Text += "3st client " + "No." + hangclientIndex3;
            */
        }
        string enter ="\n";
        string space = new string(' ', 10);
        void HienThiCauHoi(Question question)
        {
            rtbNoiDung.Text = question.Content;
            rtbNoiDung.Text = rtbNoiDung.Text + enter + "A." + question.DanhSachCauTraLoi[0] + space +
                "B. " + question.DanhSachCauTraLoi[1]+space+"C. "+ question.DanhSachCauTraLoi[2]+space+"D. " + question.DanhSachCauTraLoi[3];
            lbketqua.Text = "Đáp án: " + question.Answer;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeX_Tick(sender, e);
        }
        void timeX_Tick(object sender, EventArgs e)
        {
            time--;
            lbcountdownsv.Text = time / 60 + ":" + ((time % 60) >= 10 ? (time % 60).ToString() : "0" + time % 60);
            if (time <= 0)//het 10s
            {
                            
                time = 15;//khi chayj het set lại 15s để câu sau chạy
            }
        }
        int time = 15;//15s
        private void button3_Click(object sender, EventArgs e)//start
        {

            if (questionNum == -1)
            {
                cauHoiHientai++;
                questionNum++;
                lstQuestions[0].loai = 2;//de biet la gui cau hoi
                curQuestion = lstQuestions[questionNum];

                HienThiCauHoi(curQuestion);

                //String s = textBox2.Text;

                byte[] byteTime = Utils.ObjectToByteArray(curQuestion);

                for (int i = 0; i < countListClient; i++)
                {
                    ns[i].Write(byteTime, 0, byteTime.Length);
                }

                textBox3.Text = "";
                tongA = 0;
                tongB = 0;
                tong0 = 0;
                countAswer = 0;
                //Thread t = new Thread(() =>
                //{
                //    ThongKe(ref tongA, ref tongB, ref tong0, ref countAswer);
                //});
                //t.Start();
            }

        }

        private void button2_Click(object sender, EventArgs e)//goi y
        {

            richTextBox2.Text = curQuestion.hint;



        }
        //private void UserControl1_Paint(object sender, PaintEventArgs e)
        //{
        //    //this.Refresh();
        //    ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Red, ButtonBorderStyle.Dotted);
        //}
    }
}
