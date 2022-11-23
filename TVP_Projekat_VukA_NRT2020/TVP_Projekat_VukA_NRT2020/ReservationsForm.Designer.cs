namespace TVP_Projekat_VukA_NRT2020
{
    partial class ReservationsForm
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
            this.lstViewReservations = new System.Windows.Forms.ListView();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.btnChangeReservation = new System.Windows.Forms.Button();
            this.btnDeleteReservation = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstViewReservations
            // 
            this.lstViewReservations.HideSelection = false;
            this.lstViewReservations.Location = new System.Drawing.Point(13, 13);
            this.lstViewReservations.Name = "lstViewReservations";
            this.lstViewReservations.Size = new System.Drawing.Size(565, 386);
            this.lstViewReservations.TabIndex = 0;
            this.lstViewReservations.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Location = new System.Drawing.Point(585, 13);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(137, 23);
            this.btnAddReservation.TabIndex = 1;
            this.btnAddReservation.Text = "Dodaj Rezervaciju";
            this.btnAddReservation.UseVisualStyleBackColor = true;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // btnChangeReservation
            // 
            this.btnChangeReservation.Location = new System.Drawing.Point(585, 43);
            this.btnChangeReservation.Name = "btnChangeReservation";
            this.btnChangeReservation.Size = new System.Drawing.Size(137, 23);
            this.btnChangeReservation.TabIndex = 2;
            this.btnChangeReservation.Text = "Izmeni Rezervaciju";
            this.btnChangeReservation.UseVisualStyleBackColor = true;
            this.btnChangeReservation.Click += new System.EventHandler(this.btnChangeReservation_Click);
            // 
            // btnDeleteReservation
            // 
            this.btnDeleteReservation.Location = new System.Drawing.Point(585, 73);
            this.btnDeleteReservation.Name = "btnDeleteReservation";
            this.btnDeleteReservation.Size = new System.Drawing.Size(137, 23);
            this.btnDeleteReservation.TabIndex = 3;
            this.btnDeleteReservation.Text = "Obrisi Rezervaciju";
            this.btnDeleteReservation.UseVisualStyleBackColor = true;
            this.btnDeleteReservation.Click += new System.EventHandler(this.btnDeleteReservation_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(585, 375);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(137, 23);
            this.btnSaveChanges.TabIndex = 4;
            this.btnSaveChanges.Text = "Sacuvaj Promene";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // ReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnDeleteReservation);
            this.Controls.Add(this.btnChangeReservation);
            this.Controls.Add(this.btnAddReservation);
            this.Controls.Add(this.lstViewReservations);
            this.Name = "ReservationsForm";
            this.Text = "Rezervacije";
            this.Load += new System.EventHandler(this.ReservationsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstViewReservations;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.Button btnChangeReservation;
        private System.Windows.Forms.Button btnDeleteReservation;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}