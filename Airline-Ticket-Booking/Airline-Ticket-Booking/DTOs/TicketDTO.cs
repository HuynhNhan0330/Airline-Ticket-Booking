﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Ticket_Booking.DTOs
{
    public class TicketDTO
    {
        public string FlightID {  get; set; }
        public string TicketID { get; set; }
        public string TicketClassID { get; set; }
        public string TicketClassName { get; set; }
        public decimal Price { get; set; }
        public string FullName { get; set; }
        public string IDCard { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string SeatID { get; set; }
        public string FlightStatus { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public string accountID {  get; set; }
        public string DepartureCityName { get; set; }
        public string ArrivalCityName { get; set; }
    }
}
