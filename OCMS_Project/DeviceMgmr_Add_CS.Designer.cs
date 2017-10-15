namespace OCMS_Project
{
    partial class DeviceMgmr_Add_CS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceMgmr_Add_CS));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.save_reg = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.expire_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.import_date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.device_type = new System.Windows.Forms.ComboBox();
            this.serial_num = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.device_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.save_reg);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.expire_date);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.import_date);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.device_type);
            this.groupBox2.Controls.Add(this.serial_num);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.device_name);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 278);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "กรอกข้อมูลอุปกรณ์";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "ล้างทั้งหมด";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // save_reg
            // 
            this.save_reg.Location = new System.Drawing.Point(10, 231);
            this.save_reg.Name = "save_reg";
            this.save_reg.Size = new System.Drawing.Size(110, 33);
            this.save_reg.TabIndex = 10;
            this.save_reg.Text = "บันทึก";
            this.save_reg.UseVisualStyleBackColor = true;
            this.save_reg.Click += new System.EventHandler(this.save_reg_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "วันที่หมดอายุ";
            // 
            // expire_date
            // 
            this.expire_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expire_date.Location = new System.Drawing.Point(10, 202);
            this.expire_date.Name = "expire_date";
            this.expire_date.Size = new System.Drawing.Size(247, 20);
            this.expire_date.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "วันที่นำเข้า";
            // 
            // import_date
            // 
            this.import_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.import_date.Location = new System.Drawing.Point(10, 160);
            this.import_date.Name = "import_date";
            this.import_date.Size = new System.Drawing.Size(247, 20);
            this.import_date.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ประเภทอุปกรณ์";
            // 
            // device_type
            // 
            this.device_type.FormattingEnabled = true;
            this.device_type.Items.AddRange(new object[] {
            "Tablet",
            "Laptop",
            "PC",
            "Server",
            "Network Instrument",
            "Other"});
            this.device_type.Location = new System.Drawing.Point(10, 78);
            this.device_type.Name = "device_type";
            this.device_type.Size = new System.Drawing.Size(247, 21);
            this.device_type.TabIndex = 4;
            // 
            // serial_num
            // 
            this.serial_num.Location = new System.Drawing.Point(10, 119);
            this.serial_num.Name = "serial_num";
            this.serial_num.Size = new System.Drawing.Size(247, 20);
            this.serial_num.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "หมายเลขเครื่อง";
            // 
            // device_name
            // 
            this.device_name.Location = new System.Drawing.Point(10, 37);
            this.device_name.Name = "device_name";
            this.device_name.Size = new System.Drawing.Size(247, 20);
            this.device_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชื่ออุปกรณ์";
            // 
            // DeviceMgmr_Add_CS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 328);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeviceMgmr_Add_CS";
            this.Text = "Device Query";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeviceMgmr_Add_CS_FormClosing);
            this.Load += new System.EventHandler(this.DeviceMgmr_Add_CS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button save_reg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker expire_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker import_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox device_type;
        private System.Windows.Forms.TextBox serial_num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox device_name;
        private System.Windows.Forms.Label label1;
    }
}