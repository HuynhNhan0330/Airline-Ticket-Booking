namespace Airline_Ticket_Booking
{
    partial class ChatUC
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
            this.components = new System.ComponentModel.Container();
            this.pnTop = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pibSend = new System.Windows.Forms.PictureBox();
            this.atxbText = new Airline_Ticket_Booking.AControls.ATextboxUC();
            this.pnChat = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnTop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibSend)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.pnTop.Controls.Add(this.lbName);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(500, 56);
            this.pnTop.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(115, 15);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(270, 26);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "LIÊN HỆ VỚI CHÚNG TÔI";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pibSend);
            this.panel2.Controls.Add(this.atxbText);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 500);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 50);
            this.panel2.TabIndex = 1;
            // 
            // pibSend
            // 
            this.pibSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pibSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibSend.Image = global::Airline_Ticket_Booking.Properties.Resources.SendIcon;
            this.pibSend.Location = new System.Drawing.Point(440, 10);
            this.pibSend.Name = "pibSend";
            this.pibSend.Size = new System.Drawing.Size(35, 35);
            this.pibSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibSend.TabIndex = 2;
            this.pibSend.TabStop = false;
            this.pibSend.Click += new System.EventHandler(this.pibSend_Click);
            // 
            // atxbText
            // 
            this.atxbText.BackColor = System.Drawing.SystemColors.Window;
            this.atxbText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.atxbText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.atxbText.BorderRadius = 10;
            this.atxbText.BorderSize = 2;
            this.atxbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.atxbText.ForeColor = System.Drawing.Color.Black;
            this.atxbText.isFocused = false;
            this.atxbText.isPlaceholder = true;
            this.atxbText.Location = new System.Drawing.Point(25, 10);
            this.atxbText.Margin = new System.Windows.Forms.Padding(4);
            this.atxbText.Multiline = false;
            this.atxbText.Name = "atxbText";
            this.atxbText.Padding = new System.Windows.Forms.Padding(7);
            this.atxbText.PasswordChar = false;
            this.atxbText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbText.PlaceholderText = "Tin nhắn";
            this.atxbText.RoundType = Airline_Ticket_Booking.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbText.Size = new System.Drawing.Size(400, 35);
            this.atxbText.TabIndex = 0;
            this.atxbText.textAlign = Airline_Ticket_Booking.AControls.ATextboxUC.TextAlign.Left;
            this.atxbText.Texts = "";
            this.atxbText.UnderlinedStyle = false;
            // 
            // pnChat
            // 
            this.pnChat.AutoScroll = true;
            this.pnChat.BackColor = System.Drawing.Color.Transparent;
            this.pnChat.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnChat.Location = new System.Drawing.Point(0, 56);
            this.pnChat.Name = "pnChat";
            this.pnChat.Size = new System.Drawing.Size(500, 444);
            this.pnChat.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ChatUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnChat);
            this.Controls.Add(this.pnTop);
            this.Name = "ChatUC";
            this.Size = new System.Drawing.Size(500, 550);
            this.Load += new System.EventHandler(this.ChatUC_Load);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibSend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel panel2;
        private AControls.ATextboxUC atxbText;
        private System.Windows.Forms.PictureBox pibSend;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel pnChat;
        private System.Windows.Forms.Timer timer;
    }
}
