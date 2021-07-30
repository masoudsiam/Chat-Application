using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication
{
    public partial class Crl_ChatContainer : UserControl
    {
        private const int EM_GETLINECOUNT = 0xba;
        [DllImport("user32", EntryPoint = "SendMessageA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int SendMessage(int hwnd, int wMsg, int wParam, int lParam);
        public Crl_ChatContainers crl_ChatContainers;
        IChatContainer ChatContainer;
        ChatContainer_Managment Managment_ChatContainer;
        ChatContainer_Editable_Managment Managment_Editable_ChatContainer;
        User_Managment Managment_User;
        public Crl_ChatContainer(Crl_ChatContainers containers, IChatContainer container)
        {
            crl_ChatContainers = containers;
            ChatContainer = container;
            Managment_ChatContainer = new ChatContainer_Managment();
            Managment_Editable_ChatContainer = new ChatContainer_Editable_Managment();
            Managment_User = new User_Managment();
            InitializeComponent();
            Init_Elements();
            Init_Chats();
        }

        public void Init_Elements()
        {
            IChatContainer_Managment managment_IChatContainer;
            if (ChatContainer is Contact)
                managment_IChatContainer = new Contact_Managment();
            else if (ChatContainer is Group)
                managment_IChatContainer = new Group_Managment();
            else
                managment_IChatContainer = new Channel_Managment();
            Lbl_Name.Text = ChatContainer.Name;
            Pb_Image.Image = Image.FromFile(ChatContainer.PictureAddress);
            managment_IChatContainer.Init_Elements(User_Current.GetUser(), ChatContainer, Pnl_Bottom, Txt_Message, Btn_AddMember, Btn_RemoveMember, Btn_ChangeAccessLevel, Btn_Edit, Btn_Delete);
        }

        private void Init_Chats()
        {
            for (int i = 0; i < ChatContainer.Chats.Count; ++i)
            {
                CreateNewChatBox(i);
            }
        }

        private void CreateNewChatBox(int i)
        {
            IChat chat = ChatContainer.Chats[i];
            Panel pnl_area = new Panel
            {
                Dock = DockStyle.Top,
                AutoSize = true,
                BackColor = Color.Transparent,
                Visible = true,
            };
            Pnl_Middle.Controls.Add(pnl_area);
            Panel pnl_Chat = new Panel();
            BunifuElipse elipse = new BunifuElipse
            {
                TargetControl = pnl_Chat,
                ElipseRadius = 10,
            };
            pnl_area.Controls.Add(pnl_Chat);
            if (ChatContainer.Chats[i] is TextChat)
            {
                TextBox textBox = new TextBox
                {
                    Multiline = true,
                    Text = Managment_User.FindUser_ByPhoneNumber(chat.Sender).Name + Environment.NewLine + Environment.NewLine + chat.Content + Environment.NewLine + Environment.NewLine + chat.Time,
                    Font = new Font("Segoe UI Semilight", 11),
                    Enabled = false,
                    Location = new Point(0, 0),
                    Width = 450
                };
                var numberOfLines = SendMessage(textBox.Handle.ToInt32(), EM_GETLINECOUNT, 0, 0);
                textBox.Height = (textBox.Font.Height + 2) * numberOfLines + 5;
                pnl_Chat.Size = textBox.Size;
                pnl_Chat.Controls.Add(textBox);
                if (chat.Sender == User_Current.GetUser().PhoneNumber)
                {
                    pnl_Chat.Location = new Point(Pnl_Middle.Width - 475, 10);
                    pnl_Chat.BackColor = Color.FromArgb(239, 253, 222);
                    textBox.BackColor = Color.FromArgb(239, 253, 222);
                }
                else
                {
                    pnl_Chat.Location = new Point(10, 10);
                    pnl_Chat.BackColor = Color.White;
                    pnl_Chat.BackColor = Color.White;
                }
            }
            else
            {
                PictureBox pictureBox = new PictureBox
                {
                    Dock = DockStyle.Fill,
                    Image = Image.FromFile(chat.Content),
                    Cursor = Cursors.Hand,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                pnl_Chat.Width = 450;
                pnl_Chat.Height = 250;
                pictureBox.Click += new EventHandler(button_Click);
                pnl_Chat.Controls.Add(pictureBox);
                if (chat.Sender == User_Current.GetUser().PhoneNumber)
                {
                    pnl_Chat.Location = new Point(Pnl_Middle.Width - 475, 10);
                }
                else
                {
                    pnl_Chat.Location = new Point(10, 10);
                }
            }
        }

        private void button_Click(object sender, System.EventArgs e)
        {
            Frm_Picture frm_Picture = new Frm_Picture(((PictureBox)sender).Image);
            frm_Picture.Show();
        }

        private void Pb_Image_Click(object sender, EventArgs e)
        {
            Frm_Picture frm_Picture = new Frm_Picture(Pb_Image.Image);
            frm_Picture.Show();
        }

        private void Btn_AddMember_Click(object sender, EventArgs e)
        {
             Frm_AddMember frm_AddMember = new Frm_AddMember(ChatContainer);
            frm_AddMember.ShowDialog();
        }

        private void Btn_RemoveMember_Click(object sender, EventArgs e)
        {
            Frm_RemoveMember frm_RemoveMember = new Frm_RemoveMember(ChatContainer);
            frm_RemoveMember.ShowDialog();
        }

        private void Btn_ChangeAccessLevel_Click(object sender, EventArgs e)
        {
            Frm_ChangeAccessLevel frm_ChangeAccessLevel = new Frm_ChangeAccessLevel(ChatContainer);
            frm_ChangeAccessLevel.ShowDialog();
         }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            Frm_EditChatContainer frm_EditChatContainer = new Frm_EditChatContainer(ChatContainer, this);
            frm_EditChatContainer.ShowDialog();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (ChatContainer.Members[User_Current.GetUser().PhoneNumber] == AccessLevel.Owner)
                Managment_ChatContainer.DeleteChatContainer(ChatContainer);
            else
                Managment_Editable_ChatContainer.RemoveMember(ChatContainer, User_Current.GetUser());
            crl_ChatContainers.Init_Pnl_ChatContainers();
            crl_ChatContainers.frm_Main.Reset_Pnl_Right();
        }

        private void Pb_Send_Click(object sender, EventArgs e)
        {
            if (Txt_Message.Text != "")
            {
                Managment_ChatContainer.NewTextChat(ChatContainer, User_Current.GetUser(), Txt_Message.Text);
                Txt_Message.Text = "";
                CreateNewChatBox(ChatContainer.Chats.Count - 1);
            }
        }

        private void Pb_Attach_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImageDialog = new OpenFileDialog();
            openImageDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openImageDialog.ShowDialog() == DialogResult.OK)
            {
                Managment_ChatContainer.NewPhotoChat(ChatContainer, User_Current.GetUser(), Image.FromFile(openImageDialog.FileName));
                CreateNewChatBox(ChatContainer.Chats.Count - 1);
            }
        }

        private void Pnl_Middle_ControlAdded(object sender, ControlEventArgs e)
        {
            Pnl_Middle.ScrollControlIntoView(e.Control);
        }
    }
}
