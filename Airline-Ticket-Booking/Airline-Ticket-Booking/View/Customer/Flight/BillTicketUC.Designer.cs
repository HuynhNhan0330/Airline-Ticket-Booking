namespace Airline_Ticket_Booking
{
    partial class BillTicketUC
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
            this.pibHome = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.aPanel1 = new Airline_Ticket_Booking.AControls.APanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbAr = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbDep = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pibHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.aPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pibHome
            // 
            this.pibHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibHome.Image = global::Airline_Ticket_Booking.Properties.Resources.house;
            this.pibHome.Location = new System.Drawing.Point(539, 25);
            this.pibHome.Name = "pibHome";
            this.pibHome.Size = new System.Drawing.Size(32, 32);
            this.pibHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibHome.TabIndex = 7;
            this.pibHome.TabStop = false;
            this.pibHome.Click += new System.EventHandler(this.pibHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Airline_Ticket_Booking.Properties.Resources._checked;
            this.pictureBox1.Location = new System.Drawing.Point(248, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(137, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mua vé thành công";
            // 
            // aPanel1
            // 
            this.aPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.aPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.aPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aPanel1.BorderRadius = 40;
            this.aPanel1.BorderSize = 0;
            this.aPanel1.Controls.Add(this.panel1);
            this.aPanel1.Controls.Add(this.panel4);
            this.aPanel1.Controls.Add(this.panel3);
            this.aPanel1.Controls.Add(this.panel2);
            this.aPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aPanel1.ForeColor = System.Drawing.Color.White;
            this.aPanel1.Location = new System.Drawing.Point(0, 262);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.RoundType = Airline_Ticket_Booking.AControls.APanel.RoundStyles.Top;
            this.aPanel1.Size = new System.Drawing.Size(597, 343);
            this.aPanel1.TabIndex = 10;
            this.aPanel1.TextColor = System.Drawing.Color.White;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 55);
            this.panel1.TabIndex = 8;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTime.Location = new System.Drawing.Point(498, 15);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(64, 25);
            this.lbTime.TabIndex = 1;
            this.lbTime.Text = "label7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(25, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thời gian";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbAr);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 120);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(597, 55);
            this.panel4.TabIndex = 7;
            // 
            // lbAr
            // 
            this.lbAr.AutoSize = true;
            this.lbAr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbAr.Location = new System.Drawing.Point(498, 15);
            this.lbAr.Name = "lbAr";
            this.lbAr.Size = new System.Drawing.Size(64, 25);
            this.lbAr.TabIndex = 1;
            this.lbAr.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(25, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nơi đến:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbDep);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(597, 55);
            this.panel3.TabIndex = 6;
            // 
            // lbDep
            // 
            this.lbDep.AutoSize = true;
            this.lbDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbDep.Location = new System.Drawing.Point(498, 15);
            this.lbDep.Name = "lbDep";
            this.lbDep.Size = new System.Drawing.Size(64, 25);
            this.lbDep.TabIndex = 1;
            this.lbDep.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(25, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nơi đi:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 65);
            this.panel2.TabIndex = 5;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbName.Location = new System.Drawing.Point(498, 25);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(79, 25);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "lbName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(25, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ và tên:";
            // 
            // BillTicketUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.aPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pibHome);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BillTicketUC";
            this.Size = new System.Drawing.Size(597, 605);
            ((System.ComponentModel.ISupportInitialize)(this.pibHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.aPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pibHome;
        private System.Windows.Forms.Label label2;
        private AControls.APanel aPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbAr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbDep;
        private System.Windows.Forms.Label label6;
    }
}
