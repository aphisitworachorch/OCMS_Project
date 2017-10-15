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
        static Thread splash = null;
        private String fullname;
        private String lastname;
        private String userlogin;
        public int i;
        public LoginPage_cs()
        {
            try
            {
                splash = new Thread(new ThreadStart(Splash));

                splash.Start();

                InitializeComponent();

                Thread.Sleep(5000);

                Console.WriteLine("Complete");

                splash.Abort();

            } catch (System.Threading.ThreadAbortException)
            {
                Thread.ResetAbort();
            }
        }


        public void Splash()
        {
            try
            {
                Application.Run(new SP_2());
                splash.Abort();
            } catch(System.Threading.ThreadAbortException)
            {
                Thread.ResetAbort();
            }
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
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 10;
            try
            {
                progressBar1.Style = ProgressBarStyle.Blocks;
                SqlConnection _connect1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\OCMS\db\crediental.mdf;Integrated Security=True;Connect Timeout=30");
                progressBar1.Value = 20;
                SqlDataAdapter _datadp1 = new SqlDataAdapter("select count(*) from login where username ='" + username_Box.Text + "' and password='" + password_Box.Text + "'", _connect1);
                DataTable credientals = new DataTable();
                _datadp1.Fill(credientals);
                progressBar1.Value = 50;
                if (credientals.Rows[0][0].ToString() == "1")
                {
                    progressBar1.Value = 100;
                    MessageBox.Show("Login Successful ! You're " + username_Box.Text , "Message From System");
                    this.Hide();

                    this.getTheName(username_Box.Text);
                    this.Hide();
                    OCMS_Form main = new OCMS_Project.OCMS_Form();
                    main.Uname = fullname;
                    main.Lname = lastname;
                    main.Usr = userlogin;
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Invalid ! ", "Message From System");
                    progressBar1.Value = 0;
                }
            } catch (System.NullReferenceException)
            {
                MessageBox.Show("Error !", "Message From System");
                progressBar1.Style = ProgressBarStyle.Marquee;
                progressBar1.MarqueeAnimationSpeed = 3;
            }
        }

        private void getTheName(String username)
        {
            username = username_Box.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\OCMS\db\crediental.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                String query = "SELECT name AS name_sql, surname AS surname_sql, username AS username_sql FROM login WHERE username = @username";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.ExecuteScalar();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    fullname = rdr["name_sql"].ToString();
                    lastname = rdr["surname_sql"].ToString();
                    userlogin = rdr["username_sql"].ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error To Fetch ");
            }
            finally
            {
                con.Close();
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
                Application.ExitThread();
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
                Application.ExitThread();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Invalid Operation Error ! Please Check Carefully");
            }
        }
    }
}
