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
    public partial class Frm_NewChannel : Form
    {
        Crl_Menu crl_Menu;
        Channel_Managment managment_Channel;
        public Frm_NewChannel(Crl_Menu menu)
        {
            crl_Menu = menu;
            managment_Channel = new Channel_Managment();
            InitializeComponent();
        }

        private void Pb_Image_Click(object sender, EventArgs e)
        {
            ImageOperation.SetPictureBoxImage(Pb_Image);
        }

        private void Txt_Name_TextChanged(object sender, EventArgs e)
        {
            Lbl_ErrorFill.Visible = false;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Create_Click(object sender, EventArgs e)
        {
            if (Txt_Name.Text == "")
                Lbl_ErrorFill.Visible = true;
            else
            {
                managment_Channel.NewChannel(User_Current.GetUser(), Txt_Name.Text, Pb_Image.Image);
                crl_Menu.frm_Main.Show_Crl_ChatContainers();
                this.Close();
            }
        }
    }
}
