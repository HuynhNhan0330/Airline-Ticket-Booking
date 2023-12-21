using Airline_Ticket_Booking.DTOs;
using Airline_Ticket_Booking.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Ticket_Booking.DALs
{
    public class ContactDAL
    {
        private static ContactDAL _ins;
        public static ContactDAL Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new ContactDAL();
                return _ins;
            }
            private set => _ins = value;
        }

        public async Task<(bool, List<ContactDTO>, string)> getContact()
        {
            try
            {
                using (var context = new AirlineTicketBookingEntities())
                {
                    var contactList = (from ac in context.ACCOUNTs
                                       join permission in context.PERMISSIONs
                                       on ac.RoleID equals permission.RoleID
                                       where permission.RoleName == "Khách hàng"
                                       join message in context.MESSAGEs
                                       on ac.AccountID equals message.TexterID
                                       group message by new { message.TexterID, ac.Name} into g
                                       select new ContactDTO
                                       {
                                            AccountID = g.Key.TexterID,
                                            Name = g.Key.Name,
                                            Created = (DateTime)g.Max(m => m.Created)
                                       }).ToListAsync();

                    return (true, await contactList, "Lấy danh sách liên hệ thành công!");
                }
            }
            catch (Exception ex)
            {
                return (false, null, ex.Message);
            }
        }
    }
}
