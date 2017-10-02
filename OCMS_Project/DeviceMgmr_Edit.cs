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
    public partial class DeviceMgmr_Edit : Form
    {
        public DeviceMgmr_Edit()
        {
            InitializeComponent();
        }

        private void DeviceMgmr_Edit_FormClosing(object sender, FormClosingEventArgs e)
        {
            DeviceMgmr_CS devmain = new OCMS_Project.DeviceMgmr_CS();
            devmain.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
