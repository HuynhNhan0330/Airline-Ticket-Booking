namespace Airline_Ticket_Booking.Usercontrols
{
    partial class OutMessageUC
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
            this.pibAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbText.Location = new System.Drawing.Point(60, 16);
            this.lbText.MaximumSize = new System.Drawing.Size(410, 0);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(46, 18);
            this.lbText.TabIndex = 3;
            this.lbText.Text = "label1";
            // 
            // pibAvatar
            // 
            this.pibAvatar.Image = global::Airline_Ticket_Booking.Properties.Resources.user;
            this.pibAvatar.Location = new System.Drawing.Point(15, 15);
            this.pibAvatar.Name = "pibAvatar";
            this.pibAvatar.Size = new System.Drawing.Size(32, 32);
            this.pibAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibAvatar.TabIndex = 2;
            this.pibAvatar.TabStop = false;
            // 
            // OutMessageUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.pibAvatar);
            this.Name = "OutMessageUC";
            this.Size = new System.Drawing.Size(500, 150);
            ((System.ComponentModel.ISupportInitialize)(this.pibAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.PictureBox pibAvatar;
    }
}
