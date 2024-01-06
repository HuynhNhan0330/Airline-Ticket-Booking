using Airline_Ticket_Booking.DTOs;
using Airline_Ticket_Booking.Model;
using Airline_Ticket_Booking.Usercontrols;
using Airline_Ticket_Booking.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Airline_Ticket_Booking
{
    public partial class ReportByYearUC : UserControl
    {
        private List<DetailedAnnualRevenueReportDTO> _detailAnnualRevenueReport;
        public List<DetailedAnnualRevenueReportDTO> detailAnnualRevenueReport
        {
            get { return _detailAnnualRevenueReport; }
            set 
            { 
                _detailAnnualRevenueReport = value; 
            }
        }

        private List<DetailedAnnualRevenueReportDTO> __detailAnnualRevenueReport;

        private decimal _totalRevenue;
        public decimal totalRevenue
        {
            get { return _totalRevenue; }
            set
            {
                _totalRevenue = value;
            }
        }

        public ReportByYearUC()
        {
            InitializeComponent();
        }

        private void ReportByYearUC_Load(object sender, EventArgs e)
        {
            
        }

        public void loadData(List<DetailedAnnualRevenueReportDTO> detailAnnualRevenueReport)
        {
            this.detailAnnualRevenueReport = new List<DetailedAnnualRevenueReportDTO>(detailAnnualRevenueReport);
            this.__detailAnnualRevenueReport = new List<DetailedAnnualRevenueReportDTO>(detailAnnualRevenueReport);

            loadDataNew();
        }

        private void loadDataNew()
        {
            loadPanel();

            lbFlightCount.Text = detailAnnualRevenueReport.Sum(darr => darr.FlightCount).ToString();
            totalRevenue = detailAnnualRevenueReport.Sum(darr => darr.Revenue);
            lbRevenue.Text = Helper.FormatVNMoney(totalRevenue);

            loadChart();
        }

        public void loadPanel()
        {
            pnReportByYear.Controls.Clear();

            for (int i = 0; i < detailAnnualRevenueReport.Count; ++i)
            {
                detailAnnualRevenueReport[i].STT = i + 1;
                ReportByYearItemUC uc = new ReportByYearItemUC();
                uc.stt = i + 1;
                uc.darr = detailAnnualRevenueReport[i];
                pnReportByYear.Controls.Add(uc);
                uc.BringToFront();
                uc.Dock = DockStyle.Top;

                Panel pn = new Panel();
                pnReportByYear.Controls.Add(pn);
                pn.Height = 2;
                pn.BackColor = Color.Gray;
                pn.BringToFront();
                pn.Dock = DockStyle.Top;
            }
        }

        public void loadQuy(int quy)
        {
            if (quy == 0)
            {
                detailAnnualRevenueReport = new List<DetailedAnnualRevenueReportDTO>(__detailAnnualRevenueReport);

                loadDataNew();
            }
            else
            {
                detailAnnualRevenueReport.Clear();

                for (int i = 0; i < __detailAnnualRevenueReport.Count; ++i)
                    if ((quy - 1) * 3 + 1 <= __detailAnnualRevenueReport[i].Month && __detailAnnualRevenueReport[i].Month <= quy * 3)
                        detailAnnualRevenueReport.Add(__detailAnnualRevenueReport[i]);

                loadDataNew();
            }
        }

        public void loadChart()
        {
            List<DetailedAnnualRevenueReportDTO> filteredList = detailAnnualRevenueReport;

            int number = Math.Min(filteredList.Count, 3);
            filteredList = filteredList.OrderByDescending(r => r.Revenue).Take(number).ToList();

            chartReportByYear.Titles[0].Text = "Top " + number.ToString() + " tháng có doanh thu cao nhất";
            chartReportByYear.DataSource = filteredList;
            chartReportByYear.Series[0].XValueMember = "Month";
            chartReportByYear.Series[0].YValueMembers = "Ratio";
            chartReportByYear.DataBind();
            chartReportByYear.Update();

            chartRevenue.DataSource = detailAnnualRevenueReport;
            chartRevenue.Series[0].XValueMember = "Month";
            chartRevenue.Series[0].YValueMembers = "Revenue";
            chartRevenue.DataBind();
            chartRevenue.Update();
        }
    }
}
