using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Ticket_Booking.DTOs
{
    public class PlaneTicketClassDetailDTO
    {
        public string PlaneID { get; set; }
        public TicketClassDTO TicketClass { get; set; }
        public int Quantity { get; set; }    
    }
}
