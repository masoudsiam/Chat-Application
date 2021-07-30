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
    public partial class Crl_Login : UserControl
    {
        Frm_Welcome frm_Welcome;
        User_Managment managment_User;
        public Crl_Login(Frm_Welcome welcome)
        {
            frm_Welcome = welcome;
            managment_User = new User_Managment();
            InitializeComponent();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            frm_Welcome.Show_Crl_EnterMethod();
        }

        private void HideErrorLabels()
        {
            Lbl_Already.Visible = false;
            Lbl_ErrorFill.Visible = false;
            Lbl_NoUserFound.Visible = false;
            Lbl_WrongPassword.Visible = false;
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
            HideErrorLabels();
        }

        private void Txt_Password_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Password.Text == "")
                Txt_Password.UseSystemPasswordChar = false;
            else
                Txt_Password.UseSystemPasswordChar = true;
            HideErrorLabels();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            foreach (BunifuTextBox textBox in Pnl_Main.Controls.OfType<BunifuTextBox>())
            {
                if (textBox.Text == "")
                    Lbl_ErrorFill.Visible = true;
            }
            if (!Lbl_ErrorFill.Visible)
            {
                LoginResult loginResult = managment_User.Login(Txt_PhoneNumber.Text, Txt_Password.Text);
                if (loginResult == LoginResult.NoUserFound)
                    Lbl_NoUserFound.Visible = true;
                else if (loginResult == LoginResult.WrongPassword)
                    Lbl_WrongPassword.Visible = true;
                else if (loginResult == LoginResult.AlreadyLoggedIn)
                    Lbl_Already.Visible = true;
                else
                {
                    if (frm_Welcome.frm_Main != null)
                        frm_Welcome.frm_Main.Close();
                    frm_Welcome.frm_Main = new Frm_Main(frm_Welcome);
                    frm_Welcome.Hide();
                    frm_Welcome.frm_Main.Show();
                }
            }
        }
    }
}
