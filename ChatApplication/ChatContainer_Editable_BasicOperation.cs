using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public class ChatContainer_Editable_BasicOperation
    {
        public ChatContainer_Editable_BasicOperation()
        {
            SaveLoad_ChatContainer = new ChatContainer_SaveLoad();
        }

        public void AddChatContainer(IChatContainer chatContainer)
        {
            List<IChatContainer> chatContainers = SaveLoad_ChatContainer.Load_ChatContainers();
            chatContainers.Add(chatContainer);
            SaveLoad_ChatContainer.Save_ChatContainer(chatContainers);
        }

        public void RemoveChatContainer(IChatContainer chatContainer)
        {
            List<IChatContainer> chatContainers = SaveLoad_ChatContainer.Load_ChatContainers();
            chatContainers.Remove(chatContainer);
            SaveLoad_ChatContainer.Save_ChatContainer(chatContainers);
        }

        public void AddMember(IChatContainer chatContainer, User user)
        {
            RemoveChatContainer(chatContainer);
            chatContainer.Members[user.PhoneNumber] = AccessLevel.Member;
            AddChatContainer(chatContainer);
        }

        public void RemoveMember(IChatContainer chatContainer, User user)
        {
            RemoveChatContainer(chatContainer);
            chatContainer.Members.Remove(user.PhoneNumber);
            AddChatContainer(chatContainer);
        }

        public void ChangeAccessLevel(IChatContainer chatContainer, User user, AccessLevel accessLevel)
        {
            RemoveChatContainer(chatContainer);
            chatContainer.Members[user.PhoneNumber] = accessLevel;
            AddChatContainer(chatContainer);
        }

        private ChatContainer_SaveLoad SaveLoad_ChatContainer;
    }
}
