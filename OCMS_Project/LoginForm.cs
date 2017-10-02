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
    public partial class LoginPage_cs : Form
    {
        public LoginPage_cs()
        {

            Thread t = new Thread(new ThreadStart(Splash));
            t.Start();
            Thread.Sleep(5000);

            InitializeComponent();

            t.Abort();
        }


        public void Splash()
        {
            Application.Run(new SP_2());
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            username_Box.Text = "";
            password_Box.Text = "";
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            SqlConnection _connect1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\OCMS\db\crediental.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter _datadp1 = new SqlDataAdapter("select count(*) from login where username ='" + username_Box.Text + "' and password='" + password_Box.Text + "'", _connect1);
            DataTable credientals = new DataTable();
            _datadp1.Fill(credientals);
            if (credientals.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Login Successful ! You're " + username_Box.Text);

                this.Hide();

                OCMS_Form main = new OCMS_Form();
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid ! ");
            }
        }

        private void reg_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registrar_form reg = new Registrar_form();
            reg.Show();
        }

        private void LoginPage_cs_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Application.Exit();
            } catch(InvalidOperationException)
            {
                MessageBox.Show("Invalid Operation Error ! Please Check Carefully");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LoginPage_cs_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Invalid Operation Error ! Please Check Carefully");
            }
        }
    }
}
