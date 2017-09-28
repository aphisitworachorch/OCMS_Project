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
    public partial class Registrar_form : Form
    {
        static int password_Weak;
        public Registrar_form()
        {
            InitializeComponent();
        }

        private void Registrar_form_Load(object sender, EventArgs e)
        {

        }

        private void Registrar_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginPage_cs main = new LoginPage_cs();
            main.Show();
        }

        private void name_reg_TextChanged(object sender, EventArgs e)
        {

        }

        private void surname_reg_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_reg_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_reg_TextChanged(object sender, EventArgs e)
        {
            if(password_reg.Text.Length <= 5)
            {
                password_Weak = 20;
            } else if(password_reg.Text.Length >= 10)
            {
                password_Weak = 100;
            } else
            {
                password_Weak = 0;
            }

            /* Password Check */

            if (password_Weak <= 20)
            {
                password_leak_indc.Text = "Weak";
                progressBar1.Value = 50;
            }
            else if (password_Weak >= 100)
            {
                password_leak_indc.Text = "Strong";
                progressBar1.Value = 100;
            }
            else if (password_Weak == 0)
            {
                password_leak_indc.Text = "NULL";
                progressBar1.Value = 0;
            }

        }

        private void password_leak_indc_Click(object sender, EventArgs e)
        {

        }

        private void save_Button_Click(object sender, EventArgs e)
        {
            SqlConnection _connect1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\OCMS\db\crediental.mdf;Integrated Security=True;Connect Timeout=30");
            _connect1.Open();

            string reg = "INSERT INTO login(name , surname , username , password) VALUES ('" + name_reg.Text + "' , '" + surname_reg.Text + "' , '" + username_reg.Text + "' , '" + password_reg.Text + "')";

            SqlCommand reg_cmd = new SqlCommand(reg, _connect1);

            reg_cmd.ExecuteNonQuery();

            MessageBox.Show("Register Completed !");

        }
    }
}
