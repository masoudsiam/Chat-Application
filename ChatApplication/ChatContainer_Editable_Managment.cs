using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public class ChatContainer_Editable_Managment
    {
        public ChatContainer_Editable_Managment()
        {
            BasicOperation_Editable_ChatContainer = new ChatContainer_Editable_BasicOperation();
            BasicOperation_User = new User_BasicOperation();
        }

        public void AddMember(IChatContainer chatContainer, User user)
        {
            if (!chatContainer.Members.ContainsKey(user.PhoneNumber))
            {
                BasicOperation_Editable_ChatContainer.AddMember(chatContainer, user);
                BasicOperation_User.AddChatContainer(user, chatContainer);
            }
        }
        public void RemoveMember(IChatContainer chatContainer, User user)
        {
            BasicOperation_Editable_ChatContainer.RemoveMember(chatContainer, user);
            BasicOperation_User.RemoveChatContainer(user, chatContainer);
        }

        public void ToggleAccessLevel(IChatContainer chatContainer, User user)
        {
            if (chatContainer.Members[user.PhoneNumber] == AccessLevel.Admin)
                BasicOperation_Editable_ChatContainer.ChangeAccessLevel(chatContainer, user, AccessLevel.Member);
            else
                BasicOperation_Editable_ChatContainer.ChangeAccessLevel(chatContainer, user, AccessLevel.Admin);
        }

        public void EditChatContainer(IChatContainer chatContainer, string name, Image picture)
        {
            BasicOperation_Editable_ChatContainer.RemoveChatContainer(chatContainer);
            chatContainer.Name = name;
            chatContainer.PictureAddress = ImageOperation.SaveImage_ReturnPath(picture, chatContainer.Id);
            BasicOperation_Editable_ChatContainer.AddChatContainer(chatContainer);
        }

        private ChatContainer_Editable_BasicOperation BasicOperation_Editable_ChatContainer;
        private User_BasicOperation BasicOperation_User;
    }
}
