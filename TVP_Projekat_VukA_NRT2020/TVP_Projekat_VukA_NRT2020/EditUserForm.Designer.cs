namespace TVP_Projekat_VukA_NRT2020
{
    partial class EditUserForm
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
            this.cbUserRole = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserLastname = new System.Windows.Forms.TextBox();
            this.txtUserFirstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Ime = new System.Windows.Forms.Label();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbUserRole
            // 
            this.cbUserRole.FormattingEnabled = true;
            this.cbUserRole.Items.AddRange(new object[] {
            "Recepcioner",
            "Admin"});
            this.cbUserRole.Location = new System.Drawing.Point(12, 240);
            this.cbUserRole.Name = "cbUserRole";
            this.cbUserRole.Size = new System.Drawing.Size(236, 21);
            this.cbUserRole.TabIndex = 21;
            this.cbUserRole.Text = "Recepcioner";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Vrsta Korisnika";
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(12, 191);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(236, 20);
            this.txtUserPassword.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Lozinka";
            // 
            // txtUserUsername
            // 
            this.txtUserUsername.Location = new System.Drawing.Point(12, 141);
            this.txtUserUsername.Name = "txtUserUsername";
            this.txtUserUsername.Size = new System.Drawing.Size(236, 20);
            this.txtUserUsername.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Korisnicko Ime";
            // 
            // txtUserLastname
            // 
            this.txtUserLastname.Location = new System.Drawing.Point(12, 87);
            this.txtUserLastname.Name = "txtUserLastname";
            this.txtUserLastname.Size = new System.Drawing.Size(236, 20);
            this.txtUserLastname.TabIndex = 15;
            // 
            // txtUserFirstname
            // 
            this.txtUserFirstname.Location = new System.Drawing.Point(12, 36);
            this.txtUserFirstname.Name = "txtUserFirstname";
            this.txtUserFirstname.Size = new System.Drawing.Size(236, 20);
            this.txtUserFirstname.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Prezime";
            // 
            // Ime
            // 
            this.Ime.AutoSize = true;
            this.Ime.Location = new System.Drawing.Point(12, 20);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(24, 13);
            this.Ime.TabIndex = 12;
            this.Ime.Text = "Ime";
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(12, 285);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(236, 44);
            this.btnEditUser.TabIndex = 11;
            this.btnEditUser.Text = "Izmeni Korisnika";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 351);
            this.Controls.Add(this.cbUserRole);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUserUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserLastname);
            this.Controls.Add(this.txtUserFirstname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.btnEditUser);
            this.Name = "EditUserForm";
            this.Text = "Izmeni Korisnika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbUserRole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserLastname;
        private System.Windows.Forms.TextBox txtUserFirstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Ime;
        private System.Windows.Forms.Button btnEditUser;
    }
}