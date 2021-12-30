namespace TCPClientV1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TB_ServerIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_ServcerPort = new System.Windows.Forms.TextBox();
            this.BT_Connect = new System.Windows.Forms.Button();
            this.LB_Result = new System.Windows.Forms.Label();
            this.TB_Message = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BT_OnConnect = new System.Windows.Forms.Button();
            this.BT_OnDisconnect = new System.Windows.Forms.Button();
            this.btn_WebApi = new System.Windows.Forms.Button();
            this.ib_send = new System.Windows.Forms.TextBox();
            this.LB_Result2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server IP";
            // 
            // TB_ServerIP
            // 
            this.TB_ServerIP.Location = new System.Drawing.Point(137, 33);
            this.TB_ServerIP.Name = "TB_ServerIP";
            this.TB_ServerIP.Size = new System.Drawing.Size(100, 23);
            this.TB_ServerIP.TabIndex = 1;
            this.TB_ServerIP.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server Port";
            // 
            // TB_ServcerPort
            // 
            this.TB_ServcerPort.Location = new System.Drawing.Point(137, 84);
            this.TB_ServcerPort.Name = "TB_ServcerPort";
            this.TB_ServcerPort.Size = new System.Drawing.Size(100, 23);
            this.TB_ServcerPort.TabIndex = 3;
            this.TB_ServcerPort.Text = "80";
            // 
            // BT_Connect
            // 
            this.BT_Connect.Location = new System.Drawing.Point(91, 198);
            this.BT_Connect.Name = "BT_Connect";
            this.BT_Connect.Size = new System.Drawing.Size(111, 23);
            this.BT_Connect.TabIndex = 4;
            this.BT_Connect.Text = "連線/ 發送/接收";
            this.BT_Connect.UseVisualStyleBackColor = true;
            this.BT_Connect.Click += new System.EventHandler(this.BT_Connect_Click);
            // 
            // LB_Result
            // 
            this.LB_Result.AutoSize = true;
            this.LB_Result.Location = new System.Drawing.Point(208, 202);
            this.LB_Result.Name = "LB_Result";
            this.LB_Result.Size = new System.Drawing.Size(55, 15);
            this.LB_Result.TabIndex = 5;
            this.LB_Result.Text = "連線結果";
            // 
            // TB_Message
            // 
            this.TB_Message.Location = new System.Drawing.Point(137, 131);
            this.TB_Message.Name = "TB_Message";
            this.TB_Message.Size = new System.Drawing.Size(100, 23);
            this.TB_Message.TabIndex = 6;
            this.TB_Message.Text = "[[1,22HELLO]]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Message";
            // 
            // BT_OnConnect
            // 
            this.BT_OnConnect.Location = new System.Drawing.Point(91, 242);
            this.BT_OnConnect.Name = "BT_OnConnect";
            this.BT_OnConnect.Size = new System.Drawing.Size(75, 23);
            this.BT_OnConnect.TabIndex = 8;
            this.BT_OnConnect.Text = "連線";
            this.BT_OnConnect.UseVisualStyleBackColor = true;
            this.BT_OnConnect.Click += new System.EventHandler(this.BT_OnConnect_Click);
            // 
            // BT_OnDisconnect
            // 
            this.BT_OnDisconnect.Cursor = System.Windows.Forms.Cursors.Default;
            this.BT_OnDisconnect.Location = new System.Drawing.Point(91, 281);
            this.BT_OnDisconnect.Name = "BT_OnDisconnect";
            this.BT_OnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.BT_OnDisconnect.TabIndex = 9;
            this.BT_OnDisconnect.Text = "中斷連線";
            this.BT_OnDisconnect.UseVisualStyleBackColor = true;
            this.BT_OnDisconnect.Click += new System.EventHandler(this.BT_OnDisconnect_Click);
            // 
            // btn_WebApi
            // 
            this.btn_WebApi.Location = new System.Drawing.Point(127, 383);
            this.btn_WebApi.Name = "btn_WebApi";
            this.btn_WebApi.Size = new System.Drawing.Size(75, 23);
            this.btn_WebApi.TabIndex = 11;
            this.btn_WebApi.Text = "Web";
            this.btn_WebApi.UseVisualStyleBackColor = true;
            this.btn_WebApi.Click += new System.EventHandler(this.btn_WebApi_Click);
            // 
            // ib_send
            // 
            this.ib_send.Location = new System.Drawing.Point(283, 23);
            this.ib_send.Multiline = true;
            this.ib_send.Name = "ib_send";
            this.ib_send.Size = new System.Drawing.Size(244, 512);
            this.ib_send.TabIndex = 12;
            this.ib_send.Text = "GET /aaa.htm HTTP/1.1\r\nHost: 127.0.0.1:8000\r\n\r\n\r\n....";
            this.ib_send.TextChanged += new System.EventHandler(this.ib_send_TextChanged);
            // 
            // LB_Result2
            // 
            this.LB_Result2.Location = new System.Drawing.Point(609, 23);
            this.LB_Result2.Multiline = true;
            this.LB_Result2.Name = "LB_Result2";
            this.LB_Result2.Size = new System.Drawing.Size(244, 512);
            this.LB_Result2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 582);
            this.Controls.Add(this.LB_Result2);
            this.Controls.Add(this.ib_send);
            this.Controls.Add(this.btn_WebApi);
            this.Controls.Add(this.BT_OnDisconnect);
            this.Controls.Add(this.BT_OnConnect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_Message);
            this.Controls.Add(this.LB_Result);
            this.Controls.Add(this.BT_Connect);
            this.Controls.Add(this.TB_ServcerPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_ServerIP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TB_ServerIP;
        private Label label2;
        private TextBox TB_ServcerPort;
        private Button BT_Connect;
        private Label LB_Result;
        private TextBox TB_Message;
        private Label label3;
        private Button BT_OnConnect;
        private Button BT_OnDisconnect;
        private Button btn_WebApi;
        private TextBox ib_send;
        private TextBox LB_Result2;
    }
}