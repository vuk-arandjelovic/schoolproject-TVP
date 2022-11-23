namespace TVP_Projekat_VukA_NRT2020
{
    partial class AdminForm
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
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnGuests = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(12, 12);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(203, 37);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "Svi Korisnici";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnGuests
            // 
            this.btnGuests.Location = new System.Drawing.Point(12, 55);
            this.btnGuests.Name = "btnGuests";
            this.btnGuests.Size = new System.Drawing.Size(203, 37);
            this.btnGuests.TabIndex = 1;
            this.btnGuests.Text = "Svi Gosti";
            this.btnGuests.UseVisualStyleBackColor = true;
            this.btnGuests.Click += new System.EventHandler(this.btnGuests_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.Location = new System.Drawing.Point(12, 98);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(203, 37);
            this.btnRooms.TabIndex = 2;
            this.btnRooms.Text = "Sve Sobe";
            this.btnRooms.UseVisualStyleBackColor = true;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // btnReservations
            // 
            this.btnReservations.Location = new System.Drawing.Point(12, 141);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(203, 37);
            this.btnReservations.TabIndex = 3;
            this.btnReservations.Text = "Sve Rezervacije";
            this.btnReservations.UseVisualStyleBackColor = true;
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnLogOut.Location = new System.Drawing.Point(12, 210);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(203, 30);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Izloguj Se";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(227, 252);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnReservations);
            this.Controls.Add(this.btnRooms);
            this.Controls.Add(this.btnGuests);
            this.Controls.Add(this.btnUsers);
            this.Name = "AdminForm";
            this.Text = "Admin - Hotel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnGuests;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnReservations;
        private System.Windows.Forms.Button btnLogOut;
    }
}