namespace Airline_Ticket_Booking
{
    partial class BookTicketUC1
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
            this.abtnDone = new Airline_Ticket_Booking.AControls.AButton();
            this.pibReturn = new System.Windows.Forms.PictureBox();
            this.pnSeat = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnLine = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMoney = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pibReturn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // abtnDone
            // 
            this.abtnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.abtnDone.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.abtnDone.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnDone.BorderRadius = 10;
            this.abtnDone.BorderSize = 0;
            this.abtnDone.FlatAppearance.BorderSize = 0;
            this.abtnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnDone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abtnDone.ForeColor = System.Drawing.Color.White;
            this.abtnDone.LineType = Airline_Ticket_Booking.AControls.AButton.LineStyles.None;
            this.abtnDone.Location = new System.Drawing.Point(50, 540);
            this.abtnDone.Name = "abtnDone";
            this.abtnDone.RoundType = Airline_Ticket_Booking.AControls.AButton.RoundStyles.Full;
            this.abtnDone.Size = new System.Drawing.Size(497, 40);
            this.abtnDone.TabIndex = 55;
            this.abtnDone.Text = "Xác nhận";
            this.abtnDone.TextColor = System.Drawing.Color.White;
            this.abtnDone.ThinknessLine = 0;
            this.abtnDone.UseVisualStyleBackColor = false;
            this.abtnDone.Click += new System.EventHandler(this.abtnDone_Click);
            // 
            // pibReturn
            // 
            this.pibReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibReturn.Image = global::Airline_Ticket_Booking.Properties.Resources.return1;
            this.pibReturn.Location = new System.Drawing.Point(10, 10);
            this.pibReturn.Name = "pibReturn";
            this.pibReturn.Size = new System.Drawing.Size(32, 32);
            this.pibReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibReturn.TabIndex = 53;
            this.pibReturn.TabStop = false;
            this.pibReturn.Click += new System.EventHandler(this.pibReturn_Click);
            // 
            // pnSeat
            // 
            this.pnSeat.AutoScroll = true;
            this.pnSeat.Location = new System.Drawing.Point(50, 130);
            this.pnSeat.Name = "pnSeat";
            this.pnSeat.Size = new System.Drawing.Size(497, 300);
            this.pnSeat.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(200, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 57;
            this.label1.Text = "Chọn ghế phù hợp:";
            // 
            // pnLine
            // 
            this.pnLine.BackColor = System.Drawing.Color.Gray;
            this.pnLine.Location = new System.Drawing.Point(50, 465);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(497, 2);
            this.pnLine.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(45, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Tổng tiền thanh toán: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(50, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 30);
            this.panel1.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(432, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label3.Location = new System.Drawing.Point(13, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "1";
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbMoney.ForeColor = System.Drawing.Color.Black;
            this.lbMoney.Location = new System.Drawing.Point(376, 480);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(58, 20);
            this.lbMoney.TabIndex = 61;
            this.lbMoney.Text = "money";
            // 
            // BookTicketUC1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbMoney);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnLine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnSeat);
            this.Controls.Add(this.abtnDone);
            this.Controls.Add(this.pibReturn);
            this.Name = "BookTicketUC1";
            this.Size = new System.Drawing.Size(597, 605);
            ((System.ComponentModel.ISupportInitialize)(this.pibReturn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AControls.AButton abtnDone;
        private System.Windows.Forms.PictureBox pibReturn;
        private System.Windows.Forms.Panel pnSeat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbMoney;
    }
}
