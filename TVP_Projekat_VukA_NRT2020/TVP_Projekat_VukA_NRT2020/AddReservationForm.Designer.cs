namespace TVP_Projekat_VukA_NRT2020
{
    partial class AddReservationForm
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
            this.lstViewRooms = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddNewGuest = new System.Windows.Forms.Button();
            this.btnSelectGuest = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelectRoom = new System.Windows.Forms.Button();
            this.btnRoomReset = new System.Windows.Forms.Button();
            this.btnRoomFilter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numRoomBeds = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbPension = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateReservationTo = new System.Windows.Forms.DateTimePicker();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.dateReservationFrom = new System.Windows.Forms.DateTimePicker();
            this.txtGuest = new System.Windows.Forms.TextBox();
            this.btnCreateReservation = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomBeds)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstViewGuests
            // 
            this.lstViewGuests.HideSelection = false;
            this.lstViewGuests.Location = new System.Drawing.Point(6, 19);
            this.lstViewGuests.Name = "lstViewGuests";
            this.lstViewGuests.Size = new System.Drawing.Size(236, 307);
            this.lstViewGuests.TabIndex = 0;
            this.lstViewGuests.UseCompatibleStateImageBehavior = false;
            // 
            // lstViewRooms
            // 
            this.lstViewRooms.HideSelection = false;
            this.lstViewRooms.Location = new System.Drawing.Point(6, 19);
            this.lstViewRooms.Name = "lstViewRooms";
            this.lstViewRooms.Size = new System.Drawing.Size(236, 249);
            this.lstViewRooms.TabIndex = 1;
            this.lstViewRooms.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAddNewGuest);
            this.groupBox1.Controls.Add(this.btnSelectGuest);
            this.groupBox1.Controls.Add(this.lstViewGuests);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 419);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gost";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "ili";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddNewGuest
            // 
            this.btnAddNewGuest.Location = new System.Drawing.Point(7, 391);
            this.btnAddNewGuest.Name = "btnAddNewGuest";
            this.btnAddNewGuest.Size = new System.Drawing.Size(236, 23);
            this.btnAddNewGuest.TabIndex = 4;
            this.btnAddNewGuest.Text = "Dodaj novog gosta";
            this.btnAddNewGuest.UseVisualStyleBackColor = true;
            this.btnAddNewGuest.Click += new System.EventHandler(this.btnAddNewGuest_Click);
            // 
            // btnSelectGuest
            // 
            this.btnSelectGuest.Location = new System.Drawing.Point(7, 332);
            this.btnSelectGuest.Name = "btnSelectGuest";
            this.btnSelectGuest.Size = new System.Drawing.Size(236, 23);
            this.btnSelectGuest.TabIndex = 3;
            this.btnSelectGuest.Text = "Izaberi";
            this.btnSelectGuest.UseVisualStyleBackColor = true;
            this.btnSelectGuest.Click += new System.EventHandler(this.btnSelectGuest_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelectRoom);
            this.groupBox2.Controls.Add(this.btnRoomReset);
            this.groupBox2.Controls.Add(this.btnRoomFilter);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbRoomType);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numRoomBeds);
            this.groupBox2.Controls.Add(this.lstViewRooms);
            this.groupBox2.Location = new System.Drawing.Point(266, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 419);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Soba";
            // 
            // btnSelectRoom
            // 
            this.btnSelectRoom.Location = new System.Drawing.Point(6, 391);
            this.btnSelectRoom.Name = "btnSelectRoom";
            this.btnSelectRoom.Size = new System.Drawing.Size(235, 23);
            this.btnSelectRoom.TabIndex = 9;
            this.btnSelectRoom.Text = "Izaberi";
            this.btnSelectRoom.UseVisualStyleBackColor = true;
            this.btnSelectRoom.Click += new System.EventHandler(this.btnSelectRoom_Click);
            // 
            // btnRoomReset
            // 
            this.btnRoomReset.Location = new System.Drawing.Point(166, 360);
            this.btnRoomReset.Name = "btnRoomReset";
            this.btnRoomReset.Size = new System.Drawing.Size(75, 23);
            this.btnRoomReset.TabIndex = 8;
            this.btnRoomReset.Text = "Reset";
            this.btnRoomReset.UseVisualStyleBackColor = true;
            this.btnRoomReset.Click += new System.EventHandler(this.btnRoomReset_Click);
            // 
            // btnRoomFilter
            // 
            this.btnRoomFilter.Location = new System.Drawing.Point(6, 360);
            this.btnRoomFilter.Name = "btnRoomFilter";
            this.btnRoomFilter.Size = new System.Drawing.Size(154, 23);
            this.btnRoomFilter.TabIndex = 7;
            this.btnRoomFilter.Text = "Primeni filtere";
            this.btnRoomFilter.UseVisualStyleBackColor = true;
            this.btnRoomFilter.Click += new System.EventHandler(this.btnRoomFilter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tip";
            // 
            // cbRoomType
            // 
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Items.AddRange(new object[] {
            "Standard",
            "Lux"});
            this.cbRoomType.Location = new System.Drawing.Point(6, 289);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(236, 21);
            this.cbRoomType.TabIndex = 5;
            this.cbRoomType.Text = "Standard";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Broj kreveta";
            // 
            // numRoomBeds
            // 
            this.numRoomBeds.Location = new System.Drawing.Point(6, 329);
            this.numRoomBeds.Name = "numRoomBeds";
            this.numRoomBeds.Size = new System.Drawing.Size(236, 20);
            this.numRoomBeds.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cbPension);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dateReservationTo);
            this.groupBox3.Controls.Add(this.txtRoom);
            this.groupBox3.Controls.Add(this.dateReservationFrom);
            this.groupBox3.Controls.Add(this.txtGuest);
            this.groupBox3.Location = new System.Drawing.Point(13, 437);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(501, 107);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rezervacija";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(89, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Pansion";
            // 
            // cbPension
            // 
            this.cbPension.FormattingEnabled = true;
            this.cbPension.Items.AddRange(new object[] {
            "Pun pansion",
            "Polu pansion",
            "Samo dorucak"});
            this.cbPension.Location = new System.Drawing.Point(92, 77);
            this.cbPension.Name = "cbPension";
            this.cbPension.Size = new System.Drawing.Size(149, 21);
            this.cbPension.TabIndex = 13;
            this.cbPension.Text = "Pun pansion";
            this.cbPension.SelectedIndexChanged += new System.EventHandler(this.cbPension_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Gost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Soba";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "do";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "od";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Datum rezervacije";
            // 
            // dateReservationTo
            // 
            this.dateReservationTo.Location = new System.Drawing.Point(306, 68);
            this.dateReservationTo.MinDate = new System.DateTime(2022, 5, 4, 0, 0, 0, 0);
            this.dateReservationTo.Name = "dateReservationTo";
            this.dateReservationTo.Size = new System.Drawing.Size(188, 20);
            this.dateReservationTo.TabIndex = 7;
            this.dateReservationTo.Value = new System.DateTime(2022, 5, 5, 11, 59, 0, 0);
            this.dateReservationTo.ValueChanged += new System.EventHandler(this.dateReservationTo_ValueChanged);
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(6, 77);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.ReadOnly = true;
            this.txtRoom.Size = new System.Drawing.Size(79, 20);
            this.txtRoom.TabIndex = 1;
            // 
            // dateReservationFrom
            // 
            this.dateReservationFrom.Location = new System.Drawing.Point(306, 41);
            this.dateReservationFrom.MinDate = new System.DateTime(2022, 5, 4, 0, 0, 0, 0);
            this.dateReservationFrom.Name = "dateReservationFrom";
            this.dateReservationFrom.Size = new System.Drawing.Size(188, 20);
            this.dateReservationFrom.TabIndex = 6;
            this.dateReservationFrom.Value = new System.DateTime(2022, 5, 5, 0, 1, 0, 0);
            this.dateReservationFrom.ValueChanged += new System.EventHandler(this.dateReservationFrom_ValueChanged);
            // 
            // txtGuest
            // 
            this.txtGuest.Location = new System.Drawing.Point(6, 36);
            this.txtGuest.Name = "txtGuest";
            this.txtGuest.ReadOnly = true;
            this.txtGuest.Size = new System.Drawing.Size(236, 20);
            this.txtGuest.TabIndex = 0;
            // 
            // btnCreateReservation
            // 
            this.btnCreateReservation.Location = new System.Drawing.Point(357, 550);
            this.btnCreateReservation.Name = "btnCreateReservation";
            this.btnCreateReservation.Size = new System.Drawing.Size(160, 39);
            this.btnCreateReservation.TabIndex = 5;
            this.btnCreateReservation.Text = "Napravi rezervaciju";
            this.btnCreateReservation.UseVisualStyleBackColor = true;
            this.btnCreateReservation.Click += new System.EventHandler(this.btnCreateReservation_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(16, 555);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 31);
            this.lblTotalPrice.TabIndex = 6;
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 603);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnCreateReservation);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddReservationForm";
            this.Text = "Dodaj Reservaciju";
            this.Load += new System.EventHandler(this.AddReservationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomBeds)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstViewGuests;
        private System.Windows.Forms.ListView lstViewRooms;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numRoomBeds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNewGuest;
        private System.Windows.Forms.Button btnSelectGuest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateReservationTo;
        private System.Windows.Forms.DateTimePicker dateReservationFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.TextBox txtGuest;
        private System.Windows.Forms.Button btnCreateReservation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRoomReset;
        private System.Windows.Forms.Button btnRoomFilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnSelectRoom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbPension;
    }
}