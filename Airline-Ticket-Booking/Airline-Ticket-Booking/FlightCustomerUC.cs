using Airline_Ticket_Booking.AControls;
using Airline_Ticket_Booking.DALs;
using Airline_Ticket_Booking.DTOs;
using Airline_Ticket_Booking.Usercontrols;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Ticket_Booking
{
    public partial class FlightCustomerUC : UserControl
    {
        private ObservableCollection<FlightDTO> _flights;
        private ObservableCollection<FlightDTO> flights = new ObservableCollection<FlightDTO>();

        public FlightCustomerUC()
        {
            InitializeComponent();
        }

        private void FlightCustomerUC_Load(object sender, EventArgs e)
        {
            loadAirport();
            loadData();
        }

        private async void loadData()
        {
            (bool isGet, List<FlightDTO> flights, string label) = await FlightDAL.Ins.getListFlight();

            _flights = new ObservableCollection<FlightDTO>(flights);
        }

        private void loadPanelFlight()
        {
            foreach (FlightDTO flight in flights)
            {
                FlightMobileItemUC uc = new FlightMobileItemUC();
                pnFlight.Controls.Add(uc);
                uc.flight = flight;
                uc.Dock = DockStyle.Top;
                uc.BringToFront();
            }
        }

        private async void loadAirport()
        {
            (bool isGet, List<AirportDTO> airport, string label) = await AirportDAL.Ins.getListAirport();

            cbDepatureAirport.DisplayMember = "CityName";
            cbDepatureAirport.DataSource = new List<AirportDTO>(airport);

            cbArrivalAirport.DisplayMember = "CityName";
            cbArrivalAirport.DataSource = new List<AirportDTO>(airport);
        }

        private void abtnSearch_Click(object sender, EventArgs e)
        {
            if (cbDepatureAirport.Text == cbArrivalAirport.Text)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Thông tin nơi đi và nơi đến không được trùng nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else
            {
                pnFlight.Controls.Clear();
                flights.Clear();

                foreach (FlightDTO flight in _flights)
                {
                    if (flight.DepartureCityName == cbDepatureAirport.Text && flight.ArrivalCityName == cbArrivalAirport.Text && flight.DepartureDateTime.Date == adtpTime.Value.Date)
                        flights.Add(flight);
                }

                loadPanelFlight();
            }
        }
    }
}
