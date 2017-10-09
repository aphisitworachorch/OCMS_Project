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
    public partial class DeviceMgmr_Edit : Form
    {
        public DeviceMgmr_Edit()
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


        private void DeviceMgmr_Edit_FormClosing(object sender, FormClosingEventArgs e)
        {
            DeviceMgmr_CS devmain = new OCMS_Project.DeviceMgmr_CS();
            devmain.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeviceMgmr_Edit_Load(object sender, EventArgs e)
        {

        }
    }
}
