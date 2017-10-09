using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OCMS_Project
{
    public partial class SP_2 : Form
    {
        public SP_2()
        {
            try
            {
                InitializeComponent();

                timer1.Start();

                progressBar1.Style = ProgressBarStyle.Marquee;
                progressBar1.MarqueeAnimationSpeed = 10;
                SqlConnection _connect1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\OCMS\db\crediental.mdf;Integrated Security=True;Connect Timeout=30");

            }
            catch (System.Threading.ThreadAbortException)
            {
                MessageBox.Show("Exception Just in Time ! , Please Restart Application");
                Application.ExitThread();
            }
        }

        private void SP_2_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

    }
}
