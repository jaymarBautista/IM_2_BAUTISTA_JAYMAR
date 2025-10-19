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
    public partial class Form2 : Form
    {
        private MaskedTextBox mobileMask;
        private TextBox textboxFname;
        private TextBox textboxLname;
        private RadioButton buttonMale;
        private RadioButton buttonFmale;
        private ComboBox Combostatus;
        private DateTimePicker bdayDTP;
        private TextBox textBoxLoc;
        private string picture;
        public Form2(MaskedTextBox mobileMask2,
                     TextBox textboxFname2,
                     TextBox textboxLname2,
                     RadioButton buttonMale2,
                     RadioButton buttonFmale2,
                     ComboBox Combostatus2,
                     DateTimePicker bdayDTP2,
                     TextBox textBoxLoc2,
                     string pictureDialog
                     )
        {
            mobileMask = mobileMask2;
            textboxFname = textboxFname2;
            textboxLname =  textboxLname2;
            buttonMale = buttonMale2;
            buttonFmale = buttonFmale2;
            Combostatus = Combostatus2;
            bdayDTP = bdayDTP2;
            textBoxLoc = textBoxLoc2;
            picture = pictureDialog;

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            mobile.Text = mobileMask.Text;
            firstname.Text = textboxFname.Text;
            lastname.Text = textboxLname.Text;
            if (buttonMale.Checked)
            {
                male.Checked = buttonMale.Checked;
            } else if (buttonFmale.Checked)
            {
                female.Checked = buttonFmale.Checked;
            }
            status.Text = Combostatus.Text;
            birthday.Text = bdayDTP.Text;
            location.Text = textBoxLoc.Text;

            pictureBox1.Image = Image.FromFile(picture);
            
        }

       
    }
    }

