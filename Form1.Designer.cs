namespace ClientServerApplication
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
            this.grboxServer = new System.Windows.Forms.GroupBox();
            this.btStart = new System.Windows.Forms.Button();
            this.txtboxPortServer = new System.Windows.Forms.TextBox();
            this.txtboxIpServer = new System.Windows.Forms.TextBox();
            this.lbPortServer = new System.Windows.Forms.Label();
            this.lbIpServer = new System.Windows.Forms.Label();
            this.grboxclient = new System.Windows.Forms.GroupBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.txtBoxPortClient = new System.Windows.Forms.TextBox();
            this.txtboxIpClient = new System.Windows.Forms.TextBox();
            this.lbPortClient = new System.Windows.Forms.Label();
            this.lbIpClient = new System.Windows.Forms.Label();
            this.txtboxConversation = new System.Windows.Forms.TextBox();
            this.txtboxToSend = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.grboxServer.SuspendLayout();
            this.grboxclient.SuspendLayout();
            this.SuspendLayout();
            // 
            // grboxServer
            // 
            this.grboxServer.Controls.Add(this.btStart);
            this.grboxServer.Controls.Add(this.txtboxPortServer);
            this.grboxServer.Controls.Add(this.txtboxIpServer);
            this.grboxServer.Controls.Add(this.lbPortServer);
            this.grboxServer.Controls.Add(this.lbIpServer);
            this.grboxServer.Location = new System.Drawing.Point(12, 12);
            this.grboxServer.Name = "grboxServer";
            this.grboxServer.Size = new System.Drawing.Size(410, 100);
            this.grboxServer.TabIndex = 0;
            this.grboxServer.TabStop = false;
            this.grboxServer.Text = "Server";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(317, 36);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "START";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // txtboxPortServer
            // 
            this.txtboxPortServer.Location = new System.Drawing.Point(210, 38);
            this.txtboxPortServer.Name = "txtboxPortServer";
            this.txtboxPortServer.Size = new System.Drawing.Size(100, 20);
            this.txtboxPortServer.TabIndex = 3;
            // 
            // txtboxIpServer
            // 
            this.txtboxIpServer.Location = new System.Drawing.Point(63, 38);
            this.txtboxIpServer.Name = "txtboxIpServer";
            this.txtboxIpServer.Size = new System.Drawing.Size(100, 20);
            this.txtboxIpServer.TabIndex = 2;
            // 
            // lbPortServer
            // 
            this.lbPortServer.AutoSize = true;
            this.lbPortServer.Location = new System.Drawing.Point(169, 41);
            this.lbPortServer.Name = "lbPortServer";
            this.lbPortServer.Size = new System.Drawing.Size(37, 13);
            this.lbPortServer.TabIndex = 1;
            this.lbPortServer.Text = "PORT";
            // 
            // lbIpServer
            // 
            this.lbIpServer.AutoSize = true;
            this.lbIpServer.Location = new System.Drawing.Point(22, 41);
            this.lbIpServer.Name = "lbIpServer";
            this.lbIpServer.Size = new System.Drawing.Size(17, 13);
            this.lbIpServer.TabIndex = 0;
            this.lbIpServer.Text = "IP";
            // 
            // grboxclient
            // 
            this.grboxclient.Controls.Add(this.btConnect);
            this.grboxclient.Controls.Add(this.txtBoxPortClient);
            this.grboxclient.Controls.Add(this.txtboxIpClient);
            this.grboxclient.Controls.Add(this.lbPortClient);
            this.grboxclient.Controls.Add(this.lbIpClient);
            this.grboxclient.Location = new System.Drawing.Point(12, 118);
            this.grboxclient.Name = "grboxclient";
            this.grboxclient.Size = new System.Drawing.Size(410, 100);
            this.grboxclient.TabIndex = 1;
            this.grboxclient.TabStop = false;
            this.grboxclient.Text = "Client";
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(317, 40);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(75, 23);
            this.btConnect.TabIndex = 5;
            this.btConnect.Text = "CONNECT";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // txtBoxPortClient
            // 
            this.txtBoxPortClient.Location = new System.Drawing.Point(210, 42);
            this.txtBoxPortClient.Name = "txtBoxPortClient";
            this.txtBoxPortClient.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPortClient.TabIndex = 4;
            // 
            // txtboxIpClient
            // 
            this.txtboxIpClient.Location = new System.Drawing.Point(63, 42);
            this.txtboxIpClient.Name = "txtboxIpClient";
            this.txtboxIpClient.Size = new System.Drawing.Size(100, 20);
            this.txtboxIpClient.TabIndex = 5;
            // 
            // lbPortClient
            // 
            this.lbPortClient.AutoSize = true;
            this.lbPortClient.Location = new System.Drawing.Point(169, 45);
            this.lbPortClient.Name = "lbPortClient";
            this.lbPortClient.Size = new System.Drawing.Size(37, 13);
            this.lbPortClient.TabIndex = 2;
            this.lbPortClient.Text = "PORT";
            // 
            // lbIpClient
            // 
            this.lbIpClient.AutoSize = true;
            this.lbIpClient.Location = new System.Drawing.Point(22, 45);
            this.lbIpClient.Name = "lbIpClient";
            this.lbIpClient.Size = new System.Drawing.Size(17, 13);
            this.lbIpClient.TabIndex = 3;
            this.lbIpClient.Text = "IP";
            // 
            // txtboxConversation
            // 
            this.txtboxConversation.Location = new System.Drawing.Point(12, 224);
            this.txtboxConversation.Multiline = true;
            this.txtboxConversation.Name = "txtboxConversation";
            this.txtboxConversation.Size = new System.Drawing.Size(410, 195);
            this.txtboxConversation.TabIndex = 2;
            // 
            // txtboxToSend
            // 
            this.txtboxToSend.Location = new System.Drawing.Point(12, 425);
            this.txtboxToSend.Multiline = true;
            this.txtboxToSend.Name = "txtboxToSend";
            this.txtboxToSend.Size = new System.Drawing.Size(311, 24);
            this.txtboxToSend.TabIndex = 3;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(329, 426);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(93, 23);
            this.btSend.TabIndex = 4;
            this.btSend.Text = "SEND";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.txtboxToSend);
            this.Controls.Add(this.txtboxConversation);
            this.Controls.Add(this.grboxclient);
            this.Controls.Add(this.grboxServer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grboxServer.ResumeLayout(false);
            this.grboxServer.PerformLayout();
            this.grboxclient.ResumeLayout(false);
            this.grboxclient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grboxServer;
        private System.Windows.Forms.GroupBox grboxclient;
        private System.Windows.Forms.TextBox txtboxConversation;
        private System.Windows.Forms.TextBox txtboxToSend;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TextBox txtboxPortServer;
        private System.Windows.Forms.TextBox txtboxIpServer;
        private System.Windows.Forms.Label lbPortServer;
        private System.Windows.Forms.Label lbIpServer;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.TextBox txtBoxPortClient;
        private System.Windows.Forms.TextBox txtboxIpClient;
        private System.Windows.Forms.Label lbPortClient;
        private System.Windows.Forms.Label lbIpClient;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

