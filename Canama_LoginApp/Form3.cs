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
    public partial class Form3 : Form
    {
        string user;
        string pass;
        public Form3()
        {
            InitializeComponent();
           
        }
        FaceRec fr = new FaceRec();
        LoginAppDataContext db = new LoginAppDataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            fr.openCamera(pbOpenCamera, pbCapturedImage);
        }

        private void button2_Click(object sender, EventArgs e)
        {     
            if(Fullname.Text != "")
            {
                fr.getPersonName(Fullname);
                fr.isTrained = true;               
            }
            else
            {
                MessageBox.Show("No Records Found!");
            }
           
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (Fullname.Text != "")
            {
                fr.getPersonName(Fullname);
                fr.isTrained = true;
                if (tbPass.Text != " ")
                {
                    if (db.sp_recogface(Fullname.Text, tbPass.Text).Count() > 0)
                    {
                        var result = db.sp_recogface(Fullname.Text, tbPass.Text);
                        foreach (var item in result)
                        {
                            user = item.Username;
                            pass = item.password;
                        }
                        if (db.sp_type(user,pass) == 0)
                        {
                            MessageBox.Show("Welcome Admin");
                        }
                        else
                        {
                            MessageBox.Show("Welcome Staff");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password is incorrect!");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Password First!");
                }
            }
            else
            {
                MessageBox.Show("No Records Found!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Log l = new Log();
            l.Show();
            this.Hide();
        }
    }
}
