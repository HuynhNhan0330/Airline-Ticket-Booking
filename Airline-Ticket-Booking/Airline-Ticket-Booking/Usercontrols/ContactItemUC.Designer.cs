namespace Airline_Ticket_Booking.Usercontrols
{
    partial class ContactItemUC
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
            this.lbText = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.ForeColor = System.Drawing.Color.Black;
            this.lbText.Location = new System.Drawing.Point(15, 15);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(52, 18);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "label1";
            this.lbText.Click += new System.EventHandler(this.ContactItemUC_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lbTime.ForeColor = System.Drawing.Color.Black;
            this.lbTime.Location = new System.Drawing.Point(168, 108);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(41, 15);
            this.lbTime.TabIndex = 1;
            this.lbTime.Text = "label2";
            this.lbTime.Click += new System.EventHandler(this.ContactItemUC_Click);
            // 
            // ContactItemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbText);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ContactItemUC";
            this.Size = new System.Drawing.Size(285, 150);
            this.Load += new System.EventHandler(this.ContactItemUC_Load);
            this.Click += new System.EventHandler(this.ContactItemUC_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Label lbTime;
    }
}
