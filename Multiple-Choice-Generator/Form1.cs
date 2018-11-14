using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Multiple_Choice_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            
        }

        //-----------------------------------------------------------------------
        //CODE FOR MOVE FORM WITH DRAG
        int mov;
        int movX;
        int movY;
        int test = 0;
        //load my screen and workingarea location
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
        }

        //set movX and movY with mouse current possition when mouse is down
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        // set mov 0 to stop move the form when mouse is up
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        //while mouse is down (mov=1) when mouse move, move form
        //-10 and -31 because there is some problem with exatly possition
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
                this.SetDesktopLocation(MousePosition.X - movX-10, MousePosition.Y - movY - 31);
        }
        //-----------------------------------------------------------------------

        //TOP MENU BAR, SHOW DROP DOWN LIST WITH EFFECT
        bool createflag = false;
        bool editflag = false;

        //when left clicked pressed call timer
        private void topmenu_MouseClick(object sender, MouseEventArgs e)
        {
            Label temp = (Label)sender;
            temp.Focus();   //set focus to selected label
            //check if ckicked was left
            if (e.Button == MouseButtons.Left)
            {
                if (sender.Equals(createL))
                    timer1.Start();
                else if (sender.Equals(editL))
                    timer2.Start();
            }
        }

        //when it loose focus call timer to close submenu
        private void topmenu_Leave(object sender, EventArgs e)
        {
            Label temp = (Label)sender;
            if (createflag)
                timer1.Start();
            else if (editflag)
                timer2.Start();
        }

        //effect for create submenu (createSubMenuP)
        private void timer1_Tick(object sender, EventArgs e)
        {
            //if dropdown menu is open then close
            if(createflag)
            {
                createSubMenuP.Height -= 21;
                if (createSubMenuP.Height == 0)
                {
                    timer1.Stop();
                    createflag = false;
                    //return to blue background, we put the code here because it happend after close dropdown effect
                    createL.BackColor = Color.DodgerBlue;
                    createL.ForeColor = Color.White;
                }
            }
            //if dropdown menu is close then open
            else if(!createflag)
            {
                createSubMenuP.Height += 21;
                if(createSubMenuP.Height==105)
                {
                    timer1.Stop();
                    createflag = true;
                }
            }
        }

        //effect for edit submenu (editSubMenuP)
        private void timer2_Tick(object sender, EventArgs e)
        {
            //if dropdown menu is open then close
            if (editflag)
            {
                editSubMenuP.Height -= 21;
                if (editSubMenuP.Height == 0)
                {
                    timer2.Stop();
                    editflag = false;
                    //return to blue background, we put the code here because it happend after close dropdown effect
                    editL.BackColor = Color.DodgerBlue;
                    editL.ForeColor = Color.White;
                }
            }
            //if dropdown menu is close then open
            else if (!editflag)
            {
                editSubMenuP.Height += 21;
                if (editSubMenuP.Height == 105)
                {
                    timer2.Stop();
                    editflag = true;
                }
            }
        }
        //-----------------------------------------------------------------------

        //TOP MENU BAR, CHANCE FONT SIZE WHEN ENTER
        private void topmenu_MouseEnter(object sender, EventArgs e)
        {
            Label temp = (Label)sender;
                temp.Font = new Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));            
        }

        private void topmenu_MouseLeave(object sender, EventArgs e)
        {
            Label temp = (Label)sender;
            temp.Font = new Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));            
        }
        //-----------------------------------------------------------------------

        //TOP MENU BAR, CHANGE COLOR WHEN CLICKED
        private void topmenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label temp = (Label)sender;
                temp.BackColor = Color.White;
                temp.ForeColor = Color.DodgerBlue;
            }
        }
        //-----------------------------------------------------------------------

        //PLACEHOLDER FOR SEARCH TEXTBOX
        private void searchTBPLaceholder_Enter(object sender, EventArgs e)
        {
            if(searchTB.Text.Equals("Search..."))
            searchTB.Text = "";
        }

        private void searchTBPlaceholder_Leave(object sender, EventArgs e)
        {
            if (searchTB.Text.Equals(""))
                searchTB.Text = "Search...";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text !="")   //// Αν δεν ειναι καινό το Textbox πρόσθεσε το περιεχόμενο του στο listbox αλλιώς εκτύπωση μήνυμα λάθους
            {
                
                listBox1.Items.Add(++test+". "+textBox1.Text);
                textBox1.Focus();
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Παρακαλώ πληκρολόγησε την ερώτηση που θέλεις να προσθέσεις στο διαγώνισμα","Error",MessageBoxButtons.OK);
                textBox1.Focus();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)   //// Αν δεν ειναι καινό το Textbox πρόσθεσε το περιεχόμενο του στο listbox αλλιώς εκτύπωση μήνυμα λάθους
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                textBox1.Focus();
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Επέλεξε την ερώτηση θέλεις να διαγράψεις", "Error", MessageBoxButtons.OK);
                textBox1.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void leftmenuP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void helpB_Click(object sender, EventArgs e)
        {

        }

        private void logoL_Click(object sender, EventArgs e)
        {

        }

        private void titleL_Click(object sender, EventArgs e)
        {

        }

        private void settingsB_Click(object sender, EventArgs e)
        {

        }

        private void logoutB_Click(object sender, EventArgs e)
        {

        }

        private void testB_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            groupBox1.Visible = false;
        }

        private void questionsB_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            groupBox1.Visible = true;
        }

        private void createL_Click(object sender, EventArgs e)
        {

        }

        private void createSubMenuP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void create_questionL_Click(object sender, EventArgs e)
        {

        }

        private void topmenuP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void editL_Click(object sender, EventArgs e)
        {

        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void editSubMenuP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //-----------------------------------------------------------------------



    }
}
