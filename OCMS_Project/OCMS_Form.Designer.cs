namespace OCMS_Project
{
    partial class OCMS_Form
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeviceMgmr_Box = new System.Windows.Forms.PictureBox();
            this.Logout_Box = new System.Windows.Forms.PictureBox();
            this.maintain_Box = new System.Windows.Forms.PictureBox();
            this.printReport_Box = new System.Windows.Forms.PictureBox();
            this.clockText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeviceMgmr_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logout_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintain_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printReport_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeviceMgmr_Box);
            this.groupBox1.Controls.Add(this.Logout_Box);
            this.groupBox1.Controls.Add(this.maintain_Box);
            this.groupBox1.Controls.Add(this.printReport_Box);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 218);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // DeviceMgmr_Box
            // 
            this.DeviceMgmr_Box.Image = global::OCMS_Project.Properties.Resources.dev_mgr;
            this.DeviceMgmr_Box.Location = new System.Drawing.Point(16, 68);
            this.DeviceMgmr_Box.Name = "DeviceMgmr_Box";
            this.DeviceMgmr_Box.Size = new System.Drawing.Size(217, 39);
            this.DeviceMgmr_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeviceMgmr_Box.TabIndex = 2;
            this.DeviceMgmr_Box.TabStop = false;
            this.DeviceMgmr_Box.Click += new System.EventHandler(this.DeviceMgmr_Box_Click);
            // 
            // Logout_Box
            // 
            this.Logout_Box.Image = global::OCMS_Project.Properties.Resources.logout;
            this.Logout_Box.Location = new System.Drawing.Point(16, 158);
            this.Logout_Box.Name = "Logout_Box";
            this.Logout_Box.Size = new System.Drawing.Size(217, 39);
            this.Logout_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logout_Box.TabIndex = 3;
            this.Logout_Box.TabStop = false;
            // 
            // maintain_Box
            // 
            this.maintain_Box.Image = global::OCMS_Project.Properties.Resources.maintain_button;
            this.maintain_Box.Location = new System.Drawing.Point(16, 23);
            this.maintain_Box.Name = "maintain_Box";
            this.maintain_Box.Size = new System.Drawing.Size(217, 39);
            this.maintain_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maintain_Box.TabIndex = 0;
            this.maintain_Box.TabStop = false;
            this.maintain_Box.Click += new System.EventHandler(this.maintain_Box_Click);
            // 
            // printReport_Box
            // 
            this.printReport_Box.Image = global::OCMS_Project.Properties.Resources.print_report;
            this.printReport_Box.Location = new System.Drawing.Point(16, 113);
            this.printReport_Box.Name = "printReport_Box";
            this.printReport_Box.Size = new System.Drawing.Size(217, 39);
            this.printReport_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.printReport_Box.TabIndex = 1;
            this.printReport_Box.TabStop = false;
            this.printReport_Box.Click += new System.EventHandler(this.printReport_Box_Click);
            // 
            // clockText
            // 
            this.clockText.AutoSize = true;
            this.clockText.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.clockText.Location = new System.Drawing.Point(283, 24);
            this.clockText.Name = "clockText";
            this.clockText.Size = new System.Drawing.Size(0, 73);
            this.clockText.TabIndex = 5;
            this.clockText.Click += new System.EventHandler(this.clockText_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.OCMS_Form_Load);
            // 
            // OCMS_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 246);
            this.Controls.Add(this.clockText);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OCMS_Form";
            this.Text = "MAIN :: Organization Computer Maintenance System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OCMS_Form_FormClosing);
            this.Load += new System.EventHandler(this.OCMS_Form_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DeviceMgmr_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logout_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintain_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printReport_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox maintain_Box;
        private System.Windows.Forms.PictureBox printReport_Box;
        private System.Windows.Forms.PictureBox DeviceMgmr_Box;
        private System.Windows.Forms.PictureBox Logout_Box;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label clockText;
        private System.Windows.Forms.Timer timer1;
    }
}