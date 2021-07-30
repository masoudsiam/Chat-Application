using Bunifu.UI.WinForms.BunifuButton;
using Bunifu.UI.WinForms.BunifuTextbox;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication
{
    public class Channel_Managment : IChatContainer_Managment
    {
        public Channel_Managment()
        {
            BasicOperation_ChatContainer = new ChatContainer_BasicOperation();
            BasicOperation_User = new User_BasicOperation();
        }

        public void NewChannel(User user, string name, Image picture)
        {
            string id = "Channel-" + user.PhoneNumber + "-" + DateTime.Now.Ticks.ToString();
            Channel channel = new Channel(name, id, ImageOperation.SaveImage_ReturnPath(picture, id), user);
            BasicOperation_ChatContainer.AddChatContainer(channel);
            BasicOperation_User.AddChatContainer(user, channel);
        }

        public void Init_Elements(User user, IChatContainer chatContainer, Panel pnl_Bottom, BunifuTextBox txt_Message, BunifuButton btn_AddMember, BunifuButton btn_RemoveMember, BunifuButton btn_ChangeAccessLevel, BunifuButton btn_Edit, BunifuButton btn_DeleteChatContainer)
        {
            txt_Message.PlaceholderText = "Broadcast a message...";
            if (chatContainer.Members[user.PhoneNumber] > AccessLevel.Admin)
            {
                pnl_Bottom.Visible = false;
                btn_AddMember.Visible = false;
                btn_RemoveMember.Visible = false;
                btn_ChangeAccessLevel.Visible = false;
                btn_Edit.Visible = false;
            }
            btn_DeleteChatContainer.Text = "Leave Channel";
        }

        private ChatContainer_BasicOperation BasicOperation_ChatContainer;
        private User_BasicOperation BasicOperation_User;
    }
}
