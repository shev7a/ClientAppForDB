using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudyProject
{
    public partial class CreateTestForm : Form
    {
        DataBase database = new DataBase();

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table;
        SqlCommand command;
        string query;

        Test test;
        int examiner_id;

        public CreateTestForm(Test test, int examiner_id)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.test = test;
            this.examiner_id = examiner_id;
        }

        public void loadData(int testId)
        {
            table = new DataTable();
            database.openConnection();
            command = new SqlCommand($"SELECT id, text FROM Question WHERE test_id={test.id} ORDER BY id", database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            test.question_count = table.Rows.Count;

            questionList.DataSource = table;
            questionList.DisplayMember = "text";
            questionList.ValueMember = "id";

            database.closeConnection();
        }
        private void CreateTestForm_Load(object sender, EventArgs e)
        {
            if (test.id != -1)
            {
                headerText.Text = "Редактирование теста";
                nameInput.Text = test.name;
                
                loadData(test.id);
            }
            else
            {
                database.openConnection();
                query = $"INSERT INTO Test VALUES('', {0}, {examiner_id});" + "SELECT CAST(scope_identity() AS int)";
                command = new SqlCommand(query, database.getConnection());
                int newTestId = (Int32)command.ExecuteScalar();
                this.test = new Test(newTestId, examiner_id, nameInput.Text, 0);
                database.closeConnection();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["AddQuestionForm"] as AddQuestionForm) == null)
            {
                AddQuestionForm addQuestionForm = new AddQuestionForm(test.id, test.name);
                addQuestionForm.Owner = this;
                addQuestionForm.ShowDialog();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int questionId = Int32.Parse(questionList.SelectedValue.ToString());
            if ((Application.OpenForms["AddQuestionForm"] as AddQuestionForm) == null)
            {
                AddQuestionForm addQuestionForm = new AddQuestionForm(test.id, test.name, questionId);
                addQuestionForm.Owner = this;
                addQuestionForm.ShowDialog();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int questionId = Int32.Parse(questionList.SelectedValue.ToString());
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить вопрос?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                database.openConnection();
                query = $"DELETE FROM Answer WHERE question_id={questionId}";
                command = new SqlCommand(query, database.getConnection());
                command.ExecuteNonQuery();
                query = $"DELETE FROM Question WHERE id={questionId}";
                command = new SqlCommand(query, database.getConnection());
                command.ExecuteNonQuery();
                database.closeConnection();
                this.loadData(test.id);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            database.openConnection();
            query = $"UPDATE Test SET name='{nameInput.Text}', question_count={test.question_count} WHERE id={test.id}";
            command = new SqlCommand(query, database.getConnection());
            command.ExecuteNonQuery();
            database.closeConnection();
            this.Close();
        }

        private void CreateTestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestBankForm main = this.Owner as TestBankForm;
            if (main != null)
            {
                main.loadData();
            }
        }
    }
}
