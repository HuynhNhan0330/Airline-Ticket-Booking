using System.Drawing;
using System.Windows.Forms;

namespace Airline_Ticket_Booking
{
    partial class ReportByYearUC
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
            this.SuspendLayout();
            // 
            // ReportByYearUC
            // 
            this.Name = "ReportByYearUC";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel9;
        private PictureBox pictureBox3;
        private Label lbRevenue;
        private Label label10;
        private Panel panel7;
        private PictureBox pictureBox1;
        private Label lbFlightCount;
        private Label label5;
        private Panel pnHeader;
        private Panel panel6;
        private Label label2;
        private Panel panel5;
        private Label label3;
        private Panel panel3;
        private Label label1;
        private Panel panel2;
        private Label lb1;
        private Panel pnReportByYear;
        private Panel panel10;
        private Label label11;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReportByYear;
    }
}
