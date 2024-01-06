using Airline_Ticket_Booking.DTOs;
using Airline_Ticket_Booking.Usercontrols;
using Airline_Ticket_Booking.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Airline_Ticket_Booking
{
    public partial class ReportByMonthUC: UserControl
    {
        private List<DetailedMonthlyRevenueReportDTO> _detailedMonthlyRevenueReports;
        public List<DetailedMonthlyRevenueReportDTO> detailedMonthlyRevenueReports
        {
            get { return _detailedMonthlyRevenueReports; }
            set
            {
                _detailedMonthlyRevenueReports = value;
            }
        }

        private decimal _totalRevenue;
        public decimal totalRevenue
        {
            get { return _totalRevenue; }
            set
            {
                _totalRevenue = value;  
            }
        }

        public ReportByMonthUC()
        {
            InitializeComponent();
        }

        public void loadData(List<DetailedMonthlyRevenueReportDTO> detailedMonthlyRevenueReports)
        {
            this.detailedMonthlyRevenueReports = new List<DetailedMonthlyRevenueReportDTO>(detailedMonthlyRevenueReports);

            loadPanel();

            lbFlightCount.Text = detailedMonthlyRevenueReports.Count.ToString();
            lbTicket.Text = detailedMonthlyRevenueReports.Sum(dmrr => dmrr.TicketSold).ToString();
            totalRevenue = detailedMonthlyRevenueReports.Sum(dmrr => dmrr.Revenue);
            lbRevenue.Text = Helper.FormatVNMoney(totalRevenue);

            loadChar();
        }

        private void ReportByMonthUC_Load(object sender, EventArgs e)
        {

        }

        private void loadChar()
        {
            Dictionary<string, int> cityCounts = new Dictionary<string, int>();

            foreach (DetailedMonthlyRevenueReportDTO dmrr in detailedMonthlyRevenueReports)
            {
                string arrivalCity = dmrr.arrivalCity;

                if (cityCounts.ContainsKey(arrivalCity))
                    cityCounts[arrivalCity]++;
                else
                    cityCounts[arrivalCity] = 1;
            }


            int number = Math.Min(cityCounts.Count, 4);
            cityCounts = cityCounts.OrderByDescending(r => r.Value).Take(number).ToDictionary(pair => pair.Key, pair => pair.Value);

            chartRevenue.Titles[0].Text = "Top " + number.ToString() + " địa điểm được đến nhất";
            chartRevenue.DataSource = cityCounts;
            chartRevenue.Series[0].XValueMember = "Key";
            chartRevenue.Series[0].YValueMembers = "Value";
            chartRevenue.DataBind();
            chartRevenue.Update();
        }

        private void loadPanel()
        {
            pnReportByMonth.Controls.Clear();

            for (int i = 0; i < detailedMonthlyRevenueReports.Count; ++i)
            {
                DetailedMonthlyRevenueReportDTO dmrp = detailedMonthlyRevenueReports[i];
                detailedMonthlyRevenueReports[i].STT = i + 1;
                ReportByMonthItemUC uc = new ReportByMonthItemUC();
                uc.stt = i + 1;
                uc.dmrr = dmrp;
                pnReportByMonth.Controls.Add(uc);
                uc.BringToFront();
                uc.Dock = DockStyle.Top;

                Panel pn = new Panel();
                pnReportByMonth.Controls.Add(pn);
                pn.Height = 2;
                pn.BackColor = Color.Gray;
                pn.BringToFront();
                pn.Dock = DockStyle.Top;
            }
        }
    }
}
