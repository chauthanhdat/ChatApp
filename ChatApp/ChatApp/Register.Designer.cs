namespace ChatApp
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_PictureBox = new System.Windows.Forms.PictureBox();
            this.a_PictureBox = new System.Windows.Forms.PictureBox();
            this.OK_Button = new System.Windows.Forms.Button();
            this.confirmPassword_TextBox = new System.Windows.Forms.TextBox();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.username_TextBox = new System.Windows.Forms.TextBox();
            this.fullName_TextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.close_PictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.b_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.b_PictureBox);
            this.panel1.Controls.Add(this.a_PictureBox);
            this.panel1.Controls.Add(this.OK_Button);
            this.panel1.Controls.Add(this.confirmPassword_TextBox);
            this.panel1.Controls.Add(this.password_TextBox);
            this.panel1.Controls.Add(this.username_TextBox);
            this.panel1.Controls.Add(this.fullName_TextBox);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.close_PictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 356);
            this.panel1.TabIndex = 0;
            // 
            // b_PictureBox
            // 
            this.b_PictureBox.Image = global::ChatApp.Properties.Resources.eye_open;
            this.b_PictureBox.Location = new System.Drawing.Point(212, 251);
            this.b_PictureBox.Name = "b_PictureBox";
            this.b_PictureBox.Size = new System.Drawing.Size(20, 20);
            this.b_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.b_PictureBox.TabIndex = 6;
            this.b_PictureBox.TabStop = false;
            this.b_PictureBox.Tag = "";
            this.b_PictureBox.Visible = false;
            this.b_PictureBox.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // a_PictureBox
            // 
            this.a_PictureBox.Image = global::ChatApp.Properties.Resources.eye_open;
            this.a_PictureBox.Location = new System.Drawing.Point(212, 225);
            this.a_PictureBox.Name = "a_PictureBox";
            this.a_PictureBox.Size = new System.Drawing.Size(20, 20);
            this.a_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.a_PictureBox.TabIndex = 5;
            this.a_PictureBox.TabStop = false;
            this.a_PictureBox.Tag = "";
            this.a_PictureBox.Visible = false;
            this.a_PictureBox.Click += new System.EventHandler(this.hide_PictureBox_Click);
            // 
            // OK_Button
            // 
            this.OK_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.OK_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK_Button.ForeColor = System.Drawing.Color.White;
            this.OK_Button.Location = new System.Drawing.Point(89, 283);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 33);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = false;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // confirmPassword_TextBox
            // 
            this.confirmPassword_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassword_TextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.confirmPassword_TextBox.Location = new System.Drawing.Point(50, 251);
            this.confirmPassword_TextBox.Name = "confirmPassword_TextBox";
            this.confirmPassword_TextBox.Size = new System.Drawing.Size(156, 20);
            this.confirmPassword_TextBox.TabIndex = 4;
            this.confirmPassword_TextBox.Text = "Confirm Password";
            this.confirmPassword_TextBox.Enter += new System.EventHandler(this.confirmPassword_TextBox_Enter);
            this.confirmPassword_TextBox.Leave += new System.EventHandler(this.confirmPassword_TextBox_Leave);
            // 
            // password_TextBox
            // 
            this.password_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_TextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.password_TextBox.Location = new System.Drawing.Point(50, 225);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.Size = new System.Drawing.Size(156, 20);
            this.password_TextBox.TabIndex = 3;
            this.password_TextBox.Text = "Password";
            this.password_TextBox.Enter += new System.EventHandler(this.password_TextBox_Enter);
            this.password_TextBox.Leave += new System.EventHandler(this.password_TextBox_Leave);
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
            this.username_TextBox.Enter += new System.EventHandler(this.textBox2_Enter);
            this.username_TextBox.Leave += new System.EventHandler(this.username_TextBox_Leave);
            // 
            // fullName_TextBox
            // 
            this.fullName_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullName_TextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.fullName_TextBox.Location = new System.Drawing.Point(50, 173);
            this.fullName_TextBox.Name = "fullName_TextBox";
            this.fullName_TextBox.Size = new System.Drawing.Size(156, 20);
            this.fullName_TextBox.TabIndex = 1;
            this.fullName_TextBox.Text = "Full Name";
            this.fullName_TextBox.Enter += new System.EventHandler(this.textBox1_Enter);
            this.fullName_TextBox.Leave += new System.EventHandler(this.fullName_TextBox_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(78, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // close_PictureBox
            // 
            this.close_PictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_PictureBox.BackgroundImage")));
            this.close_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close_PictureBox.Location = new System.Drawing.Point(12, 12);
            this.close_PictureBox.Name = "close_PictureBox";
            this.close_PictureBox.Size = new System.Drawing.Size(20, 20);
            this.close_PictureBox.TabIndex = 0;
            this.close_PictureBox.TabStop = false;
            this.close_PictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(205)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(256, 356);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.b_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox close_PictureBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox fullName_TextBox;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.TextBox username_TextBox;
        private System.Windows.Forms.TextBox confirmPassword_TextBox;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.PictureBox b_PictureBox;
        private System.Windows.Forms.PictureBox a_PictureBox;
    }
}