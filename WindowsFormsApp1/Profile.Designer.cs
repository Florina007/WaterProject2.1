namespace WindowsFormsApp1
{
    partial class Profile
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
            this.name = new System.Windows.Forms.Label();
            this.ContactInfo = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.settings = new System.Windows.Forms.Label();
            this.linkLabelEditProfile = new System.Windows.Forms.LinkLabel();
            this.linkLabelChangePw = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(112, 67);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(45, 13);
            this.name.TabIndex = 0;
            this.name.Text = "<name>";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // ContactInfo
            // 
            this.ContactInfo.AutoSize = true;
            this.ContactInfo.Location = new System.Drawing.Point(33, 117);
            this.ContactInfo.Name = "ContactInfo";
            this.ContactInfo.Size = new System.Drawing.Size(99, 13);
            this.ContactInfo.TabIndex = 1;
            this.ContactInfo.Text = "Contact Information";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(140, 167);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 3;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(33, 199);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(45, 13);
            this.address.TabIndex = 4;
            this.address.Text = "Address";
            this.address.Click += new System.EventHandler(this.address_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(140, 199);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress.TabIndex = 5;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxAddress_TextChanged);
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(33, 229);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(38, 13);
            this.phone.TabIndex = 6;
            this.phone.Text = "Phone";
            this.phone.Click += new System.EventHandler(this.phone_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(33, 170);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(72, 13);
            this.email.TabIndex = 7;
            this.email.Text = "Email address";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(140, 229);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhone.TabIndex = 8;
            this.textBoxPhone.TextChanged += new System.EventHandler(this.textBoxPhone_TextChanged);
            // 
            // settings
            // 
            this.settings.AutoSize = true;
            this.settings.Location = new System.Drawing.Point(33, 281);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(45, 13);
            this.settings.TabIndex = 9;
            this.settings.Text = "Settings";
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // linkLabelEditProfile
            // 
            this.linkLabelEditProfile.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.linkLabelEditProfile.AutoSize = true;
            this.linkLabelEditProfile.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabelEditProfile.Location = new System.Drawing.Point(49, 305);
            this.linkLabelEditProfile.Name = "linkLabelEditProfile";
            this.linkLabelEditProfile.Size = new System.Drawing.Size(56, 13);
            this.linkLabelEditProfile.TabIndex = 10;
            this.linkLabelEditProfile.TabStop = true;
            this.linkLabelEditProfile.Text = "Edit profile";
            this.linkLabelEditProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEditProfile_LinkClicked);
            // 
            // linkLabelChangePw
            // 
            this.linkLabelChangePw.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.linkLabelChangePw.AutoSize = true;
            this.linkLabelChangePw.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabelChangePw.Location = new System.Drawing.Point(49, 327);
            this.linkLabelChangePw.Name = "linkLabelChangePw";
            this.linkLabelChangePw.Size = new System.Drawing.Size(93, 13);
            this.linkLabelChangePw.TabIndex = 11;
            this.linkLabelChangePw.TabStop = true;
            this.linkLabelChangePw.Text = "Change Password";
            this.linkLabelChangePw.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelChangePw_LinkClicked);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 413);
            this.Controls.Add(this.linkLabelChangePw);
            this.Controls.Add(this.linkLabelEditProfile);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.address);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.email);
            this.Controls.Add(this.ContactInfo);
            this.Controls.Add(this.name);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label ContactInfo;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label settings;
        private System.Windows.Forms.LinkLabel linkLabelEditProfile;
        private System.Windows.Forms.LinkLabel linkLabelChangePw;
    }
}