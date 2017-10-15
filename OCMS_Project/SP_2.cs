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
using System.Threading;

namespace OCMS_Project
{
    public partial class SP_2 : Form
    {
        public static string err;
        public static string st;
        public static int looptest;
        public static string l1;
        public static int l2;
        public SP_2()
        {
            InitializeComponent();
            try
            {
                timer1.Start();

                try { 
                SqlConnection _connect1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\OCMS\db\crediental.mdf;Integrated Security=True;Connect Timeout=30");
                _connect1.Open();
                    st = "Database Connected ! . Wait for System Initialize";
                    status_box.Items.Add(st);
                } catch(Exception)
                {
                    err = "Database Connect Failed ! , Please Check Somethings later ";
                    status_box.Items.Add(err);
                }
                progressBar1.Style = ProgressBarStyle.Marquee;
                progressBar1.MarqueeAnimationSpeed = 10;

            }
            catch (System.Threading.ThreadAbortException)
            {
                st = "Error Was Catched by Programmer";
                status_box.Items.Add(st);
                MessageBox.Show("Exception Just in Time ! , Please Restart Application");
                Application.ExitThread();
            }
        }

        private void SP_2_Load(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Threading.ThreadAbortException)
            {
                st = "Error Was Catched by Programmer";
                status_box.Items.Add(st);
                MessageBox.Show("Exception Just in Time ! , Please Restart Application");
                Application.ExitThread();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

    }
}
