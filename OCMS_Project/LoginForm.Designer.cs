namespace OCMS_Project
{
    partial class LoginPage_cs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage_cs));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reg_Button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.password_Box = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.username_Box = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.reg_Button);
            this.groupBox1.Controls.Add(this.login_button);
            this.groupBox1.Controls.Add(this.reset_button);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Welcome To OCMS";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // reg_Button
            // 
            this.reg_Button.Location = new System.Drawing.Point(188, 181);
            this.reg_Button.Name = "reg_Button";
            this.reg_Button.Size = new System.Drawing.Size(93, 36);
            this.reg_Button.TabIndex = 5;
            this.reg_Button.Text = "Register";
            this.reg_Button.UseVisualStyleBackColor = true;
            this.reg_Button.Click += new System.EventHandler(this.reg_Button_Click);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(386, 181);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(93, 36);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(287, 181);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(93, 36);
            this.reset_button.TabIndex = 3;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.password_Box);
            this.groupBox3.Location = new System.Drawing.Point(128, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 64);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Password";
            // 
            // password_Box
            // 
            this.password_Box.Location = new System.Drawing.Point(16, 23);
            this.password_Box.Name = "password_Box";
            this.password_Box.Size = new System.Drawing.Size(316, 20);
            this.password_Box.TabIndex = 3;
            this.password_Box.UseSystemPasswordChar = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.username_Box);
            this.groupBox2.Location = new System.Drawing.Point(128, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 60);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Username";
            // 
            // username_Box
            // 
            this.username_Box.Location = new System.Drawing.Point(16, 22);
            this.username_Box.Name = "username_Box";
            this.username_Box.Size = new System.Drawing.Size(316, 20);
            this.username_Box.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OCMS_Project.Properties.Resources.banner_left;
            this.pictureBox1.Location = new System.Drawing.Point(9, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(190, 223);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(289, 13);
            this.progressBar1.TabIndex = 6;
            // 
            // LoginPage_cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 270);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginPage_cs";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginPage_cs_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginPage_cs_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox password_Box;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox username_Box;
        private System.Windows.Forms.Button reg_Button;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

