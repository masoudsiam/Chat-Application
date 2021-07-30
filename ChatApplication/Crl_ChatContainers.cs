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
    public partial class Crl_ChatContainers : UserControl
    {
        public Frm_Main frm_Main;
        ChatContainer_Managment managment_ChatContainer;
        public Crl_ChatContainers(Frm_Main main)
        {
            frm_Main = main;
            managment_ChatContainer = new ChatContainer_Managment();
            InitializeComponent();
            Init_Pnl_ChatContainers();
        }

        public void Init_Pnl_ChatContainers()
        {
            Pnl_Bottom.Controls.Clear();
            foreach (IChatContainer chatContainer in managment_ChatContainer.ChatContainersOfUserList(User_Current.GetUser()))
            {
                BunifuFlatButton button = new BunifuFlatButton()
                {
                    Dock = DockStyle.Top,
                    Height = 40,
                    Normalcolor = Color.Transparent,
                    Activecolor = Color.FromArgb(132, 193, 255),
                    OnHovercolor = Color.FromArgb(244, 244, 248),
                    Textcolor = Color.FromArgb(74, 78, 77),
                    OnHoverTextColor = Color.FromArgb(74, 78, 77),
                    TextAlign = ContentAlignment.MiddleCenter,
                    TextFont = new Font("Segoe UI Semilight", 11),
                    Tag = chatContainer,
                    Text = chatContainer.Name,
                    Iconimage = Image.FromFile(chatContainer.PictureAddress)
                };
                button.Click += new EventHandler(button_Click);
                Pnl_Bottom.Controls.Add(button);
            }
        }

        private void button_Click(object sender, System.EventArgs e)
        {
            BunifuFlatButton button = (BunifuFlatButton)sender;
            foreach (BunifuFlatButton btn in Pnl_Bottom.Controls.OfType<BunifuFlatButton>())
                if (btn.Tag == button.Tag)
                {
                    btn.Normalcolor = Color.FromArgb(132, 193, 255);
                    btn.OnHovercolor = Color.FromArgb(132, 193, 255);
                }
                else
                {
                    btn.Normalcolor = Color.Transparent;
                    btn.OnHovercolor = Color.FromArgb(244, 244, 248);
                }
            Crl_ChatContainer crl_ChatContainer = new Crl_ChatContainer(this, (IChatContainer)button.Tag);
            frm_Main.Show_Crl_ChatContainer(crl_ChatContainer);
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            foreach (BunifuFlatButton button in Pnl_Bottom.Controls.OfType<BunifuFlatButton>())
            {
                if (button.Text.Contains(Txt_Search.Text))
                    button.Visible = true;
                else
                    button.Visible = false;
            }
        }

        private void Pb_Pnl_Top_Click(object sender, EventArgs e)
        {
            frm_Main.Show_Crl_Menu();
        }
    }
}
