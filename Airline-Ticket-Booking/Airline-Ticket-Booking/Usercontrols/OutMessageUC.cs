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
    public partial class OutMessageUC : UserControl
    {
        private MessageDTO _message;
        public MessageDTO message
        {
            get { return _message; }
            set
            {
                _message = value;
                render();
            }
        }

        public OutMessageUC()
        {
            InitializeComponent();
        }

        public void render()
        {
            lbText.Text = message.Text;

            this.Height = pibAvatar.Height + pibAvatar.Top * 2;

            if (lbText.Height + lbText.Top + pibAvatar.Top >= this.Height)
                this.Height = lbText.Height + lbText.Top + pibAvatar.Top;
            else
                lbText.Top = pibAvatar.Top + (pibAvatar.Height - lbText.Height) / 2;
        }
    }
}
