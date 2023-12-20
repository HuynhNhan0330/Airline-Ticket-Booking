using Airline_Ticket_Booking.AControls;
using Airline_Ticket_Booking.DALs;
using Airline_Ticket_Booking.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Ticket_Booking
{
    public partial class ForgotPassword1 : UserControl
    {
        public ForgotPassword1()
        {
            InitializeComponent();
        }

        private void abtnGetOTP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(atxbEmail.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu email không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else
            {
                getOTP();
            }
        }

        private async void getOTP()
        {
            AccountDTO account = await AccountDAL.Ins.findAccountByEmail(atxbEmail.Texts.Trim());

            if (account == null)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Emnail không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else
            {
                FormLogin currentForm = FindForm() as FormLogin;
                currentForm.sendOTP(atxbEmail.Texts.Trim());
                currentForm.addBody(new ForgotPassword2());
            }
        }

        private void pibReturn_Click(object sender, EventArgs e)
        {
            FormLogin form = Application.OpenForms.OfType<FormLogin>().FirstOrDefault();
            form.removeBody(this);
        }
    }
}
