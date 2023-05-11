using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject
{
    public struct Answer
    { 
        public int id;
        public string text;
        public bool isCorrect;

        public Answer(int id, string text, bool isCorrect)
        {
            this.id = id;
            this.text = text;
            this.isCorrect = isCorrect;
        }
    }

    public class Question
    {

        public int id { get; set; }
        public int testId { get; set; }
        public string text { get; set; }

        public List<Answer> answers = new List<Answer>(4);

        public Question() 
        {
            this.id = -1;
        }

        public Question(int id, int testId, string text) 
        {
            this.id = id;
            this.testId = testId;
            this.text = text;
        }

        public List<Answer> getAnswers()
        { 
            return answers; 
        }

        public int getCorrectAnswerId()
        {
            for (int i = 0; i < answers.Count; i++)
            {
                if (answers[i].isCorrect)
                {
                    return i + 1;
                }
            }
            return -1;
        }

        public void fillAnswers(List<Answer> answersList)
        {
            this.answers.Clear();
            this.answers = answersList;
        }

        public void addAnswer(Answer answer)
        {
            this.answers.Add(answer);
        }

        public List<Answer> getAnswersListFromDB()
        {
            DataBase database = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command;

            List<Answer> list = new List<Answer>();

            string query = $"SELECT id, text, is_correct FROM Answer WHERE question_id={this.id}";

            command = new SqlCommand(query, database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                int id = Int32.Parse(table.Rows[i].ItemArray[0].ToString());
                string text = table.Rows[i].ItemArray[1].ToString();
                bool isCorrect = Boolean.Parse(table.Rows[i].ItemArray[2].ToString());
                list.Add(new Answer(id, text, isCorrect));
            }

            return list;
        }
    }
}
