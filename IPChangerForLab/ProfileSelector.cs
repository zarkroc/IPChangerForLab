using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IPChangerForLab
{
    public partial class IPChanger : Form
    {
        private ArrayList nicList;
        private ProfileList profileList;

        public IPChanger()
        {
            InitializeComponent();
            nicList = Utils.GetNICNames();
            profileList = new ProfileList();

            // populate the NIC list
            nicSelectBox.Items.Clear();
            foreach (string name in nicList)
                nicSelectBox.Items.Add(name);

            // if NIC found, select the first one
            if (nicSelectBox.Items.Count > 0)
            {
                nicSelectBox.SelectedIndex = 0;
                nicSelectBox.Enabled = true;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {

        }

        private void CheckedIPListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateProfile_Click(object sender, EventArgs e)
        {
            CreateProfile createProfile = new CreateProfile();
            createProfile.Show();
            Console.WriteLine("Yo!");
            foreach (NicProfile profile in profileList.NicProfiles)
            {
                Console.WriteLine(profile.Name);
                checkedProfileList.Items.Add(profile.Name);
            }
        }

        private void NetworkCard_SelectedIndex(object sender, EventArgs e)
        {

        }
    }
}
