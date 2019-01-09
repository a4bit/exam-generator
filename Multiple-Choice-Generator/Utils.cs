using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multiple_Choice_Generator
{
    class Utils
    {

        //check if fields of createQuestion are okey to send to database
        public bool[] createQuestionConfirmation(String question, String lesson, String category, int difficulty, String[] answers)
        {
            /*
             errors[0] -> question text is empty             
             errors[1] -> lesson text is empty
             errors[2] -> one or more answers are empty, null or only whitespace
             */
            bool[] errors = {false, false, false};                                       

            if (String.IsNullOrEmpty(question) || String.IsNullOrWhiteSpace(question))  //need upgrading
                errors[0] = true;
            if(lesson.Equals(""))
                errors[1] = true;
            
            for(int i=0; i<answers.Length; i++)
            {
                if (String.IsNullOrEmpty(answers[i]) || string.IsNullOrWhiteSpace(answers[i]))
                    errors[2] = true;
            }

            return errors;
        }

        //check if fields of createAUtotest are okey to send to database
        public bool[] createAutoTestConfirmation(String lesson, int difficulty, int category)
        {
            bool[] errors = {false, false, false};
            /*
             errors[0] -> no lesson has choosen
             errors[1] -> no difficulty levels have choosen
             errors[2] -> no categories have choosen                          
             */

            if (lesson.Equals("") || lesson == null
)
                errors[0] = true;
            if (difficulty == 0)
                errors[1] = true;
            if (category == 0)
                errors[2] = true;

            return errors;
        }

        //check if fields of createLesson are okey to send to database
        public bool[] createLessonConfirmation(String title, String[] category)
        {
            bool[] errors = {false, false};
            /*
             errors[0] -> emprty title lesson
             errors[1] -> one or more categories are empty
            */

            if (String.IsNullOrEmpty(title) || String.IsNullOrWhiteSpace(title))
                errors[0] = true;

            for (int i = 0; i < category.Length; i++)
            {
                if(String.IsNullOrWhiteSpace(category[i]) || String.IsNullOrEmpty(category[i]))
                {
                    errors[1] = true;
                    break;
                }
            }

            return errors;
        }

        database db = new database();

        //reutn lessons
        public List<string> loadlessons(String user)
        {            
            List<string> lessons = new List<string>();

            //get lessons
            lessons = db.qLessons(user);

            return lessons;
        }

        //return categories
        public List<string> loadcategories(String user, String lesson)
        {
            List<string> categories = new List<string>();

            //get categories from db
            categories = db.qUnits(user, lesson);

            return categories;
        }

        //return filter questions
        public List<string> loadquestions(String user, String lesson, String[] categories, List<int> diff)
        {
            List<string> questions = new List<string>();
            
            for(int i=0; i<categories.Length; i++){
                foreach(int differ in diff)
                {
                    questions.AddRange(db.qQuestions(user, lesson, categories[i], differ));
                }              
            }            

            return questions;
        }

        //return questions
    }
}
