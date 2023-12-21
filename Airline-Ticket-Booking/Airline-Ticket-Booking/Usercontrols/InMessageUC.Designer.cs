namespace Airline_Ticket_Booking.Usercontrols
{
    partial class InMessageUC
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
            this.pibAvatar = new System.Windows.Forms.PictureBox();
            this.lbText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pibAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pibAvatar
            // 
            this.pibAvatar.Image = global::Airline_Ticket_Booking.Properties.Resources.user;
            this.pibAvatar.Location = new System.Drawing.Point(445, 15);
            this.pibAvatar.Name = "pibAvatar";
            this.pibAvatar.Size = new System.Drawing.Size(32, 32);
            this.pibAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibAvatar.TabIndex = 0;
            this.pibAvatar.TabStop = false;
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbText.Location = new System.Drawing.Point(395, 16);
            this.lbText.MaximumSize = new System.Drawing.Size(430, 0);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(46, 18);
            this.lbText.TabIndex = 1;
            this.lbText.Text = "label1";
            // 
            // InMessageUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.pibAvatar);
            this.Name = "InMessageUC";
            this.Size = new System.Drawing.Size(500, 150);
            ((System.ComponentModel.ISupportInitialize)(this.pibAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibAvatar;
        private System.Windows.Forms.Label lbText;
    }
}
