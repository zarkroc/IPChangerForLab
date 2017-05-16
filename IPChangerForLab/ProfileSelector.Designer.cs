namespace IPChangerForLab
{
    partial class IPChanger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.applySettings = new System.Windows.Forms.Button();
            this.checkedProfileList = new System.Windows.Forms.CheckedListBox();
            this.profileInformationTextBox = new System.Windows.Forms.TextBox();
            this.profileLabel = new System.Windows.Forms.Label();
            this.profileInformationLabel = new System.Windows.Forms.Label();
            this.createProfile = new System.Windows.Forms.Button();
            this.nicSelectBox = new System.Windows.Forms.ComboBox();
            this.nicLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // applySettings
            // 
            this.applySettings.Location = new System.Drawing.Point(206, 220);
            this.applySettings.Name = "applySettings";
            this.applySettings.Size = new System.Drawing.Size(94, 23);
            this.applySettings.TabIndex = 0;
            this.applySettings.Text = "Apply profile";
            this.applySettings.UseVisualStyleBackColor = true;
            this.applySettings.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // checkedProfileList
            // 
            this.checkedProfileList.FormattingEnabled = true;
            this.checkedProfileList.Location = new System.Drawing.Point(12, 65);
            this.checkedProfileList.Name = "checkedProfileList";
            this.checkedProfileList.Size = new System.Drawing.Size(136, 139);
            this.checkedProfileList.TabIndex = 1;
            this.checkedProfileList.SelectedIndexChanged += new System.EventHandler(this.CheckedIPListBox_SelectedIndexChanged);
            // 
            // profileInformationTextBox
            // 
            this.profileInformationTextBox.Location = new System.Drawing.Point(154, 65);
            this.profileInformationTextBox.Multiline = true;
            this.profileInformationTextBox.Name = "profileInformationTextBox";
            this.profileInformationTextBox.Size = new System.Drawing.Size(146, 139);
            this.profileInformationTextBox.TabIndex = 2;
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.Location = new System.Drawing.Point(9, 49);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(68, 13);
            this.profileLabel.TabIndex = 3;
            this.profileLabel.Text = "Select profile";
            // 
            // profileInformationLabel
            // 
            this.profileInformationLabel.AutoSize = true;
            this.profileInformationLabel.Location = new System.Drawing.Point(210, 49);
            this.profileInformationLabel.Name = "profileInformationLabel";
            this.profileInformationLabel.Size = new System.Drawing.Size(90, 13);
            this.profileInformationLabel.TabIndex = 4;
            this.profileInformationLabel.Text = "Profile information";
            // 
            // createProfile
            // 
            this.createProfile.Location = new System.Drawing.Point(12, 220);
            this.createProfile.Name = "createProfile";
            this.createProfile.Size = new System.Drawing.Size(94, 23);
            this.createProfile.TabIndex = 5;
            this.createProfile.Text = "Create Profile";
            this.createProfile.UseVisualStyleBackColor = true;
            this.createProfile.Click += new System.EventHandler(this.CreateProfile_Click);
            // 
            // nicSelectBox
            // 
            this.nicSelectBox.FormattingEnabled = true;
            this.nicSelectBox.Location = new System.Drawing.Point(12, 25);
            this.nicSelectBox.Name = "nicSelectBox";
            this.nicSelectBox.Size = new System.Drawing.Size(288, 21);
            this.nicSelectBox.TabIndex = 6;
            this.nicSelectBox.SelectedIndexChanged += new System.EventHandler(this.NetworkCard_SelectedIndex);
            // 
            // nicLabel
            // 
            this.nicLabel.AutoSize = true;
            this.nicLabel.Location = new System.Drawing.Point(9, 9);
            this.nicLabel.Name = "nicLabel";
            this.nicLabel.Size = new System.Drawing.Size(75, 13);
            this.nicLabel.TabIndex = 7;
            this.nicLabel.Text = "Network Card:";
            // 
            // IPChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(312, 266);
            this.Controls.Add(this.nicLabel);
            this.Controls.Add(this.nicSelectBox);
            this.Controls.Add(this.createProfile);
            this.Controls.Add(this.profileInformationLabel);
            this.Controls.Add(this.profileLabel);
            this.Controls.Add(this.profileInformationTextBox);
            this.Controls.Add(this.checkedProfileList);
            this.Controls.Add(this.applySettings);
            this.Name = "IPChanger";
            this.Text = "IP Changer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button applySettings;
        private System.Windows.Forms.CheckedListBox checkedProfileList;
        private System.Windows.Forms.TextBox profileInformationTextBox;
        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.Label profileInformationLabel;
        private System.Windows.Forms.Button createProfile;
        private System.Windows.Forms.ComboBox nicSelectBox;
        private System.Windows.Forms.Label nicLabel;
    }
}

