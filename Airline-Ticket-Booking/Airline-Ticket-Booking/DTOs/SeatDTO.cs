using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Ticket_Booking.DTOs
{
    public class SeatDTO
    {
        public string SeatID { get; set; }
        public string PlaneID { get; set; }
        public TicketClassDTO TicketClass { get; set; }
        public bool isHave { get; set; }
    }
}
