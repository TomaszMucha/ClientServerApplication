using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ClientServerApplication
{
    public partial class Form1 : Form
    {

        private TcpClient client;
        public StreamReader str;
        public StreamWriter stw;
        public string recive;
        public string textToSend;

        public Form1()
        {
            InitializeComponent();

            IPAddress[] localIp = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIp)
            {
                if (address.AddressFamily==AddressFamily.InterNetwork)
                {
                    txtboxIpServer.Text = address.ToString();
                }
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(txtboxPortServer.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            str = new StreamReader(client.GetStream());
            stw = new StreamWriter(client.GetStream());
            stw.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(txtboxIpClient.Text), int.Parse(txtBoxPortClient.Text));
            try
            {
                client.Connect(IpEnd);
                if (client.Connected)
                {
                    txtboxConversation.AppendText("Connected to server \n");
                    str = new StreamReader(client.GetStream());
                    stw = new StreamWriter(client.GetStream());
                    stw.AutoFlush = true;
                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.WorkerSupportsCancellation = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    recive = str.ReadLine();
                    this.txtboxConversation.Invoke(new MethodInvoker(delegate ()
                    {
                        this.txtboxConversation.AppendText("You: " + recive + "\n");
                    }));
                    recive = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                stw.WriteLine(textToSend);
                this.txtboxConversation.Invoke(new MethodInvoker(delegate ()
                {
                    txtboxConversation.AppendText("Me: " + textToSend + "\n");
                }));
            }
            else
            {
                MessageBox.Show("Sending failed");
            }
            backgroundWorker2.CancelAsync();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            if (txtboxToSend.Text!="")
            {
                textToSend = txtboxToSend.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            txtboxToSend.Text = "";
        }
    }
}
