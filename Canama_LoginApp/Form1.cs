using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;

namespace Canama_LoginApp
{
    public partial class Log : Form
    {
        LoginAppDataContext db = new LoginAppDataContext();
        public Log()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int result;
            result = db.sp_login(textBox1.Text, textBox2.Text).Count();
            if(result == 0)
            {
                MessageBox.Show("Unknown username or password");
            }
            else
            {
                if(db.sp_type(textBox1.Text, textBox2.Text) == 0)
                {
                    MessageBox.Show("Welcome Admin");
                }
                else
                {
                    MessageBox.Show("Welcome Staff");
                }
            }
        }

        private void registerform_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void facerecognitionPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}
