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

namespace Airline_Ticket_Booking
{
    public partial class FlightTicketUC : UserControl
    {
        private AButton currentAbtn = null;

        public FlightTicketUC()
        {
            InitializeComponent();
            loadBody(new CreateFlightTicketUC());
            currentAbtn = abtnCreateFlightTicket;
        }

        public FlightTicketUC(FlightDTO flight)
        {
            InitializeComponent();
            loadBody(new CreateFlightTicketUC(flight));
            currentAbtn = abtnCreateFlightTicket;
        }

        private void loadBody(UserControl uc)
        {
            pnBodyFlightTicket.Controls.Clear();
            pnBodyFlightTicket.Controls.Add(uc);
        }

        private void doActivateAbtn(AButton abtn)
        {
            abtn.BackgroundColor = BaseColor.XanhDam;
            abtn.ForeColor = Color.White;
        }

        private void doDeactivateAbtn(AButton abtn)
        {
            abtn.BackgroundColor = Color.Transparent;
            abtn.ForeColor = BaseColor.XanhDam;
        }

        public void abtnCreateFlightTicket_Click(object sender, EventArgs e)
        {
            //if (currentAbtn != abtnCreateFlightTicket)
            {
                if (currentAbtn != null)
                {
                    doDeactivateAbtn(currentAbtn);
                }

                currentAbtn = abtnCreateFlightTicket;
                doActivateAbtn(currentAbtn);
                loadBody(new CreateFlightTicketUC());
            }
        }

        private void abtnSearch_Click(object sender, EventArgs e)
        {
            if (currentAbtn != abtnSearch)
            {
                if (currentAbtn != null)
                {
                    doDeactivateAbtn(currentAbtn);
                }

                currentAbtn = abtnSearch;
                doActivateAbtn(currentAbtn);
                loadBody(new SearchFlightTicketUC());
            }
        }
    }
}
