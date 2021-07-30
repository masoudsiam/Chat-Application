using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    [Serializable]
    public class PhotoChat : IChat
    {
        public PhotoChat(User owner, string text)
        {
            Sender = owner.PhoneNumber;
            Content = text;
            Time = DateTime.Now;
        }
        public string Sender { get; }

        public string Content { get; }

        public DateTime Time { get; }
    }
}
