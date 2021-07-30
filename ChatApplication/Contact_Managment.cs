using Bunifu.UI.WinForms.BunifuButton;
using Bunifu.UI.WinForms.BunifuTextbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication
{
    public class Contact_Managment : IChatContainer_Managment
    {
        public Contact_Managment()
        {
            BasicOperation_ChatContainer = new ChatContainer_BasicOperation();
            BasicOperation_User = new User_BasicOperation();
        }

        public NewContactResult NewContact(User user1, string phoneNumber)
        {
            User user2 = BasicOperation_User.FindUser(phoneNumber);
            if (user2 == null)
                return NewContactResult.NoUserFound;
            else if (user1 == user2)
                return NewContactResult.CantAddYourself;
            else
            {
                string id = String.Compare(user1.PhoneNumber, user2.PhoneNumber) > 0 ? "Contact-" + user1.PhoneNumber + user2.PhoneNumber : "Contact" + user2.PhoneNumber + user1.PhoneNumber;
                if (BasicOperation_ChatContainer.FindChatContainer(id) != null)
                    return NewContactResult.AlreadyInContacts;
                else
                {
                    Contact contact = new Contact(id, user1, user2);
                    BasicOperation_ChatContainer.AddChatContainer(contact);
                    BasicOperation_User.AddChatContainer(user1, contact);
                    BasicOperation_User.AddChatContainer(user2, contact);
                    return NewContactResult.Successful;
                }
            }
        }

        public List<Contact> ContactsList(User user)
        {
            List<Contact> contacts = new List<Contact>();
            foreach (string id in user.ChatContainerIds)
            {
                IChatContainer chatContainer = BasicOperation_ChatContainer.FindChatContainer(id);
                if (chatContainer is Contact)
                    contacts.Add((Contact)chatContainer);
            }
            return contacts;
        }

        public void Init_Elements(User user, IChatContainer chatContainer, Panel pnl_Bottom, BunifuTextBox txt_Message, BunifuButton btn_AddMember, BunifuButton btn_RemoveMember, BunifuButton btn_ChangeAccessLevel, BunifuButton btn_Edit, BunifuButton btn_DeleteChatContainer)
        {
            txt_Message.PlaceholderText = "Write a message...";
            btn_AddMember.Visible = false;
            btn_RemoveMember.Visible = false;
            btn_ChangeAccessLevel.Visible = false;
            btn_Edit.Visible = false;
            btn_DeleteChatContainer.Text = "Remove Contact";
        }

        private ChatContainer_BasicOperation BasicOperation_ChatContainer;
        private User_BasicOperation BasicOperation_User;
    }
}
