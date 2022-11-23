namespace TVP_Projekat_VukA_NRT2020
{
    partial class GuestsForm
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
            this.lstViewGuests = new System.Windows.Forms.ListView();
            this.btnAddGuest = new System.Windows.Forms.Button();
            this.btnUpdateGuest = new System.Windows.Forms.Button();
            this.btnDeleteGuest = new System.Windows.Forms.Button();
            this.btnSaveGuests = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstViewGuests
            // 
            this.lstViewGuests.HideSelection = false;
            this.lstViewGuests.Location = new System.Drawing.Point(13, 13);
            this.lstViewGuests.Name = "lstViewGuests";
            this.lstViewGuests.Size = new System.Drawing.Size(565, 386);
            this.lstViewGuests.TabIndex = 0;
            this.lstViewGuests.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddGuest
            // 
            this.btnAddGuest.Location = new System.Drawing.Point(585, 13);
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.Size = new System.Drawing.Size(137, 23);
            this.btnAddGuest.TabIndex = 1;
            this.btnAddGuest.Text = "Dodaj Gosta";
            this.btnAddGuest.UseVisualStyleBackColor = true;
            this.btnAddGuest.Click += new System.EventHandler(this.btnAddGuest_Click);
            // 
            // btnUpdateGuest
            // 
            this.btnUpdateGuest.Location = new System.Drawing.Point(585, 43);
            this.btnUpdateGuest.Name = "btnUpdateGuest";
            this.btnUpdateGuest.Size = new System.Drawing.Size(137, 23);
            this.btnUpdateGuest.TabIndex = 2;
            this.btnUpdateGuest.Text = "Izmeni Gosta";
            this.btnUpdateGuest.UseVisualStyleBackColor = true;
            this.btnUpdateGuest.Click += new System.EventHandler(this.btnUpdateGuest_Click);
            // 
            // btnDeleteGuest
            // 
            this.btnDeleteGuest.Location = new System.Drawing.Point(585, 73);
            this.btnDeleteGuest.Name = "btnDeleteGuest";
            this.btnDeleteGuest.Size = new System.Drawing.Size(137, 23);
            this.btnDeleteGuest.TabIndex = 3;
            this.btnDeleteGuest.Text = "Obrisi Gosta";
            this.btnDeleteGuest.UseVisualStyleBackColor = true;
            this.btnDeleteGuest.Click += new System.EventHandler(this.btnDeleteGuest_Click);
            // 
            // btnSaveGuests
            // 
            this.btnSaveGuests.Location = new System.Drawing.Point(585, 375);
            this.btnSaveGuests.Name = "btnSaveGuests";
            this.btnSaveGuests.Size = new System.Drawing.Size(137, 23);
            this.btnSaveGuests.TabIndex = 4;
            this.btnSaveGuests.Text = "Sacuvaj Promene";
            this.btnSaveGuests.UseVisualStyleBackColor = true;
            this.btnSaveGuests.Click += new System.EventHandler(this.btnSaveGuests_Click);
            // 
            // GuestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.btnSaveGuests);
            this.Controls.Add(this.btnDeleteGuest);
            this.Controls.Add(this.btnUpdateGuest);
            this.Controls.Add(this.btnAddGuest);
            this.Controls.Add(this.lstViewGuests);
            this.Name = "GuestsForm";
            this.Text = "Admin - Gosti";
            this.Load += new System.EventHandler(this.GuestsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstViewGuests;
        private System.Windows.Forms.Button btnAddGuest;
        private System.Windows.Forms.Button btnUpdateGuest;
        private System.Windows.Forms.Button btnDeleteGuest;
        private System.Windows.Forms.Button btnSaveGuests;
    }
}