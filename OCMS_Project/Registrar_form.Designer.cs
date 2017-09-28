namespace OCMS_Project
{
    partial class Registrar_form
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.all_box = new System.Windows.Forms.GroupBox();
            this.common_box = new System.Windows.Forms.GroupBox();
            this.reset_Button = new System.Windows.Forms.Button();
            this.save_Button = new System.Windows.Forms.Button();
            this.password_leak_indc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password_reg = new System.Windows.Forms.TextBox();
            this.username_banner = new System.Windows.Forms.Label();
            this.username_reg = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.surname_banner = new System.Windows.Forms.Label();
            this.realname_banner = new System.Windows.Forms.Label();
            this.surname_reg = new System.Windows.Forms.TextBox();
            this.name_reg = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.all_box.SuspendLayout();
            this.common_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OCMS_Project.Properties.Resources.registrar_banner;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // all_box
            // 
            this.all_box.Controls.Add(this.common_box);
            this.all_box.Location = new System.Drawing.Point(13, 83);
            this.all_box.Name = "all_box";
            this.all_box.Size = new System.Drawing.Size(280, 337);
            this.all_box.TabIndex = 1;
            this.all_box.TabStop = false;
            this.all_box.Text = "Information";
            // 
            // common_box
            // 
            this.common_box.Controls.Add(this.reset_Button);
            this.common_box.Controls.Add(this.save_Button);
            this.common_box.Controls.Add(this.password_leak_indc);
            this.common_box.Controls.Add(this.label1);
            this.common_box.Controls.Add(this.password_reg);
            this.common_box.Controls.Add(this.username_banner);
            this.common_box.Controls.Add(this.username_reg);
            this.common_box.Controls.Add(this.progressBar1);
            this.common_box.Controls.Add(this.surname_banner);
            this.common_box.Controls.Add(this.realname_banner);
            this.common_box.Controls.Add(this.surname_reg);
            this.common_box.Controls.Add(this.name_reg);
            this.common_box.Location = new System.Drawing.Point(11, 19);
            this.common_box.Name = "common_box";
            this.common_box.Size = new System.Drawing.Size(254, 302);
            this.common_box.TabIndex = 1;
            this.common_box.TabStop = false;
            this.common_box.Text = "Common Information";
            // 
            // reset_Button
            // 
            this.reset_Button.Location = new System.Drawing.Point(142, 265);
            this.reset_Button.Name = "reset_Button";
            this.reset_Button.Size = new System.Drawing.Size(100, 23);
            this.reset_Button.TabIndex = 11;
            this.reset_Button.Text = "Reset";
            this.reset_Button.UseVisualStyleBackColor = true;
            // 
            // save_Button
            // 
            this.save_Button.Location = new System.Drawing.Point(12, 265);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(100, 23);
            this.save_Button.TabIndex = 10;
            this.save_Button.Text = "Save";
            this.save_Button.UseVisualStyleBackColor = true;
            this.save_Button.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // password_leak_indc
            // 
            this.password_leak_indc.AutoSize = true;
            this.password_leak_indc.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.password_leak_indc.Location = new System.Drawing.Point(87, 200);
            this.password_leak_indc.Name = "password_leak_indc";
            this.password_leak_indc.Size = new System.Drawing.Size(79, 33);
            this.password_leak_indc.TabIndex = 9;
            this.password_leak_indc.Text = "####";
            this.password_leak_indc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.password_leak_indc.Click += new System.EventHandler(this.password_leak_indc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Password";
            // 
            // password_reg
            // 
            this.password_reg.Location = new System.Drawing.Point(12, 167);
            this.password_reg.Name = "password_reg";
            this.password_reg.Size = new System.Drawing.Size(231, 20);
            this.password_reg.TabIndex = 7;
            this.password_reg.TextChanged += new System.EventHandler(this.password_reg_TextChanged);
            // 
            // username_banner
            // 
            this.username_banner.AutoSize = true;
            this.username_banner.Location = new System.Drawing.Point(9, 108);
            this.username_banner.Name = "username_banner";
            this.username_banner.Size = new System.Drawing.Size(55, 13);
            this.username_banner.TabIndex = 6;
            this.username_banner.Text = "Username";
            // 
            // username_reg
            // 
            this.username_reg.Location = new System.Drawing.Point(11, 124);
            this.username_reg.Name = "username_reg";
            this.username_reg.Size = new System.Drawing.Size(231, 20);
            this.username_reg.TabIndex = 5;
            this.username_reg.TextChanged += new System.EventHandler(this.username_reg_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 236);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(229, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // surname_banner
            // 
            this.surname_banner.AutoSize = true;
            this.surname_banner.Location = new System.Drawing.Point(9, 64);
            this.surname_banner.Name = "surname_banner";
            this.surname_banner.Size = new System.Drawing.Size(49, 13);
            this.surname_banner.TabIndex = 3;
            this.surname_banner.Text = "Surname";
            // 
            // realname_banner
            // 
            this.realname_banner.AutoSize = true;
            this.realname_banner.Location = new System.Drawing.Point(9, 23);
            this.realname_banner.Name = "realname_banner";
            this.realname_banner.Size = new System.Drawing.Size(35, 13);
            this.realname_banner.TabIndex = 1;
            this.realname_banner.Text = "Name";
            // 
            // surname_reg
            // 
            this.surname_reg.Location = new System.Drawing.Point(11, 80);
            this.surname_reg.Name = "surname_reg";
            this.surname_reg.Size = new System.Drawing.Size(231, 20);
            this.surname_reg.TabIndex = 2;
            this.surname_reg.TextChanged += new System.EventHandler(this.surname_reg_TextChanged);
            // 
            // name_reg
            // 
            this.name_reg.Location = new System.Drawing.Point(11, 39);
            this.name_reg.Name = "name_reg";
            this.name_reg.Size = new System.Drawing.Size(231, 20);
            this.name_reg.TabIndex = 0;
            this.name_reg.TextChanged += new System.EventHandler(this.name_reg_TextChanged);
            // 
            // Registrar_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 430);
            this.Controls.Add(this.all_box);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Registrar_form";
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registrar_form_FormClosing);
            this.Load += new System.EventHandler(this.Registrar_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.all_box.ResumeLayout(false);
            this.common_box.ResumeLayout(false);
            this.common_box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox all_box;
        private System.Windows.Forms.GroupBox common_box;
        private System.Windows.Forms.Label surname_banner;
        private System.Windows.Forms.Label realname_banner;
        private System.Windows.Forms.TextBox surname_reg;
        private System.Windows.Forms.TextBox name_reg;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button reset_Button;
        private System.Windows.Forms.Button save_Button;
        private System.Windows.Forms.Label password_leak_indc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password_reg;
        private System.Windows.Forms.Label username_banner;
        private System.Windows.Forms.TextBox username_reg;
    }
}