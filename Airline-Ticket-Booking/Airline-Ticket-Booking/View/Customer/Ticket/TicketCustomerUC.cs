using Airline_Ticket_Booking.AControls;
using Airline_Ticket_Booking.DALs;
using Airline_Ticket_Booking.DTOs;
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

namespace Airline_Ticket_Booking
{
    public partial class TicketCustomerUC : UserControl
    {
        private List<TicketDTO> tickets = new List<TicketDTO>();

        public TicketCustomerUC()
        {
            InitializeComponent();
            loadData();
        }

        public async void loadData()
        {
            (bool isGet, List<TicketDTO> tickets, string label) = await TicketDAL.Ins.getListTicketByAccount(Helper.getAccountCustomer().AccountID);

            if (isGet)
            {
                this.tickets = new List<TicketDTO>(tickets);
                loadPanelTicket();
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        public void loadPanelTicket()
        {
            foreach (TicketDTO ticket in tickets)
            {
                TicketItemMobileUC uc = new TicketItemMobileUC();
                uc.ticket = ticket;

                pnListTicket.Controls.Add(uc);
                uc.Dock = DockStyle.Top;
                uc.SendToBack();
            }
        }

        public void cancelTicket(Control uc)
        {
            pnListTicket.Controls.Remove(uc);
        }
    }
}
