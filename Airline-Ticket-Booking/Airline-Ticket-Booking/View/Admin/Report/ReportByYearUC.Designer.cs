﻿using System.Drawing;
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbRevenue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbFlightCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnReportByYear = new System.Windows.Forms.Panel();
            this.chartReportByYear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnHeader.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartReportByYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.pictureBox3);
            this.panel9.Controls.Add(this.lbRevenue);
            this.panel9.Controls.Add(this.label10);
            this.panel9.Location = new System.Drawing.Point(50, 535);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(300, 130);
            this.panel9.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Airline_Ticket_Booking.Properties.Resources.MoneyIcon;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(25, 45);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 40);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // lbRevenue
            // 
            this.lbRevenue.AutoSize = true;
            this.lbRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbRevenue.ForeColor = System.Drawing.Color.Black;
            this.lbRevenue.Location = new System.Drawing.Point(100, 61);
            this.lbRevenue.Name = "lbRevenue";
            this.lbRevenue.Size = new System.Drawing.Size(97, 29);
            this.lbRevenue.TabIndex = 1;
            this.lbRevenue.Text = "100000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(100, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tổng doanh thu";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Controls.Add(this.lbFlightCount);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(50, 350);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(300, 130);
            this.panel7.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Airline_Ticket_Booking.Properties.Resources.PlaneFlightIcon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(25, 45);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 40);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbFlightCount
            // 
            this.lbFlightCount.AutoSize = true;
            this.lbFlightCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbFlightCount.ForeColor = System.Drawing.Color.Black;
            this.lbFlightCount.Location = new System.Drawing.Point(100, 61);
            this.lbFlightCount.Name = "lbFlightCount";
            this.lbFlightCount.Size = new System.Drawing.Size(97, 29);
            this.lbFlightCount.TabIndex = 1;
            this.lbFlightCount.Text = "100000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(100, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng chuyến bay";
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.panel10);
            this.pnHeader.Controls.Add(this.panel6);
            this.pnHeader.Controls.Add(this.panel5);
            this.pnHeader.Controls.Add(this.panel3);
            this.pnHeader.Location = new System.Drawing.Point(375, 350);
            this.pnHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(700, 40);
            this.pnHeader.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label11);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(600, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(100, 40);
            this.panel10.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label11.Location = new System.Drawing.Point(25, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 22);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tỷ lệ";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(300, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 40);
            this.panel6.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(103, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Doanh thu";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(100, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 40);
            this.panel5.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.Location = new System.Drawing.Point(35, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số chuyến bay";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 40);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(19, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng";
            // 
            // pnReportByYear
            // 
            this.pnReportByYear.AutoScroll = true;
            this.pnReportByYear.Location = new System.Drawing.Point(375, 390);
            this.pnReportByYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnReportByYear.Name = "pnReportByYear";
            this.pnReportByYear.Size = new System.Drawing.Size(700, 275);
            this.pnReportByYear.TabIndex = 6;
            // 
            // chartReportByYear
            // 
            chartArea1.Name = "ChartArea1";
            this.chartReportByYear.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chartReportByYear.Legends.Add(legend1);
            this.chartReportByYear.Location = new System.Drawing.Point(1100, 25);
            this.chartReportByYear.Name = "chartReportByYear";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartReportByYear.Series.Add(series1);
            this.chartReportByYear.Size = new System.Drawing.Size(350, 640);
            this.chartReportByYear.TabIndex = 7;
            this.chartReportByYear.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title1.Name = "Title1";
            title1.Text = "Top 5 tháng doanh thu cao nhất";
            this.chartReportByYear.Titles.Add(title1);
            // 
            // chartRevenue
            // 
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.MajorGrid.LineWidth = 0;
            chartArea2.AxisY.LabelStyle.Format = "{0:#,#} ₫";
            chartArea2.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend2);
            this.chartRevenue.Location = new System.Drawing.Point(50, 25);
            this.chartRevenue.Name = "chartRevenue";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series2.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(184)))));
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Doanh thu";
            this.chartRevenue.Series.Add(series2);
            this.chartRevenue.Size = new System.Drawing.Size(1025, 300);
            this.chartRevenue.TabIndex = 8;
            title2.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            title2.Name = "Title1";
            title2.Text = "Biểu đồ doanh thu năm";
            this.chartRevenue.Titles.Add(title2);
            // 
            // ReportByYearUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.chartRevenue);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.chartReportByYear);
            this.Controls.Add(this.pnReportByYear);
            this.Controls.Add(this.pnHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReportByYearUC";
            this.Size = new System.Drawing.Size(1500, 690);
            this.Load += new System.EventHandler(this.ReportByYearUC_Load);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnHeader.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartReportByYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private Panel pnReportByYear;
        private Panel panel10;
        private Label label11;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartReportByYear;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
    }
}
