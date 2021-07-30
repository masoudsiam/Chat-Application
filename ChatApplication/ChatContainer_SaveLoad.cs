using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public class ChatContainer_SaveLoad
    {
        public void Save_ChatContainer(List<IChatContainer> chatContainers)
        {
            FileStream fileStream = new FileStream(Address.ChatContainers(), FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            foreach (IChatContainer chatContainer in chatContainers)
                binaryFormatter.Serialize(fileStream, chatContainer);
            fileStream.Close();
        }

        public List<IChatContainer> Load_ChatContainers()
        {
            FileStream fileStream = new FileStream(Address.ChatContainers(), FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            List<IChatContainer> chatContainers = new List<IChatContainer>();
            while (fileStream.Position != fileStream.Length)
                chatContainers.Add((IChatContainer)binaryFormatter.Deserialize(fileStream));
            fileStream.Close();
            return chatContainers;
        }
    }
}
