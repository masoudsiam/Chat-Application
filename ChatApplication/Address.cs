using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public static class Address
    {
        public static string Users()
        {
            string Dir = Path.GetFullPath(Path.Combine(System.IO.Directory.GetCurrentDirectory(), @"..\..\files\users"));
            if (!Directory.Exists(Dir))
                Directory.CreateDirectory(Dir);
            string FilePath = Path.GetFullPath(Path.Combine(Dir, @"users.txt"));
            if (!File.Exists(FilePath))
                File.Create(FilePath).Close();
            return FilePath;
        }

        public static string LoggedUsers()
        {
            string Dir = Path.GetFullPath(Path.Combine(System.IO.Directory.GetCurrentDirectory(), @"..\..\files\logged users"));
            if (!Directory.Exists(Dir))
                Directory.CreateDirectory(Dir);
            string FilePath = Path.GetFullPath(Path.Combine(Dir, @"logged users.txt"));
            if (!File.Exists(FilePath))
                File.Create(FilePath).Close();
            return FilePath;
        }

        public static string ChatContainers()
        {
            string Dir = Path.GetFullPath(Path.Combine(System.IO.Directory.GetCurrentDirectory(), @"..\..\files\chat containers"));
            if (!Directory.Exists(Dir))
                Directory.CreateDirectory(Dir);
            string FilePath = Path.GetFullPath(Path.Combine(Dir, @"chat containers.txt"));
            if (!File.Exists(FilePath))
                File.Create(FilePath).Close();
            return FilePath;
        }

        public static string Pictures()
        {
            string Dir = Path.GetFullPath(Path.Combine(System.IO.Directory.GetCurrentDirectory(), @"..\..\files\photos"));
            if (!Directory.Exists(Dir))
                Directory.CreateDirectory(Dir);
            return Dir;
        }
    }
}
