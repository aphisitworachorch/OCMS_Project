using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCMS_Project
{
    public partial class DeviceMgmr_CS : Form
    {
        public DeviceMgmr_CS()
        {
            InitializeComponent();
        }

        private String uname;

        public String Uname
        {
            get { return uname; }
            set { uname = value; }
        }

        private String lname;

        public String Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        private String usr;

        public String Usr
        {
            get { return usr; }
            set { usr = value; }
        }

        public String priv;

        public String upv
        {
            get { return priv; }
            set { priv = value; }
        }

        private void DeviceMgmr_CS_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            } catch (System.NullReferenceException)
            {
                MessageBox.Show("Internal Error");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            { 
            DeviceMgmr_Add_CS devadd = new OCMS_Project.DeviceMgmr_Add_CS();
            devadd.Uname = uname;
            devadd.Lname = lname;
            devadd.Usr = usr;
            devadd.priv = upv;
            this.Hide();
            devadd.Show();
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Internal Error");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try { 
            DeviceMgmr_Edit devedit = new OCMS_Project.DeviceMgmr_Edit();
            devedit.Uname = uname;
            devedit.Lname = lname;
            devedit.Usr = usr;
            devedit.priv = upv;
            this.Hide();
            devedit.Show();
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Internal Error");
            }
        }

        private void DeviceMgmr_CS_Load(object sender, EventArgs e)
        {
            try
            {
                if(upv == "user")
                {
                    this.Size = new Size(240, 225);
                    pictureBox2.Hide();
                } else if (upv == "admin") {
                    this.Size = new Size(371, 225);
                    pictureBox2.Show();
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Internal Error");
            }
        }

        private void DeviceMgmr_CS_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                OCMS_Form main = new OCMS_Project.OCMS_Form();
                main.Uname = uname;
                main.Lname = lname;
                main.Usr = usr;
                main.priv = upv;
                main.Show();
                this.Hide();
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Internal Error");
            }
        }
    }
}
