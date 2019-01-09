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
            errorLabel.Text = "";   //delete errors in label
            String username = this.loginUsernameTextbox.Text;
            String password = this.loginPasswordTextbox.Text;

            if(String.IsNullOrEmpty(username) || String.IsNullOrWhiteSpace(username) || String.IsNullOrEmpty(password) || String.IsNullOrWhiteSpace(password))
            {
                //error in login cause blank fields
                errorLabel.Text = "Συμπληρώστε τα απαιτούμενα πεδία και ξαναπροσπαθήστε.";
            }
            else
            {
                //send to database
                database db = new database();
                List<string> list = new List<string>();
                list = db.login(username, password);
                if (list == null)
                    errorLabel.Text = "Λάθος κωδικός ή όνομα χρήστη. Προσπαθήστε ξανά.";
                else
                {
                    Form1 main = new Form1(list);
                    main.Show();
                    this.Hide();
                }
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
