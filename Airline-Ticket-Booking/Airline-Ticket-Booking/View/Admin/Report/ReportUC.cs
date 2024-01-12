using Airline_Ticket_Booking.AControls;
using Airline_Ticket_Booking.DALs;
using Airline_Ticket_Booking.DTOs;
using Airline_Ticket_Booking.Utils;
using MiniExcelLibs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using System.IO;
using Airline_Ticket_Booking.Model;
using System.Windows.Forms.DataVisualization.Charting;

namespace Airline_Ticket_Booking
{
    public partial class ReportUC : UserControl
    {
        public ReportUC()
        {
            InitializeComponent();
            cbTypeReport.SelectedIndex = 0;
            cbQuy.SelectedIndex = 0;
        }

        private void loadBody(UserControl uc)
        {
            pnBodyReport.Controls.Clear();
            pnBodyReport.Controls.Add(uc);
        }

        private void cbTypeReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbTypeReport.SelectedIndex)
            {
                case 0:
                    loadBody(new ReportByMonthUC());
                    adtpTime.CustomFormat = "MM/yyyy";
                    cbQuy.Visible = false;
                    break;
                case 1:
                    loadBody(new ReportByYearUC());
                    adtpTime.CustomFormat = "yyyy";
                    cbQuy.Visible = true;
                    break;
            }

