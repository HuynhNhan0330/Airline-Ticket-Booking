namespace Airline_Ticket_Booking
{
    partial class ContactUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.flpnListContact = new System.Windows.Forms.FlowLayoutPanel();
            this.abtnSearch = new Airline_Ticket_Booking.AControls.AButton();
            this.atxbNameCustomer = new Airline_Ticket_Booking.AControls.ATextboxUC();
            this.chatUC1 = new Airline_Ticket_Booking.ChatUC();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm theo tên:";
            // 
            // flpnListContact
            // 
            this.flpnListContact.AutoScroll = true;
            this.flpnListContact.Location = new System.Drawing.Point(50, 100);
            this.flpnListContact.Name = "flpnListContact";
            this.flpnListContact.Size = new System.Drawing.Size(800, 625);
            this.flpnListContact.TabIndex = 3;
            // 
            // abtnSearch
            // 
            this.abtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnSearch.BorderRadius = 10;
            this.abtnSearch.BorderSize = 0;
            this.abtnSearch.FlatAppearance.BorderSize = 0;
            this.abtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnSearch.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abtnSearch.ForeColor = System.Drawing.Color.White;
            this.abtnSearch.LineType = Airline_Ticket_Booking.AControls.AButton.LineStyles.None;
            this.abtnSearch.Location = new System.Drawing.Point(700, 25);
            this.abtnSearch.Name = "abtnSearch";
            this.abtnSearch.RoundType = Airline_Ticket_Booking.AControls.AButton.RoundStyles.Full;
            this.abtnSearch.Size = new System.Drawing.Size(150, 35);
            this.abtnSearch.TabIndex = 2;
            this.abtnSearch.Text = "Tìm kiếm";
            this.abtnSearch.TextColor = System.Drawing.Color.White;
            this.abtnSearch.ThinknessLine = 0;
            this.abtnSearch.UseVisualStyleBackColor = false;
            this.abtnSearch.Click += new System.EventHandler(this.abtnSearch_Click);
            // 
            // atxbNameCustomer
            // 
            this.atxbNameCustomer.BackColor = System.Drawing.Color.White;
            this.atxbNameCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.atxbNameCustomer.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.atxbNameCustomer.BorderRadius = 10;
            this.atxbNameCustomer.BorderSize = 2;
            this.atxbNameCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.atxbNameCustomer.ForeColor = System.Drawing.Color.Black;
            this.atxbNameCustomer.isFocused = false;
            this.atxbNameCustomer.isPlaceholder = true;
            this.atxbNameCustomer.Location = new System.Drawing.Point(250, 25);
            this.atxbNameCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.atxbNameCustomer.Multiline = false;
            this.atxbNameCustomer.Name = "atxbNameCustomer";
            this.atxbNameCustomer.Padding = new System.Windows.Forms.Padding(7);
            this.atxbNameCustomer.PasswordChar = false;
            this.atxbNameCustomer.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbNameCustomer.PlaceholderText = "Nhập tên khách hàng muốn tìm kiếm";
            this.atxbNameCustomer.RoundType = Airline_Ticket_Booking.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbNameCustomer.Size = new System.Drawing.Size(400, 35);
            this.atxbNameCustomer.TabIndex = 0;
            this.atxbNameCustomer.textAlign = Airline_Ticket_Booking.AControls.ATextboxUC.TextAlign.Left;
            this.atxbNameCustomer.Texts = "";
            this.atxbNameCustomer.UnderlinedStyle = false;
            // 
            // chatUC1
            // 
            this.chatUC1.BackColor = System.Drawing.Color.White;
            this.chatUC1.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.chatUC1.customerID = null;
            this.chatUC1.Location = new System.Drawing.Point(950, 100);
            this.chatUC1.name = "LIÊN HỆ VỚI CHÚNG TÔI";
            this.chatUC1.Name = "chatUC1";
            this.chatUC1.Size = new System.Drawing.Size(500, 550);
            this.chatUC1.TabIndex = 4;
            this.chatUC1.type = 0;
            // 
            // ContactUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.chatUC1);
            this.Controls.Add(this.flpnListContact);
            this.Controls.Add(this.abtnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.atxbNameCustomer);
            this.Name = "ContactUC";
            this.Size = new System.Drawing.Size(1500, 750);
            this.Load += new System.EventHandler(this.ContactUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AControls.ATextboxUC atxbNameCustomer;
        private System.Windows.Forms.Label label1;
        private AControls.AButton abtnSearch;
        private System.Windows.Forms.FlowLayoutPanel flpnListContact;
        private ChatUC chatUC1;
    }
}
