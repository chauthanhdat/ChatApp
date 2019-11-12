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
using MySql.Data.MySqlClient;

namespace ChatApp
{
    public partial class LoginForm : Form
    {
        private Point formDownPos;
        private Point mouseDownPos;
        private Boolean isMouseDown = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (password_TextBox.PasswordChar == '\0')
            {
                hide_PictureBox.Image = ChatApp.Properties.Resources.eye_open;
                password_TextBox.PasswordChar = '●';
            }
            else
            {
                hide_PictureBox.Image = ChatApp.Properties.Resources.eye_close;
                password_TextBox.PasswordChar = '\0';
            }
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
                hide_PictureBox.Image = ChatApp.Properties.Resources.eye_open;
                password_TextBox.PasswordChar = '●';
                hide_PictureBox.Visible = true;
            }
        }

        private void password_TextBox_Leave(object sender, EventArgs e)
        {
            if (password_TextBox.Text.Length == 0)
            {
                password_TextBox.Text = "Password";
                password_TextBox.ForeColor = SystemColors.GrayText;
                hide_PictureBox.Image = ChatApp.Properties.Resources.eye_close;
                password_TextBox.PasswordChar = '\0';
                hide_PictureBox.Visible = false;
            }
        }

        Thread thread;
        private void login_Button_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void openChat(object sender)
        {
            Application.Run(new Chat(Properties.Settings.Default["username"].ToString()));
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownPos = Control.MousePosition;
                formDownPos = Location;
                isMouseDown = true;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                isMouseDown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                int dx = mousePos.X - mouseDownPos.X;
                int dy = mousePos.Y - mouseDownPos.Y;
                Location = new Point(formDownPos.X + dx, formDownPos.Y + dy);
            }
        }

        private void register_Button_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void password_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void Login()
        {
            Database database = new Database();
            if (database.Login(username_TextBox.Text, password_TextBox.Text))
            {
                Properties.Settings.Default["username"] = username_TextBox.Text;
                Close();
                thread = new Thread(openChat);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }
    }
}
