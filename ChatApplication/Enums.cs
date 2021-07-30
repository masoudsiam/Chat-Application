using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public enum LoginResult
    {
        Successful,
        AlreadyLoggedIn,
        WrongPassword,
        NoUserFound
    }

    public enum RegisterResult
    {
        Successful,
        Already
    }

    public enum AccessLevel
    {
        Owner,
        Admin,
        Member
    }

    public enum NewContactResult
    {
        Successful,
        AlreadyInContacts,
        CantAddYourself,
        NoUserFound
    }
}
