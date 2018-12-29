using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiple_Choice_Generator
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginConfigButton_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }

        //CODE LINKLABEL FOR NAVIGATE TO SIGNUP URL
        private void LoginSignupLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.google.com");   //navigate to URL
        }
    }
}
