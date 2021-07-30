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
    public class Group_Managment : IChatContainer_Managment
    {
        public Group_Managment()
        {
            BasicOperation_ChatContainer = new ChatContainer_BasicOperation();
            BasicOperation_User = new User_BasicOperation();
        }


        public void NewGroup(User user, string name, Image picture)
        {
            string id = "Group-" + user.PhoneNumber + "-" + DateTime.Now.Ticks.ToString();
            Group group = new Group(name, id, ImageOperation.SaveImage_ReturnPath(picture, id), user);
            BasicOperation_ChatContainer.AddChatContainer(group);
            BasicOperation_User.AddChatContainer(user, group);
        }

        public void Init_Elements(User user, IChatContainer chatContainer, Panel pnl_Bottom, BunifuTextBox txt_Message, BunifuButton btn_AddMember, BunifuButton btn_RemoveMember, BunifuButton btn_ChangeAccessLevel, BunifuButton btn_Edit, BunifuButton btn_DeleteChatContainer)
        {
            txt_Message.PlaceholderText = "Write a message...";
            if (chatContainer.Members[user.PhoneNumber] > AccessLevel.Admin)
            {
                btn_AddMember.Visible = false;
                btn_RemoveMember.Visible = false;
                btn_ChangeAccessLevel.Visible = false;
                btn_Edit.Visible = false;
            }
            btn_DeleteChatContainer.Text = "Leave Group";
        }

        private ChatContainer_BasicOperation BasicOperation_ChatContainer;
        private User_BasicOperation BasicOperation_User;
    }
}
