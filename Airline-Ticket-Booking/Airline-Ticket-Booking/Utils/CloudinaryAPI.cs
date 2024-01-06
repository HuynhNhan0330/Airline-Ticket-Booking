using CloudinaryDotNet.Actions;
using CloudinaryDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airline_Ticket_Booking.DALs;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace Airline_Ticket_Booking.Utils
{
    public class CloudinaryAPI
    {
        private static CloudinaryAPI _ins;
        public static CloudinaryAPI Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new CloudinaryAPI();
                return _ins;
            }
            private set => _ins = value;
        }

        private static Cloudinary cloudinary;

        static CloudinaryAPI()
        {
            Account account = new Account(
              "dclzpc4gd",
              "673248188376562",
              "YuE5o0-X2csdTsCaUQXt9BCYNMs");

            cloudinary = new Cloudinary(account);
        }

        public static string UploadImageAndGetPublicUrl(string imagePath)
        {
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(imagePath)
            };

            var uploadResult = cloudinary.Upload(uploadParams);

            return uploadResult.SecureUrl.ToString();
        }

        public static string UploadChartImageAndGetPublicUrl(Chart chart)
        {
            //Image image = new Bitmap(chart.Width, chart.Height);
            //chart.DrawToBitmap((Bitmap)image, chart.Bounds);

            // Chuyển đổi Image thành Stream
            MemoryStream ms = new MemoryStream();
            chart.SaveImage(ms, ChartImageFormat.Png);

            //image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            ms.Position = 0; // Đặt lại vị trí của stream

            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription("my_chart.jpg", ms),
                Folder = "Airline"
            };

            var uploadResult = cloudinary.Upload(uploadParams);

            return uploadResult.SecureUrl.ToString();
        }
    }
}
