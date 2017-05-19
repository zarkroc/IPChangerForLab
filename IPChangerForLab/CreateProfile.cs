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
        internal NicProfile nicProfile;



        private void CheckBoxDhcp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDhcp.Checked)
            {
                useDhcp = true;
                inputBoxIP.Text = null;
                inputBoxGateway.Text = null;
                inputBoxNetmask.Text = null;
            }

        }

        private void CreateProfile_Load(object sender, EventArgs e)
        {

        }

        public CreateProfile()
        {
            InitializeComponent();
        }
        
           

        private void ProfileButtonOk_Click(object sender, EventArgs e)
        {
            ipAddr = inputBoxIP.Text;
            subnetAddr = inputBoxNetmask.Text;
            gatewayAddr = inputBoxGateway.Text;
            name = inputBoxName.Text;
            nicProfile = new NicProfile(name, ipAddr, subnetAddr, gatewayAddr, useDhcp);
            Close();
        }

  
        private void ProfileButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
