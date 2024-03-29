﻿namespace ChatApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.username_TextBox = new System.Windows.Forms.TextBox();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.login_Button = new System.Windows.Forms.Button();
            this.register_Button = new System.Windows.Forms.Button();
            this.hide_PictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.login_PictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.hide_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_PictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // username_TextBox
            // 
            this.username_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_TextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.username_TextBox.Location = new System.Drawing.Point(50, 199);
            this.username_TextBox.Name = "username_TextBox";
            this.username_TextBox.Size = new System.Drawing.Size(156, 20);
            this.username_TextBox.TabIndex = 2;
            this.username_TextBox.Text = "Username";
            this.username_TextBox.Enter += new System.EventHandler(this.username_TextBox_Enter);
            this.username_TextBox.Leave += new System.EventHandler(this.username_TextBox_Leave);
            // 
            // password_TextBox
            // 
            this.password_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_TextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.password_TextBox.Location = new System.Drawing.Point(50, 225);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.Size = new System.Drawing.Size(156, 20);
            this.password_TextBox.TabIndex = 4;
            this.password_TextBox.Text = "Password";
            this.password_TextBox.Enter += new System.EventHandler(this.password_TextBox_Enter);
            this.password_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_TextBox_KeyDown);
            this.password_TextBox.Leave += new System.EventHandler(this.password_TextBox_Leave);
            // 
            // login_Button
            // 
            this.login_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.login_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Button.ForeColor = System.Drawing.Color.White;
            this.login_Button.Location = new System.Drawing.Point(50, 283);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(75, 33);
            this.login_Button.TabIndex = 0;
            this.login_Button.Text = "Login";
            this.login_Button.UseVisualStyleBackColor = false;
            this.login_Button.Click += new System.EventHandler(this.login_Button_Click);
            // 
            // register_Button
            // 
            this.register_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.register_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_Button.ForeColor = System.Drawing.Color.White;
            this.register_Button.Location = new System.Drawing.Point(131, 283);
            this.register_Button.Name = "register_Button";
            this.register_Button.Size = new System.Drawing.Size(75, 33);
            this.register_Button.TabIndex = 1;
            this.register_Button.Text = "Register";
            this.register_Button.UseVisualStyleBackColor = false;
            this.register_Button.Click += new System.EventHandler(this.register_Button_Click);
            // 
            // hide_PictureBox
            // 
            this.hide_PictureBox.Image = global::ChatApp.Properties.Resources.eye_close;
            this.hide_PictureBox.Location = new System.Drawing.Point(212, 225);
            this.hide_PictureBox.Name = "hide_PictureBox";
            this.hide_PictureBox.Size = new System.Drawing.Size(20, 20);
            this.hide_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hide_PictureBox.TabIndex = 4;
            this.hide_PictureBox.TabStop = false;
            this.hide_PictureBox.Tag = "";
            this.hide_PictureBox.Visible = false;
            this.hide_PictureBox.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(224, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // login_PictureBox
            // 
            this.login_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("login_PictureBox.Image")));
            this.login_PictureBox.Location = new System.Drawing.Point(78, 40);
            this.login_PictureBox.Name = "login_PictureBox";
            this.login_PictureBox.Size = new System.Drawing.Size(100, 100);
            this.login_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.login_PictureBox.TabIndex = 0;
            this.login_PictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.login_PictureBox);
            this.panel1.Controls.Add(this.login_Button);
            this.panel1.Controls.Add(this.register_Button);
            this.panel1.Controls.Add(this.username_TextBox);
            this.panel1.Controls.Add(this.password_TextBox);
            this.panel1.Controls.Add(this.hide_PictureBox);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 356);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(205)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(256, 356);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.hide_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_PictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox login_PictureBox;
        private System.Windows.Forms.TextBox username_TextBox;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox hide_PictureBox;
        private System.Windows.Forms.Button login_Button;
        private System.Windows.Forms.Button register_Button;
        private System.Windows.Forms.Panel panel1;
    }
}

