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
    public partial class Frm_NewContact : Form
    {
        Crl_Menu crl_Menu;
        Contact_Managment managment_Contact;
        public Frm_NewContact(Crl_Menu menu)
        {
            crl_Menu = menu;
            managment_Contact = new Contact_Managment();
            InitializeComponent();
        }

        private void Txt_PhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txt_PhoneNumber_TextChanged(object sender, EventArgs e)
        {
            Lbl_NoUserFound.Visible = false;
            Lbl_ErrorFill.Visible = false;
            Lbl_AlreadyInContacts.Visible = false;
            Lbl_CantAddYourself.Visible = false;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (Txt_PhoneNumber.Text == "")
                Lbl_ErrorFill.Visible = true;
            else
            {
                NewContactResult newContactResult = managment_Contact.NewContact(User_Current.GetUser(), Txt_PhoneNumber.Text);
                if (newContactResult == NewContactResult.NoUserFound)
                    Lbl_NoUserFound.Visible = true;
                else if (newContactResult == NewContactResult.CantAddYourself)
                    Lbl_CantAddYourself.Visible = true;
                else if (newContactResult == NewContactResult.AlreadyInContacts)
                    Lbl_AlreadyInContacts.Visible = true;
                else
                {
                    crl_Menu.frm_Main.Show_Crl_ChatContainers();
                    this.Close();
                }
            }
        }
    }
}
