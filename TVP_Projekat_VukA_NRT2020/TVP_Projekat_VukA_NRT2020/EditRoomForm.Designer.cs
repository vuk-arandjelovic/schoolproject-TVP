namespace TVP_Projekat_VukA_NRT2020
{
    partial class EditRoomForm
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
            this.numRoomDiscount = new System.Windows.Forms.NumericUpDown();
            this.numRoomDays = new System.Windows.Forms.NumericUpDown();
            this.numRoomBeds = new System.Windows.Forms.NumericUpDown();
            this.btnEditRoom = new System.Windows.Forms.Button();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numRoomNumber = new System.Windows.Forms.NumericUpDown();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomBeds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // numRoomDiscount
            // 
            this.numRoomDiscount.Location = new System.Drawing.Point(13, 255);
            this.numRoomDiscount.Name = "numRoomDiscount";
            this.numRoomDiscount.Size = new System.Drawing.Size(145, 20);
            this.numRoomDiscount.TabIndex = 29;
            // 
            // numRoomDays
            // 
            this.numRoomDays.Location = new System.Drawing.Point(13, 313);
            this.numRoomDays.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.numRoomDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRoomDays.Name = "numRoomDays";
            this.numRoomDays.Size = new System.Drawing.Size(145, 20);
            this.numRoomDays.TabIndex = 28;
            this.numRoomDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numRoomBeds
            // 
            this.numRoomBeds.Location = new System.Drawing.Point(13, 79);
            this.numRoomBeds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRoomBeds.Name = "numRoomBeds";
            this.numRoomBeds.Size = new System.Drawing.Size(145, 20);
            this.numRoomBeds.TabIndex = 27;
            this.numRoomBeds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnEditRoom
            // 
            this.btnEditRoom.Location = new System.Drawing.Point(13, 365);
            this.btnEditRoom.Name = "btnEditRoom";
            this.btnEditRoom.Size = new System.Drawing.Size(145, 48);
            this.btnEditRoom.TabIndex = 26;
            this.btnEditRoom.Text = "Izmeni Sobu";
            this.btnEditRoom.UseVisualStyleBackColor = true;
            this.btnEditRoom.Click += new System.EventHandler(this.btnEditRoom_Click);
            // 
            // cbRoomType
            // 
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Items.AddRange(new object[] {
            "Standard",
            "Lux"});
            this.cbRoomType.Location = new System.Drawing.Point(13, 136);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(145, 21);
            this.cbRoomType.TabIndex = 24;
            this.cbRoomType.Text = "Standard";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Minimalno Dana Rezervisano";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Popust (%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Cena (RSD)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tip Sobe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Broj Kreveta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Broj Sobe";
            // 
            // numRoomNumber
            // 
            this.numRoomNumber.Location = new System.Drawing.Point(15, 25);
            this.numRoomNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numRoomNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRoomNumber.Name = "numRoomNumber";
            this.numRoomNumber.Size = new System.Drawing.Size(143, 20);
            this.numRoomNumber.TabIndex = 30;
            this.numRoomNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(14, 201);
            this.numPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(145, 20);
            this.numPrice.TabIndex = 31;
            this.numPrice.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // EditRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 422);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.numRoomNumber);
            this.Controls.Add(this.numRoomDiscount);
            this.Controls.Add(this.numRoomDays);
            this.Controls.Add(this.numRoomBeds);
            this.Controls.Add(this.btnEditRoom);
            this.Controls.Add(this.cbRoomType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditRoomForm";
            this.Text = "Izmeni Sobu";
            ((System.ComponentModel.ISupportInitialize)(this.numRoomDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomBeds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numRoomDiscount;
        private System.Windows.Forms.NumericUpDown numRoomDays;
        private System.Windows.Forms.NumericUpDown numRoomBeds;
        private System.Windows.Forms.Button btnEditRoom;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numRoomNumber;
        private System.Windows.Forms.NumericUpDown numPrice;
    }
}