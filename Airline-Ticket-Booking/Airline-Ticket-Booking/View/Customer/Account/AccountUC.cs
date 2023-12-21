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

namespace Airline_Ticket_Booking
{
    public partial class AccountUC : UserControl
    {
        public AccountUC()
        {
            InitializeComponent();
        }

        private void AccountUC_Load(object sender, EventArgs e)
        {
            AccountDTO account = Helper.getAccountCustomer();

            lbName.Text = account.Name;
            lbEmail.Text = account.Email;
            lbPhone.Text = account.Phone;
            lbCash.Text = Helper.FormatVNMoney(account.Cash);
        }

        private void pibHideViewPassword_Click(object sender, EventArgs e)
        {
            if (atxbPassword.PasswordChar)
            {
                atxbPassword.PasswordChar = false;
                pibHideViewPassword.BackgroundImage = Properties.Resources.hide;
            }
            else
            {
                atxbPassword.PasswordChar = true;
                pibHideViewPassword.BackgroundImage = Properties.Resources.view;
            }
        }

        private void pibHideViewPasswordNew_Click(object sender, EventArgs e)
        {
            if (atxbNewPassword.PasswordChar)
            {
                atxbNewPassword.PasswordChar = false;
                pibHideViewPasswordNew.BackgroundImage = Properties.Resources.hide;
            }
            else
            {
                atxbNewPassword.PasswordChar = true;
                pibHideViewPasswordNew.BackgroundImage = Properties.Resources.view;
            }
        }

        private void pibHideViewRePasswordNew_Click(object sender, EventArgs e)
        {
            if (atxbReNewPassword.PasswordChar)
            {
                atxbReNewPassword.PasswordChar = false;
                pibHideViewRePasswordNew.BackgroundImage = Properties.Resources.hide;
            }
            else
            {
                atxbReNewPassword.PasswordChar = true;
                pibHideViewRePasswordNew.BackgroundImage = Properties.Resources.view;
            }
        }

        private void abtnDone_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(atxbPassword.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Mật khẩu không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbNewPassword.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Mật khẩu mới không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbReNewPassword.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Nhập lại mật khẩu mới không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (atxbPassword.Texts.Trim() != Helper.getAccountCustomer().Password)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Mật khẩu hiện tại không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (atxbNewPassword.Texts.Trim() != atxbReNewPassword.Texts.Trim())
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Mật khẩu nhập lại không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else
            {
                Helper.getAccountCustomer().Password = atxbNewPassword.Texts.Trim();
                changePassword();
            }
        }

        private async void changePassword()
        {
            (bool isUpdate, string label) = await AccountDAL.Ins.updateAccount(Helper.getAccountCustomer());

            if (isUpdate)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ms.ShowDialog();
            }
            else
            {
                Helper.getAccountCustomer().Password = atxbPassword.Texts.Trim();

                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }

        }
    }
}
