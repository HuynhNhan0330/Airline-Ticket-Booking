using Airline_Ticket_Booking.AControls;
using Airline_Ticket_Booking.DALs;
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
    public partial class ContactCustomerUC : UserControl
    {
        public ContactCustomerUC()
        {
            InitializeComponent();
        }

        private void ContactCustomerUC_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private async void loadData()
        {
            chatUC1.type = 1;

            (bool isGet, List<MessageDTO> messages, string label) = await MessageDAL.Ins.getMessage(Helper.getAccountCustomer().AccountID , "AC0001");
            if (isGet)
            {
                chatUC1.loadMessage(messages, Helper.getAccountCustomer().AccountID);
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }
    }
}
