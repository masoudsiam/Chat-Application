using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public interface IChat
    {
        string Sender { get; }
        string Content { get; }
        DateTime Time { get; }
    }
}
