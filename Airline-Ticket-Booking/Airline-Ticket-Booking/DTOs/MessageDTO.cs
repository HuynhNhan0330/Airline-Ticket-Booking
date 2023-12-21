using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Ticket_Booking.DTOs
{
    public class MessageDTO
    {
        public string MessageID { get; set; }
        public string TexterID { get; set; }
        public string RecipientID { get; set; }
        public string Text { get; set; }

        public DateTime Created { get; set; }
    }
}
