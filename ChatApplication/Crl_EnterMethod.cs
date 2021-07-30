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
    public partial class Crl_EnterMethod : UserControl
    {
        Frm_Welcome frm_Welcome;
        public Crl_EnterMethod(Frm_Welcome welcome)
        {
            frm_Welcome = welcome;
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            frm_Welcome.Show_Crl_Login();
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            frm_Welcome.Show_Crl_Register();
        }
    }
}
