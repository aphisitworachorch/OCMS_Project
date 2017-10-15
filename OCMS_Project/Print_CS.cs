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
    public partial class Print_CS : Form
    {
        public Print_CS()
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

        public String priv;

        public String upv
        {
            get { return priv; }
            set { priv = value; }
        }


        private void Print_CS_FormClosed(object sender, FormClosedEventArgs e)
        {
            OCMS_Form main2 = new OCMS_Form();
            main2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Print_CS_Load(object sender, EventArgs e)
        {

        }
    }
}
