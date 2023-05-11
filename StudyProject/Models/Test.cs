using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject
{
    public class Test
    {
        public int id { get; set; }
        public int examiner_id { get; set; }
        public string name { get; set; }
        public int question_count { get; set; }

        public List<Question> questions;

        public Test()
        {
            this.id = -1;
        }

        public Test(int id, int examiner_id, string name, int question_count)
        {
            this.id = id;
            this.examiner_id = examiner_id;
            this.name = name;
            this.question_count = question_count;
        }

        public Test(int id)
        {
            this.id = id;
        }

        public List<Question> getQuestionsList()
        {
            DataBase database = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command;

            this.questions = new List<Question>();

            string query = $"SELECT * FROM Question WHERE test_id={this.id} ORDER BY id";
            command = new SqlCommand(query, database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                int id = Int32.Parse(table.Rows[i].ItemArray[0].ToString());
                string text = table.Rows[i].ItemArray[1].ToString();
                questions.Add(new Question(id, this.id, text));
            }

            return questions;
        }
    }
}
