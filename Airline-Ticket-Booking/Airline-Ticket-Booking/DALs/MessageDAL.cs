using Airline_Ticket_Booking.DTOs;
using Airline_Ticket_Booking.Model;
using Airline_Ticket_Booking.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Ticket_Booking.DALs
{
    public class MessageDAL
    {
        private static MessageDAL _ins;
        public static MessageDAL Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new MessageDAL();
                return _ins;
            }
            private set => _ins = value;
        }

        public async Task<(bool, List<MessageDTO>, string)> getMessage(string texterID, string recipientID)
        {
            try
            {
                using (var context = new AirlineTicketBookingEntities())
                {
                    var messList = (from messgae in context.MESSAGEs
                                    where (messgae.TexterID == texterID && recipientID == messgae.RecipientID) ||
                                    (messgae.TexterID == recipientID && messgae.RecipientID == texterID)
                                       select new MessageDTO
                                       {
                                           TexterID = messgae.TexterID,
                                           RecipientID = messgae.RecipientID,
                                           Text = messgae.Text,
                                           MessageID = messgae.MessageID,
                                           Created = (DateTime)messgae.Created
                                       }).ToListAsync();

                    return (true, await messList, "Lấy danh sách tin nhắn thành công!");
                }
            }
            catch (Exception ex)
            {
                return (false, null, ex.Message);
            }
        }

        public async Task<(bool, string)> createMessage(MessageDTO message)
        {
            try
            {
                using (var context = new AirlineTicketBookingEntities())
                {
                    string currentMaxCode = await context.MESSAGEs.MaxAsync(mess => mess.MessageID);
                    string newCode = Helper.nextCode(currentMaxCode, "MS");

                    MESSAGE newMessage= new MESSAGE
                    {
                        MessageID = newCode,
                        TexterID = message.TexterID,
                        RecipientID = message.RecipientID,
                        Text = message.Text,
                        Created = message.Created
                    };

                    context.MESSAGEs.Add(newMessage);

                    context.SaveChanges();

                    return (true, "Gửi tin nhắn thành công");
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}
