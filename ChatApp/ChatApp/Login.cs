using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ChatApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            password_TextBox.UseSystemPasswordChar = !password_TextBox.UseSystemPasswordChar;
            if (password_TextBox.UseSystemPasswordChar)
                hide_PictureBox.Image = ChatApp.Properties.Resources.eye_close;
            else
                hide_PictureBox.Image = ChatApp.Properties.Resources.eye_open;
        }

        private void username_TextBox_Enter(object sender, EventArgs e)
        {
            if (username_TextBox.Text == "Username")
            {
                username_TextBox.Text = "";
                username_TextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void username_TextBox_Leave(object sender, EventArgs e)
        {
            if (username_TextBox.Text.Length == 0)
            {
                username_TextBox.Text = "Username";
                username_TextBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void password_TextBox_Enter(object sender, EventArgs e)
        {
            if (password_TextBox.Text == "Password")
            {
                password_TextBox.Text = "";
                password_TextBox.ForeColor = SystemColors.WindowText;
                password_TextBox.UseSystemPasswordChar = true;
                hide_PictureBox.Visible = true;
            }
        }

        private void password_TextBox_Leave(object sender, EventArgs e)
        {
            if (password_TextBox.Text.Length == 0)
            {
                password_TextBox.Text = "Password";
                password_TextBox.ForeColor = SystemColors.GrayText;
                password_TextBox.UseSystemPasswordChar = false;
                hide_PictureBox.Visible = false;
            }
        }

        Thread thread;
        private void login_Button_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            database.OpenConnection();
            //this.Close();
            //thread = new Thread(openChat);
            //thread.SetApartmentState(ApartmentState.STA);
            //thread.Start();
        }

        private void openChat(object obj)
        {
            Application.Run(new Chat());
        }
    }
}
