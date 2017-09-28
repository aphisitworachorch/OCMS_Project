using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCMS_Project
{
    public partial class DeviceMgmr_CS : Form
    {
        public DeviceMgmr_CS()
        {
            InitializeComponent();
        }

        private void DeviceMgmr_CS_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            OCMS_Form main = new OCMS_Form();
            main.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeviceMgmr_Add_CS devadd = new DeviceMgmr_Add_CS();
            devadd.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeviceMgmr_Edit devedit = new DeviceMgmr_Edit();
            devedit.Show();
        }
    }
}
