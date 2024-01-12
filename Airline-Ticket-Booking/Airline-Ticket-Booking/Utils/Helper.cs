using Airline_Ticket_Booking.AControls;
using Airline_Ticket_Booking.DTOs;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Collections;

namespace Airline_Ticket_Booking.Utils
{
    public class Helper
    {
        public static string FormatVNMoney(decimal money)
        {
            if (money == 0)
            {
                return "0 ₫";
            }
            return String.Format(CultureInfo.InvariantCulture,
                                "{0:#,#} ₫", money);
        }

        public static string nextCode(string code, string key)
        {
            if (code is null)
                return key + "0001";

            string newCodeString = $"000{int.Parse(code.Substring(key.Length)) + 1}";
            return key + newCodeString.Substring(newCodeString.Length - 4, 4);
        }

        public static void enterOnlyNumber(EventArgs e1)
        {
            KeyEventArgs e = e1 as KeyEventArgs;

            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) &&
               !(e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) &&
               e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete)
            {
                // Không phải phím số hoặc phím xóa
                // Hủy bỏ sự kiện KeyDown
                e.SuppressKeyPress = true;
            }
        }
        
        public static void enterOnlyLetter(EventArgs e1)
        {
            KeyEventArgs e = e1 as KeyEventArgs;

            if (!((e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z) || e.KeyCode == Keys.Space ||
            Regex.IsMatch(e.KeyCode.ToString(), @"^[a-zA-ZÀ-ỹà-ỹ\s]+$"))
            && e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete)
            {
                // Không phải chữ cái bình thường hoặc khoảng trắng
                // Hủy bỏ sự kiện KeyDown
                e.SuppressKeyPress = true;
            }
        }

        public static void enterNotSpecialCharacters(EventArgs e1)
        {
            
        }

        public static bool checkPhone(string phone)
        {
            return Regex.IsMatch(phone, @"^0\d{9}$");
        }
        
        public static bool checkEmail(string email)
        {
            return Regex.IsMatch(email, @"^([\w\.-]+)@([\w-]+)((\.(\w){2,3})+)$");
        }

        public static bool checkCardID(string cardID)
        {
            return Regex.IsMatch(cardID, @"^\d{9}$|^\d{12}$");
        }

        public static AccountDTO getAccountAdmin()
        {
            FormAdminHome form = Application.OpenForms.OfType<FormAdminHome>().FirstOrDefault();

            if (form.account != null)
                return form.account;
            else
                return new AccountDTO();
        }

        public static AccountDTO getAccountCustomer()
        {
            FormMainCustomerWindown form = Application.OpenForms.OfType<FormMainCustomerWindown>().FirstOrDefault();

            if (form != null)
                if (form.customer != null)
                    return form.customer;
                else
                    return new AccountDTO();

            return new AccountDTO();
        }

        public static bool AreImagesEqual(Image image1, Image image2)
        {
            if (image1 == null || image2 == null)
            {
                return false;
            }

            // Chuyển đổi hình ảnh thành mảng byte
            byte[] imageBytes1;
            byte[] imageBytes2;

            using (var ms1 = new System.IO.MemoryStream())
            using (var ms2 = new System.IO.MemoryStream())
            {
                image1.Save(ms1, image1.RawFormat);
                image2.Save(ms2, image2.RawFormat);
                imageBytes1 = ms1.ToArray();
                imageBytes2 = ms2.ToArray();
            }

            // So sánh mảng byte của hai hình ảnh
            return StructuralComparisons.StructuralEqualityComparer.Equals(imageBytes1, imageBytes2);
        }

    }
}
