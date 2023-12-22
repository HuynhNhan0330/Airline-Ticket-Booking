namespace Airline_Ticket_Booking.Usercontrols
{
    partial class FlightMobileItemUC
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
            this.lbDeparture = new System.Windows.Forms.Label();
            this.lbArrival = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.pnLine = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDeparture
            // 
            this.lbDeparture.AutoSize = true;
            this.lbDeparture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeparture.ForeColor = System.Drawing.Color.Black;
            this.lbDeparture.Location = new System.Drawing.Point(15, 15);
            this.lbDeparture.MaximumSize = new System.Drawing.Size(470, 0);
            this.lbDeparture.Name = "lbDeparture";
            this.lbDeparture.Size = new System.Drawing.Size(53, 20);
            this.lbDeparture.TabIndex = 0;
            this.lbDeparture.Text = "label1";
            // 
            // lbArrival
            // 
            this.lbArrival.AutoSize = true;
            this.lbArrival.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArrival.ForeColor = System.Drawing.Color.Black;
            this.lbArrival.Location = new System.Drawing.Point(15, 45);
            this.lbArrival.MaximumSize = new System.Drawing.Size(470, 0);
            this.lbArrival.Name = "lbArrival";
            this.lbArrival.Size = new System.Drawing.Size(70, 20);
            this.lbArrival.TabIndex = 1;
            this.lbArrival.Text = "lbArrival";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.Black;
            this.lbTime.Location = new System.Drawing.Point(15, 70);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(59, 20);
            this.lbTime.TabIndex = 2;
            this.lbTime.Text = "lbTime";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.Black;
            this.lbPrice.Location = new System.Drawing.Point(406, 89);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(53, 20);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "label4";
            // 
            // pnLine
            // 
            this.pnLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.pnLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnLine.Location = new System.Drawing.Point(0, 147);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(497, 3);
            this.pnLine.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Airline_Ticket_Booking.Properties.Resources.airplane;
            this.pictureBox1.Location = new System.Drawing.Point(399, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FlightMobileItemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnLine);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbArrival);
            this.Controls.Add(this.lbDeparture);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "FlightMobileItemUC";
            this.Size = new System.Drawing.Size(497, 150);
            this.Click += new System.EventHandler(this.FlightMobileItemUC_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDeparture;
        private System.Windows.Forms.Label lbArrival;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Panel pnLine;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
