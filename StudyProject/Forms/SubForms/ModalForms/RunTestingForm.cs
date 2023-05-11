using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudyProject.Forms
{
    public partial class RunTestingForm : Form
    {
        DataBase database = new DataBase();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        SqlCommand command;
        string query;

        int testingId;
        int employeeId;
        int currentQuestionNum;
        List<Question> questions;
        int questionsCount;
        Question currentQuestion;
        List<Answer> currentAnswers;
        int correctAnswersCount;

        private int getTestId()
        {
            table = new DataTable();
            query = $"SELECT test_id FROM Testing WHERE id={this.testingId}";
            command = new SqlCommand(query, database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return Int32.Parse(table.Rows[0].ItemArray[0].ToString());
        }

        public RunTestingForm(int testingId, int employeeId)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.testingId = testingId;
            this.employeeId = employeeId;
            this.currentQuestionNum = 1;
            Test test = new Test(getTestId());
            questions = test.getQuestionsList();
            questionsCount = questions.Count;
            correctAnswersCount = 0;
        }

        private void loadData(int questionNum)
        {
            currentQuestion = questions[questionNum - 1];
            currentAnswers = currentQuestion.getAnswersListFromDB();

            questionNumLabel.Text = $"Вопрос №{questionNum}";
            questionGroupBox.Text = currentQuestion.text;
            answer1.Text = currentAnswers[0].text;
            answer2.Text = currentAnswers[1].text;
            answer3.Text = currentAnswers[2].text;
            answer4.Text = currentAnswers[3].text;

            answer1.Checked = false;
            answer2.Checked = false;
            answer3.Checked = false;
            answer4.Checked = false;
        }

        private void RunTestingForm_Load(object sender, EventArgs e)
        {
            loadData(this.currentQuestionNum);
        }

        private bool isAnswerCorrect()
        {
            return (answer1.Checked == true && currentAnswers[0].isCorrect) || (answer2.Checked == true && currentAnswers[1].isCorrect) || (answer3.Checked == true && currentAnswers[2].isCorrect) || (answer4.Checked == true && currentAnswers[3].isCorrect);
        }

        private void reduceAttemptsCount()
        {
            database.openConnection();
            query = $"UPDATE Testing SET attempts_count=attempts_count-1 WHERE id={this.testingId}";
            command = new SqlCommand(query, database.getConnection());
            command.ExecuteNonQuery();
            
            query = $"SELECT attempts_count FROM Testing WHERE id={this.testingId}";
            command = new SqlCommand(query, database.getConnection());
            table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            int attemptsCount = Int32.Parse(table.Rows[0].ItemArray[0].ToString());

            if (attemptsCount < 1)
            {
                query = $"UPDATE Testing SET status_id=3 WHERE id={this.testingId}";
                command = new SqlCommand(query, database.getConnection());
                command.ExecuteNonQuery();
            }
            else
            {
                query = $"UPDATE Testing SET status_id=2 WHERE id={this.testingId}";
                command = new SqlCommand(query, database.getConnection());
                command.ExecuteNonQuery();
            }
            database.closeConnection();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (answer1.Checked == false && answer2.Checked == false && answer3.Checked == false && answer4.Checked == false)
            {
                MessageBox.Show("Выберите вариант ответа", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                currentQuestionNum++;
                if (isAnswerCorrect())
                {
                    correctAnswersCount++;
                }
                if (currentQuestionNum < questionsCount)
                {
                    loadData(currentQuestionNum);
                }
                else
                {
                    int percentage = (Int32)Math.Round(100 * ((Double)correctAnswersCount / (Double)questionsCount));
                    MessageBox.Show($"Процент правильных ответов: {percentage}%", "Тестирование завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string result;
                    if (percentage >= 75)
                    {
                        result = "Тестирование пройдено";
                    }
                    else
                    {
                        result = "Тестирование провалено. Дано меньше 75% правильных ответов";
                    }
                    query = $"INSERT INTO Result VALUES({this.testingId}, {this.employeeId}, {getTestId()}, {percentage}, '{result}', '{DateTime.Now.ToString()}')";
                    database.openConnection();
                    command = new SqlCommand(query, database.getConnection());
                    command.ExecuteNonQuery();
                    database.closeConnection();
                    reduceAttemptsCount();
                    this.Close();
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы уверены, что хотите завершить тестирование?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                reduceAttemptsCount();
                this.Close();
            }
        }

        private void RunTestingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            EmployeeTestingsForm main = this.Owner as EmployeeTestingsForm;
            if (main != null)
            {
                main.loadData();
            }
        }
    }
}