            adtpTime_ValueChanged(sender, e);
        }

        private void adtpTime_ValueChanged(object sender, EventArgs e)
        {
            switch (cbTypeReport.SelectedIndex)
            {
                // Xử lý trên tháng
                case 0:
                    loadReportByMonth();
                    break;

                // Xử lý trên năm
                case 1:
                    loadReportByYear();
                    break;
            }
        }

        private async void loadReportByMonth()
        {
            List<DetailedMonthlyRevenueReportDTO> listReportByMonthDetail = await calculateMonth(adtpTime.Value.Month, adtpTime.Value.Year);

            ReportByMonthUC uc = pnBodyReport.Controls[0] as ReportByMonthUC;
            uc.loadData(listReportByMonthDetail);
        }


        public async Task<List<DetailedMonthlyRevenueReportDTO>> calculateMonth(int month, int year)
        {
            // Tính toán chi tiết theo tháng

            // Bước 1: Lấy thông tin báo cáo tháng chi tiết dụa trên chi tiết hạng vé chuyến bay
            (bool isGet, List<DetailedMonthlyRevenueReportDTO> detailedMonthlyRevenueReports) = await DetailedMonthlyRevenueReportDAL.Ins.getDetailedMonthlyRevenueReportInTicket(month, year);

            if (isGet)
            {
                decimal totalRevenue = detailedMonthlyRevenueReports.Sum(dmrr => dmrr.Revenue);

                // Tính tỉ lệ cho chi tiết báo cáo tháng
                if (totalRevenue > 0)
                    foreach (DetailedMonthlyRevenueReportDTO dmrr in detailedMonthlyRevenueReports)
                        dmrr.Ratio = Math.Round(dmrr.Revenue * 100 / totalRevenue, 2);

                // Hiển thị lên view
                return detailedMonthlyRevenueReports;
            }
            else
            {
                return null;
            }
        }

        public async Task<List<DetailedAnnualRevenueReportDTO>> calculateYear(int year)
        {
            List<DetailedAnnualRevenueReportDTO> ListAnnualRevenueReport = new List<DetailedAnnualRevenueReportDTO>();

            for (int month = 1; month <= 12; ++month)
            {
                // Kiểm tra tháng này đã tồn tại chưa
                DetailedAnnualRevenueReportDTO findDetailedAnnualRevenueReport = null;

                List<DetailedMonthlyRevenueReportDTO> detailedMonthlyRevenueReports = await calculateMonth(month, year);

                if (detailedMonthlyRevenueReports.Count > 0)
                {
                    DetailedAnnualRevenueReportDTO detailedAnnualRevenueReport = new DetailedAnnualRevenueReportDTO();
                    detailedAnnualRevenueReport.Year = year;
                    detailedAnnualRevenueReport.Month = month;
                    detailedAnnualRevenueReport.Revenue = detailedMonthlyRevenueReports.Sum(dmrr => dmrr.Revenue);
                    detailedAnnualRevenueReport.FlightCount = detailedMonthlyRevenueReports.Count();

                    findDetailedAnnualRevenueReport = detailedAnnualRevenueReport;
                }

                if (findDetailedAnnualRevenueReport != null)
                    ListAnnualRevenueReport.Add(findDetailedAnnualRevenueReport);
            }

            decimal totalRevenue = ListAnnualRevenueReport.Sum(darr => darr.Revenue);

            if (totalRevenue > 0)
                foreach (var darr in ListAnnualRevenueReport) 
                    darr.Ratio = Math.Round(darr.Revenue * 100 / totalRevenue, 2);

            return ListAnnualRevenueReport;
        }

        private async void loadReportByYear()
        {
            List<DetailedAnnualRevenueReportDTO> listReportByYearDetail = await calculateYear(adtpTime.Value.Year);

            ReportByYearUC uc = pnBodyReport.Controls[0] as ReportByYearUC;
            uc.loadData(listReportByYearDetail);
        }

        private void abtnExportExcel_Click(object sender, EventArgs e)
        {
            exportExcel();
        }

        private string exportExcel()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx;*.xlsm";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string PATH_EXPORT = saveFileDialog.FileName;

                if (cbTypeReport.SelectedIndex == 0)
                {
                    string PATH_TEMPLATE = @"../../Excel/TemplateReportByMonth.xlsx";

                    ReportByMonthUC uc = pnBodyReport.Controls[0] as ReportByMonthUC;

                    var value = new
                    {
                        reportType = "Báo cáo tháng " + adtpTime.Value.Month + "/" + adtpTime.Value.Year,
                        reportTime = DateTime.Now.ToString("dd/MM/yyyy"),
                        nameUser = Helper.getAccountAdmin().Name,
                        totalRevenue = uc.totalRevenue,
                        data = uc.detailedMonthlyRevenueReports.ToArray()
                    };

                    MiniExcel.SaveAsByTemplate(PATH_EXPORT, PATH_TEMPLATE, value);
                    Process.Start(PATH_EXPORT);
                }
                else
                {
                    string PATH_TEMPLATE = @"../../Excel/TemplateReportByYear.xlsx";

                    ReportByYearUC uc = pnBodyReport.Controls[0] as ReportByYearUC;

                    var value = new
                    {
                        reportType = "Báo cáo năm " + adtpTime.Value.Year,
                        reportTime = DateTime.Now.ToString("dd/MM/yyyy"),
                        nameUser = Helper.getAccountAdmin().Name,
                        totalRevenue = uc.totalRevenue,
                        data = uc.detailAnnualRevenueReport.ToArray()
                    };

                    MiniExcel.SaveAsByTemplate(PATH_EXPORT, PATH_TEMPLATE, value);
                    Process.Start(PATH_EXPORT);
                }

                return PATH_EXPORT;
            }

            return null;
        }

        private void abtnSendEmail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(atxbEmail.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Email không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else
            {
                // Thông tin tài khoản Gmail
                string email = "nhanhelpxx@gmail.com";
                string password = "xxts wmgb aeoe favp";

                // Tạo đối tượng MailMessage
                MailMessage message = new MailMessage();
                message.From = new MailAddress(email);
                message.To.Add(atxbEmail.Texts.Trim());
                message.Subject = "Báo cáo ";

                switch (cbTypeReport.SelectedIndex)
                {
                    // Xử lý trên tháng
                    case 0:
                        message.Subject += "tháng " + adtpTime.Value.Month + "/" + adtpTime.Value.Year;
                        ReportByMonthUC ucReportMonth = pnBodyReport.Controls[0] as ReportByMonthUC;

                        StringBuilder tableMonthHTML = new StringBuilder();

                        bool isEvenYear = false;

                        foreach (DetailedMonthlyRevenueReportDTO mrr in ucReportMonth.detailedMonthlyRevenueReports)
                        {
                            if (isEvenYear)
                                tableMonthHTML.Append("<tr style=\"background-color: #f3f3f3;\">");
                            else
                                tableMonthHTML.Append("<tr style=\"border-bottom: 1px solid #dddddd;\">");

                            isEvenYear = !isEvenYear;

                            tableMonthHTML.Append("<td style=\"padding: 12px 15px;\">" + mrr.FlightName + "</td>");
                            tableMonthHTML.Append("<td style=\"padding: 12px 15px;\">" + mrr.TicketSold + "</td>");
                            tableMonthHTML.Append("<td style=\"padding: 12px 15px;\">" + mrr.Revenue + "</td>");
                            tableMonthHTML.Append("<td style=\"padding: 12px 15px;\">" + mrr.Ratio + "</td>");
                            tableMonthHTML.Append("</tr>");
                        }

                        String urlRevenueMonth = CloudinaryAPI.UploadChartImageAndGetPublicUrl(ucReportMonth.chartRevenue);

                        String HTMLMonth = System.IO.File.ReadAllText(@"../../HTML/TemplateEmailReportMonth.txt")
                                    .Replace("{TABLE_CONTENT}", tableMonthHTML.ToString())
                                    .Replace("{UrlRevenue}", urlRevenueMonth);
                        message.Body = HTMLMonth;
                        break;

                    // Xử lý trên năm
                    case 1:
                        message.Subject += "năm " + adtpTime.Value.Year;
                        ReportByYearUC ucReportYear = pnBodyReport.Controls[0] as ReportByYearUC;

                        StringBuilder tableYearHTML = new StringBuilder();

                        bool isEven = false;

                        foreach (DetailedAnnualRevenueReportDTO arr in ucReportYear.detailAnnualRevenueReport)
                        {
                            if (isEven) 
                                tableYearHTML.Append("<tr style=\"background-color: #f3f3f3;\">");
                            else
                                tableYearHTML.Append("<tr style=\"border-bottom: 1px solid #dddddd;\">");

                            isEven = !isEven;

                            tableYearHTML.Append("<td style=\"padding: 12px 15px;\">" + arr.Month + "</td>");
                            tableYearHTML.Append("<td style=\"padding: 12px 15px;\">" + arr.FlightCount + "</td>");
                            tableYearHTML.Append("<td style=\"padding: 12px 15px;\">" + arr.Revenue + "</td>");
                            tableYearHTML.Append("<td style=\"padding: 12px 15px;\">" + arr.Ratio + "</td>");
                            tableYearHTML.Append("</tr>");
                        }

                        String urlRevenue = CloudinaryAPI.UploadChartImageAndGetPublicUrl(ucReportYear.chartRevenue); 
                        String urlChartReportByYear = CloudinaryAPI.UploadChartImageAndGetPublicUrl(ucReportYear.chartReportByYear);


                        String HTMLYear = System.IO.File.ReadAllText(@"../../HTML/TemplateEmailReportYear.txt")
                                    .Replace("{TABLE_CONTENT}", tableYearHTML.ToString())
                                    .Replace("{UrlRevenue}", urlRevenue)
                                    .Replace("{UrlChartReportByYear}", urlChartReportByYear);

                        message.Body = HTMLYear;

                        break;
                }


                message.IsBodyHtml = true;
                
                // Tạo đối tượng SmtpClient và cấu hình thông tin SMTP của Gmail
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Credentials = new NetworkCredential(email, password);
                
                try
                {
                    // Gửi email
                    smtpClient.Send(message);

                    AMessageBoxFrm ms = new AMessageBoxFrm("Gửi báo cáo qua email thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ms.ShowDialog();
                }
                catch (Exception ex)
                {
                    AMessageBoxFrm ms = new AMessageBoxFrm(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ms.ShowDialog();
                }
            }
        }

        private void cbQuy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pnBodyReport.Controls[0] is ReportByYearUC)
            {
                ReportByYearUC uc = pnBodyReport.Controls[0] as ReportByYearUC;
                uc.loadQuy(cbQuy.SelectedIndex);
            }
        }
    }
}
