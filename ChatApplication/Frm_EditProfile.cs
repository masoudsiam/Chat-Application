using Bunifu.UI.WinForms.BunifuTextbox;
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
    public partial class Frm_EditProfile : Form
    {
        Crl_Menu crl_Menu;
        User_Managment managment_User;
        public Frm_EditProfile(Crl_Menu menu)
        {
            crl_Menu = menu;
            managment_User = new User_Managment();
            InitializeComponent();
            Init_Elements();
        }

        private void Init_Elements()
        {
            Pb_Image.Image = Image.FromFile(User_Current.GetUser().PictureAddress);
            Txt_Name.Text = User_Current.GetUser().Name;
            Txt_Password.Text = User_Current.GetUser().Password;
            Txt_Password.UseSystemPasswordChar = true;
        }

        private void Pb_Image_Click(object sender, EventArgs e)
        {
            ImageOperation.SetPictureBoxImage(Pb_Image);
        }

        private void Txt_Name_TextChanged(object sender, EventArgs e)
        {
            Lbl_ErrorFill.Visible = false;
        }

        private void Txt_Password_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Password.Text == "")
                Txt_Password.UseSystemPasswordChar = false;
            else
                Txt_Password.UseSystemPasswordChar = true;
            Lbl_ErrorFill.Visible = false;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            foreach (BunifuTextBox textBox in Pnl_Main.Controls.OfType<BunifuTextBox>())
            {
                if (textBox.Text == "")
                    Lbl_ErrorFill.Visible = true;
            }
            if (!Lbl_ErrorFill.Visible)
            {
                managment_User.EditUser(User_Current.GetUser(), Txt_Name.Text, Txt_Password.Text, Pb_Image.Image);
                crl_Menu.Init_Pnl_Info();
                crl_Menu.Init_Pnl_Accounts();
                this.Close();
            }
        }
    }
}
