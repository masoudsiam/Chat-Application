using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public class User_BasicOperation
    {
        public User_BasicOperation()
        {
            SaveLoad_User = new User_SaveLoad();
        }

        public void AddUser(User user)
        {
            List<User> users = SaveLoad_User.LoadUser();
            users.Add(user);
            SaveLoad_User.SaveUser(users);
        }

        public void RemoveUser(User user)
        {
            List<User> users = SaveLoad_User.LoadUser();
            users.Remove(user);
            SaveLoad_User.SaveUser(users);
        }

        public User FindUser(string phoneNumber)
        {
            User result = null;
            foreach (User user in SaveLoad_User.LoadUser())
            {
                if (user.PhoneNumber == phoneNumber)
                {
                    result = user;
                    break;
                }
            }
            return result;
        }

        public void AddChatContainer(User user, IChatContainer chatContainer)
        {
            RemoveUser(user);
            user.ChatContainerIds.Add(chatContainer.Id);
            AddUser(user);
        }

        public void RemoveChatContainer(User user, IChatContainer chatContainer)
        {
            RemoveUser(user);
            user.ChatContainerIds.Remove(chatContainer.Id);
            AddUser(user);
        }

        private User_SaveLoad SaveLoad_User;
    }
}
