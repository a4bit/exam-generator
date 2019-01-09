using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Multiple_Choice_Generator
{
    public class database
    {
        private string team = "pao";




        //string server = "dblabs.it.teithe.gr";
        //string db = "it154551";
        //string uid = "it154551";
        //string password = "123456";


        string server = "localhost";
        string db = "multiple";
        string uid = "root";
        string password = "";
        MySqlConnection dbcon = null;

        public database()
        {
            
        }
        //Συνδέση με βάση δεδομένων
        public bool connection()
        {
            string conn = "SERVER=" + server + ";" + "DATABASE=" + db + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";charset=utf8;";
            dbcon = new MySqlConnection(conn);
            try
            {
                dbcon.Open();
                Console.WriteLine("Επιτυχής σύνδεση στην βάση " + db + " του σέρβερ " + server + "!!!");
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 1045:
                        Console.WriteLine("Λάθος όνομα χρήστη και/ή κωδικός του σερβερ!!!");
                        break;

                    case 0:
                        Console.WriteLine("Δεν μπόρεσε να συνδεθεί στον σέρβερ!!");
                        break;
                }
                return false;
            }
        }

        //Σύνδεση χρήστη και επιστροφή των στοιχείων του σε λιστα
        public List<string> login(string username, string password)
        {
            int exist = 0;
            if (connection() == true)
            {
                List<string> list = new List<string>();

                string query = "Select * From users where username='" + username + "' and password='" + password + "'";
                MySqlCommand cmd = new MySqlCommand(query, dbcon);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list.Add(dataReader["username"] + "");
                    list.Add(dataReader["password"] + "");
                    list.Add(dataReader["surname"] + "");
                    list.Add(dataReader["name"] + "");
                    list.Add(dataReader["email"] + "");
                    list.Add(dataReader["school"] + "");
                    exist++;
                }
                dataReader.Close();
                if (exist == 1)
                    return list;
                else
                    return null;
            }
            else
                return null;
        }

        public List<string> qQuestions(string username, string lesson, string unit)
        {
            int exist = 0;
            if (connection() == true)
            {
                List<string> list = new List<string>();
                int unit_id = convertUnit(unit, username, lesson);
                string query = "Select * From questions where owner='" + username + "' and lesson='" + lesson + "' and unit_id=" + unit_id ; 
                MySqlCommand cmd = new MySqlCommand(query, dbcon);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list.Add(dataReader["text"] + "");
                    exist++;
                }
                dataReader.Close();
                if (exist == 0)
                    return null;
                else
                    return list;
            }
            else
                return null;
        }

        public List<string> qQuestions(string username, string lesson, string unit, int dif)
        {
            int exist = 0;
            if (connection() == true)
            {
                List<string> list = new List<string>();
                int unit_id = convertUnit(unit, username, lesson);
                string query = "Select * From questions where owner='" + username + "' and lesson='" + lesson + "' and unit_id=" + unit_id + " and dif=" + dif;
                MySqlCommand cmd = new MySqlCommand(query, dbcon);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list.Add(dataReader["text"] + "");
                    exist++;
                }
                dataReader.Close();
                if (exist == 0)
                    return null;
                else
                    return list;
            }
            else
                return null;
        }

        public List<string>[] qQuestionsMore(string username, string lesson, string unit, int dif)
        {
            int exist = 0;
            if (connection() == true)
            {
                List<string>[] list = new List<string>[4];
                list[0] = new List<string>();
                list[1] = new List<string>();
                list[2] = new List<string>();
                list[3] = new List<string>();
                int unit_id = convertUnit(unit, username, lesson);
                string query = "Select Q.*, U.name From questions Q JOIN units U ON Q.unit_id=U.id where Q.owner='" + username + "' and Q.lesson='" + lesson + "' and Q.unit_id=" + unit_id + " and Q.dif=" + dif;
                MySqlCommand cmd = new MySqlCommand(query, dbcon);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["text"] + "");
                    list[1].Add(dataReader["lesson"] + "");
                    list[2].Add(dataReader["name"] + "");
                    list[3].Add(dataReader["dif"] + "");
                    exist++;
                }
                dataReader.Close();
                if (exist == 0)
                    return null;
                else
                    return list;
            }
            else
                return null;
        }

        public List<string> qAnswers(string question, string unit, string username, string lesson)
        {
            int exist = 0;
            if (connection() == true)
            {
                List<string> list = new List<string>();
                int id_que = convertQuestion(question, convertUnit(unit, username, lesson));
                string query = "Select * From answers where id_q=" + id_que;
                MySqlCommand cmd = new MySqlCommand(query, dbcon);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list.Add(dataReader["text"] + "");
                    exist++;
                }
                dataReader.Close();
                if (exist == 0)
                    return null;
                else
                    return list;
            }
            else
                return null;
        }

        //Επιστροφή των τίτλων των μαθημάτων του συνδεδεμένου χρήστη σε λιστα
        public List<string> qLessons(string username)
        {
            int exist = 0;
            if (connection() == true)
            {
                List<string> list = new List<string>();

                string query = "Select * From lessons where owner='" + username + "'";
                MySqlCommand cmd = new MySqlCommand(query, dbcon);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list.Add(dataReader["name"] + "");
                    exist++;
                }
                dataReader.Close();
                if (exist == 0)
                    return null;
                else
                    return list;
            }
            else
                return null;
        }

        //Επιστροφή των ενοτήτων ενός μαθήματος του συνδεδεμένου χρήστη σε λιστα
        public List<string> qUnits(string owner, string lesson)
        {
            int exist = 0;
            if (connection() == true)
            {
                List<string> list = new List<string>();

                string query = "Select * From units where owner='" + owner + "' and lesson='" + lesson + "'";
                MySqlCommand cmd = new MySqlCommand(query, dbcon);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list.Add(dataReader["name"] + "");
                    exist++;
                }
                dataReader.Close();
                if (exist == 0)
                    return null;
                else
                    return list;
            }
            else
                return null;
        }

        public List<string> qΤest(string owner, string lesson)
        {
            int exist = 0;
            if (connection() == true)
            {
                List<string> list = new List<string>();

                string query = "Select distinct name From tests where owner='" + owner + "' and lesson='" + lesson +"'";
                MySqlCommand cmd = new MySqlCommand(query, dbcon);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list.Add(dataReader["name"] + "");
                    exist++;
                }
                dataReader.Close();
                if (exist == 0)
                    return null;
                else
                    return list;
            }
            else
                return null;
        }

        //Καταχώρηση ερώτησης στην βάση + τις απαντησεις της
        public int iQuestion(string username, string question, List<string> answers, string lesson, string unit, int dif)
        {
            if (connection() == true)
            {
                try
                {
                    List<string> list = new List<string>();
                    int unit_id = convertUnit(unit, username, lesson);
                    if (unit_id == -2)
                        return 0;
                    else if (unit_id == -1)
                        return -1;
                    else
                    {
                        string query = "Insert into questions values (NULL, '" + question + "', '" + username + "', '" + lesson + "', " + unit_id + ", " + dif + ")";
                        Console.WriteLine(query);
                        MySqlCommand cmd = new MySqlCommand(query, dbcon);

                        cmd.ExecuteNonQuery();

                        int id_que = convertQuestion(question,unit_id);
                        query = "";
                        for (int i=0; i < answers.Count; i++)
                        {
                            query = "Insert into answers values(NULL, '" + answers.ElementAt(i) + "', " + id_que + ", 0)";
                            cmd = new MySqlCommand(query, dbcon);
                            cmd.ExecuteNonQuery();
                        }
                        return 1;
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return 2;
                }
            }
            else
                return 0;

        }

        public int iLesson(string username, string lesson, string desc)
        {
            if (connection() == true)
            {
                try
                {
                    string query = "Insert into lessons values ('" + lesson + "', '" + username + "', '" + desc +"')";
                    Console.WriteLine(query);
                    MySqlCommand cmd = new MySqlCommand(query, dbcon);

                    cmd.ExecuteNonQuery();
                    return 1;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return 2;
                }
            }
            else
                return 0;
        }

        public int iUnit(string unit, string username, string lesson)
        {
            if (connection() == true)
            {
                try
                {
                    string query = "Insert into units values (NULL, '" + unit + "', '" + username + "', '" + lesson + "')";
                    Console.WriteLine(query);
                    MySqlCommand cmd = new MySqlCommand(query, dbcon);

                    cmd.ExecuteNonQuery();
                    return 1;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return 2;
                }
            }
            else
                return 0;
        }

        public int iTest(List<string> questions, string username, string lesson, List<string> units)
        {
            if (connection() == true)
            {
                try
                {
                    int question = 0;
                    
                    string query = "select max(id) from tests";
                    MySqlCommand cmd = new MySqlCommand(query, dbcon);
                    int id = int.Parse(cmd.ExecuteScalar() + "") + 1;
                        
                    for (int i=0; i < questions.Count; i++)
                    {
                        int unit_id = convertUnit(units.ElementAt(i), username, lesson);

                        if (unit_id == -2)
                            return 0;
                        else if (unit_id == -1)
                            return -1;
                        else
                        {
                            question = convertQuestion(questions.ElementAt(i), unit_id);
                            if (question == -3)
                                return -2;
                            query = "Insert into tests values (" + id + ", " + question + ", '" + username + "', " + unit_id + ", '" + lesson + "')";
                            Console.WriteLine(query);
                            cmd = new MySqlCommand(query, dbcon);

                            cmd.ExecuteNonQuery();
                        }
                    }
                       
                    return 1;
                    
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return 2;
                }
            }
            else
                return 0;

            
        }

        public int uUser(string username, string surname, string name, string email, string school, string gender, string birth)
        {
            if (connection() == true)
            {
                try
                {
                    string query = "Update users set surname='" + surname + "', name='" + name + "', email='" + email + "', school='" + school + "', gender='" + gender + "', birth='" + birth + "' where username='" + username + "'";
                    Console.WriteLine(query);
                    MySqlCommand cmd = new MySqlCommand(query, dbcon);

                    cmd.ExecuteNonQuery();
                    return 1;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return 2;
                }
            }
            else
                return 0;
        }

        public int uLesson(string username, string newname, string oldname)
        {
            if (connection() == true)
            {
                try
                {
                    string query = "Update lessons set name='" + newname + "' where owner='" + username + "' and name='" + oldname + "'";
                    Console.WriteLine(query);
                    MySqlCommand cmd = new MySqlCommand(query, dbcon);

                    cmd.ExecuteNonQuery();
                    return 1;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return 2;
                }
            }
            else
                return 0;
        }

        public int uUnit(string username, string lesson, string newname, string oldname)
        {
            if (connection() == true)
            {
                try
                {
                    int id = convertUnit(oldname,username,lesson);
                    string query = "Update units set name='" + newname + "' where id=" + id;
                    Console.WriteLine(query);
                    MySqlCommand cmd = new MySqlCommand(query, dbcon);

                    cmd.ExecuteNonQuery();
                    return 1;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return 2;
                }
            }
            else
                return 0;
        }

        public int uQuestion(string username, string lesson, string unit, string newname, string oldname, List<string> newanswers, List<string> oldanswers)
        {
            if (connection() == true)
            {
                try
                {
                    int id_unit = convertUnit(unit, username, lesson);
                    int id_que = convertQuestion(oldname,id_unit);
                    string query = "Update questions set text='" + newname + "' where id=" + id_que;
                    Console.WriteLine(query);
                    MySqlCommand cmd = new MySqlCommand(query, dbcon);

                    cmd.ExecuteNonQuery();

                    for(int i=0; i < oldanswers.Count; i++)
                    {
                        query = "Update answers set text='" + newanswers.ElementAt(i) + "' where id_q=" + id_que + " and text='" + oldanswers.ElementAt(i) + "'";
                        cmd = new MySqlCommand(query, dbcon);
                        cmd.ExecuteNonQuery();
                    }
                    return 1;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return 2;
                }
            }
            else
                return 0;
        }



        //Βοηθητική συνάρτηση που μετατρέπει το όνομα της ενότητας σε id
        public int convertUnit(string name, string owner, string lesson)
        {
            if (connection() == true)
            {
                int exist=0;
                int id = 0;
                string query = "Select id From units where name='" + name + "' and owner='" + owner + "' and lesson='" + lesson + "'";
                MySqlCommand cmd = new MySqlCommand(query, dbcon);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    id = int.Parse(dataReader["id"] + "");
                    exist++;
                }
                dataReader.Close();
                if (exist == 0)
                    return -1;
                else
                    return id;
            }
            else
                return -2;
        }

        public int convertQuestion(string text, int unit)
        {
            if (connection() == true)
            {
                int exist = 0;
                int id = 0;
                string query = "Select id From questions where text='" + text + "' and unit_id='" + unit + "'";
                MySqlCommand cmd = new MySqlCommand(query, dbcon);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    id = int.Parse(dataReader["id"] + "");
                    exist++;
                }
                dataReader.Close();
                if (exist == 0)
                    return -3;
                else
                    return id;
            }
            else
                return -2;
        }
    }
}
