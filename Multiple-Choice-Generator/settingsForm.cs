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
            this.MaximizeBox = false;
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


        private void button5_Click(object sender, EventArgs e)
        {
            if(settingsConfButton.Enabled == false)
            {
                this.settingsUsernameTextbox.Enabled = true;
                this.settingsEmailTextbox.Enabled = true;
                this.settingsPasswordTextbox.Enabled = true;
                this.settingsFirstnameTextbox.Enabled = true;
                this.settingsLastnameTextbox.Enabled = true;
                this.settingsGenderRadioButton1.Enabled = true;
                this.settingsGenderRadioButton2.Enabled = true;
                this.maskedTextBox.Enabled = true;
                this.settingsConfButton.Enabled = true;
                this.settingsEditButton.Text = "Ακύρωση";
                
            } else
            {
                ConfigForm configForm = new ConfigForm("Είστε σίγουρος ότι θέλετε να επιβεβαιώσετε την ακύρωση της επεξεργασίας; \nΌλες οι αλλαγές σας θα χαθούν.", "Ακύρωση", "Επιβεβαίωση", Color.Red, "Κλείσιμο");
                if (configForm.ShowDialog(this) == DialogResult.OK)
                {
                    this.settingsUsernameTextbox.Enabled = false;
                    this.settingsEmailTextbox.Enabled = false;
                    this.settingsPasswordTextbox.Enabled = false;
                    this.settingsFirstnameTextbox.Enabled = false;
                    this.settingsLastnameTextbox.Enabled = false;
                    this.settingsGenderRadioButton1.Enabled = false;
                    this.settingsGenderRadioButton2.Enabled = false;
                    this.maskedTextBox.Enabled = false;
                    this.settingsConfButton.Enabled = false;
                    this.settingsEditButton.Text = "Επεξεργασία";
                }
                configForm.Dispose();

            }
        }

        private void personalButton_Click(object sender, EventArgs e)
        {
            if(!this.personalPanel.Visible)
            {
                this.personalPanel.Visible= true;
                this.systemPanel.Visible = false;
            }
        }

        private void systemButton_Click(object sender, EventArgs e)
        {
            if(!this.systemPanel.Visible)
            {
                this.personalPanel.Visible = false;
                this.systemPanel.Visible = true;
            }
        }

        private void settingsForm_Load(object sender, EventArgs e)
        {
            this.OSLabel.Text = System.Environment.OSVersion.ToString();
            this.dateLabel.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
