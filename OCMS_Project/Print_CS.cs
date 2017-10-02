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

        private void Print_CS_FormClosed(object sender, FormClosedEventArgs e)
        {
            OCMS_Form main2 = new OCMS_Form();
            main2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
