using Airline_Ticket_Booking.AControls;
using Airline_Ticket_Booking.DTOs;
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

namespace Airline_Ticket_Booking.Usercontrols
{
    public partial class FlightMobileItemUC : UserControl
    {
        private FlightDTO _flight;
        public FlightDTO flight
        {
            get { return _flight; }
            set
            {
                _flight = value;
                render();
            }
        }

        public FlightMobileItemUC()
        {
            InitializeComponent();
        }

        private void render()
        {
            lbDeparture.Text = "Địa điểm đi: " + flight.DepartureCityName;
            lbArrival.Text = "Địa điểm đến: " + flight.ArrivalCityName;
            lbTime.Text = flight.DepartureDateTime.ToString("HH:mm dd/MM/yyyy");
            lbPrice.Text = Helper.FormatVNMoney(flight.TicketPrice);

            lbPrice.Top = 10;
            lbArrival.Top = lbDeparture.Top + lbDeparture.Height + 10;
            lbTime.Top = lbArrival.Top + lbArrival.Height + 10;
            lbPrice.Top = lbTime.Top;

            this.Height = lbTime.Top + lbPrice.Height + 10 + pnLine.Height;

            lbPrice.Left = this.Width - lbPrice.Width - 30;
        }

        private void FlightMobileItemUC_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.AddDays(ParametersDTO.Ins.EarliestBookingTime) <= flight.DepartureDateTime)
            {
                FormMainCustomerWindown formMainCustomerWindown = Application.OpenForms.OfType<FormMainCustomerWindown>().FirstOrDefault();
                formMainCustomerWindown.addBody(new BookTicketUC(flight));
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Hiện tại đã trễ để đặt vé chuyến bay này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }
    }
}
