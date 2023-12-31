﻿using Airline_Ticket_Booking.AControls;
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
    public partial class RegisterUC : UserControl
    {
        public RegisterUC()
        {
            InitializeComponent();
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            FormLogin currentForm = FindForm() as FormLogin;
            currentForm.loadBody(new LoginUC());
        }

        private void pibHideViewPassword_Click(object sender, EventArgs e)
        {
            if(atxbPassword.PasswordChar)
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

        private void pibHideViewRePassword_Click(object sender, EventArgs e)
        {
            if (atxbRePassword.PasswordChar)
            {
                atxbRePassword.PasswordChar = false;
                pibHideViewRePassword.BackgroundImage = Properties.Resources.hide;
            }
            else
            {
                atxbRePassword.PasswordChar = true;
                pibHideViewRePassword.BackgroundImage = Properties.Resources.view;
            }
        }

        private void abtnRegsiter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(atxbName.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Tên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbEmail.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Email không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbPhone.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Số điện thoại không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbPassword.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbRePassword.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Mật khẩu nhập lại không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (atxbPassword.Texts.Trim() != atxbRePassword.Texts.Trim())
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Mật khẩu nhập lại không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (!Helper.checkEmail(atxbEmail.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Email chưa đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (!Helper.checkPhone(atxbPhone.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Số điện thoại chưa đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else
            {
                AccountDTO account = new AccountDTO();
                account.Name = atxbName.Texts.Trim();
                account.Email = atxbEmail.Texts.Trim();
                account.Phone = atxbPhone.Texts.Trim();
                account.Password = atxbPassword.Texts.Trim();
                account.RoleID = "RL0005";
                account.Created = DateTime.Now;

                regsiter(account);
            }
        }

        private async void regsiter(AccountDTO account)
        {
            (bool isCreate, string label, string newCode) = await AccountDAL.Ins.createAccount(account);

            if (isCreate)
            {
                account.AccountID = newCode;

                AMessageBoxFrm ms = new AMessageBoxFrm("Đăng ký tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ms.ShowDialog();
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        private void atxbName__KeyDown(object sender, EventArgs e)
        {
            Helper.enterOnlyLetter(e);
        }

        private void atxbPhone__KeyDown(object sender, EventArgs e)
        {
            Helper.enterOnlyNumber(e);
        }
    }
}
