using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Multiple_Choice_Generator.Properties;


namespace Multiple_Choice_Generator
{
    public partial class settingsForm : Form
    {

        Form father;    //father form
        public settingsForm(Form father)
        {
            InitializeComponent();
            this.father = father;
        }

        //SET sett IN FORM1 NULL
        private void settingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((Form1)this.father).setterSett = null;
        }


        //CHANGE THEME
        private void button2_Click(object sender, EventArgs e)
        {
            int temp = comboBox1.SelectedIndex;
            if (temp == 1)
            {
                Settings.Default["BackColor"] = Color.DimGray;
                Settings.Default["Filters"] = Color.Gray;
                Settings.Default["ButtonColor1"] = Color.Goldenrod;
            }
            else            
            {
                Settings.Default["BackColor"] = Color.DodgerBlue;
                Settings.Default["Filters"] = Color.SkyBlue;
                Settings.Default["ButtonColor1"] = Color.DodgerBlue;
            }                
            Settings.Default.Save();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            int temp = this.comboBox2.SelectedIndex;
            if (temp == 1)
                Settings.Default["Maximized"] = true;
            else
                Settings.Default["Maximized"] = false;
        }
    }
}
