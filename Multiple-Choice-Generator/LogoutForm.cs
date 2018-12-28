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
    public partial class LogoutForm : Form
    {
        Form father = null;
        public LogoutForm(Form father)
        {            
           InitializeComponent();
            this.father = father;
        }

        //application exit
        private void yesButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //close only logout form
        private void noButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //enable father form on close
        private void LogoutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            father.Enabled = true;
        }
    }
}
