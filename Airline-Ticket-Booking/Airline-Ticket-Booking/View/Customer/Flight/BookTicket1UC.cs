using Airline_Ticket_Booking.AControls;
using Airline_Ticket_Booking.DALs;
using Airline_Ticket_Booking.DTOs;
using Airline_Ticket_Booking.Model;
using Airline_Ticket_Booking.Usercontrols;
using Airline_Ticket_Booking.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.IO;

namespace Airline_Ticket_Booking
{
    public partial class BookTicketUC1 : UserControl
    {
        private FlightDTO flight;
        private TicketClassDTO ticketClass;
        private TicketDTO ticket;
        public string CurrentSeatID = null;
        private decimal price;

        public BookTicketUC1()
        {
            InitializeComponent();
        }

        public BookTicketUC1(FlightDTO flight, TicketClassDTO ticketClass, TicketDTO ticket)
        {
            InitializeComponent();
            this.flight = flight;
            this.ticketClass = ticketClass;
            this.ticket = ticket;
            loadSeat();
            ticket.Price = flight.TicketPrice * ticketClass.PricePercentage / 100;
            price = ticket.Price;
            lbMoney.Text = Helper.FormatVNMoney(ticket.Price);
            lbMoney.Left = this.Width - lbMoney.Width - 25;
        }

        private void pibReturn_Click(object sender, EventArgs e)
        {
            FormMainCustomerWindown formMainCustomerWindown = Application.OpenForms.OfType<FormMainCustomerWindown>().FirstOrDefault();
            formMainCustomerWindown.removeBody(this);
        }

        private async void loadSeat()
        {
            pnSeat.Controls.Clear();
            (bool isGetSeats, List<SeatDTO> seats, string label) = await SeatDAL.Ins.getSeats(flight.PlaneID);

            if (isGetSeats)
            {
                for (int index1 = 0; index1 < seats.Count / 6; ++index1)
                {
                    SeatMobilieItemUC uc = new SeatMobilieItemUC();

                    // Set seat
                    for (int index2 = 0; index2 < 6; ++index2)
                    {
                        uc.seats.Add(seats[index1 * 6 + index2]);
                    }

                    uc.stt = seats[index1 * 6].SeatID[0].ToString();

                    pnSeat.Controls.Add(uc);
                    uc.BringToFront();
                    uc.Dock = DockStyle.Top;
                    uc.loadTicketColor(flight.FlightID, ticketClass.TicketClassID);

                    Panel pn = new Panel();
                    pnSeat.Controls.Add(pn);
                    pn.Height = 2;
                    pn.BackColor = Color.Transparent;
                    pn.BringToFront();
                    pn.Dock = DockStyle.Top;
                }
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        public void deleteSeatSelected()
        {
            if (!string.IsNullOrEmpty(CurrentSeatID))
                foreach (Control ctr in pnSeat.Controls)
                {
                    if (ctr is SeatMobilieItemUC)
                    {
                        SeatMobilieItemUC ctrSeat = ctr as SeatMobilieItemUC;

                        if (char.Parse(ctrSeat.stt) == CurrentSeatID[0])
                            ctrSeat.clearColor(CurrentSeatID[1]);
                    }
                }
        }

        private void abtnDone_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CurrentSeatID))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Vui lòng chọn ghế thích hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            if (this.price > Helper.getAccountCustomer().Cash)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Số tiền hiện tại không đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else
            {
                AccountDTO account = Helper.getAccountCustomer();
                account.Cash -= this.price;

                ticket.SeatID = CurrentSeatID;
                ticket.accountID = account.AccountID;
                CreateTicket(ticket);
            }
        }

        private async void CreateTicket(TicketDTO ticket)
        {
            (bool isCreate, string label) = await TicketDAL.Ins.createTicket(ticket);

            if (isCreate)
            {
                (bool isUpdate, string label1) = await FlightTicketClassDetailDAL.Ins.updateFlightTicketClassDetail(flight.FlightID, ticket.TicketClassID);

                sendEmail(ticket);

                FormMainCustomerWindown form = Application.OpenForms.OfType<FormMainCustomerWindown>().FirstOrDefault();
                form.addBody(new BillTicketUC(flight));
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        private void sendEmail(TicketDTO ticket)
        {
            String HTML = File.ReadAllText(@"../../HTML/TemplateEmailTicket.txt").Replace("{CUSTOMER_NAME}", ticket.FullName ?? "Bạn")
            .Replace("{FLIGHT_ID}", ticket.FlightID)
            .Replace("{SEAT}", ticket.SeatID)
            .Replace("{NOI_DI}", flight.DepartureCityName)
            .Replace("{NOI_DEN}", flight.ArrivalCityName)
            .Replace("{THOI_GIAN}", flight.DepartureDateTime.ToString("HH:mm dd/MM/yyyy"));

            // Thông tin tài khoản Gmail
            string email = "nhanhelpxx@gmail.com";
            string password = "xxts wmgb aeoe favp";

            // Tạo đối tượng MailMessage
            MailMessage message = new MailMessage();
            message.From = new MailAddress(email);
            message.To.Add(ticket.Email);
            message.Subject = "[AIRLINEVN] MUA VÉ THÀNH CÔNG ";

            // Tạo ngẫu nhiên
            message.Body = HTML;
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
            }
            catch (Exception ex)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }
    }
}
