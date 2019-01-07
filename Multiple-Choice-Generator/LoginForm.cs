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
            database db = new database();
            List<string> list = new List<string>();
            list = db.login(loginUsernameTextbox.Text, loginPasswordTextbox.Text);
            if (list == null)
                MessageBox.Show("Λάθος κωδικός ή όνομα χρήστη!!");
            else
            {
                MessageBox.Show("Επιτυχής σύνδεση " + list.ElementAt(0));
                Form1 main = new Form1(list);
                main.Show();
                this.Hide();
            }
        }

        //CODE LINKLABEL FOR NAVIGATE TO SIGNUP URL
        private void LoginSignupLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.google.com");   //navigate to URL
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }
    }
}
