﻿using Airline_Ticket_Booking.AControls;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Airline_Ticket_Booking
{
    public partial class ReportUC : UserControl
    {
        public ReportUC()
        {
            InitializeComponent();
            cbTypeReport.SelectedIndex = 0;
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
                    break;
                case 1:
                    loadBody(new ReportByYearUC());
                    adtpTime.CustomFormat = "yyyy";
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
            // Xem đã có chi tiết báo cáo năm của tháng này chưa
            DetailedAnnualRevenueReportDTO findDetailedAnnualRevenueReport = await DetailedAnnualRevenueReportDAL.Ins.find(adtpTime.Value.Year, adtpTime.Value.Month);

            List<DetailedMonthlyRevenueReportDTO> listReportByMonthDetail = null;

            // Không tồn tại
            if (findDetailedAnnualRevenueReport == null)
            {
                listReportByMonthDetail = await calculateMonth(adtpTime.Value.Month, adtpTime.Value.Year);
            }
            else
            {
                (bool isGet, List< DetailedMonthlyRevenueReportDTO> x, string label) = await DetailedMonthlyRevenueReportDAL.Ins.getListDetailedMonthlyRevenueReport(adtpTime.Value.Month, adtpTime.Value.Year);
                if (isGet)
                {
                    listReportByMonthDetail = new List<DetailedMonthlyRevenueReportDTO>(x);
                }
                else
                {
                    AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ms.ShowDialog();
                }
            }

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
                foreach (DetailedMonthlyRevenueReportDTO dmrr in detailedMonthlyRevenueReports)
                    dmrr.Ratio = Math.Round(dmrr.Revenue * 100 / totalRevenue, 2);

                // Kiểm tra điều kiên phù hợp sẽ lưu lên cơ sở dữ liệu của mình
                // Trên bảng chi tiết báo cáo tháng (Detailed Monthly Revenue Report)
                if (month < DateTime.Now.Month && year <= DateTime.Now.Year && detailedMonthlyRevenueReports.Count > 0)
                {
                    // Tạo chi tiết báo cáo theo năm
                    DetailedAnnualRevenueReportDTO detailedAnnualRevenueReport = new DetailedAnnualRevenueReportDTO();
                    detailedAnnualRevenueReport.Year = year;
                    detailedAnnualRevenueReport.Month = month;
                    detailedAnnualRevenueReport.Revenue = totalRevenue;
                    detailedAnnualRevenueReport.FlightCount = detailedMonthlyRevenueReports.Count();

                    (bool isCreateDetailedAnnualRevenueReport, string label) = await DetailedAnnualRevenueReportDAL.Ins.createDetailedAnnualRevenueReport(detailedAnnualRevenueReport);

                    if (isCreateDetailedAnnualRevenueReport)
                    {
                        // Lưu danh sách báo cáo chi tiết theo tháng
                        (bool isCreateDetailMonthlyRevenueReport, string label1) = await DetailedMonthlyRevenueReportDAL.Ins.createDetailedMonthlyRevenueReport(detailedMonthlyRevenueReports);

                        if (!isCreateDetailMonthlyRevenueReport)
                        {
                            AMessageBoxFrm ms = new AMessageBoxFrm(label1, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ms.ShowDialog();
                        }
                    }
                    else
                    {
                        AMessageBoxFrm ms = new AMessageBoxFrm(label, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ms.ShowDialog();
                    }

                }

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
                DetailedAnnualRevenueReportDTO findDetailedAnnualRevenueReport = await DetailedAnnualRevenueReportDAL.Ins.find(year, month);

                // Chưa có tồn tại báo cáo tháng đó
                if (findDetailedAnnualRevenueReport == null)
                {
                    List <DetailedMonthlyRevenueReportDTO> detailedMonthlyRevenueReports = await calculateMonth(month, year);

                    if (detailedMonthlyRevenueReports.Count > 0)
                    {
                        DetailedAnnualRevenueReportDTO detailedAnnualRevenueReport = new DetailedAnnualRevenueReportDTO();
                        detailedAnnualRevenueReport.Year = year;
                        detailedAnnualRevenueReport.Month = month;
                        detailedAnnualRevenueReport.Revenue = detailedMonthlyRevenueReports.Sum(dmrr => dmrr.Revenue);
                        detailedAnnualRevenueReport.FlightCount = detailedMonthlyRevenueReports.Count();

                        findDetailedAnnualRevenueReport = detailedAnnualRevenueReport;
                    }
                }
                
                if (findDetailedAnnualRevenueReport != null)
                    ListAnnualRevenueReport.Add(findDetailedAnnualRevenueReport);
            }

            decimal totalRevenue = ListAnnualRevenueReport.Sum(darr => darr.Revenue);

            foreach (var darr in ListAnnualRevenueReport) 
                darr.Ratio = Math.Round(darr.Revenue * 100 / totalRevenue, 2);

            // Lưu lại báo cáo năm
            if (year < DateTime.Now.Year)
            {
                //Lưu báo cáo năm
                AnnualRevenueReportDTO annualRevenueReport = new AnnualRevenueReportDTO();
                annualRevenueReport.Years = year;
                annualRevenueReport.TotalRevenue = totalRevenue;

                (bool isCreate, string label) = await AnnualRevenueReportDAL.Ins.createAnnualRevenueReport(annualRevenueReport);

                // Cập nhật ratio
                await DetailedAnnualRevenueReportDAL.Ins.update(ListAnnualRevenueReport);
            }

            return ListAnnualRevenueReport;
        }

        private async void loadReportByYear()
        {
            // Xem đã có báo cáo năm này chưa
            AnnualRevenueReportDTO findAnnualRevenueReport = await AnnualRevenueReportDAL.Ins.find(adtpTime.Value.Year);


            List<DetailedAnnualRevenueReportDTO> listReportByYearDetail = null;

            // Không tồn tại báo cáo năm
            if (findAnnualRevenueReport == null)
            {
                listReportByYearDetail = await calculateYear(adtpTime.Value.Year);
            }
            else
            {
                (bool isGet, List<DetailedAnnualRevenueReportDTO> x, string label) = await DetailedAnnualRevenueReportDAL.Ins.getListDetailedAnnualRevenueReport(adtpTime.Value.Year);
                if (isGet)
                {
                    listReportByYearDetail = new List<DetailedAnnualRevenueReportDTO>(x);
                }
                else
                {
                    AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ms.ShowDialog();
                }
            }

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
                if (cbTypeReport.SelectedIndex == 0)
                    message.Subject += "tháng " + adtpTime.Value.Month + "/" + adtpTime.Value.Year;
                else
                    message.Subject += "năm " + adtpTime.Value.Year;
                // Tạo ngẫu nhiên
                message.Body = message.Subject + ":";

                // Tạo đối tượng SmtpClient và cấu hình thông tin SMTP của Gmail
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Credentials = new NetworkCredential(email, password);
                Attachment attachment = new Attachment(exportExcel());
                message.Attachments.Add(attachment);
                try
                {
                    // Gửi email
                    smtpClient.Send(message);
                }
                catch (Exception ex)
                {
                    AMessageBoxFrm ms = new AMessageBoxFrm(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ms.ShowDialog();
                }
            }
        }
    }
}
