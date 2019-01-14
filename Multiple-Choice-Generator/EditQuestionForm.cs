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
    public partial class EditQuestionForm : Form
    {
        //fields
        private String user;
        private String question;
        private String lesson;
        private String unit;
        private String diff;
        private List<string> answers;
        private Form1 father;
        private database db = new database();

        public EditQuestionForm(String user, String question, String lesson, String unit, String diff, Form1 father)
        {
            InitializeComponent();

            this.user = user;
            this.question = question;
            this.lesson = lesson;
            this.unit = unit;
            this.diff = diff;
            this.father = father;
        }

        //load form
        private void EditQuestionForm_Load(object sender, EventArgs e)
        {
            //values to textboxes
            this.setTitle();
            this.questionTextbox.Text = this.question;
            this.lessonTextbox.Text = this.lesson;

            //diff level set
            if (this.diff.Equals("Εύκολη"))            
                this.diffRadioButton1.Select();
            else if (this.diff.Equals("Μέτρια"))            
                this.diffRadioButton2.Select();            
            else            
                this.diffRadioButton3.Select();

            //get units
            List<string> units = db.qUnits(user, lesson);

            foreach(String unit in units)
            {
                this.unitsComboBox.Items.Add(unit);

                if (unit.Equals(this.unit))
                    this.unitsComboBox.SelectedIndex = this.unitsComboBox.Items.Count - 1;
            }
            
            


            //load answers
            answers = db.qAnswers(question, unit, user, lesson);

            this.editQuestionsDataGridView.Rows.Clear();
            
            foreach(String answer in answers)
            {
                this.editQuestionsDataGridView.Rows.Add(answer);
            }

            

        }

        //set title of form the start of question, if question too bigger than 100 char then cut it
        public void setTitle()
        {
            this.Text += " - ";

            int count = this.question.Length;            

            if (count > 100)
            {
                for (int i = 0; i < 100; i++)
                    this.Text += question[i];

                this.Text += "...";
            }
            else
            {
                for (int i = 0; i < question.Length; i++)
                    this.Text += question[i];
            }
        }

        //delete question
        private void deleteQuestionButton_Click(object sender, EventArgs e)
        {
            ConfigForm conf = new ConfigForm("Είστε σίγουρος ότι θέλετε να διαγράψετε αυτή την ερώτηση;\nΑυτό το βήμα είναι ορισικό και δεν υπάρχει δυνατότητα επαναφοράς!", "Ακύρωση", "Διαγραφή", Color.Red, "Διαγραφή Ερώτησης");
            if (conf.ShowDialog(this) == DialogResult.OK)
            {
                int check = db.dQuestion(user, lesson, unit, question); //delete question and check status

                if(check != 1)
                {
                    errorsLabel.Text = "Υπήρξε κάποιο πρόβλημα με την διαγραφή ερώτησης!";
                    errorsLabel.Visible = true;
                    errorTittleLabel.Visible = true;
                }
                else
                {
                    //load questions again
                    father.loadQuestions();

                    this.Close();
                    this.Dispose();
                }
            }
            conf.Dispose();
        }

        //cancel button
        private void cancelButton_Click(object sender, EventArgs e)
        {
            ConfigForm conf = new ConfigForm("Θέλετε να ακυρώσετε την επεξεργασία;\nΟποιαδίποτε αλλαγή πραγματοποιήσατε θα χαθεί!", "Οχι", "Ναι", Color.OrangeRed, "Ακύρωση Επεξεργασίας Ερώτησης");
            if (conf.ShowDialog(this) == DialogResult.OK)
            {
                this.Close();
                this.Dispose();
            }
            conf.Dispose();
        }

        //ok button
        private void okButton_Click(object sender, EventArgs e)
        {
            //error0 = less than 2 questions
            //error1 = empty answer
            //error2 = empty title
            bool[] errors = {false, false, false, false};

            this.clearErrors();

            ConfigForm conf = new ConfigForm("Είστε σίγουρος ότι θέλετε να επιβεβαιώσετε τις αλλαγές σας;\nΟι αλλαγές θα είναι οριστικές!", "Ακύρωση", "Επιβεβαίωση", Color.LimeGreen, "Επιβεβαίωση Επεξεργασίας Ερώτησης");
            if (conf.ShowDialog(this) == DialogResult.OK)
            {
                int check = 0;  //status check from db

                //get number of new answers
                int numberCount = this.editQuestionsDataGridView.Rows.Count;
                int delCount = 0;

                //check if answers are >2
                for(int i=0; i<numberCount-1; i++)
                {
                    //get answer go to delete
                    bool flag = false;
                    try
                    {
                        flag = (bool)this.editQuestionsDataGridView.Rows[i].Cells[1].Value;
                    }
                    catch   //it was null
                    { }

                    if (flag)
                    {
                        delCount++;
                    }
                }

                if (numberCount - 1 - delCount < 2)
                    errors[0] = true;

                //check if there is empty answer
                for(int i=0; i<this.editQuestionsDataGridView.Rows.Count-1; i++)
                {
                    String temptxt = (String)this.editQuestionsDataGridView.Rows[i].Cells[0].Value;
                    if (String.IsNullOrEmpty(temptxt) || String.IsNullOrWhiteSpace(temptxt))
                    {
                        errors[1] = true;
                    }
                }

                //check if there is empty title question
                if (String.IsNullOrEmpty(this.questionTextbox.Text) || String.IsNullOrWhiteSpace(this.questionTextbox.Text))
                    errors[2] = true;                

                   
                
                
                
                
                
                
                //getanswers


                //check question rename
                if (!this.questionTextbox.Text.Equals(this.question))
                {
                    //check = db.uQuestion(user, lesson, unit, this.questionTextbox.Text, this.question, this.answers);
                }

                //checkerrors
                if (errors[0])
                    this.errorsLabel.Text = "Δε μπορείτε να καταχορήσετε λιγότερες από 2 ερωτήσεις";
                else if (errors[1])
                    this.errorsLabel.Text = "Δε μπορείτε να καταχορήσετε κενή απάντηση";
                else if (errors[2])
                    this.errorsLabel.Text = "Δε μπορείτε να καταχορήσετε κενό τίτλο ερώτησης.";
            }
            conf.Dispose();
        }

        public void clearErrors()
        {
            this.errorsLabel.Visible = false;
            this.errorTittleLabel.Visible = false;
            this.errorsLabel.Text = "";
        }

        private void editQuestionsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.editQuestionsDataGridView.Rows.Count > 10)
                this.editQuestionsDataGridView.AllowUserToAddRows = false;               
        }
    }
}
