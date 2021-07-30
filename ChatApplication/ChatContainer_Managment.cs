using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public class ChatContainer_Managment
    {
        public ChatContainer_Managment()
        {
            BasicOperation_ChatContainer = new ChatContainer_BasicOperation();
            BasicOperation_User = new User_BasicOperation();
        }

        public IChatContainer FindChatContainer_ById(string Id)
        {
            return BasicOperation_ChatContainer.FindChatContainer(Id);
        }

        public List<IChatContainer> ChatContainersOfUserList(User user)
        {
            List<IChatContainer> chatContainers = new List<IChatContainer>();
            foreach (string id in user.ChatContainerIds)
            {
                chatContainers.Add(BasicOperation_ChatContainer.FindChatContainer(id));
            }
            return chatContainers;
        }

        public List<User> UsersOfChatContainerList(IChatContainer chatContainer)
        {
            List<User> users = new List<User>();
            foreach (string phoneNumber in chatContainer.Members.Keys)
            {
                users.Add(BasicOperation_User.FindUser(phoneNumber));
            }
            return users;
        }

        public void DeleteChatContainer(IChatContainer chatContainer)
        {
            List<User> containerUser = UsersOfChatContainerList(chatContainer);
            foreach (User user in containerUser)
            {
                BasicOperation_User.RemoveChatContainer(user, chatContainer);
            }
            BasicOperation_ChatContainer.RemoveChatContainer(chatContainer);
        }

        public void NewTextChat(IChatContainer chatContainer, User owner, string text)
        {
            BasicOperation_ChatContainer.AddChat(chatContainer, new TextChat(owner, text));
        }

        public void NewPhotoChat(IChatContainer chatContainer, User owner, Image photo)
        {
            BasicOperation_ChatContainer.AddChat(chatContainer, new PhotoChat(owner, ImageOperation.SaveImage_ReturnPath(photo, chatContainer.Id)));
        }

        private ChatContainer_BasicOperation BasicOperation_ChatContainer;
        private User_BasicOperation BasicOperation_User;
    }
}
