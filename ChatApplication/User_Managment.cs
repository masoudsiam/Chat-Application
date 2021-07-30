using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public class User_Managment
    {
        public User_Managment()
        {
            BasicOperation_User = new User_BasicOperation();
            BasicOperation_User_Logged = new User_Logged_BasicOperation();
        }

        public LoginResult Login(string phoneNumber, string password)
        {
            User user = BasicOperation_User.FindUser(phoneNumber);
            if (user == null)
                return LoginResult.NoUserFound;
            else if (user.Password != password)
                return LoginResult.WrongPassword;
            else if (IsLogged(user))
                return LoginResult.AlreadyLoggedIn;
            else
            {
                BasicOperation_User_Logged.AddLoggedUser(user);
                User_Current.SetUser(user);
                return LoginResult.Successful;
            }
        }

        public RegisterResult Register(string name, string phoneNumber, string password, Image picture)
        {
            if (BasicOperation_User.FindUser(phoneNumber) != null)
                return RegisterResult.Already;
            else
            {
                User user = new User(name, phoneNumber, password, ImageOperation.SaveImage_ReturnPath(picture, phoneNumber));
                BasicOperation_User.AddUser(user);
                BasicOperation_User_Logged.AddLoggedUser(user);
                User_Current.SetUser(user);
                return RegisterResult.Successful;
            }
        }

        public void LogOut(User user)
        {
            BasicOperation_User_Logged.RemoveLoggedUser(user);
            User_Current.SetUser(null);
        }

        public void EditUser(User user, string name, string password, Image picture)
        {
            BasicOperation_User.RemoveUser(user);
            user.Name = name;
            user.Password = password;
            user.PictureAddress = ImageOperation.SaveImage_ReturnPath(picture, user.PhoneNumber);
            BasicOperation_User.AddUser(user);
        }

        public User FindUser_ByPhoneNumber(string phoneNumber)
        {
            return BasicOperation_User.FindUser(phoneNumber);
        }

        public List<User> LoggedUserList()
        {
            List<User> users = new List<User>();
            foreach(string phoneNumber in BasicOperation_User_Logged.PhoneNumberList())
            {
                users.Add(BasicOperation_User.FindUser(phoneNumber));
            }
            return users;
        }

        public bool IsLogged(User user)
        {
            if (LoggedUserList().Contains(user))
                return true;
            else
                return false;
        }

        public bool AutoSelectCurrentUser()
        {
            List<User> LoggedUsers = LoggedUserList();
            if (LoggedUsers.Count == 0)
                return false;
            else
            {
                User_Current.SetUser(LoggedUsers[0]);
                return true;
            }
        }

        private User_BasicOperation BasicOperation_User;
        private User_Logged_BasicOperation BasicOperation_User_Logged;
    }
}
