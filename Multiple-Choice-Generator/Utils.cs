using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Choice_Generator
{
    class Utils
    {

        //check if informations are okey to send to database
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
            if (lesson.Equals(""))
                errors[1] = true;
            
            for(int i=0; i<answers.Length; i++)
            {
                if (String.IsNullOrEmpty(answers[i]) || string.IsNullOrWhiteSpace(answers[i]))
                    errors[2] = true;
            }

            return errors;
        }


    }
}
