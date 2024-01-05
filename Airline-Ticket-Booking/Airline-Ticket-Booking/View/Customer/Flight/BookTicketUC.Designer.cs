namespace Airline_Ticket_Booking
{
    partial class BookTicketUC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.abtnNext = new Airline_Ticket_Booking.AControls.AButton();
            this.label6 = new System.Windows.Forms.Label();
            this.aPanel3 = new Airline_Ticket_Booking.AControls.APanel();
            this.cbTicketClass = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.aPanel4 = new Airline_Ticket_Booking.AControls.APanel();
            this.atxbIDCard = new Airline_Ticket_Booking.AControls.ATextboxUC();
            this.aPanel2 = new Airline_Ticket_Booking.AControls.APanel();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbArrival = new System.Windows.Forms.Label();
            this.lbDeparture = new System.Windows.Forms.Label();
            this.lbFlightID = new System.Windows.Forms.Label();
            this.aPanel1 = new Airline_Ticket_Booking.AControls.APanel();
            this.lbCash = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.pibReturn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.aPanel3.SuspendLayout();
            this.aPanel4.SuspendLayout();
            this.aPanel2.SuspendLayout();
            this.aPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.abtnNext);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.aPanel3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.aPanel4);
            this.panel1.Controls.Add(this.aPanel2);
            this.panel1.Controls.Add(this.aPanel1);
            this.panel1.Controls.Add(this.pibReturn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 605);
            this.panel1.TabIndex = 0;
            // 
            // abtnNext
            // 
            this.abtnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.abtnNext.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.abtnNext.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnNext.BorderRadius = 10;
            this.abtnNext.BorderSize = 0;
            this.abtnNext.FlatAppearance.BorderSize = 0;
            this.abtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnNext.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abtnNext.ForeColor = System.Drawing.Color.White;
            this.abtnNext.LineType = Airline_Ticket_Booking.AControls.AButton.LineStyles.None;
            this.abtnNext.Location = new System.Drawing.Point(50, 540);
            this.abtnNext.Name = "abtnNext";
            this.abtnNext.RoundType = Airline_Ticket_Booking.AControls.AButton.RoundStyles.Full;
            this.abtnNext.Size = new System.Drawing.Size(497, 40);
            this.abtnNext.TabIndex = 52;
            this.abtnNext.Text = "Tiếp theo";
            this.abtnNext.TextColor = System.Drawing.Color.White;
            this.abtnNext.ThinknessLine = 0;
            this.abtnNext.UseVisualStyleBackColor = false;
            this.abtnNext.Click += new System.EventHandler(this.abtnNext_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(50, 487);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Hạng vé";
            // 
            // aPanel3
            // 
            this.aPanel3.BackColor = System.Drawing.Color.White;
            this.aPanel3.BackgroundColor = System.Drawing.Color.White;
            this.aPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.aPanel3.BorderRadius = 10;
            this.aPanel3.BorderSize = 2;
            this.aPanel3.Controls.Add(this.cbTicketClass);
            this.aPanel3.ForeColor = System.Drawing.Color.White;
            this.aPanel3.Location = new System.Drawing.Point(247, 475);
            this.aPanel3.Name = "aPanel3";
            this.aPanel3.RoundType = Airline_Ticket_Booking.AControls.APanel.RoundStyles.Full;
            this.aPanel3.Size = new System.Drawing.Size(300, 43);
            this.aPanel3.TabIndex = 50;
            this.aPanel3.TextColor = System.Drawing.Color.White;
            // 
            // cbTicketClass
            // 
            this.cbTicketClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTicketClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTicketClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbTicketClass.FormattingEnabled = true;
            this.cbTicketClass.Location = new System.Drawing.Point(13, 8);
            this.cbTicketClass.Name = "cbTicketClass";
            this.cbTicketClass.Size = new System.Drawing.Size(277, 28);
            this.cbTicketClass.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(50, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "CMND/CCCD";
            // 
            // aPanel4
            // 
            this.aPanel4.BackColor = System.Drawing.Color.White;
            this.aPanel4.BackgroundColor = System.Drawing.Color.White;
            this.aPanel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.aPanel4.BorderRadius = 10;
            this.aPanel4.BorderSize = 2;
            this.aPanel4.Controls.Add(this.atxbIDCard);
            this.aPanel4.ForeColor = System.Drawing.Color.White;
            this.aPanel4.Location = new System.Drawing.Point(247, 410);
            this.aPanel4.Name = "aPanel4";
            this.aPanel4.RoundType = Airline_Ticket_Booking.AControls.APanel.RoundStyles.Full;
            this.aPanel4.Size = new System.Drawing.Size(300, 43);
            this.aPanel4.TabIndex = 48;
            this.aPanel4.TextColor = System.Drawing.Color.White;
            // 
            // atxbIDCard
            // 
            this.atxbIDCard.BackColor = System.Drawing.Color.White;
            this.atxbIDCard.BorderColor = System.Drawing.Color.Transparent;
            this.atxbIDCard.BorderFocusColor = System.Drawing.Color.White;
            this.atxbIDCard.BorderRadius = 0;
            this.atxbIDCard.BorderSize = 2;
            this.atxbIDCard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.atxbIDCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.atxbIDCard.ForeColor = System.Drawing.Color.Black;
            this.atxbIDCard.isFocused = false;
            this.atxbIDCard.isPlaceholder = true;
            this.atxbIDCard.Location = new System.Drawing.Point(19, 5);
            this.atxbIDCard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbIDCard.Multiline = false;
            this.atxbIDCard.Name = "atxbIDCard";
            this.atxbIDCard.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbIDCard.PasswordChar = false;
            this.atxbIDCard.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbIDCard.PlaceholderText = "Nhập CMND/CCCD của bạn";
            this.atxbIDCard.RoundType = Airline_Ticket_Booking.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbIDCard.Size = new System.Drawing.Size(260, 33);
            this.atxbIDCard.TabIndex = 29;
            this.atxbIDCard.textAlign = Airline_Ticket_Booking.AControls.ATextboxUC.TextAlign.Left;
            this.atxbIDCard.Texts = "";
            this.atxbIDCard.UnderlinedStyle = false;
            this.atxbIDCard._KeyDown += new System.EventHandler(this.atxbIDCard__KeyDown);
            // 
            // aPanel2
            // 
            this.aPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.aPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.aPanel2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aPanel2.BorderRadius = 20;
            this.aPanel2.BorderSize = 0;
            this.aPanel2.Controls.Add(this.lbTime);
            this.aPanel2.Controls.Add(this.lbArrival);
            this.aPanel2.Controls.Add(this.lbDeparture);
            this.aPanel2.Controls.Add(this.lbFlightID);
            this.aPanel2.ForeColor = System.Drawing.Color.White;
            this.aPanel2.Location = new System.Drawing.Point(50, 215);
            this.aPanel2.Name = "aPanel2";
            this.aPanel2.RoundType = Airline_Ticket_Booking.AControls.APanel.RoundStyles.Full;
            this.aPanel2.Size = new System.Drawing.Size(497, 175);
            this.aPanel2.TabIndex = 47;
            this.aPanel2.TextColor = System.Drawing.Color.White;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(25, 130);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(77, 20);
            this.lbTime.TabIndex = 4;
            this.lbTime.Text = "Thời gian";
            // 
            // lbArrival
            // 
            this.lbArrival.AutoSize = true;
            this.lbArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArrival.Location = new System.Drawing.Point(25, 100);
            this.lbArrival.Name = "lbArrival";
            this.lbArrival.Size = new System.Drawing.Size(66, 20);
            this.lbArrival.TabIndex = 3;
            this.lbArrival.Text = "Nơi đến";
            // 
            // lbDeparture
            // 
            this.lbDeparture.AutoSize = true;
            this.lbDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeparture.Location = new System.Drawing.Point(25, 70);
            this.lbDeparture.Name = "lbDeparture";
            this.lbDeparture.Size = new System.Drawing.Size(52, 20);
            this.lbDeparture.TabIndex = 2;
            this.lbDeparture.Text = "Nơi đi";
            // 
            // lbFlightID
            // 
            this.lbFlightID.AutoSize = true;
            this.lbFlightID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFlightID.Location = new System.Drawing.Point(25, 25);
            this.lbFlightID.Name = "lbFlightID";
            this.lbFlightID.Size = new System.Drawing.Size(98, 29);
            this.lbFlightID.TabIndex = 0;
            this.lbFlightID.Text = "FL0001";
            // 
            // aPanel1
            // 
            this.aPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.aPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.aPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aPanel1.BorderRadius = 20;
            this.aPanel1.BorderSize = 0;
            this.aPanel1.Controls.Add(this.lbCash);
            this.aPanel1.Controls.Add(this.lbPhone);
            this.aPanel1.Controls.Add(this.lbEmail);
            this.aPanel1.Controls.Add(this.lbName);
            this.aPanel1.ForeColor = System.Drawing.Color.White;
            this.aPanel1.Location = new System.Drawing.Point(50, 25);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.RoundType = Airline_Ticket_Booking.AControls.APanel.RoundStyles.Full;
            this.aPanel1.Size = new System.Drawing.Size(497, 175);
            this.aPanel1.TabIndex = 46;
            this.aPanel1.TextColor = System.Drawing.Color.White;
            // 
            // lbCash
            // 
            this.lbCash.AutoSize = true;
            this.lbCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCash.Location = new System.Drawing.Point(25, 130);
            this.lbCash.Name = "lbCash";
            this.lbCash.Size = new System.Drawing.Size(105, 20);
            this.lbCash.TabIndex = 4;
            this.lbCash.Text = "Tiền hiện tại:";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(25, 100);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(99, 20);
            this.lbPhone.TabIndex = 3;
            this.lbPhone.Text = "0906123123";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(25, 70);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(111, 20);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "a@gmail.com";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(25, 25);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(254, 29);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Huỳnh Mai Cao Nhân";
            // 
            // pibReturn
            // 
            this.pibReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibReturn.Image = global::Airline_Ticket_Booking.Properties.Resources.return1;
            this.pibReturn.Location = new System.Drawing.Point(10, 10);
            this.pibReturn.Name = "pibReturn";
            this.pibReturn.Size = new System.Drawing.Size(32, 32);
            this.pibReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibReturn.TabIndex = 13;
            this.pibReturn.TabStop = false;
            this.pibReturn.Click += new System.EventHandler(this.pibReturn_Click);
            // 
            // BookTicketUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "BookTicketUC";
            this.Size = new System.Drawing.Size(597, 605);
            this.Load += new System.EventHandler(this.BookTicketUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.aPanel3.ResumeLayout(false);
            this.aPanel4.ResumeLayout(false);
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibReturn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pibReturn;
        private AControls.APanel aPanel1;
        private System.Windows.Forms.Label lbCash;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbName;
        private AControls.APanel aPanel2;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbArrival;
        private System.Windows.Forms.Label lbDeparture;
        private System.Windows.Forms.Label lbFlightID;
        private System.Windows.Forms.Label label5;
        private AControls.APanel aPanel4;
        private AControls.ATextboxUC atxbIDCard;
        private System.Windows.Forms.Label label6;
        private AControls.AButton abtnNext;
        private AControls.APanel aPanel3;
        private System.Windows.Forms.ComboBox cbTicketClass;
    }
}
