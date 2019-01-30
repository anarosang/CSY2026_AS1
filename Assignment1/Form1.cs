using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        delegate void SetTextCallBack(string text);

        private void SetText(string text)
        {
            if (this.textBox2.InvokeRequired)
            {
                SetTextCallBack s = new SetTextCallBack(SetText);
                this.Invoke(s, new object[] { text });
            }
            else
            {
                this.textBox2.Text = this.textBox2.Text + text + Environment.NewLine;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        class WncTcpServer
        {
            TcpClient client;
            StreamReader sr;
            StreamWriter sw;
            int port;
            Button btn;
            TextBox tx1, tx2;
            SetTextCallBack st;
            TcpListener listener;

            public WncTcpServer(ref Button bt, ref TextBox tb1, ref TextBox tb2, String lport, SetTextCallBack ff)
            {
                listener = new TcpListener(IPAddress.Any, int.Parse(lport));
                listener.Start();

                client = listener.AcceptTcpClient();

                sr = new StreamReader(client.GetStream());
                sw = new StreamWriter(client.GetStream());
                sw.AutoFlush = true;
                
                port = int.Parse(lport);
                btn = bt;
                tx1 = tb1;
                tx2 = tb2;
                btn.Click += tx;

                st = ff;

                Thread th = new Thread(rx);
                th.Start();
            }

            public void tx(Object sender, EventArgs e)
            {
                String toClient;
                toClient = tx1.Text;
                if (toClient != null) sw.WriteLine(toClient);
                st("Server/Me: " + toClient);
                tx1.Text = "";
            }

            void rx()
            {
                String fromClient;
                do
                {
                    fromClient = sr.ReadLine();
                    if (fromClient != null) st("Client: " + fromClient);
                }
                while (fromClient != null);

                System.Environment.Exit(0);
            }

        }

        class WncTcpClient
        {
            public TcpClient client;
            StreamReader sr;
            StreamWriter sw;
            Button btn;
            TextBox tx1, tx2;
            SetTextCallBack st;

            public WncTcpClient(ref Button bt, ref TextBox tb1, ref TextBox tb2, String rip,String rport, SetTextCallBack ff)
            {
                client = new TcpClient(rip, int.Parse(rport));

                sr = new StreamReader(client.GetStream());
                sw = new StreamWriter(client.GetStream());
                sw.AutoFlush = true;
                
                btn = bt;
                tx1 = tb1;
                tx2 = tb2;
                btn.Click += tx;

                st = ff;

                Thread th = new Thread(rx);
                th.Start();
            }

            public void tx(Object sender, EventArgs e)
            {
                String toServer;
                toServer = tx1.Text;
                if (toServer != null) sw.WriteLine(toServer);
                st("Client/Me: " + toServer);
                tx1.Text = "";
            }

            void rx()
            {
                String fromServer;
                do
                {
                    fromServer = sr.ReadLine();
                    if (fromServer != null) st("Server: " + fromServer);
                }
                while (fromServer != null);

                System.Environment.Exit(0);
            }
        }
        
        class WncUdpServer
        {
            UdpClient client;
            String ip = null;
            int port;
            Button btn;
            TextBox tx1, tx2;
            SetTextCallBack st;

            public WncUdpServer(ref Button bt, ref TextBox tb1, ref TextBox tb2, String lport, SetTextCallBack ff)
            {
                port = int.Parse(lport);
                client = new UdpClient(port);

                btn = bt;
                tx1 = tb1;
                tx2 = tb2;
                btn.Click += tx;

                st = ff;

                Thread th = new Thread(rx);
                th.Start();
            }

            public void tx(Object sender, EventArgs e)
            {
                String toClient;
                toClient = tx1.Text;

                if (toClient != null) client.Send(Encoding.ASCII.GetBytes(toClient), toClient.Length, ip, port);

                st("Server/Me: " + toClient);
                tx1.Text = "";
            }

            void rx()
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);

                String fromClient;
                do
                {
                    fromClient = Encoding.ASCII.GetString(client.Receive(ref RemoteIpEndPoint));
                    ip = RemoteIpEndPoint.Address + "";
                    port = RemoteIpEndPoint.Port;
                    if (fromClient != null) st("Client: " + fromClient);
                }
                while (fromClient != null);

                System.Environment.Exit(0);
            }
        }

        class WncUdpClient
        {
            UdpClient client;
            String ip = null;
            int port;
            Button btn;
            TextBox tx1, tx2;
            SetTextCallBack st;

            public WncUdpClient(ref Button bt, ref TextBox tb1, ref TextBox tb2, String rip, String rport, SetTextCallBack ff)
            {
                client = new UdpClient();
                
                ip = rip;
                port = int.Parse(rport);

                btn = bt;
                tx1 = tb1;
                tx2 = tb2;

                btn.Click += tx;

                st = ff;

                Thread th = new Thread(rx);
                th.Start();
            }
            
            public void tx(Object sender, EventArgs e)
            {
                String toServer;
                toServer = tx1.Text;

                if (toServer != null) client.Send(Encoding.ASCII.GetBytes(toServer), toServer.Length, ip, port);

                st("Client/Me: " + toServer);
                tx1.Text = "";
            }
            
            void rx()
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                client.Client.Bind(RemoteIpEndPoint); // NOTE THIS LINE. THIS IS FOR THE UDP CLIENT ONLY
                
                String fromServer;
                do
                {

                    fromServer = Encoding.ASCII.GetString(client.Receive(ref RemoteIpEndPoint));
                    ip = RemoteIpEndPoint.Address + "";
                    port = RemoteIpEndPoint.Port;

                    if (fromServer != null) st("Server: " + fromServer);
                }

                while (fromServer != null);

                System.Environment.Exit(0);
            }

        }

        private void bnSend_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            address.Enabled = false;
            remoteport.Enabled = false;
            port.Enabled = false;
            listBox1.Enabled = false;
            btnStart.Enabled = false;

            if (listBox1.SelectedIndex == 0) new WncTcpServer(ref bntSend,ref textBox1, ref textBox2, port.Text, SetText);
            if (listBox1.SelectedIndex == 1) new WncTcpClient(ref bntSend, ref textBox1, ref textBox2, address.Text, remoteport.Text, SetText);
            if (listBox1.SelectedIndex == 2) new WncUdpServer(ref bntSend, ref textBox1, ref textBox2, port.Text, SetText);
            if (listBox1.SelectedIndex == 3) new WncUdpClient(ref bntSend, ref textBox1, ref textBox2, address.Text, remoteport.Text, SetText);
        }

        /*private void btnStop_Click(object sender, EventArgs e)
        {
            /*address.Enabled = true;
             remoteport.Enabled = true;
             port.Enabled = true; byiul.nqwr
             listBox1.Enabled = true;
             btnStart.Enabled = true;
           // System.Environment.Exit(0);
        }*/
    }
}
