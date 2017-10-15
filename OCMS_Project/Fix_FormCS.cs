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
    public partial class Fix_FormCS : Form
    {
        public Fix_FormCS()
        {
            InitializeComponent();
        }

        public string devname;
        public string serialdev;
        public string devtype;

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

        private String usr;

        public String Usr
        {
            get { return usr; }
            set { usr = value; }
        }

        private void Fix_FormCS_Load(object sender, EventArgs e)
        {
            try
            {
                string namex;
                namex = uname + " " + lname;
                name_Show.Text = namex;
            } catch (Exception)
            {
                MessageBox.Show("Internal Error !");
            }

            // Database Importing
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\OCMS\db\device_db.mdf;Integrated Security=True;Connect Timeout=30");
            String query = "SELECT device_name AS devname, device_type AS devtype, serial_num AS serialdev FROM device_db WHERE username = @username";
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", Usr);
                cmd.ExecuteScalar();
                SqlDataReader rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                        devname = rdr["devname"].ToString();
                        comboBox1.Items.Add(devname);
                        devtype = rdr["devtype"].ToString();
                        comboBox2.Items.Add(devtype);
                        serialdev = rdr["serialdev"].ToString();
                        comboBox3.Items.Add(serialdev);
                }
            } catch (Exception) {
                MessageBox.Show("Error To Fetch ");
            }
            finally
            {
                con.Close();
            }

        }

        private void Fix_FormCS_FormClosing(object sender, FormClosingEventArgs e)
        {
            OCMS_Form xm = new OCMS_Project.OCMS_Form();
            xm.Uname = uname;
            xm.Lname = lname;
            xm.Usr = usr;
            xm.Show();
        }
    }
}
