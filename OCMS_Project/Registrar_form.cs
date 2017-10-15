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
        static string priv;
        public Registrar_form()
        {
            InitializeComponent();
        }

        private void Registrar_form_Load(object sender, EventArgs e)
        {

        }

        private void Registrar_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { 
            LoginPage_cs main = new OCMS_Project.LoginPage_cs();
            main.Show();
            this.Hide();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Error : Divide By Zero Exception", "Error");
            }
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
            try
            {
                if (password_reg.Text.Length <= 5)
                {
                    password_Weak = 20;
                }
                else if (password_reg.Text.Length >= 10)
                {
                    password_Weak = 100;
                }
                else if (password_reg.Text.Length > 10)
                {
                    MessageBox.Show("Password Too Long");   
                } else
                {
                    password_Weak = 0;
                }

                /* Password Check */

                progressBar1.Value = password_reg.Text.Length * 9;

                if (password_Weak <= 20)
                {
                    password_leak_indc.Text = "อ่อน";
                }
                else if (password_Weak >= 100)
                {
                    password_leak_indc.Text = "ใช้ได้";
                }
                else if (password_Weak == 0)
                {
                    password_leak_indc.Text = "NULL";
                }
            } catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Your Password Length is so long !");
            }

        }

        private void password_leak_indc_Click(object sender, EventArgs e)
        {

        }

        private void save_Button_Click(object sender, EventArgs e)
        {
            if(name_reg.Text.Length <= 0 || surname_reg.Text.Length <= 0 || username_reg.Text.Length <=0 || password_reg.Text.Length <= 0)
            {
                MessageBox.Show("มีบางสิ่งบางอย่างขาดหายนะ กรุณาตรวจสอบให้ถูกต้องก่อนกดลงทะเบียน", "เตือน");
            }

            try { 
            SqlConnection _connect1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\OCMS\db\crediental.mdf;Integrated Security=True;Connect Timeout=30");
            _connect1.Open();
            
            if(admincheckbox.Checked)
                {
                    priv = "admin";
                    string reg = "INSERT INTO login(name , surname , username , password , user_privilege) VALUES ('" + name_reg.Text + "' , '" + surname_reg.Text + "' , '" + username_reg.Text + "' , '" + password_reg.Text + "' , '" + priv + "')";

                    SqlCommand reg_cmd = new SqlCommand(reg, _connect1);

                    reg_cmd.ExecuteNonQuery();

                    MessageBox.Show("ลงทะเบียนสำเร็จ คุณคือ " + name_reg.Text + " " + surname_reg.Text);
                } else if(usercheckbox.Checked) {
                    priv = "user";
                    string reg = "INSERT INTO login(name , surname , username , password , user_privilege) VALUES ('" + name_reg.Text + "' , '" + surname_reg.Text + "' , '" + username_reg.Text + "' , '" + password_reg.Text + "' , '" + priv + "')";

                    SqlCommand reg_cmd = new SqlCommand(reg, _connect1);

                    reg_cmd.ExecuteNonQuery();

                    MessageBox.Show("ลงทะเบียนสำเร็จ คุณคือ " + name_reg.Text + " " + surname_reg.Text);
                } else if(usercheckbox.Checked && admincheckbox.Checked)
                {
                    MessageBox.Show("Please Select One of your user privillege");
                } else
                {
                    MessageBox.Show("Please Select User Privillege");
                }
            

            }
            catch (Exception)
            {
                MessageBox.Show("Database Entering Error , \nPlease Check Carefully !");
            }

        }

        private void common_box_Enter(object sender, EventArgs e)
        {

        }
    }
}
