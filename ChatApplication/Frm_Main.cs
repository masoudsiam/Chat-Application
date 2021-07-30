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
    public partial class Frm_Main : Form
    {
        Frm_Welcome frm_Welcome;
        public Frm_Main(Frm_Welcome welcome)
        {
            frm_Welcome = welcome;
            InitializeComponent();
            Show_Crl_ChatContainers();
        }

        public void Show_Crl_ChatContainers()
        {
            Pnl_Left.Controls.Clear();
            Crl_ChatContainers crl_ChatContainers = new Crl_ChatContainers(this);
            Pnl_Left.Controls.Add(crl_ChatContainers);
        }

        public void Show_Crl_Menu()
        {
            Pnl_Left.Controls.Clear();
            Crl_Menu crl_Menu = new Crl_Menu(this);
            Pnl_Left.Controls.Add(crl_Menu);
        }

        public void Show_Frm_Welcome()
        {
            this.Hide();
            frm_Welcome.Show();
        }

        public void Reset_Pnl_Right()
        {
            Pnl_Right.Controls.Clear();
        }

        public void Show_Crl_ChatContainer(Crl_ChatContainer crl_ChatContainer)
        {
            Pnl_Right.Controls.Clear();
            Pnl_Right.Controls.Add(crl_ChatContainer);
        }

        private void Pb_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pb_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Visible)
                Application.Exit();
        }
    }
}
