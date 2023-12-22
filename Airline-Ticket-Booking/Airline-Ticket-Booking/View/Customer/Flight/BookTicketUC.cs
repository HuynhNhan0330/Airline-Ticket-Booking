using Airline_Ticket_Booking.AControls;
using Airline_Ticket_Booking.DALs;
using Airline_Ticket_Booking.DTOs;
using Airline_Ticket_Booking.Model;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Airline_Ticket_Booking
{
    public partial class BookTicketUC : UserControl
    {
        private FlightDTO flight;
        private TicketDTO ticket = new TicketDTO();

        public BookTicketUC()
        {
            InitializeComponent();
        }

        public BookTicketUC(FlightDTO flight)
        {
            InitializeComponent();
            this.flight = flight;

            lbFlightID.Text = flight.FlightID;
            ticket.FlightID = flight.FlightID;
            lbDeparture.Text = "Địa điểm đi: " + flight.DepartureCityName;
            lbArrival.Text = "Địa điểm đến: " + flight.ArrivalCityName;
            lbTime.Text = flight.DepartureDateTime.ToString("HH:mm dd/MM/yyyy");


            loadDataTicketClass();
        }

        private void pibReturn_Click(object sender, EventArgs e)
        {
            FormMainCustomerWindown formMainCustomerWindown = Application.OpenForms.OfType<FormMainCustomerWindown>().FirstOrDefault();
            formMainCustomerWindown.removeBody(this);
        }

        private void BookTicketUC_Load(object sender, EventArgs e)
        {
            AccountDTO account = Helper.getAccountCustomer();

            lbName.Text = account.Name;
            lbEmail.Text = account.Email;
            lbPhone.Text = account.Phone;
            lbCash.Text = Helper.FormatVNMoney(account.Cash);

            ticket.PhoneNumber = account.Phone;
            ticket.FullName = account.Name;
            ticket.Email = account.Email;
        }

        private void abtnNext_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(atxbIDCard.Texts.Trim())) 
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Không được để trống CMND/CCCD", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (Helper.checkCardID(atxbIDCard.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("CMND/CCCD không phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else
            {
                TicketClassDTO ticketClass = cbTicketClass.SelectedItem as TicketClassDTO;
                ticket.TicketClassID = ticketClass.TicketClassID;
                ticket.IDCard = atxbIDCard.Texts.Trim();

                FormMainCustomerWindown formMainCustomerWindown = Application.OpenForms.OfType<FormMainCustomerWindown>().FirstOrDefault();
                formMainCustomerWindown.addBody(new BookTicketUC1(flight, ticketClass, ticket));
            }
        }

        private async void loadDataTicketClass()
        {
            (bool isGet, List<TicketClassDTO> TicketClass, string label) = await TicketClassDAL.Ins.getListTicketClass();

            cbTicketClass.DataSource = TicketClass;
            cbTicketClass.DisplayMember = "TicketClassName";
        }
    }
}
