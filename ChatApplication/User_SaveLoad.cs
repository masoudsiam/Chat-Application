using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public class User_SaveLoad
    {
        public void SaveUser(List<User> users)
        {
            FileStream fileStream = new FileStream(Address.Users(), FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            foreach (User user in users)
                binaryFormatter.Serialize(fileStream, user);
            fileStream.Close();
        }

        public List<User> LoadUser()
        {
            FileStream fileStream = new FileStream(Address.Users(), FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            List<User> users = new List<User>();
            while (fileStream.Position != fileStream.Length)
                users.Add((User)binaryFormatter.Deserialize(fileStream));
            fileStream.Close();
            return users;
        }
    }
}
