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
    public partial class Fix_FormCS : Form
    {
        public Fix_FormCS()
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

        private void Fix_FormCS_Load(object sender, EventArgs e)
        {
            string namex;
            namex = uname + " " + lname;
            name_Show.Text = namex;
        }

        private void Fix_FormCS_FormClosing(object sender, FormClosingEventArgs e)
        {
            OCMS_Form xm = new OCMS_Form();
            xm.Show();
        }
    }
}
