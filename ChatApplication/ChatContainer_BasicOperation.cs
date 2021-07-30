using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public class ChatContainer_BasicOperation
    {
        public ChatContainer_BasicOperation()
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
    
        public IChatContainer FindChatContainer(string Id)
        {
            IChatContainer result = null;
            foreach (IChatContainer chatContainer in SaveLoad_ChatContainer.Load_ChatContainers())
            {
                if (chatContainer.Id == Id)
                {
                    result = chatContainer;
                    break;
                }
            }
            return result;
        }

        public void AddChat(IChatContainer chatContainer, IChat chat)
        {
            RemoveChatContainer(chatContainer);
            chatContainer.Chats.Add(chat);
            AddChatContainer(chatContainer);
        }

        private ChatContainer_SaveLoad SaveLoad_ChatContainer;
    }
}
