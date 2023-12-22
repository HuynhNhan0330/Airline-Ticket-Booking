namespace Airline_Ticket_Booking
{
    partial class TicketCustomerUC
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
            this.pnListTicket = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnListTicket
            // 
            this.pnListTicket.Location = new System.Drawing.Point(50, 25);
            this.pnListTicket.Name = "pnListTicket";
            this.pnListTicket.Size = new System.Drawing.Size(497, 550);
            this.pnListTicket.TabIndex = 0;
            // 
            // TicketCustomerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnListTicket);
            this.Name = "TicketCustomerUC";
            this.Size = new System.Drawing.Size(597, 605);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnListTicket;
    }
}
