namespace TVP_Projekat_VukA_NRT2020
{
    partial class RoomsForm
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
            this.lstViewRooms = new System.Windows.Forms.ListView();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.btnSaveRooms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstViewRooms
            // 
            this.lstViewRooms.HideSelection = false;
            this.lstViewRooms.Location = new System.Drawing.Point(13, 13);
            this.lstViewRooms.Name = "lstViewRooms";
            this.lstViewRooms.Size = new System.Drawing.Size(565, 386);
            this.lstViewRooms.TabIndex = 0;
            this.lstViewRooms.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(585, 13);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(137, 23);
            this.btnAddRoom.TabIndex = 1;
            this.btnAddRoom.Text = "Dodaj Sobu";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.Location = new System.Drawing.Point(585, 43);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(137, 23);
            this.btnUpdateRoom.TabIndex = 2;
            this.btnUpdateRoom.Text = "Izmeni Sobu";
            this.btnUpdateRoom.UseVisualStyleBackColor = true;
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.Location = new System.Drawing.Point(585, 73);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(137, 23);
            this.btnDeleteRoom.TabIndex = 3;
            this.btnDeleteRoom.Text = "Obrisi Sobu";
            this.btnDeleteRoom.UseVisualStyleBackColor = true;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // btnSaveRooms
            // 
            this.btnSaveRooms.Location = new System.Drawing.Point(585, 375);
            this.btnSaveRooms.Name = "btnSaveRooms";
            this.btnSaveRooms.Size = new System.Drawing.Size(137, 23);
            this.btnSaveRooms.TabIndex = 4;
            this.btnSaveRooms.Text = "Sacuvaj Promene";
            this.btnSaveRooms.UseVisualStyleBackColor = true;
            this.btnSaveRooms.Click += new System.EventHandler(this.btnSaveRooms_Click);
            // 
            // RoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.btnSaveRooms);
            this.Controls.Add(this.btnDeleteRoom);
            this.Controls.Add(this.btnUpdateRoom);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.lstViewRooms);
            this.Name = "RoomsForm";
            this.Text = "Admin - Sobe";
            this.Load += new System.EventHandler(this.RoomsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstViewRooms;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnUpdateRoom;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Button btnSaveRooms;
    }
}