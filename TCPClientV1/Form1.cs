using System.Net.Sockets;
using System.Text;

namespace TCPClientV1
{
    public partial class Form1 : Form
    {
        static TcpClient myClient = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void BT_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                String SIP = TB_ServerIP.Text.Trim();
                Int32 SPort = Convert.ToInt32(TB_ServcerPort.Text.Trim());
                TcpClient myClient = new TcpClient(SIP, SPort);   //1.連線Server
                //-----------------------------------------
                NetworkStream myStream = myClient.GetStream();    //取得TcpClient內部的傳輸串流
                if (myStream.CanWrite)
                {
                    string SendStr = TB_Message.Text;
                    Byte[] SendBuffer = Encoding.UTF8.GetBytes(SendStr); //將要傳送的文字放入SendBuffer陣列內
                    myStream.Write(SendBuffer, 0, SendBuffer.Length);

                    Byte[] ReadBuffer = new byte[1500];
                    myStream.Read(ReadBuffer, 0, 1500);                  //讀到的資料會放在ReadBuffer陣列內
                    String GetStr = Encoding.UTF8.GetString(ReadBuffer);

                    LB_Result.Text = GetStr;
                }
                else
                {
                    LB_Result.Text = "無法讀寫";
                }
                myStream.Close();
                myClient.Close();
            }
            catch
            {
                LB_Result.Text = "連線失敗!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BT_OnConnect_Click(object sender, EventArgs e)
        {
            if (myClient == null)
            {
                String SIP = TB_ServerIP.Text.Trim();
                Int32 SPort = Convert.ToInt32(TB_ServcerPort.Text.Trim());
                myClient = new TcpClient(SIP, SPort);
            }

            if (myClient.Connected == true)
            {
                LB_Result.Text = "OK";
            }
        }

        private void BT_OnDisconnect_Click(object sender, EventArgs e)
        {
            if (myClient == null) return;
            if (myClient.Connected == false)
            {
                return;
            }
            myClient.Close();
            LB_Result.Text = "Closed";
            myClient = null;

        }
        private void btn_WebApi_Click(object sender, EventArgs e)
        {
            LB_Result.Text = "";
            LB_Result2.Text = "---";
            try
            {
                String SIP = TB_ServerIP.Text.Trim();
                Int32 SPort = Convert.ToInt32(TB_ServcerPort.Text.Trim());
                TcpClient myClient = new TcpClient(SIP, SPort);
                myClient.ReceiveTimeout = 5000;
                myClient.SendTimeout = 5000;
                NetworkStream networkStream = myClient.GetStream();
                if (networkStream.CanWrite)
                {
                    foreach(string ite in ib_send.Lines)
                    {
                        Byte[] SendBuffer = Encoding.UTF8.GetBytes(ib_send.Text); //將要傳送的文字放入SendBuffer陣列內
                        networkStream.Write(SendBuffer, 0, SendBuffer.Length);
                    }

                    if (networkStream.CanRead)
                    {
                        LB_Result2.Text = "";
                        int count = 0, buffersize = 8192, ReadBytes = 0;
                        while (true)
                        {
                            Byte[] ReadBuffer = new byte[buffersize];
                            ReadBytes = networkStream.Read(ReadBuffer,0, buffersize);
                            LB_Result2.Text += Encoding.UTF8.GetString(ReadBuffer);
                            if(ReadBytes != buffersize) break;
                            count++;
                        }
                        LB_Result2.Text += "次數=" + count.ToString() + "最後餘數=" + ReadBytes.ToString();
                    }
                    else
                    {
                        LB_Result.Text = "沒有資料可讀";
                    }
                }
                else
                {
                    LB_Result.Text = "無法讀寫";
                }
                myClient.GetStream().Close();
                myClient.Close();
                myClient.Dispose();
                myClient = null;
            }
            catch
            {
                LB_Result.Text = "連線失敗";
            }
        }

        private void ib_send_TextChanged(object sender, EventArgs e)
        {

        }

    }
}