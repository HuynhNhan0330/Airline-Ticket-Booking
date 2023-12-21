namespace Airline_Ticket_Booking
{
    partial class FlightCustomerUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbArrivalAirport = new System.Windows.Forms.ComboBox();
            this.cbDepatureAirport = new System.Windows.Forms.ComboBox();
            this.pnFlight = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.abtnSearch = new Airline_Ticket_Booking.AControls.AButton();
            this.adtpTime = new Airline_Ticket_Booking.AControls.ADateTimePicker();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // cbArrivalAirport
            // 
            this.cbArrivalAirport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArrivalAirport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbArrivalAirport.FormattingEnabled = true;
            this.cbArrivalAirport.Location = new System.Drawing.Point(100, 125);
            this.cbArrivalAirport.Name = "cbArrivalAirport";
            this.cbArrivalAirport.Size = new System.Drawing.Size(447, 30);
            this.cbArrivalAirport.TabIndex = 10;
            // 
            // cbDepatureAirport
            // 
            this.cbDepatureAirport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepatureAirport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbDepatureAirport.FormattingEnabled = true;
            this.cbDepatureAirport.Location = new System.Drawing.Point(100, 75);
            this.cbDepatureAirport.Name = "cbDepatureAirport";
            this.cbDepatureAirport.Size = new System.Drawing.Size(447, 30);
            this.cbDepatureAirport.TabIndex = 9;
            // 
            // pnFlight
            // 
            this.pnFlight.AutoScroll = true;
            this.pnFlight.Location = new System.Drawing.Point(50, 230);
            this.pnFlight.Name = "pnFlight";
            this.pnFlight.Size = new System.Drawing.Size(497, 350);
            this.pnFlight.TabIndex = 53;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Airline_Ticket_Booking.Properties.Resources.FlightDown;
            this.pictureBox2.Location = new System.Drawing.Point(50, 125);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Airline_Ticket_Booking.Properties.Resources.FlightUp;
            this.pictureBox1.Location = new System.Drawing.Point(50, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // abtnSearch
            // 
            this.abtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.abtnSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.abtnSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnSearch.BorderRadius = 10;
            this.abtnSearch.BorderSize = 0;
            this.abtnSearch.FlatAppearance.BorderSize = 0;
            this.abtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abtnSearch.ForeColor = System.Drawing.Color.White;
            this.abtnSearch.LineType = Airline_Ticket_Booking.AControls.AButton.LineStyles.None;
            this.abtnSearch.Location = new System.Drawing.Point(50, 170);
            this.abtnSearch.Name = "abtnSearch";
            this.abtnSearch.RoundType = Airline_Ticket_Booking.AControls.AButton.RoundStyles.Full;
            this.abtnSearch.Size = new System.Drawing.Size(497, 40);
            this.abtnSearch.TabIndex = 52;
            this.abtnSearch.Text = "Tìm kiếm";
            this.abtnSearch.TextColor = System.Drawing.Color.White;
            this.abtnSearch.ThinknessLine = 0;
            this.abtnSearch.UseVisualStyleBackColor = false;
            this.abtnSearch.Click += new System.EventHandler(this.abtnSearch_Click);
            // 
            // adtpTime
            // 
            this.adtpTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.adtpTime.BorderSize = 2;
            this.adtpTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adtpTime.CustomFormat = "dd/MM/yyyy";
            this.adtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.adtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.adtpTime.Location = new System.Drawing.Point(100, 25);
            this.adtpTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adtpTime.MinimumSize = new System.Drawing.Size(4, 30);
            this.adtpTime.Name = "adtpTime";
            this.adtpTime.Size = new System.Drawing.Size(447, 30);
            this.adtpTime.SkinColor = System.Drawing.Color.White;
            this.adtpTime.TabIndex = 54;
            this.adtpTime.TextColor = System.Drawing.Color.Black;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Airline_Ticket_Booking.Properties.Resources.calendar;
            this.pictureBox3.Location = new System.Drawing.Point(50, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 55;
            this.pictureBox3.TabStop = false;
            // 
            // FlightCustomerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.adtpTime);
            this.Controls.Add(this.pnFlight);
            this.Controls.Add(this.abtnSearch);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbArrivalAirport);
            this.Controls.Add(this.cbDepatureAirport);
            this.Name = "FlightCustomerUC";
            this.Size = new System.Drawing.Size(597, 605);
            this.Load += new System.EventHandler(this.FlightCustomerUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbArrivalAirport;
        private System.Windows.Forms.ComboBox cbDepatureAirport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private AControls.AButton abtnSearch;
        private System.Windows.Forms.Panel pnFlight;
        private AControls.ADateTimePicker adtpTime;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
