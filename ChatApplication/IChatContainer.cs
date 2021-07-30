using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public interface IChatContainer
    {
        string Name { get; set; }
        string Id { get; }
        string PictureAddress { get; set; }
        List<IChat> Chats { get; set; }
        Dictionary<string, AccessLevel> Members { get; set; }
    }
}
