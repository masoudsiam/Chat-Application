using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public class User_Logged_BasicOperation
    {
        public User_Logged_BasicOperation()
        {
            SaveLoad_Logged_User = new User_Logged_SaveLoad();
        }

        public List<string> PhoneNumberList()
        {
            return SaveLoad_Logged_User.LoadPhoneNumber();
        }

        public void AddLoggedUser(User user)
        {
            List<string> phoneNumbers = SaveLoad_Logged_User.LoadPhoneNumber();
            phoneNumbers.Add(user.PhoneNumber);
            SaveLoad_Logged_User.SavePhoneNumber(phoneNumbers);
        }

        public void RemoveLoggedUser(User user)
        {
            List<string> phoneNumbers = SaveLoad_Logged_User.LoadPhoneNumber();
            phoneNumbers.Remove(user.PhoneNumber);
            SaveLoad_Logged_User.SavePhoneNumber(phoneNumbers);
        }

        private User_Logged_SaveLoad SaveLoad_Logged_User;
    }
}
