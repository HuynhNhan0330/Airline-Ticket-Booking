using Airline_Ticket_Booking.AControls;
using Airline_Ticket_Booking.DALs;
using Airline_Ticket_Booking.DTOs;
using Airline_Ticket_Booking.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Ticket_Booking.Usercontrols
{
    public partial class SeatMobilieItemUC : UserControl
    {
        private string _stt;
        public string stt
        {
            set
            { 
                _stt = value; 
                lbSTT.Text = stt;
            }
            get { return _stt; }
        }

        public List<SeatDTO> seats = new List<SeatDTO>();

        public SeatMobilieItemUC()
        {
            InitializeComponent();
        }

        public async void loadTicketColor(string flightID, string ticketClassID)
        {
            for (int i = 1; i <= 6; ++i)
            {
                bool isCheck = await TicketDAL.Ins.checkSeat(flightID, this.stt + i.ToString());

                if (isCheck)
                {
                    if (seats[i - 1].TicketClass.TicketClassID == "TC0001")
                        switch (i)
                        {
                            case 1:
                                pib1.Image = Properties.Resources.SeatUniversalRed;
                                break;
                            case 2:
                                pib2.Image = Properties.Resources.SeatUniversalRed;
                                break;
                            case 3:
                                pib3.Image = Properties.Resources.SeatUniversalRed;
                                break;
                            case 4:
                                pib4.Image = Properties.Resources.SeatUniversalRed;
                                break;
                            case 5:
                                pib5.Image = Properties.Resources.SeatUniversalRed;
                                break;
                            case 6:
                                pib6.Image = Properties.Resources.SeatUniversalRed;
                                break;
                        }

                    if (seats[i - 1].TicketClass.TicketClassID == "TC0002")
                        switch (i)
                        {
                            case 1:
                                pib1.Image = Properties.Resources.SeatTraderRed;
                                break;
                            case 2:
                                pib2.Image = Properties.Resources.SeatTraderRed;
                                break;
                            case 3:
                                pib3.Image = Properties.Resources.SeatTraderRed;
                                break;
                            case 4:
                                pib4.Image = Properties.Resources.SeatTraderRed;
                                break;
                            case 5:
                                pib5.Image = Properties.Resources.SeatTraderRed;
                                break;
                            case 6:
                                pib6.Image = Properties.Resources.SeatTraderRed;
                                break;
                        }
                }
                else
                {
                    if (seats[i - 1].TicketClass.TicketClassID == "TC0001")
                        if (seats[i - 1].TicketClass.TicketClassID == ticketClassID)
                        {
                            switch (i)
                            {
                                case 1:
                                    pib1.Image = Properties.Resources.SeatUniversalGreen;
                                    break;
                                case 2:
                                    pib2.Image = Properties.Resources.SeatUniversalGreen;
                                    break;
                                case 3:
                                    pib3.Image = Properties.Resources.SeatUniversalGreen;
                                    break;
                                case 4:
                                    pib4.Image = Properties.Resources.SeatUniversalGreen;
                                    break;
                                case 5:
                                    pib5.Image = Properties.Resources.SeatUniversalGreen;
                                    break;
                                case 6:
                                    pib6.Image = Properties.Resources.SeatUniversalGreen;
                                    break;
                            }
                        }
                        else
                            switch (i)
                            {
                                case 1:
                                    pib1.Image = Properties.Resources.SeatUniversal;
                                    break;
                                case 2:
                                    pib2.Image = Properties.Resources.SeatUniversal;
                                    break;
                                case 3:
                                    pib3.Image = Properties.Resources.SeatUniversal;
                                    break;
                                case 4:
                                    pib4.Image = Properties.Resources.SeatUniversal;
                                    break;
                                case 5:
                                    pib5.Image = Properties.Resources.SeatUniversal;
                                    break;
                                case 6:
                                    pib6.Image = Properties.Resources.SeatUniversal;
                                    break;
                            }

                    if (seats[i - 1].TicketClass.TicketClassID == "TC0002")
                        if (seats[i - 1].TicketClass.TicketClassID == ticketClassID)
                        {
                            switch (i)
                            {
                                case 1:
                                    pib1.Image = Properties.Resources.SeatTraderGreen;
                                    break;
                                case 2:
                                    pib2.Image = Properties.Resources.SeatTraderGreen;
                                    break;
                                case 3:
                                    pib3.Image = Properties.Resources.SeatTraderGreen;
                                    break;
                                case 4:
                                    pib4.Image = Properties.Resources.SeatTraderGreen;
                                    break;
                                case 5:
                                    pib5.Image = Properties.Resources.SeatTraderGreen;
                                    break;
                                case 6:
                                    pib6.Image = Properties.Resources.SeatTraderGreen;
                                    break;
                            }
                        }
                        else
                            switch (i)
                            {
                                case 1:
                                    pib1.Image = Properties.Resources.SeatTrader;
                                    break;
                                case 2:
                                    pib2.Image = Properties.Resources.SeatTrader;
                                    break;
                                case 3:
                                    pib3.Image = Properties.Resources.SeatTrader;
                                    break;
                                case 4:
                                    pib4.Image = Properties.Resources.SeatTrader;
                                    break;
                                case 5:
                                    pib5.Image = Properties.Resources.SeatTrader;
                                    break;
                                case 6:
                                    pib6.Image = Properties.Resources.SeatTrader;
                                    break;
                            }
                }
            }
        }

        private void bookSeat(object sender, EventArgs e)
        {
            PictureBox pib = sender as PictureBox;

            Control ctr = this.Parent;
            while (!(ctr is BookTicketUC1))
                ctr = ctr.Parent;

            BookTicketUC1 ctrParent = ctr as BookTicketUC1;

            if (Helper.AreImagesEqual(pib.Image, Properties.Resources.SeatTraderGreen) || Helper.AreImagesEqual(pib.Image, Properties.Resources.SeatUniversalGreen))
            {
                // Xoá ghế đã chọn hiện tại
                if (!string.IsNullOrEmpty(ctrParent.CurrentSeatID))
                    ctrParent.deleteSeatSelected();

                int stt = int.Parse(pib.Name.Substring(3));

                if (seats[stt - 1].TicketClass.TicketClassID == "TC0002")
                    pib.Image = Properties.Resources.SeatTraderBlue;
                else
                    pib.Image = Properties.Resources.SeatUniversalBlue;

                // Lưu mã ghế
                ctrParent.CurrentSeatID = this.stt + stt.ToString();
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Chọn ghế không phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        public void clearColor(char id)
        {
            switch (id)
            {
                case '1':
                    if (seats[0].TicketClass.TicketClassID == "TC0001")
                        pib1.Image = Properties.Resources.SeatUniversalGreen;
                    else
                        pib1.Image = Properties.Resources.SeatTraderGreen;
                    break;

                case '2':
                    if (seats[1].TicketClass.TicketClassID == "TC0001")
                        pib2.Image = Properties.Resources.SeatUniversalGreen;
                    else
                        pib2.Image = Properties.Resources.SeatTraderGreen;
                    break;

                case '3':
                    if (seats[2].TicketClass.TicketClassID == "TC0001")
                        pib3.Image = Properties.Resources.SeatUniversalGreen;
                    else
                        pib3.Image = Properties.Resources.SeatTraderGreen;
                    break;

                case '4':
                    if (seats[3].TicketClass.TicketClassID == "TC0001")
                        pib4.Image = Properties.Resources.SeatUniversalGreen;
                    else
                        pib4.Image = Properties.Resources.SeatTraderGreen;
                    break;

                case '5':
                    if (seats[4].TicketClass.TicketClassID == "TC0001")
                        pib5.Image = Properties.Resources.SeatUniversalGreen;
                    else
                        pib5.Image = Properties.Resources.SeatTraderGreen;
                    break;

                case '6':
                    if (seats[5].TicketClass.TicketClassID == "TC0001")
                        pib6.Image = Properties.Resources.SeatUniversalGreen;
                    else
                        pib6.Image = Properties.Resources.SeatTraderGreen;
                    break;
            }
        }
    }
}
