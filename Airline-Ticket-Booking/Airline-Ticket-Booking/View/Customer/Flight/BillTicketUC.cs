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

namespace Airline_Ticket_Booking
{
    public partial class BillTicketUC : UserControl
    {
        public BillTicketUC()
        {
            InitializeComponent();
        }

        public BillTicketUC(FlightDTO flight)
        {
            InitializeComponent();

            lbName.Text = Helper.getAccountCustomer().Name;
            lbDep.Text = flight.DepartureCityName;
            lbAr.Text = flight.ArrivalCityName;
            lbTime.Text = flight.DepartureDateTime.ToString("HH:mm dd/MM/yyyy");

            lbName.Left = this.Width - lbName.Width - 25;
            lbDep.Left = this.Width - lbDep.Width - 25;
            lbAr.Left = this.Width - lbAr.Width - 25;
            lbTime.Left = this.Width - lbTime.Width - 25;
        }

        private void pibHome_Click(object sender, EventArgs e)
        {
            FormMainCustomerWindown form = Application.OpenForms.OfType<FormMainCustomerWindown>().FirstOrDefault();
            form.abtnFlight_Click(sender, e);
        }
    }
}
