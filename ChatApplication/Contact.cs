using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    [Serializable]
    public class Contact : IChatContainer
    {
        public Contact(string id, User user1, User user2)
        {
            Id = id;
            Chats = new List<IChat>();
            Members = new Dictionary<string, AccessLevel>();
            Members[user1.PhoneNumber] = AccessLevel.Owner;
            Members[user2.PhoneNumber] = AccessLevel.Owner;
        }

        public override bool Equals(object obj) => this.Equals(obj as Contact);

        public bool Equals(Contact contact)
        {
            if (contact is null)
            {
                return false;
            }
            if (Object.ReferenceEquals(this, contact))
            {
                return true;
            }
            if (this.GetType() != contact.GetType())
            {
                return false;
            }
            return Id == contact.Id;
        }

        public override int GetHashCode() => (Id).GetHashCode();

        public static bool operator ==(Contact lhs, Contact rhs)
        {
            if (lhs is null)
            {
                if (rhs is null)
                {
                    return true;
                }
                return false;
            }
            return lhs.Equals(rhs);
        }

        public static bool operator !=(Contact lhs, Contact rhs) => !(lhs == rhs);

        public string Name
        {
            get
            {
                User_Managment managment_User = new User_Managment();
                foreach (string phoneNumber in Members.Keys)
                    if (User_Current.GetUser().PhoneNumber != phoneNumber)
                        return managment_User.FindUser_ByPhoneNumber(phoneNumber).Name;
                return null;
            }
            set { }
        }
        public string Id { get; }
        public string PictureAddress
        {
            get
            {
                User_Managment managment_User = new User_Managment();
                foreach (string phoneNumber in Members.Keys)
                    if (User_Current.GetUser().PhoneNumber != phoneNumber)
                        return managment_User.FindUser_ByPhoneNumber(phoneNumber).PictureAddress;
                return null;
            }
            set { }
        }
        public string PhoneNumber
        {
            get
            {
                foreach (string phoneNumber in Members.Keys)
                    if (User_Current.GetUser().PhoneNumber != phoneNumber)
                        return phoneNumber;
                return null;
            }
            set { }
        }
        public List<IChat> Chats { get; set; }
        public Dictionary<string, AccessLevel> Members { get; set; }

    }
}
