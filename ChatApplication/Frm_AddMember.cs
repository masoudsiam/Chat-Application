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
    public partial class Frm_AddMember : Form
    {
        IChatContainer ChatContainer;
        ChatContainer_Editable_Managment Managment_Editable_ChatContainer;
        User_Managment managment_User;
        public Frm_AddMember(IChatContainer container)
        {
            ChatContainer = container;
            Managment_Editable_ChatContainer = new ChatContainer_Editable_Managment();
            managment_User = new User_Managment();
            InitializeComponent();
            Init_Pnl_Middle();
        }

        private void Init_Pnl_Middle()
        {
            Contact_Managment managment_Contact = new Contact_Managment();
            foreach (Contact contact in managment_Contact.ContactsList(User_Current.GetUser()))
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
                    Tag = contact.PhoneNumber,
                    Text = contact.Name,
                    Iconimage = Image.FromFile(contact.PictureAddress)
                };
                if (ChatContainer.Members.ContainsKey(contact.PhoneNumber))
                    button.Enabled = false;
                button.Click += new EventHandler(button_Click);
                Pnl_Middle.Controls.Add(button);
            }
        }

        private void button_Click(object sender, System.EventArgs e)
        {
            Managment_Editable_ChatContainer.AddMember(ChatContainer, managment_User.FindUser_ByPhoneNumber((((BunifuFlatButton)sender).Tag).ToString()));
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
