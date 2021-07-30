using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    [Serializable]
    public class Group : IChatContainer
    {
        public Group(string name, string id, string pictureAddress, User owner)
        {
            Name = name;
            Id = id;
            PictureAddress = pictureAddress;
            Chats = new List<IChat>();
            Members = new Dictionary<string, AccessLevel>();
            Members[owner.PhoneNumber] = AccessLevel.Owner;
        }

        public override bool Equals(object obj) => this.Equals(obj as Group);

        public bool Equals(Group group)
        {
            if (group is null)
            {
                return false;
            }
            if (Object.ReferenceEquals(this, group))
            {
                return true;
            }
            if (this.GetType() != group.GetType())
            {
                return false;
            }
            return Id == group.Id;
        }

        public override int GetHashCode() => (Id).GetHashCode();

        public static bool operator ==(Group lhs, Group rhs)
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

        public static bool operator !=(Group lhs, Group rhs) => !(lhs == rhs);

        public string Name { get; set; }
        public string Id { get; }
        public string PictureAddress { get; set; }
        public List<IChat> Chats { get; set; }
        public Dictionary<string, AccessLevel> Members { get; set; }
    }
}
