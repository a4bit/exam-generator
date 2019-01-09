/*Ο κώδικας είναι οργανωμένος κατά ενότητες. Κάθε ενότητα χωρίζεται ξεκινάει με τον τίτλο της σε σχόλιο και "-----" στην επόμενη γραμμή.
 * Κάθε μέθοδος έχει μια σύντομη περίληψη στην ακριβώς πάνω γραμμή σαν σχόλιο.
   Επίσης υπάρχουν επιπλέον βοηθητικά σχόλια*/


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Multiple_Choice_Generator.Properties;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Multiple_Choice_Generator
{
    public partial class Form1 : Form
    {
        database db = new database();

        //lists from database
        private List<string> user = new List<string>();
        private List<string> lessons = new List<string>();
        private List<string> categories = new List<string>();
        private List<string> questions = new List<string>();

        //object for Utils
        Utils myutils = new Utils();


        public Form1(List<string> a)
        {
            InitializeComponent();
            user = a;
            this.DoubleBuffered = true; //fix gradiend resize problem
            temp = panel1;
        }

        Panel temp; //which of main panels is visible now

        //Array for newsLabel text
        String[] newsArr = {"Για οποιαδίποτε απορία ή πρόβλημα επικοινωνήστε μαζί μας στο email example@gmail.com",
            "Για οποιαδίποτε πληροφορία συμβουλευτείτε τον οδηγό. Θα τον βρείτε κάτω αριστερά.",
            "Multiple Choice Generator, η καλύτερη πλατφόρμα για δημιουργία, αποθήκευση και οργάνωση ερωτήσεων και διαγωνισμάτων πολλαπλής επιλογής.",
            "Μπορείτε να πραγματοποιήσετε αλλαγές στην εμφάνιση του συστήματος από τις ρυθμίσεις.",
            "Μπορείτε να κάνετε αλλαγές στα προσωπικά σας στοιχεία από τις ρυθμίσεις."};
        



        //LOAD FORM1 AND DO SOME THINGS IN THE START OF APP
        //-----------------------------------------------------------------------
        int mov;
        int movX;
        int movY;
        //load my screen and workingarea location
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'multipleDataSet1.questions' table. You can move, or remove it, as needed.
            this.questionsTableAdapter1.Fill(this.multipleDataSet1.questions);
            // TODO: This line of code loads data into the 'multipleDataSet.questions' table. You can move, or remove it, as needed.
            this.questionsTableAdapter.Fill(this.multipleDataSet.questions);
            //load my screen and workingarea location
            this.Location = Screen.AllScreens[0].WorkingArea.Location;

            //button ellipes
            System.Drawing.Drawing2D.GraphicsPath ellipseRadius = new System.Drawing.Drawing2D.GraphicsPath();
            ellipseRadius.StartFigure();
            ellipseRadius.AddArc(new Rectangle(0, 0, 20, 20), 180, 90);
            ellipseRadius.AddLine(20, 0, createQuestionConfigButton.Width - 20, 0);
            ellipseRadius.AddArc(new Rectangle(createQuestionConfigButton.Width - 20, 0, 20, 20), -90, 90);
            ellipseRadius.AddLine(createQuestionConfigButton.Width, 20, createQuestionConfigButton.Width, createQuestionConfigButton.Height - 20);
            ellipseRadius.AddArc(new Rectangle(createQuestionConfigButton.Width - 20, createQuestionConfigButton.Height - 20, 20, 20), 0, 90);
            ellipseRadius.AddLine(createQuestionConfigButton.Width - 20, createQuestionConfigButton.Height, 20, createQuestionConfigButton.Height);
            ellipseRadius.AddArc(new Rectangle(0, createQuestionConfigButton.Height - 20, 20, 20), 90, 90);
            ellipseRadius.CloseFigure();
            createQuestionConfigButton.Region = new Region(ellipseRadius);

            //leftmenu news bar
            this.newsLabel.Text = newsArr[0];
            this.newsTimer.Start();

            

            //call loadLessons
            this.loadLessons();

        }

        //LOAD LESSONS FROM DATABASE AND FILL COMBOBOXES
        private void loadLessons()
        {
            //load lessons            
            this.lessons = myutils.loadlessons(user.ElementAt(0));

            this.createAutoTestLessonComboBox.Items.Clear();
            this.createQuestionLessonCombobox.Items.Clear();
            this.createManualTestComboBox.Items.Clear();
            this.showQuestionLessonCombobox.Items.Clear();
            foreach (String lesson in this.lessons)
            {
                this.createAutoTestLessonComboBox.Items.Add(lesson);
                this.createQuestionLessonCombobox.Items.Add(lesson);
                this.createManualTestComboBox.Items.Add(lesson);
                this.showQuestionLessonCombobox.Items.Add(lesson);
            }   
        }



        //EXIT APLLICATION WHEN THIS FORM CLOSE
        //-----------------------------------------------------------------------
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



        //SELECTED THEME
        //-----------------------------------------------------------------------
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            leftmenuP.BackColor = (Color)Settings.Default["BackColor"];
            topmenuP.BackColor = (Color)Settings.Default["BackColor"];
            showQuestionsFilterButton.BackColor = (Color)Settings.Default["Filters"];
            showQuestionsFilterPanel.BackColor = (Color)Settings.Default["Filters"];
            createQuestionConfigButton.BackColor = (Color)Settings.Default["ButtonColor1"];
            questionsB.BackColor = (Color)Settings.Default["ButtonColor1"];
            testB.BackColor = (Color)Settings.Default["ButtonColor1"];

            //topmenu
            createL.BackColor = (Color)Settings.Default["BackColor"];
            createQuestionL.BackColor = (Color)Settings.Default["BackColor"];
            createLessonL.BackColor = (Color)Settings.Default["BackColor"];
            createTestL.BackColor = (Color)Settings.Default["BackColor"];
            editL.BackColor = (Color)Settings.Default["BackColor"];
            editQuestionL.BackColor = (Color)Settings.Default["BackColor"];
            editLessonL.BackColor = (Color)Settings.Default["BackColor"];
            editTestL.BackColor = (Color)Settings.Default["BackColor"];

        }



        //SET FOCUS TO ITEMS WHEN THEY DON'T TAKE IT AUTOMATIC
        //-----------------------------------------------------------------------
        private void setfocus_Click(object sender, EventArgs e)
        {
            //we set focus to components only if a subMenu or filterPanel is open
            if (createSubMenuP.Height != 0 || editSubMenuP.Height != 0 || showQuestionsFilterPanel.Width != 0 || createManualTestFilterPanel.Width != 0)
            {
                if (sender.Equals(leftmenuP))
                    leftmenuP.Focus();
                else if (sender.Equals(topmenuP))
                    topmenuP.Focus();
                else if (sender.Equals(titleL))
                    titleL.Focus();
                else if (sender.Equals(createQuestionPanel))
                    createQuestionPanel.Focus();
                else if (sender.Equals(createManualTestPanel))
                    createManualTestPanel.Focus();
                else if (sender.Equals(createAutoTestPanel))
                    createAutoTestPanel.Focus();
                else if (sender.Equals(showQuestionsPanel))
                    showQuestionsPanel.Focus();
                else if (sender.Equals(createLessonPanel))
                    createLessonPanel.Focus();
                else if (sender.Equals(createTestPanel))
                    createTestPanel.Focus();
            }
        }


        #region CODE FOR MOVE FORM WITH DRAG AND BUTTON DESIGN
        
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
        #endregion


        #region TOP MENU BAR EFFECTS

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
        private void createSubMenuTimer(object sender, EventArgs e)
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
                    createL.BackColor = (Color)Settings.Default["BackColor"];
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
        private void editSubMenuTimer(object sender, EventArgs e)
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
                    editL.BackColor = (Color)Settings.Default["BackColor"];
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

        //top menu, change font size when enter
        private void topmenu_MouseEnter(object sender, EventArgs e)
        {
            Label temp = (Label)sender;
                temp.Font = new Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));            
        }

        //reset font when leave
        private void topmenu_MouseLeave(object sender, EventArgs e)
        {
            Label temp = (Label)sender;
            temp.Font = new Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));            
        }

        //change color when click in top bar menu
        private void topmenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label temp = (Label)sender;
                temp.BackColor = Color.White;
                temp.ForeColor = Color.DodgerBlue;
            }
        }
     
        //placeholder for topbar search textbox and set text to empty when we enter
        private void searchTBPLaceholder_Enter(object sender, EventArgs e)
        {
            if(searchTB.Text.Equals("Search..."))
            searchTB.Text = "";
        }

        //reset placeholder on topbar menu when we leave and textbox is empty
        private void searchTBPlaceholder_Leave(object sender, EventArgs e)
        {
            if (searchTB.Text.Equals(""))
                searchTB.Text = "Search...";
        }
        #endregion


        #region CODE BUTTONS TO CALL FORMS

        //call logooutForm or focus
        private void logoutB_Click(object sender, EventArgs e)
        {
            ConfigForm configForm = new ConfigForm("Είστε σίγουρος ότι θέλετε να κλείσετε την εφαρμογή;", "Ακύρωση", "Κλείσιμο", Color.Red, "Κλείσιμο");
            if (configForm.ShowDialog(this) == DialogResult.OK)
            {
                Application.Exit();                
            }            
            configForm.Dispose();
        }


        //call settingsForm or set focus  
        private Form sett = null;
        public Form setterSett
        {
            //need this setter to sett=null from settingsForm
            set
            {
                sett = value;
            }
        }
        private void settingsB_Click(object sender, EventArgs e)
        {
            if (sett != null)
            {
                if (sett.WindowState == FormWindowState.Minimized)
                    sett.WindowState = FormWindowState.Normal;
                else
                    sett.Focus();
            }
            else
            {
                sett = new settingsForm(this);
                sett.Show();
            }
        }

        //open infoForm or focus
        private Form info = null;
        public Form setterinfo
        {
            //need this setter to info=null from infoForm
            set
            {
                info = value;
            }
        }
        private void helpB_Click(object sender, EventArgs e)
        {
            if (info != null)
            {
                if (info.WindowState == FormWindowState.Minimized)
                    info.WindowState = FormWindowState.Normal;
                else
                    info.Focus();
            }
            else
            {
                info = new infoForm(this);
                info.Show();
            }
        }

        #endregion


        #region CODE SUBMENUS BUTTONS AND OTHER BUTTONS TO CALL THEIR PANELS

        //call createqiestionPanel  and close submenu
        private void create_questionL_Click(object sender, EventArgs e)
        {
            temp.Visible = false;   //set current panel not visible
            createQuestionPanel.Visible = true; //set createQuestionPanel visible            
            temp = createQuestionPanel; //set new temp panel
            timer1.Start(); //close createSubMenuP
        }

        //call createLessonPanel and close submenu
        private void lessonL_Click(object sender, EventArgs e)
        {
            temp.Visible = false;   //set current panel not visible
            createLessonPanel.Visible = true;   //set createLessonPanel visible            
            temp = createLessonPanel; //set new temp panel
            timer1.Start(); //close createSubMenuP
        }

        //call createTestPanel and close submenu
        private void createTestL_Click(object sender, EventArgs e)
        {
            temp.Visible = false;
            createTestPanel.Visible = true;            
            temp = createTestPanel;
            timer1.Start(); //close createSubMenuP
        }

        //call editLessonPanel and close submenu
        private void editLessonL_Click(object sender, EventArgs e)
        {
            timer2.Start(); //close editSubMenuP
        }

        //call editQuestionPanel and close submenu
        private void editQuestionL_Click(object sender, EventArgs e)
        {
            timer2.Start(); //close editSubMenuP
        }

        //call editTestPanel and close submenu
        private void editTestL_Click(object sender, EventArgs e)
        {
            timer2.Start(); //close editSubMenuP
        }

        //call showQuestionsPanel
        private void questionsB_Click(object sender, EventArgs e)
        {
            temp.Visible = false;
            showQuestionsPanel.Visible = true;
            temp = showQuestionsPanel;
        }
        
        //call createAutoTestPanel
        private void button1_Click(object sender, EventArgs e)
        {
            temp.Visible = false;
            createAutoTestPanel.Visible = true;
            temp = createAutoTestPanel;
        }

        //call createManualTestPanel
        private void button2_Click(object sender, EventArgs e)
        {
            createManualTestPanel.Visible = true;
            temp.Visible = false;
            temp = createManualTestPanel;
        }

        #endregion


        #region METHODS OF showQuestionsPanel
        //-----------------------------------------------------------------------
        //code showQuestionsFilterConfButton
        private void showQuestionsFilterConfButton_Click(object sender, EventArgs e)
        {
            filtersButtonFlag = 'S';
            filtersTimer.Start();
        }

        //open filter panel of showQuestionPanel
        private void showQuestionsFilterButton_Click(object sender, EventArgs e)
        {
            this.filtersButtonFlag = 'S';
            filtersTimer.Start();
        }

        private void showQuestionLessonCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.showQuestionCategoryCheckbox.Items.Clear();
            categories = myutils.loadcategories(user.ElementAt(0), this.showQuestionLessonCombobox.Text);

            foreach(String category in categories)
            {
                this.showQuestionCategoryCheckbox.Items.Add(category);
            }

            List<string>[] viewQuestions = new List<string>[4];
            viewQuestions = db.qQuestionsMore(user.ElementAt(0), this.showQuestionLessonCombobox.Text, this.showQuestionCategoryCheckbox.Text, 2);
            for (int i=0; i < viewQuestions[0].Count; i++)
            {
                showQuestionDataGridView.Rows[i].Cells[0].Value = viewQuestions[0].ElementAt(i);
                showQuestionDataGridView.Rows[i].Cells[1].Value = viewQuestions[1].ElementAt(i);
                showQuestionDataGridView.Rows[i].Cells[2].Value = viewQuestions[2].ElementAt(i);
                switch(int.Parse(viewQuestions[3].ElementAt(i)))
                {
                    case 1:
                        showQuestionDataGridView.Rows[i].Cells[3].Value = "Εύκολη";
                        break;
                    case 2:
                        showQuestionDataGridView.Rows[i].Cells[3].Value = "Μέτρια";
                        break;
                    case 3:
                        showQuestionDataGridView.Rows[i].Cells[3].Value = "Δύσκολη";
                        break;
                }
                
            }

        }
        #endregion


        #region METHODS OF createQuestionPanel
        //set richTextBox test to webBrowser
        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            webBrowser1.DocumentText = createQuestionRichTextBox.Text;
        }

        //number of max answers
        private static int maxAnswers = 4;  //max answers allowed-1, (ex if maxAnswers=4 then the real maxAnswers are 6 cause first 2 textboxes don't content in array)
        TextBox[] textboxes = new TextBox[maxAnswers];    //array with textboxes (first and second textboxes don't content in array) 
        int n = 0;        
        int textboxY; //last textbox height location
        bool flagerrorsVisible = false;  //need this flag for corrext errors location

        //create textboxes when pess the button createTextBoxButton
        private void createTextBoxButton_Click(object sender, EventArgs e)
        {
            if (n < maxAnswers)
            {
                //get the locationY from last textBox
                if(n > 0)
                {
                    textboxY = textboxes[n-1].Location.Y;
                }
                else
                {
                    textboxY = createQuestionTextBox2.Location.Y;
                }

                //create textbox and set propeties
                textboxes[n] = new TextBox();
                this.createQuestionPanel.Controls.Add(textboxes[n]);
                this.textboxes[n].Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                this.textboxes[n].Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
                this.textboxes[n].Location = new System.Drawing.Point(createQuestionTextBox2.Location.X, textboxY+54);                 
                this.textboxes[n].Margin = new System.Windows.Forms.Padding(22, 3, 22, 3);
                this.textboxes[n].Multiline = true;
                this.textboxes[n].Name = "createQuestionTextBox" + (n+3);
                this.textboxes[n].ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
                this.textboxes[n].Size = new System.Drawing.Size(createQuestionTextBox2.Size.Width, createQuestionTextBox2.Size.Height);
                this.textboxes[n].TabIndex = n + 9;

                this.createQuestionConfigButton.Location = new System.Drawing.Point(createQuestionConfigButton.Location.X, textboxY + 167); //move config button down              
                this.createTextboxPictureBox.Location = new System.Drawing.Point(createTextboxPictureBox.Location.X, textboxY + 108); //move add textbox button down
                this.deleteTextboxPictureBox.Location = new System.Drawing.Point(deleteTextboxPictureBox.Location.X, textboxY + 108); //move dellete textbox button down

                

                this.deleteTextboxPictureBox.Enabled = true; //set deleteTextBoxButton enable

                //enable deleteTextBoxButton if disable
                if (!this.deleteTextboxPictureBox.Enabled)
                    this.deleteTextboxPictureBox.Enabled = true;

                //disable createTextBoxButton if textBoxes == max answers
                if (n == maxAnswers - 1)
                    this.createTextboxPictureBox.Enabled = false;

                n++;                
            }            
        }       

        //delete textboxes when pressthe button deleteTextBoxButton
        private void deleteTextBoxButton_Click(object sender, EventArgs e)
        {
            if(n>0)
            {
                n--;
                textboxes[n].Visible = false;
                textboxes[n] = null;
                this.createQuestionConfigButton.Location = new System.Drawing.Point(createQuestionConfigButton.Location.X, createQuestionConfigButton.Location.Y-54); //move config button up
                this.createTextboxPictureBox.Location = new System.Drawing.Point(createTextboxPictureBox.Location.X, createTextboxPictureBox.Location.Y-54); //move add textbox button up               
                this.deleteTextboxPictureBox.Location = new System.Drawing.Point(deleteTextboxPictureBox.Location.X, deleteTextboxPictureBox.Location.Y-54); //move deleteTextButton up

               

                //enabe createTextBoxButton when delete 1 textbox if disable
                if (!this.createTextboxPictureBox.Enabled)
                    this.createTextboxPictureBox.Enabled = true;

                //disable add button to when you have 2 answers
                if (n == 0)
                {
                    this.deleteTextboxPictureBox.Enabled = false;
                }
            }            
        }

        //createQuestionConfigButton Code
        private void createQuestionConfigButton_Click(object sender, EventArgs e)
        {
            createQuestionPanel.Focus();    //set focus to panel so button not stay focus

            createQuestionErrorsLabel.Visible = false;
            label18.Visible = false;

            //get question's lesson
            String lesson = createQuestionLessonCombobox.Text;

            //get question's category
            String category = createQuestionCategoryCombobox.Text;

            //get question's difficulty
            int difficulty;
            if (createQuestionRadioButton1.Checked)
                difficulty = 1;
            else if (createQuestionRadioButton2.Checked)
                difficulty = 2;
            else
                difficulty = 3;

            //get question
            String question = createQuestionRichTextBox.Text;

            //get answers            
            String[] answers = new String[n+2];
            answers[0] = createQuestionTextBox1.Text;
            answers[1] = createQuestionTextBox2.Text;            
            for(int i=0; i<n; i++)
            {
                answers[i + 2] = textboxes[i].Text;
            }

            //check if we there are errors
            bool checkflag = true;
            bool[] errors = myutils.createQuestionConfirmation(question, lesson, category, difficulty, answers);

            //if there are errors write them to label
            this.createQuestionErrorsLabel.Text = "";
            if(errors[0])
            {
                checkflag = false;
                createQuestionErrorsLabel.Text += "Δεν μπορείτε να καταχωρήσετε κενή ερώτηση.\n";
            }
            if (errors[1])
            {
                checkflag = false;
                createQuestionErrorsLabel.Text += "Πρέπει να επιλέξετε μάθημα για την εισαγωγή ερώτησης.\n";
            }
            if (errors[2])
            {
                checkflag = false;
                createQuestionErrorsLabel.Text += "Δε μπορείτε να καταχωρήσετε κενή απάντηση, σβήστε την ή συμπληρώστε την.\n";
            }

            if (!checkflag)
            {                
                //code for error
                label18.Visible = true;
                createQuestionErrorsLabel.Visible = true;                
            }
            else
            {
                //code for send to database
                List<string> answerslist = new List<string>();
                
                answerslist.Add(this.createQuestionTextBox1.Text);
                answerslist.Add(this.createQuestionTextBox2.Text);
                for(int i=0; i<n; i++)
                    answerslist.Add(this.textboxes[i].Text);

                int check = db.iQuestion(user.ElementAt(0),question, answerslist, lesson, category,difficulty); //send to database


                if (check == 1)
                {
                    //set some fields to blank
                    this.createQuestionRichTextBox.Text = "";
                    this.createQuestionTextBox1.Text = "";
                    this.createQuestionTextBox2.Text = "";
                    for (int i = 0; i < n; i++)
                        textboxes[i].Text = "";
                    
                    MessageBox.Show("Η ερώτηση καταχωρήθηκε με επιτυχία!");
                } else if (check == 0)
                    createQuestionErrorsLabel.Text = "Αδυναμία σύνδεσης στη βάση!";
                else if (check == -1)
                    createQuestionErrorsLabel.Text = "Δεν υπάρχει η ενότητα!";
                else
                    createQuestionErrorsLabel.Text = "Υπήρξε πρόβλημα. Δεν καταχωρήθηκε η ερώτηση!!";
            }

            

           

        }        
        //change image when mouse enter
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            PictureBox temp = (PictureBox)sender;
            temp.Image = Resources.icon_plus_enter;
        }

        //reset image when mouse leave
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            PictureBox temp = (PictureBox)sender;
            temp.Image = Resources.icon_plus;
        }

        //set image when mouse is down
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox temp = (PictureBox)sender;
            temp.Image = Resources.icon_plus_pressed;
        }

        //change img when mouse is up
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox temp = (PictureBox)sender;
                temp.Image = Resources.icon_plus;

        }

        //change img when mouse enter
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            PictureBox temp = (PictureBox)sender;
            temp.Image = Resources.icon_negative_enter;
        }

        //change img when mouse leave
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            PictureBox temp = (PictureBox)sender;
            this.deleteTextboxPictureBox.Image = Resources.icon_negative;
        }

        //change img when mouse is down
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox temp = (PictureBox)sender;
            temp.Image = Resources.icon_negative_press;
        }

        //change img ehen mouse is up
        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox temp = (PictureBox)sender;
            temp.Image = Resources.icon_negative;
        }



        //load categories when we choose lesson
        private void createQuestionLessonCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.createQuestionCategoryCombobox.Items.Clear();
            String lesson = this.createQuestionLessonCombobox.Text;
            //load categories
            categories = myutils.loadcategories(user.ElementAt(0), lesson);
            foreach (String category in this.categories)
            {
                this.createQuestionCategoryCombobox.Items.Add(category);
            }
        }

        #endregion

        #region METHODS OF createLessonPanel
        //methods of add and delete buttons for change the image (eg mouseover) are on createQuestionPanel region cause they first created there!

        int categoryCount = 0;  //current categories

        //code for add category textbox and move buttons
        TextBox[] createLessonCategoriesTextboxes = new TextBox[50];
        int createLessonCategoriesMax = 50;
        int createLessonCategoriesCount = 0;
        private void createLessonAddPictureBox_Click(object sender, EventArgs e)
        {
            if(createLessonCategoriesCount < createLessonCategoriesMax)
            {

                //get last textbox Y
                int textboxY;
                if (createLessonCategoriesCount > 0)
                    textboxY = this.createLessonCategoriesTextboxes[createLessonCategoriesCount - 1].Location.Y;
                else
                    textboxY = this.createLessonCategoryTextbox.Location.Y;

                //create category textbox
                createLessonCategoriesTextboxes[createLessonCategoriesCount] = new TextBox();
                this.createLessonPanel.Controls.Add(createLessonCategoriesTextboxes[createLessonCategoriesCount]);
                createLessonCategoriesTextboxes[createLessonCategoriesCount].Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                createLessonCategoriesTextboxes[createLessonCategoriesCount].Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
                createLessonCategoriesTextboxes[createLessonCategoriesCount].Location = new System.Drawing.Point(41, textboxY + 36);
                createLessonCategoriesTextboxes[createLessonCategoriesCount].Margin = new System.Windows.Forms.Padding(22, 3, 22, 3);
                createLessonCategoriesTextboxes[createLessonCategoriesCount].MaxLength = 100;
                createLessonCategoriesTextboxes[createLessonCategoriesCount].Name = "createLessonCategoryTextbox" + (this.createLessonCategoriesCount + 2);                
                createLessonCategoriesTextboxes[createLessonCategoriesCount].Size = new System.Drawing.Size(this.createLessonCategoryTextbox.Size.Width, this.createLessonCategoryTextbox.Size.Height);
                createLessonCategoriesTextboxes[createLessonCategoriesCount].TabIndex = this.createLessonCategoriesCount + 3;

                createLessonCategoriesCount++;  //count++

                //move objects down
                this.createLessonDeletePictureBox.Location = new Point(this.createLessonDeletePictureBox.Location.X, this.createLessonDeletePictureBox.Location.Y + 36); //move delete button
                this.createLessonAddPictureBox.Location = new Point(this.createLessonAddPictureBox.Location.X, this.createLessonAddPictureBox.Location.Y + 36);  //move add button
                this.createLessonErrorLabel.Location = new Point(this.createLessonErrorLabel.Location.X, this.createLessonErrorLabel.Location.Y + 36);     //move error label
                this.createLessonErrorTitleLabel.Location = new Point(this.createLessonErrorTitleLabel.Location.X, this.createLessonErrorTitleLabel.Location.Y + 36);       //move error titlelabel
                this.createLessonConfButton.Location = new Point(this.createLessonConfButton.Location.X, this.createLessonConfButton.Location.Y + 36);     //move config


                //enable delete button if it's not
                if (!this.createLessonDeletePictureBox.Enabled)
                    this.createLessonDeletePictureBox.Enabled = true;

                //disable when count = max number
                if (createLessonCategoriesCount == createLessonCategoriesMax)
                    this.createLessonAddPictureBox.Enabled = false;
            }
        }

        //code for delete category textbox and move buttons
        private void createLessonDeletePictureBox_Click(object sender, EventArgs e)
        {
            if (this.createLessonCategoriesCount > 0)
            {
                this.createLessonCategoriesCount--;

                //delete last textbox
                this.createLessonCategoriesTextboxes[this.createLessonCategoriesCount].Dispose();
                this.createLessonCategoriesTextboxes[this.createLessonCategoriesCount] = null;

                //move objects up
                this.createLessonDeletePictureBox.Location = new Point(this.createLessonDeletePictureBox.Location.X, this.createLessonDeletePictureBox.Location.Y - 36); //move delete button
                this.createLessonAddPictureBox.Location = new Point(this.createLessonAddPictureBox.Location.X, this.createLessonAddPictureBox.Location.Y - 36);  //move add button
                this.createLessonErrorLabel.Location = new Point(this.createLessonErrorLabel.Location.X, this.createLessonErrorLabel.Location.Y - 36);     //move error label
                this.createLessonErrorTitleLabel.Location = new Point(this.createLessonErrorTitleLabel.Location.X, this.createLessonErrorTitleLabel.Location.Y - 36);       //move error titlelabel
                this.createLessonConfButton.Location = new Point(this.createLessonConfButton.Location.X, createLessonConfButton.Location.Y - 36);     //move config button


                //enable add category button if it's not
                if (!this.createLessonAddPictureBox.Enabled)
                    createLessonAddPictureBox.Enabled = true;


                //disable when you have 1 category
                if (this.createLessonCategoriesCount == 0)
                    this.createLessonDeletePictureBox.Enabled = false;

            }
        }

        //code fore createLesson Config Button
        private void createLessonConfButton_Click(object sender, EventArgs e)
        {
            //get fields
            String title = this.createLessonTitleTextbox.Text;  //get  title
            String description = this.createLessonDescriptionTextbox.Text;  //get description   
            

            //get categories
            String[] category = new string[categoryCount];
            for(int i=0; i<categoryCount; i++)
            {
                category[i] = this.createLessonCategoriesTextboxes[i].Text;
            }

            //call confirmation for createLesson to check if fields are okey
            bool[] errors = myutils.createLessonConfirmation(title, category);

            bool checkflag = false; //flag=true if there are errors, else flag=false
            createLessonErrorLabel.Text = "";
            createLessonErrorLabel.Visible = false;
            createLessonErrorTitleLabel.Visible = false;

            if (errors[0])
            {
                checkflag = true;
                createLessonErrorLabel.Text += "Ο τίτλος είναι κενός, συμπληρώστε τον και ξαναπροσπαθήστε.\n";
            }
            if (errors[1])
            {
                checkflag = true;
                createLessonErrorLabel.Text += "Μία ή περισσότερες κατηγορίες είναι κενές, συμπληρώστε ή διαγράψτε τες και ξαναπροσπαθήστε.\n";
            }

            if (checkflag)
            {
                this.createLessonErrorTitleLabel.Visible = true;
                this.createLessonErrorLabel.Visible = true;
            }
            else
            {
                // all good, code for send to database


                int check = db.iLesson(user.ElementAt(0), title, description);

                if (check == 1)
                {
                    check = db.iUnit(this.createLessonCategoryTextbox.Text, user.ElementAt(0), title);
                    for (int i = 0; i < createLessonCategoriesCount; i++)
                    {
                        check = db.iUnit(this.createLessonCategoriesTextboxes[i].Text, user.ElementAt(0), title);
                    }

                    MessageBox.Show("Το μάθημα καταχωρήθηκε!");                    

                    //delete all fields
                    this.createLessonCategoryTextbox.Text = "";
                    this.createLessonDescriptionTextbox.Text = "";
                    this.createLessonTitleTextbox.Text = "";
                    for (int i = 0; i < createLessonCategoriesCount; i++)
                    {
                        this.createLessonCategoriesTextboxes[i].Text = "";                                              
                    }                   

                }
                else
                {
                    //errors
                    this.createLessonErrorLabel.Text = "Υπήρξε πρόβλημα, προσπαθήστε ξανά.";
                    this.createLessonErrorLabel.Visible = true;
                    this.createLessonErrorTitleLabel.Visible = true;                    
                }
                this.loadLessons();


            }

        }

        #endregion

        #region METHODS OF createManualTestPanel

        //open filter panel of createManualTestPanel
        private void createTestFilterButton_Click(object sender, EventArgs e)
        {
            this.filtersButtonFlag = 'C';
            filtersTimer.Start();
        }

        //code createManualTestFilterConfButton    
        private void createManualTestFilterConfButton_Click(object sender, EventArgs e)
        {
            filtersButtonFlag = 'C';
            filtersTimer.Start();
        }

        //code button for choose lesson
        private void createManualTestLessonButton_Click(object sender, EventArgs e)
        {
            //code button to choose a lesson
            if (this.createManualTestComboBox.Enabled)
            {
                this.createManualTestDataGridView.Enabled = true;
                this.createManualTestConfButton.Enabled = true;
                this.createManualTestSearchTextbox.Enabled = true;
                this.createTestFilterButton.Enabled = true;
                this.createManualTestComboBox.Enabled = false;
                this.createManualTestLessonButton.Text = "Αλλαγή";

                //load categories when we choose lesson
                categories = myutils.loadcategories(user.ElementAt(0), this.createManualTestComboBox.Text);
                this.createManualTestCatagoryCheckbox.Items.Clear();
                foreach (String category in categories)
                {
                    this.createManualTestCatagoryCheckbox.Items.Add(category);
                }
            }
            //call showDialog and reset
            else
            {
                this.createManualTestDataGridView.Enabled = false;
                this.createManualTestConfButton.Enabled = false;
                this.createManualTestSearchTextbox.Enabled = false;
                this.createTestFilterButton.Enabled = false;
                this.createManualTestComboBox.Enabled = true;
                this.createManualTestLessonButton.Text = "Επιλογή";
                //if filter panel is open then close it
                if (createManualQuestionFilterFlag)
                {
                    filtersButtonFlag = 'C';
                    filtersTimer.Start();
                }                
            }

            List<string>[] viewQuestions = new List<string>[4];
            viewQuestions = db.qQuestionsMore(user.ElementAt(0), "Δίκτυα", "Επίπεδο Εφαρμογής", 1);
            for (int i = 0; i < viewQuestions[0].Count; i++)
            {
                
                createManualTestDataGridView.Rows[i].Cells[0].Value = viewQuestions[0].ElementAt(i);
                createManualTestDataGridView.Rows[i].Cells[1].Value = viewQuestions[1].ElementAt(i);
                switch (int.Parse(viewQuestions[3].ElementAt(i)))
                {
                    case 1:
                        createManualTestDataGridView.Rows[i].Cells[2].Value = "Εύκολη";
                        break;
                    case 2:
                        createManualTestDataGridView.Rows[i].Cells[2].Value = "Μέτρια";
                        break;
                    case 3:
                        createManualTestDataGridView.Rows[i].Cells[2].Value = "Δύσκολη";
                        break;
                }

            }

            //call showDialog
            /*List<string> que = new List<string>();
            que.Add("Τί είναι το FTP;");
            que.Add("Τί είναι το SMTP;");
            que.Add("Τί είναι το HTTP;");

            int check = db.iTest(que, user.ElementAt(0), "Δίκτυα", "Επίπεδο Εφαρμογής");

            if (check == 1)
                MessageBox.Show("Το διαγώνισμα καταχωρήθηκε!!");
            else if (check == 0)
                MessageBox.Show("Αδυναμία σύνδεσης στη βάση!!");
            else if (check == -1)
                MessageBox.Show("Δεν υπάρχει η ενότητα!!");
            else if (check == -3)
                MessageBox.Show("Δεν υπάρχει η ερώτηση!!");
            else
                MessageBox.Show("Υπήρξε πρόβλημα. Δεν καταχωρήθηκε η ερώτηση!!");*/

        }



        #endregion

        #region METHODS OF createAutoTestPanel
        private void createAutoTestConfButton_Click(object sender, EventArgs e)
        {
            bool errorflag = false; //flag for errors
            createAutoTestErrorsTitleLabel.Visible = false;
            createAutoTestErrorsLabel.Visible = false;
            createAutoTestErrorsLabel.Text = "";            

            //get fields
            String lesson = this.createAutoTestLessonComboBox.Text;//get lesson
            int number = Convert.ToInt32(createAutoTestNumericUpDown.Value);    //get number of questions

            //get difficulty checked
            int difficultyCount = createAutoTestDifficultyCheckedListBox.CheckedIndices.Count;
            String[] difficulty = new string[difficultyCount];
            for (int i = 0; i < difficultyCount; i++)
            {
                difficulty[i] = createAutoTestDifficultyCheckedListBox.CheckedItems[i].ToString();
            }

            //get category checked
            int categoryCount = this.createAutoTestCategoryCheckedListBox.CheckedIndices.Count;
            String[] category = new string[categoryCount];
            for (int i = 0; i < categoryCount; i++)
            {
                category[i] = createAutoTestCategoryCheckedListBox.CheckedItems[i].ToString();
            }

            //call confiration util method to check if all are okey
            bool[] errors = myutils.createAutoTestConfirmation(lesson, difficultyCount, categoryCount);

            if (errors[0])
            {
                errorflag = true;
                this.createAutoTestErrorsLabel.Text += "Δεν έχετε επιλέξει μάθημα.\n";
            }            
            if (errors[1])
            {
                errorflag = true;
                this.createAutoTestErrorsLabel.Text += "Πρέπει να διαλέξετε τουλάχιστον ένα επίπεδο δυσκολίας.\n";
            }                
            if (errors[2])
            {
                errorflag = true;
                this.createAutoTestErrorsLabel.Text += "Πρέπει να επιλέξετε τουλάχιστον μία κατηγορία μαθήματος.\n";
            }

            //check if is is okey to send or do visible error labels
            if (errorflag)
            {
                createAutoTestErrorsTitleLabel.Visible = true;
                createAutoTestErrorsLabel.Visible = true;
            }
            else //code to send to database
            {
                //find questions
                List<string> units = this.createAutoTestCategoryCheckedListBox.CheckedItems.OfType<string>().ToList();
                List<string> diffString = this.createAutoTestDifficultyCheckedListBox.CheckedItems.OfType<string>().ToList();
                List<int> diff = new List<int>();
                foreach(String checkedItem in diffString)
                {
                    if (checkedItem.Equals("Εύκολες"))
                        diff.Add(1);
                    else if(checkedItem.Equals("Δύσκολες"))
                        diff.Add(3);
                    else
                        diff.Add(2);
                }
                   

                List<string> questions = myutils.loadquestions(user.ElementAt(0),lesson,category,diff); //get questions with filters

                questions.OrderBy(arg => Guid.NewGuid()).Take(number).ToList(); //take random questions


                //μεχρι εδω καλα

                int check = db.iTest(questions, user.ElementAt(0), lesson, units);

                if (check == 1)
                {
                    MessageBox.Show("Το διαγώνισμα δημιουργήθηκε");
                    this.createAutoTestDifficultyCheckedListBox.SelectedItems.Clear();
                    this.createAutoTestCategoryCheckedListBox.SelectedItems.Clear();
                }
                else
                {
                    this.createAutoTestErrorsLabel.Text = "Υπήρξε πρόβλημα, προσπαθήστε ξανά.";
                    this.createAutoTestErrorsLabel.Visible = true;
                    this.createAutoTestErrorsTitleLabel.Visible = true;
                }  
            }
           
        }

        //load categories when we select lesson in createAutoTestPanel
        private void createAutoTestLessonComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.createAutoTestCategoryCheckedListBox.Items.Clear();
            //load categories
            categories = myutils.loadcategories(user.ElementAt(0), this.createAutoTestLessonComboBox.Text);
            foreach (String category in categories)
            {
                this.createAutoTestCategoryCheckedListBox.Items.Add(category);
            }

        }
        #endregion


        #region FILTERS PANEL EFFECT
        //-----------------------------------------------------------------------
        private char filtersButtonFlag; //flag to see which filter button pressed
        bool showQuestionFiltrerflag = false;  //flag to see if panel is open or not
        bool createManualQuestionFilterFlag = false; //flag to see if panel is open or not
        private void filtrersPanelTimer(object sender, EventArgs e)
        {
            //temps to code the right panel
            Panel tempPanel = null;
            Button tempButton = null;
            bool tempFlag = false;

            //check whick fliter panel we need to code
            if (filtersButtonFlag == 'S')
            {
                tempPanel = this.showQuestionsFilterPanel;
                tempButton = this.showQuestionsFilterButton;
                tempFlag = this.showQuestionFiltrerflag;
            }
            else if (filtersButtonFlag == 'C')
            {
                tempPanel = this.createManualTestFilterPanel;
                tempButton = this.createTestFilterButton;
                tempFlag = this.createManualQuestionFilterFlag;
            }

            //if panel is open then close
            if (tempFlag)
            {
                tempPanel.Width -= 22;
                tempButton.Location = new Point(tempButton.Location.X - 22, tempButton.Location.Y);
                if (tempPanel.Width == 0)
                {
                    filtersTimer.Stop();
                    if (filtersButtonFlag == 'S')
                        showQuestionFiltrerflag = false;
                    else
                        createManualQuestionFilterFlag = false;

                }
            }
            //if panel is close then open
            else
            {
                tempPanel.Width += 22;
                tempButton.Location = new Point(tempButton.Location.X + 22, tempButton.Location.Y);

                if (tempPanel.Width == 242)
                {
                    filtersTimer.Stop();
                    if (filtersButtonFlag == 'S')
                        showQuestionFiltrerflag = true;
                    else
                        createManualQuestionFilterFlag = true;
                }
            }
        }

        #endregion


        #region NEWS LABEL TO LEFTPANEL FROM RIGHT TO LEFT
        private void newstimer_Tick(object sender, EventArgs e)
        {
            this.newsLabel.Location = new Point(this.newsLabel.Location.X - 1, this.newsLabel.Location.Y);
            if (this.newsLabel.Location.X + this.newsLabel.Width < 0)
            {
                newsTimer.Stop();
                this.newsLabel.Location = new Point(224, this.newsLabel.Location.Y);
                this.newsLabel.Text = this.newsArr[new Random().Next(0, 4)];
                this.sleepTimer.Start();    //call sleepTimer to sleep for X seconds 

            }


        }
        //sleep for x seconds and then start again newsTimer
        private void sleepTimer_Tick(object sender, EventArgs e)
        {
            newsTimer.Start();
            sleepTimer.Stop();
        }


        #endregion


        #region KONAMI CODE EGG

        //Click the titleL in leftmenuP and then the Konami code (UP,UP,DOWN,DOWN,LEFT,RIGHT,LEFT,RIGHT,B,A,ENTER) and Gradius theme song will play.
        Keys[] konami = { Keys.Up, Keys.Up, Keys.Down, Keys.Down, Keys.Left, Keys.Right, Keys.Left, Keys.Right, Keys.B, Keys.A, Keys.Enter };
        int konamiCounter = 0;

        private void konamiTextbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == konami[konamiCounter])
            {
                konamiCounter++;
                if (konamiCounter == konami.Length)
                {
                    SoundPlayer audio = new SoundPlayer(Resources.gradius_nes_music_1_); 
                    audio.Play();
                    konamiCounter = 0;    
                }

            }
            else
                konamiCounter = 0;
        }

        private void konamiTextbox_Leave(object sender, EventArgs e)
        {
            konamiCounter = 0;
        }

        private void titleL_Click(object sender, EventArgs e)
        {
            konamiTextbox.Focus();
        }





        #endregion

        private void createManualTestConfButton_Click(object sender, EventArgs e)
        {

        }
    }
}
