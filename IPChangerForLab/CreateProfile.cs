using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IPChangerForLab
{
    public partial class CreateProfile : Form
    {
        private string ipAddr, subnetAddr, gatewayAddr, name;
        private bool useDhcp;
        

        private void checkBoxDhcp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDhcp.Checked)
                useDhcp = true;
        }

        public CreateProfile()
        {
            InitializeComponent();
        }
        
           

        private void profileButtonOk_Click(object sender, EventArgs e)
        {
            ipAddr = inputBoxIP.Text;
            subnetAddr = inputBoxNetmask.Text;
            gatewayAddr = inputBoxGateway.Text;
            name = inputBoxName.Text;
            NicProfile nicProfile = new NicProfile(name, ipAddr, subnetAddr, gatewayAddr, useDhcp);
            Close();
        }

        private void profileButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
