using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    [Serializable]
    public class User
    {
        public User(string name, string phoneNumber, string password, string pictureAddress)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Password = password;
            PictureAddress = pictureAddress;
            ChatContainerIds = new List<string>();
        }

        public override bool Equals(object obj) => this.Equals(obj as User);

        public bool Equals(User user)
        {
            if (user is null)
            {
                return false;
            }
            if (Object.ReferenceEquals(this, user))
            {
                return true;
            }
            if (this.GetType() != user.GetType())
            {
                return false;
            }
            return PhoneNumber == user.PhoneNumber;
        }

        public override int GetHashCode() => (PhoneNumber).GetHashCode();

        public static bool operator ==(User lhs, User rhs)
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

        public static bool operator !=(User lhs, User rhs) => !(lhs == rhs);

        public string Name { set; get; }
        public string PhoneNumber { get; }
        public string Password { set; get; }
        public string PictureAddress { set; get; }
        public List<string> ChatContainerIds { set; get; }
    }
}
