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
    public partial class Crl_Menu : UserControl
    {
        public Frm_Main frm_Main;
        User_Managment managment_User;
        public Crl_Menu(Frm_Main main)
        {
            frm_Main = main;
            managment_User = new User_Managment();
            InitializeComponent();
            Init_Pnl_Info();
            Init_Pnl_Accounts();
        }

        private void Pb_Pnl_Top_Click(object sender, EventArgs e)
        {
            frm_Main.Show_Crl_ChatContainers();
        }

        public void Init_Pnl_Info()
        {
            Pb_Image.Image = Image.FromFile(User_Current.GetUser().PictureAddress);
            Lbl_Name.Text = User_Current.GetUser().Name;
            Lbl_PhoneNumber.Text = User_Current.GetUser().PhoneNumber;
        }

        public void Init_Pnl_Accounts()
        {
            List<User> loggedUsers = managment_User.LoggedUserList();
            for (int index = 0; index < 3; ++index)
            {
                foreach (BunifuFlatButton button in Pnl_Accounts.Controls.OfType<BunifuFlatButton>())
                {
                    if (button.Name.Last() == (char)(index + 48))
                    {
                        if (index < loggedUsers.Count)
                        {
                            button.Text = loggedUsers[index].Name;
                            button.Tag = loggedUsers[index];
                            button.Iconimage = Image.FromFile(loggedUsers[index].PictureAddress);
                        }
                        else
                        {
                            button.Text = "Add Account";
                            button.Tag = null;
                            button.Iconimage = null;
                        }
                        break;
                    }
                }
            }
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            BunifuFlatButton button = (BunifuFlatButton)sender;
            if (button.Tag != null && User_Current.GetUser() != (User)button.Tag)
            {
                User_Current.SetUser((User)button.Tag);
                frm_Main.Reset_Pnl_Right();
                Init_Pnl_Info();
            }
            else if (button.Tag == null)
            {
                frm_Main.Show_Frm_Welcome();
            }
        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            managment_User.LogOut(User_Current.GetUser());
            if (managment_User.AutoSelectCurrentUser())
            {
                frm_Main.Reset_Pnl_Right();
                Init_Pnl_Info();
                Init_Pnl_Accounts();
            }
            else
            {
                frm_Main.Show_Frm_Welcome();
                frm_Main.Close();
            }
        }

        private void Pb_Image_Click(object sender, EventArgs e)
        {
            Frm_Picture frm_Picture = new Frm_Picture(Pb_Image.Image);
            frm_Picture.Show();
        }

        private void Btn_EditProfile_Click(object sender, EventArgs e)
        {
            Frm_EditProfile frm_EditProfile = new Frm_EditProfile(this);
            frm_EditProfile.ShowDialog();
        }

        private void Btn_NewContact_Click(object sender, EventArgs e)
        {
            Frm_NewContact frm_NewContact = new Frm_NewContact(this);
            frm_NewContact.ShowDialog();
        }

        private void Btn_NewGroup_Click(object sender, EventArgs e)
        {
            Frm_NewGroup frm_NewGroup = new Frm_NewGroup(this);
            frm_NewGroup.ShowDialog();
        }

        private void Btn_NewChannel_Click(object sender, EventArgs e)
        {
            Frm_NewChannel frm_NewChannel = new Frm_NewChannel(this);
            frm_NewChannel.ShowDialog();
        }
    }
}
