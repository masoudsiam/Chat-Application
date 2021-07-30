using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication
{
    public partial class Frm_RemoveMember : Form
    {
        IChatContainer ChatContainer;
        ChatContainer_Managment Managment_ChatContainer;
        ChatContainer_Editable_Managment Managment_Editable_ChatContainer;
        public Frm_RemoveMember(IChatContainer container)
        {
            ChatContainer = container;
            Managment_ChatContainer = new ChatContainer_Managment();
            Managment_Editable_ChatContainer = new ChatContainer_Editable_Managment();
            InitializeComponent();
            Init_Pnl_Middle();
        }

        private void Init_Pnl_Middle()
        {
            foreach (User user in Managment_ChatContainer.UsersOfChatContainerList(ChatContainer))
            {
                BunifuFlatButton button = new BunifuFlatButton()
                {
                    Dock = DockStyle.Top,
                    Height = 30,
                    Textcolor = Color.FromArgb(74, 78, 77),
                    OnHoverTextColor = Color.FromArgb(74, 78, 77),
                    Normalcolor = Color.Transparent,
                    Activecolor = Color.White,
                    OnHovercolor = Color.White,
                    TextAlign = ContentAlignment.MiddleCenter,
                    TextFont = new Font("Segoe UI Semilight", 11),
                    Tag = user,
                    Text = user.Name,
                    Iconimage = Image.FromFile(user.PictureAddress)
                };
                if (ChatContainer.Members[User_Current.GetUser().PhoneNumber] >= ChatContainer.Members[user.PhoneNumber])
                    button.Enabled = false;
                button.Click += new EventHandler(button_Click);
                Pnl_Middle.Controls.Add(button);
            }
        }

        private void button_Click(object sender, System.EventArgs e)
        {
            Managment_Editable_ChatContainer.RemoveMember(ChatContainer, (User)(((BunifuFlatButton)sender).Tag));
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
