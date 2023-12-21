namespace Airline_Ticket_Booking
{
    partial class ContactCustomerUC
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
            this.chatUC1 = new Airline_Ticket_Booking.ChatUC();
            this.SuspendLayout();
            // 
            // chatUC1
            // 
            this.chatUC1.BackColor = System.Drawing.Color.White;
            this.chatUC1.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.chatUC1.Location = new System.Drawing.Point(50, 25);
            this.chatUC1.Name = "chatUC1";
            this.chatUC1.Size = new System.Drawing.Size(500, 550);
            this.chatUC1.TabIndex = 0;
            // 
            // ContactCustomerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.chatUC1);
            this.Name = "ContactCustomerUC";
            this.Size = new System.Drawing.Size(597, 605);
            this.Load += new System.EventHandler(this.ContactCustomerUC_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ChatUC chatUC1;
    }
}
