using Bunifu.UI.WinForms.BunifuButton;
using Bunifu.UI.WinForms.BunifuTextbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication
{
    public interface IChatContainer_Managment
    {
        void Init_Elements(User user, IChatContainer chatContainer, Panel pnl_Bottom, BunifuTextBox txt_Message, BunifuButton btn_AddMember, BunifuButton btn_RemoveMember, BunifuButton btn_ChangeAccessLevel, BunifuButton btn_Edit, BunifuButton btn_DeleteChatContainer);
    }
}
