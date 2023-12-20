namespace Airline_Ticket_Booking
{
    partial class FormMainCustomerWindown
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
            this.pnMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnTop = new System.Windows.Forms.Panel();
            this.lbNameBank = new System.Windows.Forms.Label();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pibClose = new System.Windows.Forms.PictureBox();
            this.abtnFlight = new Airline_Ticket_Booking.AControls.AButton();
            this.abtnAccount = new Airline_Ticket_Booking.AControls.AButton();
            this.abtnContact = new Airline_Ticket_Booking.AControls.AButton();
            this.abtnTicket = new Airline_Ticket_Booking.AControls.AButton();
            this.pnMenu.SuspendLayout();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.White;
            this.pnMenu.Controls.Add(this.panel2);
            this.pnMenu.Controls.Add(this.abtnFlight);
            this.pnMenu.Controls.Add(this.abtnAccount);
            this.pnMenu.Controls.Add(this.abtnContact);
            this.pnMenu.Controls.Add(this.abtnTicket);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnMenu.Location = new System.Drawing.Point(0, 705);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(597, 95);
            this.pnMenu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 5);
            this.panel2.TabIndex = 0;
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pnTop.Controls.Add(this.pibClose);
            this.pnTop.Controls.Add(this.lbNameBank);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(597, 100);
            this.pnTop.TabIndex = 1;
            // 
            // lbNameBank
            // 
            this.lbNameBank.AutoSize = true;
            this.lbNameBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lbNameBank.ForeColor = System.Drawing.Color.White;
            this.lbNameBank.Location = new System.Drawing.Point(211, 30);
            this.lbNameBank.Name = "lbNameBank";
            this.lbNameBank.Size = new System.Drawing.Size(174, 39);
            this.lbNameBank.TabIndex = 0;
            this.lbNameBank.Text = "AirportVN";
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 100);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(597, 605);
            this.pnMain.TabIndex = 2;
            // 
            // pibClose
            // 
            this.pibClose.BackgroundImage = global::Airline_Ticket_Booking.Properties.Resources.log_out;
            this.pibClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibClose.Location = new System.Drawing.Point(25, 34);
            this.pibClose.Name = "pibClose";
            this.pibClose.Size = new System.Drawing.Size(32, 32);
            this.pibClose.TabIndex = 1;
            this.pibClose.TabStop = false;
            this.pibClose.Click += new System.EventHandler(this.pibClose_Click);
            // 
            // abtnFlight
            // 
            this.abtnFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.abtnFlight.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.abtnFlight.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            this.abtnFlight.BorderRadius = 30;
            this.abtnFlight.BorderSize = 0;
            this.abtnFlight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abtnFlight.FlatAppearance.BorderSize = 0;
            this.abtnFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnFlight.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abtnFlight.ForeColor = System.Drawing.Color.White;
            this.abtnFlight.Image = global::Airline_Ticket_Booking.Properties.Resources.flightActive1;
            this.abtnFlight.LineType = Airline_Ticket_Booking.AControls.AButton.LineStyles.None;
            this.abtnFlight.Location = new System.Drawing.Point(-2, 1);
            this.abtnFlight.Name = "abtnFlight";
            this.abtnFlight.RoundType = Airline_Ticket_Booking.AControls.AButton.RoundStyles.Top;
            this.abtnFlight.Size = new System.Drawing.Size(150, 90);
            this.abtnFlight.TabIndex = 0;
            this.abtnFlight.Text = "Chuyến bay";
            this.abtnFlight.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.abtnFlight.TextColor = System.Drawing.Color.White;
            this.abtnFlight.ThinknessLine = 0;
            this.abtnFlight.UseVisualStyleBackColor = false;
            this.abtnFlight.Click += new System.EventHandler(this.abtnFlight_Click);
            // 
            // abtnAccount
            // 
            this.abtnAccount.BackColor = System.Drawing.Color.Transparent;
            this.abtnAccount.BackgroundColor = System.Drawing.Color.Transparent;
            this.abtnAccount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            this.abtnAccount.BorderRadius = 30;
            this.abtnAccount.BorderSize = 0;
            this.abtnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abtnAccount.FlatAppearance.BorderSize = 0;
            this.abtnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnAccount.Font = new System.Drawing.Font("Arial", 9.5F);
            this.abtnAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.abtnAccount.Image = global::Airline_Ticket_Booking.Properties.Resources.accountDeactive;
            this.abtnAccount.LineType = Airline_Ticket_Booking.AControls.AButton.LineStyles.None;
            this.abtnAccount.Location = new System.Drawing.Point(448, 1);
            this.abtnAccount.Name = "abtnAccount";
            this.abtnAccount.RoundType = Airline_Ticket_Booking.AControls.AButton.RoundStyles.Top;
            this.abtnAccount.Size = new System.Drawing.Size(150, 90);
            this.abtnAccount.TabIndex = 5;
            this.abtnAccount.Text = "Tài khoản";
            this.abtnAccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.abtnAccount.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.abtnAccount.ThinknessLine = 0;
            this.abtnAccount.UseVisualStyleBackColor = false;
            this.abtnAccount.Click += new System.EventHandler(this.abtnAccount_Click);
            // 
            // abtnContact
            // 
            this.abtnContact.BackColor = System.Drawing.Color.Transparent;
            this.abtnContact.BackgroundColor = System.Drawing.Color.Transparent;
            this.abtnContact.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            this.abtnContact.BorderRadius = 30;
            this.abtnContact.BorderSize = 0;
            this.abtnContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abtnContact.FlatAppearance.BorderSize = 0;
            this.abtnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnContact.Font = new System.Drawing.Font("Arial", 9.5F);
            this.abtnContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.abtnContact.Image = global::Airline_Ticket_Booking.Properties.Resources.contactDeactive;
            this.abtnContact.LineType = Airline_Ticket_Booking.AControls.AButton.LineStyles.None;
            this.abtnContact.Location = new System.Drawing.Point(298, 1);
            this.abtnContact.Name = "abtnContact";
            this.abtnContact.RoundType = Airline_Ticket_Booking.AControls.AButton.RoundStyles.Top;
            this.abtnContact.Size = new System.Drawing.Size(150, 90);
            this.abtnContact.TabIndex = 1;
            this.abtnContact.Text = "Liên hệ";
            this.abtnContact.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.abtnContact.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.abtnContact.ThinknessLine = 0;
            this.abtnContact.UseVisualStyleBackColor = false;
            this.abtnContact.Click += new System.EventHandler(this.abtnContact_Click);
            // 
            // abtnTicket
            // 
            this.abtnTicket.BackColor = System.Drawing.Color.Transparent;
            this.abtnTicket.BackgroundColor = System.Drawing.Color.Transparent;
            this.abtnTicket.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            this.abtnTicket.BorderRadius = 30;
            this.abtnTicket.BorderSize = 0;
            this.abtnTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abtnTicket.FlatAppearance.BorderSize = 0;
            this.abtnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnTicket.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abtnTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.abtnTicket.Image = global::Airline_Ticket_Booking.Properties.Resources.ticketDeactive;
            this.abtnTicket.LineType = Airline_Ticket_Booking.AControls.AButton.LineStyles.None;
            this.abtnTicket.Location = new System.Drawing.Point(148, 1);
            this.abtnTicket.Name = "abtnTicket";
            this.abtnTicket.RoundType = Airline_Ticket_Booking.AControls.AButton.RoundStyles.Top;
            this.abtnTicket.Size = new System.Drawing.Size(150, 90);
            this.abtnTicket.TabIndex = 4;
            this.abtnTicket.Text = "Vé";
            this.abtnTicket.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.abtnTicket.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.abtnTicket.ThinknessLine = 0;
            this.abtnTicket.UseVisualStyleBackColor = false;
            this.abtnTicket.Click += new System.EventHandler(this.abtnTicket_Click);
            // 
            // FormMainCustomerWindown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(597, 800);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.pnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainCustomerWindown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMainWindown";
            this.Load += new System.EventHandler(this.FormMainCustomerWindown_Load);
            this.pnMenu.ResumeLayout(false);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private AControls.AButton abtnFlight;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lbNameBank;
        private System.Windows.Forms.PictureBox pibClose;
        private System.Windows.Forms.Panel pnMain;
        private AControls.AButton abtnTicket;
        private AControls.AButton abtnContact;
        private AControls.AButton abtnAccount;
    }
}