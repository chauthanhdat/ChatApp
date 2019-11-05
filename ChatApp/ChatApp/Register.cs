using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (fullName_TextBox.Text == "Full Name")
            {
                fullName_TextBox.Text = "";
                fullName_TextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void fullName_TextBox_Leave(object sender, EventArgs e)
        {
            if (fullName_TextBox.Text.Length == 0)
            {
                fullName_TextBox.Text = "Full Name";
                fullName_TextBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
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
                a_PictureBox.Image = ChatApp.Properties.Resources.eye_open;
                password_TextBox.PasswordChar = '●';
                a_PictureBox.Visible = true;
            }
        }

        private void password_TextBox_Leave(object sender, EventArgs e)
        {
            if (password_TextBox.Text.Length == 0)
            {
                password_TextBox.Text = "Password";
                password_TextBox.ForeColor = SystemColors.GrayText;
                a_PictureBox.Image = ChatApp.Properties.Resources.eye_close;
                password_TextBox.PasswordChar = '\0';
                a_PictureBox.Visible = false;
            }
        }

        private void confirmPassword_TextBox_Enter(object sender, EventArgs e)
        {
            if (confirmPassword_TextBox.Text == "Confirm Password")
            {
                confirmPassword_TextBox.Text = "";
                confirmPassword_TextBox.ForeColor = SystemColors.WindowText;
                b_PictureBox.Image = ChatApp.Properties.Resources.eye_open;
                confirmPassword_TextBox.PasswordChar = '●';
                b_PictureBox.Visible = true;
            }
        }

        private void confirmPassword_TextBox_Leave(object sender, EventArgs e)
        {
            if (confirmPassword_TextBox.Text.Length == 0)
            {
                confirmPassword_TextBox.Text = "Confirm Password";
                confirmPassword_TextBox.ForeColor = SystemColors.GrayText;
                b_PictureBox.Image = ChatApp.Properties.Resources.eye_close;
                confirmPassword_TextBox.PasswordChar = '\0';
                b_PictureBox.Visible = false;
            }
        }

        private void hide_PictureBox_Click(object sender, EventArgs e)
        {
            if (password_TextBox.PasswordChar == '\0')
            {
                a_PictureBox.Image = ChatApp.Properties.Resources.eye_open;
                password_TextBox.PasswordChar = '●';
            }
            else
            {
                a_PictureBox.Image = ChatApp.Properties.Resources.eye_close;
                password_TextBox.PasswordChar = '\0';
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (confirmPassword_TextBox.PasswordChar == '\0')
            {
                b_PictureBox.Image = ChatApp.Properties.Resources.eye_open;
                confirmPassword_TextBox.PasswordChar = '●';
            }
            else
            {
                b_PictureBox.Image = ChatApp.Properties.Resources.eye_close;
                confirmPassword_TextBox.PasswordChar = '\0';
            }
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            if (password_TextBox.Text != confirmPassword_TextBox.Text)
            {
                MessageBox.Show("Password does not match");
            }
            else
            {
                Database database = new Database();
                database.Insert("account (username, password, name)", "('" + username_TextBox.Text + "', '" + password_TextBox.Text + "', '" + fullName_TextBox.Text + "')");
                MessageBox.Show("Success");
                Close();
            }
        }
    }
}
