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
    public partial class DeviceMgmr_Add_CS : Form
    {
        public DeviceMgmr_Add_CS()
        {
            InitializeComponent();
        }

        private void DeviceMgmr_Add_CS_FormClosing(object sender, FormClosingEventArgs e)
        {
            DeviceMgmr_CS devmain = new OCMS_Project.DeviceMgmr_CS();
            devmain.Show();
        }
    }
}
