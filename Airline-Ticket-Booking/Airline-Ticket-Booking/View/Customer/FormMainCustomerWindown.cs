using Airline_Ticket_Booking.AControls;
using Airline_Ticket_Booking.DALs;
using Airline_Ticket_Booking.DTOs;
using Airline_Ticket_Booking.Model;
using Airline_Ticket_Booking.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations.Builders;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Ticket_Booking
{
    public partial class FormMainCustomerWindown : Form
    {
        private AButton currentButton = null;
        private AccountDTO _customer = new AccountDTO();
        public AccountDTO customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

        public FormMainCustomerWindown()
        {
            InitializeComponent();
        }

        #region Event form
        private void FormMainCustomerWindown_Load(object sender, EventArgs e)
        {
            _ = ParametersDAL.Ins.getParameters();

            currentButton = abtnFlight;
            loadBody(new FlightCustomerUC());
        }
        #endregion

        #region Top
        private void pibClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Menu
        private void loadBody(UserControl uc)
        {
            pnMain.Controls.Clear();
            pnMain.Controls.Add(uc);
        }

        public void addBody(UserControl uc)
        {
            pnMain.Controls.Add(uc);
            uc.BringToFront();
        }

        public void removeBody(UserControl uc)
        {
            pnMain.Controls.Remove(uc);
        }

        private void doActiveButton(AButton abtn)
        {
            abtn.BackColor = BaseColor.XanhDam1;
            abtn.ForeColor = Color.White;

            switch (abtn.Name)
            {
                case "abtnFlight":
                    abtn.Image = Properties.Resources.flightActive1;
                    break;

                case "abtnTicket":
                    abtn.Image = Properties.Resources.ticketActive;
                    break;

                case "abtnContact":
                    abtn.Image = Properties.Resources.ContactActive;
                    break;

                case "abtnAccount":
                    abtn.Image = Properties.Resources.accountActive;
                    break;
            }
        }

        private void doDeactiveButton(AButton abtn)
        {
            abtn.BackColor = Color.Transparent;
            abtn.ForeColor = BaseColor.Xam1;

            switch (abtn.Name)
            {
                case "abtnFlight":
                    abtn.Image = Properties.Resources.flightDeactive;
                    break;

                case "abtnTicket":
                    abtn.Image = Properties.Resources.ticketDeactive;
                    break;

                case "abtnContact":
                    abtn.Image = Properties.Resources.contactDeactive;
                    break;

                case "abtnAccount":
                    abtn.Image = Properties.Resources.accountDeactive;
                    break;
            }
        }


        public void abtnFlight_Click(object sender, EventArgs e)
        {
            if (currentButton != null) doDeactiveButton(currentButton);
            doActiveButton(abtnFlight);

            loadBody(new FlightCustomerUC());
        }

        private void abtnTicket_Click(object sender, EventArgs e)
        {
            AButton abtnChoose = sender as AButton;

            if (abtnChoose != currentButton)
            {
                if (currentButton != null) doDeactiveButton(currentButton);
                doActiveButton(abtnChoose);
                currentButton = abtnChoose;

                //loadBody(new HomeUC());
            }
        }

        private void abtnContact_Click(object sender, EventArgs e)
        {
            AButton abtnChoose = sender as AButton;

            if (abtnChoose != currentButton)
            {
                if (currentButton != null) doDeactiveButton(currentButton);
                doActiveButton(abtnChoose);
                currentButton = abtnChoose;

                loadBody(new ContactCustomerUC());
            }
        }

        private void abtnAccount_Click(object sender, EventArgs e)
        {
            AButton abtnChoose = sender as AButton;

            if (abtnChoose != currentButton)
            {
                if (currentButton != null) doDeactiveButton(currentButton);
                doActiveButton(abtnChoose);
                currentButton = abtnChoose;

                loadBody(new AccountUC());
            }
        }
        #endregion
    }
}
