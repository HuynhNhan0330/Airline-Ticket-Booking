using Airline_Ticket_Booking.DALs;
using Airline_Ticket_Booking.DTOs;
using Airline_Ticket_Booking.Utils;
using MiniExcelLibs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Ticket_Booking
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test();
        }

        private async void test()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx;*.xlsm";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string PATH_TEMPLATE = @"../../Excel/TemplateReportByMonth.xlsx";
                string PATH_EXPORT = saveFileDialog.FileName;

                var value = new
                {
                    reportType = "Báo cáo năm",
                    reportTime = DateTime.Now.ToString("dd/MM/yyyy"),
                    nameUser = "Huỳnh Mai Cao Nhân"
                };

                MiniExcel.SaveAsByTemplate(PATH_EXPORT, PATH_TEMPLATE, value);

                Process.Start(PATH_EXPORT);
            }
        }
    }
}
