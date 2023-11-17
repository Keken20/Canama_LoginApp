using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;

namespace Canama_LoginApp
{
    public partial class Form2 : Form
    {
        LoginAppDataContext db = new LoginAppDataContext();
        public Form2()
        {
            InitializeComponent();
        }
        FaceRec fc = new FaceRec();
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtFname.Text == " " || txtLname.Text == " " || txtUsername.Text == " " || txtPassword.Text == " " || cbUserType.SelectedItem == null)
            {
                MessageBox.Show("Fill all informations", "Message");
            }
            else
            {
                
                fc.openCamera(pbOpencamera, pbImageCaptured);
                //db.sp_register(txtFname.Text, txtLname.Text,txtUsername.Text, txtPassword, cbUserType.SelectedItem,imagename);
            }
        }

        private void btnCaptureImage_Click(object sender, EventArgs e)
        {         
            if (txtFname.Text != "" || txtLname.Text != "")
            {
                string imagename = txtFname.Text + " " + txtLname.Text;                
                fc.Save_IMAGE(txtFname.Text + " " + txtLname.Text);
                fc.isTrained = true;
                db.sp_register(txtFname.Text, txtLname.Text, txtUsername.Text, txtPassword.Text, Convert.ToInt32(cbUserType.SelectedValue), imagename);
                MessageBox.Show("Saved Successfully", "Saved");
            }
            else
            {
                MessageBox.Show("Please fill name");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Log l = new Log();
            l.Show();
            this.Hide();
        }
    }
}
