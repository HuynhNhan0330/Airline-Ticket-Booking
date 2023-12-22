namespace Airline_Ticket_Booking.Usercontrols
{
    partial class TicketItemMobileUC
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
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.pibCancel = new System.Windows.Forms.PictureBox();
            this.pnLine = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pibCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.ForeColor = System.Drawing.Color.Black;
            this.lbInfo.Location = new System.Drawing.Point(15, 15);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(46, 18);
            this.lbInfo.TabIndex = 0;
            this.lbInfo.Text = "label1";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.ForeColor = System.Drawing.Color.Black;
            this.lbType.Location = new System.Drawing.Point(15, 43);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(46, 18);
            this.lbType.TabIndex = 1;
            this.lbType.Text = "label2";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.Black;
            this.lbTime.Location = new System.Drawing.Point(15, 71);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(46, 18);
            this.lbTime.TabIndex = 2;
            this.lbTime.Text = "label3";
            // 
            // pibCancel
            // 
            this.pibCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibCancel.Image = global::Airline_Ticket_Booking.Properties.Resources.cancel_ticket;
            this.pibCancel.Location = new System.Drawing.Point(430, 34);
            this.pibCancel.Name = "pibCancel";
            this.pibCancel.Size = new System.Drawing.Size(32, 32);
            this.pibCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibCancel.TabIndex = 11;
            this.pibCancel.TabStop = false;
            this.pibCancel.Click += new System.EventHandler(this.pibCancel_Click);
            // 
            // pnLine
            // 
            this.pnLine.BackColor = System.Drawing.Color.White;
            this.pnLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnLine.Location = new System.Drawing.Point(0, 97);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(497, 3);
            this.pnLine.TabIndex = 12;
            // 
            // TicketItemMobileUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.pnLine);
            this.Controls.Add(this.pibCancel);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbInfo);
            this.Name = "TicketItemMobileUC";
            this.Size = new System.Drawing.Size(497, 100);
            ((System.ComponentModel.ISupportInitialize)(this.pibCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.PictureBox pibCancel;
        private System.Windows.Forms.Panel pnLine;
    }
}
