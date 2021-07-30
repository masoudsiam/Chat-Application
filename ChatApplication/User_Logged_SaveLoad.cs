using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public class User_Logged_SaveLoad
    {
        public void SavePhoneNumber(List<string> phoneNumbers)
        {
            FileStream fileStream = new FileStream(Address.LoggedUsers(), FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            foreach (string phoneNumber in phoneNumbers)
                binaryFormatter.Serialize(fileStream, phoneNumber);
            fileStream.Close();
        }

        public List<string> LoadPhoneNumber()
        {
            FileStream fileStream = new FileStream(Address.LoggedUsers(), FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            List<string> phoneNumbers = new List<string>();
            while (fileStream.Position != fileStream.Length)
                phoneNumbers.Add((string)binaryFormatter.Deserialize(fileStream));
            fileStream.Close();
            return phoneNumbers;
        }
    }
}
