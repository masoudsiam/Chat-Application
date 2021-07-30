using BunifuAnimatorNS;
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
    public partial class Frm_Welcome : Form
    {
        public Frm_Main frm_Main;
        User_Managment managment_User;
        public Frm_Welcome()
        {
            managment_User = new User_Managment();
            InitializeComponent();
        }

        public void Show_Crl_EnterMethod()
        {
            Pnl_Middle.Controls.Clear();
            Crl_EnterMethod crl_EnterMethod = new Crl_EnterMethod(this);
            Pnl_Middle.Controls.Add(crl_EnterMethod);
        }

        public void Show_Crl_Login()
        {
            Pnl_Middle.Controls.Clear();
            Crl_Login crl_Login = new Crl_Login(this);
            Pnl_Middle.Controls.Add(crl_Login);
        }

        public void Show_Crl_Register()
        {
            Pnl_Middle.Controls.Clear();
            Crl_Register crl_Register = new Crl_Register(this);
            Pnl_Middle.Controls.Add(crl_Register);
        }

        private void Pb_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Pb_Close_Click(object sender, EventArgs e)
        {
            if (User_Current.GetUser() != null)
            {
                frm_Main.Show();
                this.Hide();
            }
            else
            {
                this.Close();
            }
        }

        private void Frm_Welcome_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
                Show_Crl_EnterMethod();
        }

        private void Frm_Welcome_Shown(object sender, EventArgs e)
        {
            if (managment_User.AutoSelectCurrentUser())
            {
                frm_Main = new Frm_Main(this);
                this.Hide();
                frm_Main.Show();
            }
        }
    }
}
