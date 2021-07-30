using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public class User_Current
    {
        public static User GetUser()
        {
            if (PhoneNumber == "")
                return null;
            else
            {
                return Managment_User.FindUser_ByPhoneNumber(PhoneNumber);
            }
        }

        public static void SetUser(User user)
        {
            if (user == null)
                PhoneNumber = "";
            else
                PhoneNumber = user.PhoneNumber;
        }

        private static string PhoneNumber;
        private static User_Managment Managment_User = new User_Managment();
    }
}
