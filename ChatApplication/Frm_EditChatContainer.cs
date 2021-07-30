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
    public partial class Frm_EditChatContainer : Form
    {
        IChatContainer ChatContainer;
        ChatContainer_Editable_Managment Managment_Editable_ChatContainer;
        Crl_ChatContainer crl_ChatContainer;
        public Frm_EditChatContainer(IChatContainer container, Crl_ChatContainer chatContainer)
        {
            ChatContainer = container;
            Managment_Editable_ChatContainer = new ChatContainer_Editable_Managment();
            crl_ChatContainer = chatContainer;
            InitializeComponent();
            Init_Elements();
        }

        private void Init_Elements()
        {
            Pb_Image.Image = Image.FromFile(ChatContainer.PictureAddress);
            Txt_Name.Text = ChatContainer.Name;
        }

        private void Pb_Image_Click(object sender, EventArgs e)
        {
            ImageOperation.SetPictureBoxImage(Pb_Image);
        }

        private void Txt_Name_TextChange(object sender, EventArgs e)
        {
            Lbl_ErrorFill.Visible = false;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (Txt_Name.Text == "")
                Lbl_ErrorFill.Visible = true;
            else
            {
                Managment_Editable_ChatContainer.EditChatContainer(ChatContainer, Txt_Name.Text, Pb_Image.Image);
                crl_ChatContainer.Init_Elements();
                crl_ChatContainer.crl_ChatContainers.Init_Pnl_ChatContainers();
                this.Close();
            }
        }
    }
}
