namespace IPChangerForLab
{
    partial class CreateProfile
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
            this.labelIP = new System.Windows.Forms.Label();
            this.labelNetmask = new System.Windows.Forms.Label();
            this.labelGateway = new System.Windows.Forms.Label();
            this.inputBoxIP = new System.Windows.Forms.TextBox();
            this.inputBoxNetmask = new System.Windows.Forms.TextBox();
            this.inputBoxGateway = new System.Windows.Forms.TextBox();
            this.profileButtonOk = new System.Windows.Forms.Button();
            this.profileButtonCancel = new System.Windows.Forms.Button();
            this.ProfileName = new System.Windows.Forms.Label();
            this.inputBoxName = new System.Windows.Forms.TextBox();
            this.checkBoxDhcp = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(26, 12);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(58, 13);
            this.labelIP.TabIndex = 0;
            this.labelIP.Text = "IP number:";
            // 
            // labelNetmask
            // 
            this.labelNetmask.AutoSize = true;
            this.labelNetmask.Location = new System.Drawing.Point(32, 43);
            this.labelNetmask.Name = "labelNetmask";
            this.labelNetmask.Size = new System.Drawing.Size(52, 13);
            this.labelNetmask.TabIndex = 1;
            this.labelNetmask.Text = "Netmask:";
            // 
            // labelGateway
            // 
            this.labelGateway.AutoSize = true;
            this.labelGateway.Location = new System.Drawing.Point(32, 72);
            this.labelGateway.Name = "labelGateway";
            this.labelGateway.Size = new System.Drawing.Size(52, 13);
            this.labelGateway.TabIndex = 2;
            this.labelGateway.Text = "Gateway:";
            // 
            // inputBoxIP
            // 
            this.inputBoxIP.Location = new System.Drawing.Point(87, 8);
            this.inputBoxIP.Name = "inputBoxIP";
            this.inputBoxIP.Size = new System.Drawing.Size(200, 20);
            this.inputBoxIP.TabIndex = 3;
            // 
            // inputBoxNetmask
            // 
            this.inputBoxNetmask.Location = new System.Drawing.Point(87, 40);
            this.inputBoxNetmask.Name = "inputBoxNetmask";
            this.inputBoxNetmask.Size = new System.Drawing.Size(200, 20);
            this.inputBoxNetmask.TabIndex = 4;
            // 
            // inputBoxGateway
            // 
            this.inputBoxGateway.Location = new System.Drawing.Point(87, 69);
            this.inputBoxGateway.Name = "inputBoxGateway";
            this.inputBoxGateway.Size = new System.Drawing.Size(200, 20);
            this.inputBoxGateway.TabIndex = 5;
            // 
            // profileButtonOk
            // 
            this.profileButtonOk.Location = new System.Drawing.Point(87, 138);
            this.profileButtonOk.Name = "profileButtonOk";
            this.profileButtonOk.Size = new System.Drawing.Size(75, 23);
            this.profileButtonOk.TabIndex = 6;
            this.profileButtonOk.Text = "OK";
            this.profileButtonOk.UseVisualStyleBackColor = true;
            this.profileButtonOk.Click += new System.EventHandler(this.profileButtonOk_Click);
            // 
            // profileButtonCancel
            // 
            this.profileButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.profileButtonCancel.Location = new System.Drawing.Point(212, 138);
            this.profileButtonCancel.Name = "profileButtonCancel";
            this.profileButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.profileButtonCancel.TabIndex = 7;
            this.profileButtonCancel.Text = "Cancel";
            this.profileButtonCancel.UseVisualStyleBackColor = true;
            this.profileButtonCancel.Click += new System.EventHandler(this.profileButtonCancel_Click);
            // 
            // ProfileName
            // 
            this.ProfileName.AutoSize = true;
            this.ProfileName.Location = new System.Drawing.Point(43, 99);
            this.ProfileName.Name = "ProfileName";
            this.ProfileName.Size = new System.Drawing.Size(38, 13);
            this.ProfileName.TabIndex = 8;
            this.ProfileName.Text = "Name:";
            // 
            // inputBoxName
            // 
            this.inputBoxName.Location = new System.Drawing.Point(87, 95);
            this.inputBoxName.Name = "inputBoxName";
            this.inputBoxName.Size = new System.Drawing.Size(200, 20);
            this.inputBoxName.TabIndex = 9;
            // 
            // checkBoxDhcp
            // 
            this.checkBoxDhcp.AutoSize = true;
            this.checkBoxDhcp.Location = new System.Drawing.Point(87, 122);
            this.checkBoxDhcp.Name = "checkBoxDhcp";
            this.checkBoxDhcp.Size = new System.Drawing.Size(75, 17);
            this.checkBoxDhcp.TabIndex = 10;
            this.checkBoxDhcp.Text = "UseDHCP";
            this.checkBoxDhcp.UseVisualStyleBackColor = true;
            this.checkBoxDhcp.CheckedChanged += new System.EventHandler(this.checkBoxDhcp_CheckedChanged);
            // 
            // CreateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.CancelButton = this.profileButtonCancel;
            this.ClientSize = new System.Drawing.Size(316, 186);
            this.Controls.Add(this.checkBoxDhcp);
            this.Controls.Add(this.inputBoxName);
            this.Controls.Add(this.ProfileName);
            this.Controls.Add(this.profileButtonCancel);
            this.Controls.Add(this.profileButtonOk);
            this.Controls.Add(this.inputBoxGateway);
            this.Controls.Add(this.inputBoxNetmask);
            this.Controls.Add(this.inputBoxIP);
            this.Controls.Add(this.labelGateway);
            this.Controls.Add(this.labelNetmask);
            this.Controls.Add(this.labelIP);
            this.Name = "CreateProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label labelNetmask;
        private System.Windows.Forms.Label labelGateway;
        private System.Windows.Forms.TextBox inputBoxIP;
        private System.Windows.Forms.TextBox inputBoxNetmask;
        private System.Windows.Forms.TextBox inputBoxGateway;
        private System.Windows.Forms.Button profileButtonOk;
        private System.Windows.Forms.Button profileButtonCancel;
        private System.Windows.Forms.Label ProfileName;
        private System.Windows.Forms.TextBox inputBoxName;
        private System.Windows.Forms.CheckBox checkBoxDhcp;
    }
}