using Airline_Ticket_Booking.AControls;
using Airline_Ticket_Booking.DALs;
using Airline_Ticket_Booking.DTOs;
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
    public partial class TicketItemMobileUC : UserControl
    {
        private TicketDTO _ticket;
        public TicketDTO ticket
        {
            get { return _ticket; } 
            set
            {
                _ticket = value;
                render();
            }
        }

        public TicketItemMobileUC()
        {
            InitializeComponent();
        }

        public void render()
        {
            lbInfo.Text = "Từ " + ticket.DepartureCityName + " đến " + ticket.ArrivalCityName;
            lbType.Text = ticket.TicketClassName;
            lbTime.Text = ticket.DepartureDateTime.ToString("HH:mm dd/MM/yyyy");
        }

        private void pibCancel_Click(object sender, EventArgs e)
        {
            AMessageBoxFrm ms = new AMessageBoxFrm("Xác nhận huỷ vé", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ms.ShowDialog() == DialogResult.Yes)
            {
                if (DateTime.Now.AddDays(ParametersDTO.Ins.LatestBookingCancellationTime) <= ticket.DepartureDateTime)
                {
                    cancelTicket();
                }
                else
                {
                    AMessageBoxFrm ms1 = new AMessageBoxFrm("Hiện tại đã trễ để huỷ vé chuyến bay này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ms1.ShowDialog();
                }
            }
        }

        private async void cancelTicket()
        {
            (bool isCancel, string label) = await TicketDAL.Ins.cancelTicket(ticket);

            if (isCancel)
            {
                Control ctr = this;

                while (!(ctr is TicketCustomerUC))
                    ctr = ctr.Parent;

                TicketCustomerUC uc = ctr as TicketCustomerUC;
                uc.cancelTicket(this);

                FlightTicketClassDetailDAL.Ins.updateFlightTicketClassDetail(ticket.FlightID, ticket.TicketClassID, 1);

                AMessageBoxFrm ms = new AMessageBoxFrm("Huỷ vé thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ms.ShowDialog();
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }
    }
}
