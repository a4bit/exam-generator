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
        private void submenuVis_Click(object sender, EventArgs e)
        {
            if (sender.Equals(createL))
                timer1.Start();
        }

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
        //-----------------------------------------------------------------------

        //TOP MENU BAR, CHANCE FONT SIZE WHEN ENTER
        private void topmenu_MouseEnter(object sender, EventArgs e)
        {
            Label temp = (Label)sender;

            if(temp.Equals(createL))
            {
                createL.Font = new Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            }
        }

        private void topmenu_MouseLeave(object sender, EventArgs e)
        {
            Label temp = (Label)sender;

            if (temp.Equals(createL))
            {
                createL.Font = new Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            }
        }
        //-----------------------------------------------------------------------

        //TOP MENU BAR, CHANGE COLOR WHEN CLICKED
        private void topmenu_MouseDown(object sender, MouseEventArgs e)
        {
            Label temp = (Label)sender;
            temp.BackColor = Color.White;
            temp.ForeColor = Color.DodgerBlue;
        }







        private void changeColorTopMen_MouseOver(object sender, EventArgs e)
        {
            Label temp = (Label)sender;
            temp.BackColor = Color.DodgerBlue;
            temp.ForeColor = Color.White;
        }
    }
}
