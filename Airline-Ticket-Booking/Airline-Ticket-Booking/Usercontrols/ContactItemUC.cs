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
    public partial class ContactItemUC : UserControl
    {
        private ContactDTO _contact;
        public ContactDTO contact
        {
            get { return _contact; }
            set
            {
                _contact = value;
                render();
            }
        }

        public ContactItemUC()
        {
            InitializeComponent();
        }

        public void render()
        {
            lbText.Text = contact.Name;
            lbTime.Text = contact.Created.ToString("HH:mm dd/MM/yyyy");

            lbTime.Top = lbText.Top + lbText.Height + 10;
            lbTime.Left = this.Width - 15 - lbTime.Width;
            
            this.Height = lbTime.Height + lbTime.Top + 10;
        }

        private void ContactItemUC_Load(object sender, EventArgs e)
        {

        }

        private void ContactItemUC_Click(object sender, EventArgs e)
        {
            Control ctr = this;

            while (!(ctr is ContactUC))
            {
                ctr = ctr.Parent;
            }

            ContactUC uc = ctr as ContactUC;
            uc.loadChat(contact);
        }
    }
}
