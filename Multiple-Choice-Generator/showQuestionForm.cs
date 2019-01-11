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
    public partial class ShowQuestionForm : Form
    {
        //fields
        private String question;
        private String lesson;
        private String unit;
        private String diff;
        private database db = new database();


        public ShowQuestionForm(String question, String lesson, String unit, String diff)
        {
            InitializeComponent();
            this.question = question;
            this.lesson = lesson;
            this.unit = unit;
            this.diff = diff;
        }
        
        private void ShowQuestionForm_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;   

            this.questionLabel.Text = this.question;    //set question label
            this.lessonLabel.Text = this.lesson;    //set lesson
            this.unitLabel.Text = this.unit;        //set unit
            this.diffLabel.Text = this.diff;        //set diff level

            //get answers
            List<string> answers = new List<string>();
            //answers = db.i
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
