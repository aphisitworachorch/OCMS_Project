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
    public partial class OCMS_Form : Form
    {
        public OCMS_Form()
        {
            InitializeComponent();
        }

        private void OCMS_Form_Load(object sender, EventArgs e)
        {
            timer1.Start();
            clockText.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void clockText_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void OCMS_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void OCMS_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { 
            this.Hide();
            LoginPage_cs login = new LoginPage_cs();
            login.Show();
            } catch (DivideByZeroException)
            {
                MessageBox.Show("Error : Divide By Zero Exception","Error");
            }
        }

        private void maintain_Box_Click(object sender, EventArgs e)
        {
            try { 
            this.Hide();
            Fix_FormCS fxfrm = new Fix_FormCS();
            fxfrm.Show();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Error : Divide By Zero Exception", "Error");
            }
        }

        private void DeviceMgmr_Box_Click(object sender, EventArgs e)
        {
            try {
            this.Hide();
            DeviceMgmr_CS devmgr = new DeviceMgmr_CS();
            devmgr.Show();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Error : Divide By Zero Exception", "Error");
            }
        }

        private void printReport_Box_Click(object sender, EventArgs e)
        {
            try { 
            this.Hide();
            Print_CS print = new Print_CS();
            print.Show();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Error : Divide By Zero Exception", "Error");
            }
        }

        private void Logout_Box_Click(object sender, EventArgs e)
        {
            try {
            this.Hide();
            LoginPage_cs main = new OCMS_Project.LoginPage_cs();
            main.Show();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Error : Divide By Zero Exception", "Error");
            }
        }
    }
}
