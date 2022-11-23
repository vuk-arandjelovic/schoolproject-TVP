namespace TVP_Projekat_VukA_NRT2020
{
    partial class EditGuestForm
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
            this.txtGuestPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGuestLastname = new System.Windows.Forms.TextBox();
            this.txtGuestFirstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Ime = new System.Windows.Forms.Label();
            this.btnEditGuest = new System.Windows.Forms.Button();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtGuestPhone
            // 
            this.txtGuestPhone.Location = new System.Drawing.Point(12, 181);
            this.txtGuestPhone.Name = "txtGuestPhone";
            this.txtGuestPhone.Size = new System.Drawing.Size(236, 20);
            this.txtGuestPhone.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Broj Telefona";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Datum Rodjenja";
            // 
            // txtGuestLastname
            // 
            this.txtGuestLastname.Location = new System.Drawing.Point(12, 77);
            this.txtGuestLastname.Name = "txtGuestLastname";
            this.txtGuestLastname.Size = new System.Drawing.Size(236, 20);
            this.txtGuestLastname.TabIndex = 30;
            // 
            // txtGuestFirstname
            // 
            this.txtGuestFirstname.Location = new System.Drawing.Point(12, 26);
            this.txtGuestFirstname.Name = "txtGuestFirstname";
            this.txtGuestFirstname.Size = new System.Drawing.Size(236, 20);
            this.txtGuestFirstname.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Prezime";
            // 
            // Ime
            // 
            this.Ime.AutoSize = true;
            this.Ime.Location = new System.Drawing.Point(12, 10);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(24, 13);
            this.Ime.TabIndex = 27;
            this.Ime.Text = "Ime";
            // 
            // btnEditGuest
            // 
            this.btnEditGuest.Location = new System.Drawing.Point(12, 220);
            this.btnEditGuest.Name = "btnEditGuest";
            this.btnEditGuest.Size = new System.Drawing.Size(236, 44);
            this.btnEditGuest.TabIndex = 26;
            this.btnEditGuest.Text = "Izmeni Gosta";
            this.btnEditGuest.UseVisualStyleBackColor = true;
            this.btnEditGuest.Click += new System.EventHandler(this.btnEditGuest_Click);
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Location = new System.Drawing.Point(12, 132);
            this.dateOfBirth.MaxDate = new System.DateTime(2022, 5, 25, 23, 59, 59, 0);
            this.dateOfBirth.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(237, 20);
            this.dateOfBirth.TabIndex = 35;
            // 
            // EditGuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 278);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.txtGuestPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGuestLastname);
            this.Controls.Add(this.txtGuestFirstname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.btnEditGuest);
            this.Name = "EditGuestForm";
            this.Text = "Izmeni Gosta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtGuestPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGuestLastname;
        private System.Windows.Forms.TextBox txtGuestFirstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Ime;
        private System.Windows.Forms.Button btnEditGuest;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
    }
}