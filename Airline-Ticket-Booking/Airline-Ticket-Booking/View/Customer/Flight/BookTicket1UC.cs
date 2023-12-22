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
using System.Reflection.Emit;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Airline_Ticket_Booking
{
    public partial class BookTicketUC1 : UserControl
    {
        private FlightDTO flight;
        private TicketClassDTO ticketClass;
        private TicketDTO ticket;
        public string CurrentSeatID = null;

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
            else
            {
                ticket.SeatID = CurrentSeatID;
                ticket.accountID = Helper.getAccountCustomer().AccountID;
                CreateTicket(ticket);
            }
        }

        private async void CreateTicket(TicketDTO ticket)
        {
            (bool isCreate, string label) = await TicketDAL.Ins.createTicket(ticket);

            if (isCreate)
            {
                FormMainCustomerWindown form = Application.OpenForms.OfType<FormMainCustomerWindown>().FirstOrDefault();
                form.addBody(new BillTicketUC(flight));
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }
    }
}
