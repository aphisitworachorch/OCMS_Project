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
    public partial class DeviceMgmr_Add_CS : Form
    {
        public DeviceMgmr_Add_CS()
        {
            InitializeComponent();
        }

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

        private void DeviceMgmr_Add_CS_FormClosing(object sender, FormClosingEventArgs e)
        {
            DeviceMgmr_CS devmain = new OCMS_Project.DeviceMgmr_CS();
            devmain.Show();
        }

        private void DeviceMgmr_Add_CS_Load(object sender, EventArgs e)
        {

        }

        private void save_reg_Click(object sender, EventArgs e)
        {
            SqlConnection _connect1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\OCMS\db\device_db.mdf;Integrated Security=True;Connect Timeout=30");
            _connect1.Open();

            string dev = "INSERT INTO device_db(username , device_name , device_type , serial_num , import_date , expire_date , time_save) VALUES ('" + Usr + "' , '" + device_name.Text + "' , '" + this.device_type.GetItemText(this.device_type.SelectedItem) + "' , '" + serial_num.Text + "' , '" + this.import_date.Text + "' , '" + this.expire_date.Text + "' , '" + DateTime.Now + "')";

            SqlCommand reg_cmd = new SqlCommand(dev, _connect1);

            reg_cmd.ExecuteNonQuery();

            MessageBox.Show("Device Add Complete !");

            _connect1.Close();

        }
    }
}
