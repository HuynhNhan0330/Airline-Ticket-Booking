using Airline_Ticket_Booking.AControls;
using Airline_Ticket_Booking.DALs;
using Airline_Ticket_Booking.DTOs;
using Airline_Ticket_Booking.Model;
using Airline_Ticket_Booking.Usercontrols;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Airline_Ticket_Booking
{
    public partial class ChatUC : UserControl
    {
        private Color _color = BaseColor.XanhDam1;
        public Color color
        {
            get { return _color; }
            set
            {
                _color = value;
                pnTop.BackColor = color;
                atxbText.BorderColor = color;
                atxbText.BorderFocusColor = color;
                this.Invalidate();
            }
        }

        private DateTime? _timeGet = null;
        public DateTime? timeGet
        {
            get { return _timeGet; }
            set
            {
                _timeGet = value;
            }
        }


        private int _type = 0;
        public int type
        {
            get { return _type; }
            set
            {
                _type = value;
            }
        }

        public string name
        {
            get { return lbName.Text; }
            set
            {
                lbName.Text = value;
                lbName.Left = (this.Width - lbName.Width) / 2;
            }
        }

        private string _customerID;
        public string customerID
        {
            get { return _customerID; }
            set
            {
                _customerID = value;
            }
        }

        public ChatUC()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Tạo một bút mới với màu sắc mong muốn
            Pen pen = new Pen(color, 2);

            // Vẽ đường viền xung quanh form
            e.Graphics.DrawRectangle(pen, this.ClientRectangle);
        }

        private void pibSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(atxbText.Texts.Trim())) 
            {
                switch (type)
                {
                    case 0:
                        sendMessagneInAdmin();
                        break;

                    case 1:
                        sendMessagneInCustomer();
                        break;
                }
            }
        }

        private async void sendMessagneInCustomer()
        {
            MessageDTO message = new MessageDTO();
            message.Text = atxbText.Texts.Trim();
            message.TexterID = Helper.getAccountCustomer().AccountID;
            message.RecipientID = "AC0001";
            message.Created = DateTime.Now;
            timeGet = message.Created;

            (bool isGet, string label) = await MessageDAL.Ins.createMessage(message);

            if (isGet)
            {
                addInMessage(message);
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }

        }

        private async void sendMessagneInAdmin()
        {
            MessageDTO message = new MessageDTO();
            message.Text = atxbText.Texts.Trim();
            message.TexterID = "AC0001";
            message.RecipientID = customerID;
            message.Created = DateTime.Now;
            timeGet = message.Created;

            (bool isGet, string label) = await MessageDAL.Ins.createMessage(message);

            if (isGet)
            {
                addInMessage(message);
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }

        }

        private void addInMessage(MessageDTO message)
        {
            InMessageUC uc = new InMessageUC();
            pnChat.Controls.Add(uc);
            uc.Dock = DockStyle.Top;
            uc.BringToFront();
            uc.message = message;
        }

        private void addOutMessage(MessageDTO message)
        {
            OutMessageUC uc = new OutMessageUC();
            pnChat.Controls.Add(uc);
            uc.Dock = DockStyle.Top;
            uc.BringToFront();
            uc.message = message;
        }

        private void ChatUC_Load(object sender, EventArgs e)
        {

        }

        public void loadMessage(List<MessageDTO> messages, string texterID)
        {
            pnChat.Controls.Clear();

            foreach (MessageDTO message in messages)
            {
                if (message.TexterID == texterID)
                    addInMessage(message);
                else
                    addOutMessage(message);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (timeGet == null)
                return;

            // Load dữ liệu mới

            updateMessage();
        }

        private async void updateMessage()
        {
            switch (type)
            {
                case 0:
                    (bool isGetAdmin, List<MessageDTO> messagesAdmin, string labelAdmin) = await MessageDAL.Ins.getMessageByTime("AC0001", customerID, (DateTime)timeGet);

                    if (isGetAdmin)
                    {
                        timeGet = DateTime.Now;

                        foreach (MessageDTO message in messagesAdmin)
                        {
                            if (message.TexterID == "AC0001")
                                addInMessage(message);
                            else
                                addOutMessage(message);
                        }
                    }

                    break;

                case 1:
                    (bool isGetCustomer, List<MessageDTO> messagesCustomer, string labelCustomer) = await MessageDAL.Ins.getMessageByTime(Helper.getAccountCustomer().AccountID, "AC0001", (DateTime)timeGet);

                    if (isGetCustomer)
                    {
                        timeGet = DateTime.Now;
                        string texterID = Helper.getAccountCustomer().AccountID;

                        foreach (MessageDTO message in messagesCustomer)
                        {
                            if (message.TexterID == texterID)
                                addInMessage(message);
                            else
                                addOutMessage(message);
                        }
                    }

                    break;
            }
        }
    }
}
