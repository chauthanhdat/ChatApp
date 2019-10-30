using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class Chat : Form
    {
        private  string username;
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
            label6.Text = richTextBox1.Text;
            richTextBox1.Text = "";
        }

        private bool isPressed = false;

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !isPressed)
            {
                isPressed = true;
                label6.Text = richTextBox1.Text;
                richTextBox1.Text = "";
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
                label5.Text = openFileDialog.FileName;
            }
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            Database database = new Database();
            yourName.Text = database.Select(username);
        }

        Thread thread;
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["username"] = "";
            Close();
            thread = new Thread(openLogin);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void openLogin(object sender)
        {
            Application.Run(new LoginForm());
        }

        int x = 95;
        int y = 220;

        private void button1_Click(object sender, EventArgs e)
        {
            y += 80;
            Label label = new Label();
            label.Text = "a";
            label.Location = new Point(x, y);

            this.chat_Panel.Controls.Add(label);
        }
    }
}
