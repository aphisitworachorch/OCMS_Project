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
        private String fullname;
        private String lastname;
        private String userlogin;

        public LoginPage_cs()
        {
            try
            {
                Thread t = new Thread(new ThreadStart(Splash));
                t.Start();
                Thread.Sleep(5000);

                InitializeComponent();

                t.Abort();
            } catch (System.Threading.ThreadAbortException)
            {
                MessageBox.Show("Exception Just in Time ! , Please Restart Application");
            }
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
            try
            {
                SqlConnection _connect1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\OCMS\db\crediental.mdf;Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter _datadp1 = new SqlDataAdapter("select count(*) from login where username ='" + username_Box.Text + "' and password='" + password_Box.Text + "'", _connect1);
                DataTable credientals = new DataTable();
                _datadp1.Fill(credientals);
                if (credientals.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Login Successful ! You're " + username_Box.Text);

                    this.Hide();

                    this.getTheName(username_Box.Text);
                    this.Hide();
                    OCMS_Form main = new OCMS_Form();
                    main.Uname = fullname.Trim();
                    main.Lname = lastname.Trim();
                    main.Usr = userlogin.Trim();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Invalid ! ");
                }
            } catch (System.NullReferenceException)
            {
                MessageBox.Show("Error !");
            }
        }

        private void getTheName(String username)
        {
            username = username_Box.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\OCMS\db\crediental.mdf;Integrated Security=True;Connect Timeout=30");
            String query = "SELECT name AS name_sql, surname AS surname_sql, username AS username_sql FROM login WHERE username = @username";
            try
            {
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
                Application.ExitThread();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Invalid Operation Error ! Please Check Carefully");
            }
        }
    }
}
