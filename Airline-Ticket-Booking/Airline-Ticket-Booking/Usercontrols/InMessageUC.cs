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
    public partial class InMessageUC : UserControl
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

        public InMessageUC()
        {
            InitializeComponent();
        }

        public void render()
        {
            lbText.Text = message.Text;
            lbText.Left = this.Width - lbText.Width - (this.Width - pibAvatar.Left) - 5;

            this.Height = pibAvatar.Height + pibAvatar.Top * 2;

            if (lbText.Height + lbText.Top + pibAvatar.Top >= this.Height)
                this.Height = lbText.Height + lbText.Top + pibAvatar.Top;
            else 
                lbText.Top = pibAvatar.Top + (pibAvatar.Height - lbText.Height) / 2;
        }
    }
}
