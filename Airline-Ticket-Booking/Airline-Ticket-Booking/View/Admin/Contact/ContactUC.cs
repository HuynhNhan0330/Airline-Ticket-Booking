using Airline_Ticket_Booking.AControls;
using Airline_Ticket_Booking.DALs;
using Airline_Ticket_Booking.DTOs;
using Airline_Ticket_Booking.Usercontrols;
using Airline_Ticket_Booking.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Ticket_Booking
{
    public partial class ContactUC : UserControl
    {
        private List<ContactDTO> _contacts;
        private List<ContactDTO> contacts;

        public ContactUC()
        {
            InitializeComponent();
        }

        private void ContactUC_Load(object sender, EventArgs e)
        {
            loadData();

            chatUC1.color = BaseColor.XanhDam;
        }

        private void loadPanelContact()
        {
            flpnListContact.Controls.Clear();

            foreach (ContactDTO contact in contacts)
            {
                ContactItemUC uc = new ContactItemUC();
                uc.contact = contact;

                flpnListContact.Controls.Add(uc);
            }
        }

        private async void loadData()
        {
            (bool isGet, List<ContactDTO> contacts, string label) = await ContactDAL.Ins.getContact();

            if (isGet)
            {
                _contacts = new List<ContactDTO>(contacts.OrderByDescending(c => c.Created));
                this.contacts = new List<ContactDTO>(_contacts);
                loadPanelContact();
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        public void loadChat(ContactDTO contact)
        {
            chatUC1.Visible = true;
            chatUC1.name = contact.Name;
            chatUC1.customerID = contact.AccountID;
            chatUC1.timeGet = DateTime.Now;
            loadMessage(contact);
        }

        private async void loadMessage(ContactDTO contact)
        {
            (bool isGet, List<MessageDTO> messages, string label) = await MessageDAL.Ins.getMessage("AC0001", contact.AccountID);
            
            if (isGet)
            {
                chatUC1.loadMessage(messages, "AC0001");
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        private void abtnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(atxbNameCustomer.Texts.Trim()))
                return;

            contacts.Clear();

            foreach (ContactDTO contact in _contacts)
            {
                if (contact.Name.Contains(atxbNameCustomer.Texts.Trim())) 
                    contacts.Add(contact);
            }

            loadPanelContact();
        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }
    }
}
