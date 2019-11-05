using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class Chat : Form
    {
        private Point formDownPos;
        private Point mouseDownPos;
        private Boolean isMouseDown = false;

        private Thread thread;

        private TcpListener tcpServer;
        private TcpClient tcpClient;
        private Thread serverThread;

        private Label chossen;
        private string currentChat;

        private Label receive = new Label();
        

        //private ArrayList current = new ArrayList();

        Database database = new Database();

        private string username;
        public Chat()
        {
            InitializeComponent();
        }

        public Chat(string _username)
        {
            InitializeComponent();
            username = _username;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sendMessage();
        }

        private bool isPressed = false;

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !isPressed)
            {
                isPressed = true;
                sendMessage();
            }
        }

        int x = 3;
        int y = 3;
        private void sendMessage()
        {
            string hostname = database.Select("ip", "account", "username", currentChat);
            
            if (hostname == "")
            {
                MessageBox.Show("Offline");
                richTextBox1.Text = "";
            }
            else
            {
                if (richTextBox1.Text != "")
                {
                    //---create a TCPClient object at the IP and port---
                    int port = 0;
                    Int32.TryParse(database.Select("port", "account", "username", currentChat), out port);
                    tcpClient = new TcpClient(hostname,port);
                    NetworkStream ns = tcpClient.GetStream();
                    byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(richTextBox1.Text);
                    ns.Write(bytesToSend, 0, bytesToSend.Length);
                    tcpClient.Close();

                    //UI
                    Label label = new Label();
                    label.Text = richTextBox1.Text;
                    richTextBox1.Text = "";
                    label.Location = new Point(x + 62, y + 31);
                    label.BackColor = Color.FromArgb(100, 151, 177);
                    label.AutoSize = true;
                    label.Font = new Font(label.Font.FontFamily, 15);
                    y += 62;
                    this.chat_Panel.Controls.Add(label);

                    //int change = chat_Panel.VerticalScroll.Value + chat_Panel.VerticalScroll.SmallChange * 80;
                    //chat_Panel.AutoScrollPosition = new Point(0, change);
                }
            }
        }

        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                richTextBox1.Text = "";
                if (isPressed)
                {
                    isPressed = false;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //label4.Text = openFileDialog.FileName;
            }
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            // UI
            yourName.Text = database.Select("name", "account", "username", username);

            // friend list
            database.SelectTable(ref friend);
            int xx = 6;
            int yy = 3;
            for (int row = 0; row < friend.Rows.Count - 1; row++)
            {
                string yName = friend.Rows[row].Cells[1].Value.ToString();
                if (yName != yourName.Text)
                {
                    Label label = new Label();
                    label.Text = friend.Rows[row].Cells[1].Value.ToString();
                    label.Location = new Point(xx + 62, yy);
                    label.Font = new Font(label.Font.FontFamily, 15);
                    label.BackColor = Color.FromArgb(100, 151, 177);
                    label.AutoSize = false;
                    label.Size = new Size(173, 56);
                    label.TextAlign = ContentAlignment.MiddleLeft;
                    label.Click += new EventHandler(click);
                    chossen = label;

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Location = new Point(xx, yy);
                    pictureBox.Size = new Size(56, 56);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Image = ChatApp.Properties.Resources.user;

                    friend_Panel.Controls.Add(label);
                    friend_Panel.Controls.Add(pictureBox);

                    yy += 62;
                }
            }

            // socket
            StartServer();

            // get ip, port
            database.Update("account", "ip", getIP().ToString(), "username", username);
        }

        private void click(object sender, EventArgs e)
        {
            chossen.BackColor = Color.FromArgb(100, 151, 177);
            chossen = (Label)sender;
            chossen.BackColor = Color.FromArgb(179, 205, 224);
            roomName_Label.Text = ((Label)sender).Text;
            chat_Panel.Controls.Clear();
            x = 3; y = 3;

            for (int row = 0; row < friend.Rows.Count - 1; row++)
            {
                if (friend.Rows[row].Cells[1].Value.ToString() == roomName_Label.Text)
                {
                    currentChat = friend.Rows[row].Cells[0].Value.ToString();
                    break;
                }
            }
        }

        private void StartServer()
        {
            serverThread = new Thread(new ThreadStart(StartListen));
            serverThread.Start();
        }

        private void StartListen()
        {
            tcpServer = new TcpListener(getIP(), 0);
            tcpServer.Start();

            database.Update("account", "port", ((IPEndPoint)tcpServer.LocalEndpoint).Port.ToString(), "username", username); // problem is here

            while (true)
            {
                //---incoming client connected---
                TcpClient client = tcpServer.AcceptTcpClient();

                //---get the incoming data through a network stream---
                NetworkStream ns = client.GetStream();
                byte[] buffer = new byte[client.ReceiveBufferSize];

                //---read incoming stream---
                int bytesRead = ns.Read(buffer, 0, client.ReceiveBufferSize);

                //---convert the data received into a string---
                string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                SetText(dataReceived);
            }
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.chat_Panel.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                Label label = new Label();
                label.Text = text;
                label.Location = new Point(x + 62, y + 31);
                label.BackColor = Color.FromArgb(1, 31, 75);
                label.ForeColor = Color.White;
                label.AutoSize = true;
                label.Font = new Font(label.Font.FontFamily, 15);
                y += 62;

                this.chat_Panel.Controls.Add(label);
            }
        }

        private void StopServer()
        {
            if (tcpServer != null)
            {
                serverThread.Abort();
                tcpServer.Stop();
            }
        }

        private IPAddress getIP()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip;
                }
            }
            return null;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            database.Update("account", "ip", null, "username", username);
            database.Update("account", "port", null, "username", username);
            Properties.Settings.Default["username"] = null;
            StopServer();
            Close();
            thread = new Thread(openLogin);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void openLogin(object sender)
        {
            Application.Run(new LoginForm());
        }

        private void close_PictureBox_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            database.Update("account", "ip", null, "username", username);
            database.Update("account", "port", null, "username", username);
            StopServer();
            Close();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownPos = Control.MousePosition;
                formDownPos = Location;
                isMouseDown = true;
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                isMouseDown = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                int dx = mousePos.X - mouseDownPos.X;
                int dy = mousePos.Y - mouseDownPos.Y;
                Location = new Point(formDownPos.X + dx, formDownPos.Y + dy);
            }
        }
    }
}
