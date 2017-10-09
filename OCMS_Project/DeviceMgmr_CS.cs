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

        private void DeviceMgmr_CS_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.Hide();
                OCMS_Form main = new OCMS_Form();
                main.Uname = uname.Trim();
                main.Lname = lname.Trim();
                main.Usr = usr.Trim();
                main.Show();
            } catch (System.NullReferenceException)
            {
                MessageBox.Show("Internal Error");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            { 
            DeviceMgmr_Add_CS devadd = new DeviceMgmr_Add_CS();
            devadd.Uname = uname.Trim();
            devadd.Lname = lname.Trim();
            devadd.Usr = usr.Trim();
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
            DeviceMgmr_Edit devedit = new DeviceMgmr_Edit();
            devedit.Uname = uname.Trim();
            devedit.Lname = lname.Trim();
            devedit.Usr = usr.Trim();
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

            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Internal Error");
            }
        }
    }
}
