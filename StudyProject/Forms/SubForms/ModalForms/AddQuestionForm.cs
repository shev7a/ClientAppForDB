using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudyProject
{
    public partial class AddQuestionForm : Form
    {
        DataBase database = new DataBase();
        
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table;
        SqlCommand command;

        int testId;
        string testName;
        int questionId;

        bool isEdit = false;

        Question question;

        public AddQuestionForm(int testId, string testName, int questionId = -1)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.testId = testId;
            this.testName = testName;
            this.questionId = questionId;
        }

        private void loadQuestionData(int id)
        {
            table = new DataTable();
            command = new SqlCommand($"SELECT text, test_id FROM Question WHERE id = '{id}'", database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            var data = table.Rows[0].ItemArray;
            string text = data[0].ToString();

            this.question = new Question(id, this.testId, text);

            table = new DataTable();
            command = new SqlCommand($"SELECT id, text, is_correct FROM Answer WHERE question_id = '{id}'", database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            var rows = table.Rows;

            List<Answer> answers = new List<Answer>();

            for (int i = 0; i < rows.Count; i++)
            {
                int answId = Int32.Parse(rows[i].ItemArray[0].ToString());
                string answText = rows[i].ItemArray[1].ToString();
                bool isCorrect = bool.Parse(rows[i].ItemArray[2].ToString());
                answers.Add(new Answer(answId, answText, isCorrect));
            }

            this.question.fillAnswers(answers);
            Console.WriteLine(this.question.answers.Count);
            Console.WriteLine(this.question.getAnswers().Count);
        }

        private void AddQuestionForm_Load(object sender, EventArgs e)
        {
            if (questionId != -1)
            {
                Control[] cntrls;

                loadQuestionData(this.questionId);
                questionText.Text = question.text;
                addButton.Text = "Сохранить";

                headerLabel.Text = "Редактирование вопроса";
                isEdit = true;

                for (int i = 0; i < question.answers.Count; i++)
                {
                    cntrls = this.Controls.Find("answer" + (i + 1), true);
                    cntrls[0].Text = question.answers[i].text;
                }

                switch(question.getCorrectAnswerId())
                {
                    case 1:
                        {
                            answCorrect1.Checked = true;
                            break;
                        }
                    case 2:
                        {
                            answCorrect2.Checked = true;
                            break;
                        }
                    case 3:
                        {
                            answCorrect3.Checked = true;
                            break;
                        }
                    case 4:
                        {
                            answCorrect4.Checked = true;
                            break;
                        }
                }

            }
        }

        private int getCorrectAnswerId()
        {
            if (answCorrect1.Checked)
            {
                return 0;
            }
            else if (answCorrect2.Checked)
            {
                return 1;
            }
            else if (answCorrect3.Checked)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        private bool checkRequiredFields()
        {
            if (String.IsNullOrEmpty(questionText.Text.Trim()))
            {
                MessageBox.Show("Заполните текст вопроса", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (String.IsNullOrEmpty(answer1.Text.Trim()) || String.IsNullOrEmpty(answer2.Text.Trim())
                || String.IsNullOrEmpty(answer3.Text.Trim()) || String.IsNullOrEmpty(answer4.Text.Trim()))
            {
                MessageBox.Show("Заполните все варианты ответа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!answCorrect1.Checked && !answCorrect2.Checked && !answCorrect3.Checked && !answCorrect4.Checked)
            {
                MessageBox.Show("Укажите правильный вариант ответа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (checkRequiredFields())
            {
                Control[] cntrl;

                string query;
                database.openConnection();

                if (isEdit)
                {
                    query = $"UPDATE Question SET text='{questionText.Text}' WHERE id={questionId}";
                    command = new SqlCommand(query, database.getConnection());
                    command.ExecuteNonQuery();

                    query = $"DELETE FROM Answer WHERE question_id={questionId}";
                    command = new SqlCommand(query, database.getConnection());
                    command.ExecuteNonQuery();
                }
                else
                {
                    query = $"INSERT INTO Question VALUES('{questionText.Text}', {testId});" + "SELECT CAST(scope_identity() AS int)";
                    command = new SqlCommand(query, database.getConnection());
                    questionId = (Int32)command.ExecuteScalar();
                }
                               

                for (int i = 0; i < 4; i++)
                {
                    cntrl = this.Controls.Find("answer" + (i + 1), true);
                    string answText = cntrl[0].Text.ToString();
                    if (getCorrectAnswerId() == i)
                    {
                        query = $"INSERT INTO Answer VALUES('{answText}', {1}, {questionId})";

                    }
                    else
                    {
                        query = $"INSERT INTO Answer VALUES('{answText}', {0}, {questionId})";
                    }
                    command = new SqlCommand(query, database.getConnection());
                    command.ExecuteNonQuery();
                }

                database.closeConnection();
                if (isEdit)
                {
                    MessageBox.Show($"Вопрос успешно изменен", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Вопрос успешно добавлен в тест", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddQuestionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CreateTestForm main = this.Owner as CreateTestForm;
            if (main != null)
            {
                main.loadData(testId);
            }
        }
    }
}
