using Airline_Ticket_Booking.DTOs;
using Airline_Ticket_Booking.Model;
using Airline_Ticket_Booking.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Ticket_Booking.DALs
{
    public class SeatDAL
    {
        private static SeatDAL _ins;
        public static SeatDAL Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new SeatDAL();
                return _ins;
            }
            private set => _ins = value;
        }

        public async Task<(bool, string)> createSeats(List<SeatDTO> seats, string planeID)
        {
            try
            {
                using (var context = new AirlineTicketBookingEntities())
                {
                    var seatList= (from s in seats
                                   select new SEAT
                                   {
                                       SeatID = s.SeatID,
                                       PlaneID = planeID,
                                       TicketClassID = s.TicketClass.TicketClassID
                                   }).ToList();

                    context.SEATs.AddRange(seatList);
                    context.SaveChanges();

                    return (true, "Thêm ghế thành công!");
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task<(bool, List<SeatDTO>, string)> getSeats(PlaneDTO plane)
        {
            try
            {
                using (var context = new AirlineTicketBookingEntities())
                {
                    var SeatList = (from seat in context.SEATs
                                    join ticketClass in context.TICKET_CLASS 
                                    on seat.TicketClassID equals ticketClass.TicketClassID
                                    where seat.PlaneID == plane.PlaneID
                                     select new SeatDTO
                                     {
                                         SeatID = seat.SeatID,
                                         PlaneID = seat.PlaneID,
                                         TicketClass = new TicketClassDTO
                                         {
                                             TicketClassID = ticketClass.TicketClassID,
                                             TicketClassName = ticketClass.TicketClassName,
                                             PricePercentage = ticketClass.PricePercentage
                                         }
                                     }).ToListAsync();

                    return (true, await SeatList, "Lấy danh sách ghế thành công!");
                }
            }
            catch (Exception ex)
            {
                return (false, null, ex.Message);
            }
        }

        public async Task<(bool, List<SeatDTO>, string)> getSeats(string planeID)
        {
            try
            {
                using (var context = new AirlineTicketBookingEntities())
                {
                    var SeatList = (from seat in context.SEATs
                                    join ticketClass in context.TICKET_CLASS
                                    on seat.TicketClassID equals ticketClass.TicketClassID
                                    where seat.PlaneID == planeID
                                    select new SeatDTO
                                    {
                                        SeatID = seat.SeatID,
                                        PlaneID = seat.PlaneID,
                                        TicketClass = new TicketClassDTO
                                        {
                                            TicketClassID = ticketClass.TicketClassID,
                                            TicketClassName = ticketClass.TicketClassName,
                                            PricePercentage = ticketClass.PricePercentage
                                        }
                                    }).ToListAsync();

                    return (true, await SeatList, "Lấy danh sách ghế thành công!");
                }
            }
            catch (Exception ex)
            {
                return (false, null, ex.Message);
            }
        }

        public async Task<(bool, string)> deleteSeats(PlaneDTO plane)
        {
            try
            {
                using (var context = new AirlineTicketBookingEntities())
                {
                    var seatsDelete = context.SEATs.Where(s => s.PlaneID == plane.PlaneID);

                    context.SEATs.RemoveRange(seatsDelete);
                    context.SaveChanges();

                    return (true, "Xoá thành công");
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task<(bool, string)> updateSeats(PlaneDTO plane, List<SeatDTO> seats)
        {
            try
            {
                using (var context = new AirlineTicketBookingEntities())
                {
                    // Cập nhật
                    foreach (var seat in seats)
                    {
                        var existingSeat = await context.SEATs.FirstOrDefaultAsync(s => s.SeatID == seat.SeatID && s.PlaneID == plane.PlaneID);
                        if (existingSeat != null)
                        {
                            // Cập nhật thông tin ghế
                            existingSeat.TicketClassID = seat.TicketClass.TicketClassID;
                        }
                        else
                        {
                            // Thêm mới ghế
                            var newSeat = new SEAT
                            {
                                SeatID = seat.SeatID,
                                PlaneID = plane.PlaneID,
                                TicketClassID = seat.TicketClass.TicketClassID
                            };
                            context.SEATs.Add(newSeat);
                        }
                    }

                    // Xoá
                    var seatIds = seats.Select(s => s.SeatID);
                    var seatsToDelete = await context.SEATs.Where(s => s.PlaneID == plane.PlaneID && !seatIds.Contains(s.SeatID)).ToListAsync();
                    context.SEATs.RemoveRange(seatsToDelete);

                    context.SaveChanges();

                    return (true, "Cập nhật thành công");
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}
