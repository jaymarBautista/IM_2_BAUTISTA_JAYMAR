using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMCARDREGISTRATION
{
    public partial class Birthday : Form
    {
        private string imagePath = "";
        public Birthday()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(mobile, firstname, lastname, male, female, status,bday, location, imagePath );
            frm2.Show();
        }

        private void buttonpicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Open an Image File";
            dialog.Filter = "Image Files | *.jpg;*.jpeg;*.png";
            DialogResult dr = dialog.ShowDialog();

            if ( dr == DialogResult.OK)
            {
                imagePath = dialog.FileName;  
                MessageBox.Show("Uploaded");
            }
        }

       
    }
}
