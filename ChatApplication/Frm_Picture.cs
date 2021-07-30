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
    public partial class Frm_Picture : Form
    {
        public Frm_Picture(Image image)
        {
            InitializeComponent();
            Pb_Image.Image = image;
        }

        private void Pb_Image_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
