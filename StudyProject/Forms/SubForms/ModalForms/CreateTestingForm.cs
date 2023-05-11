using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace StudyProject
{
    public partial class CreateTestingForm : Form
    {
        DataBase database = new DataBase();

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table;
        SqlCommand command;
        string query;

        int examinerId;

        public CreateTestingForm(int examinerId)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.examinerId = examinerId;
        }

        private void loadData()
        {
            query = $"SELECT surname AS Фамилия, name AS Имя, patronymic AS Отчество, birthday AS 'Дата рождения', job AS Должность, email FROM Employee ORDER BY Фамилия";
            command = new SqlCommand(query, database.getConnection());
            table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            employeesTable.DataSource = table;

            query = $"SELECT Test.name as Название, Test.question_count as 'Количество вопросов', Examiner.login as Автор FROM Test JOIN Examiner ON Test.examiner_id=Examiner.id ORDER BY Test.id";
            command = new SqlCommand(query, database.getConnection());
            table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            testingsTable.DataSource = table;
        }


        private void CreateTestingForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void surnameInput_TextChanged(object sender, EventArgs e)
        {
            (employeesTable.DataSource as DataTable).DefaultView.RowFilter = String.Format("Фамилия LIKE '%{0}%'", surnameInput.Text);
        }

        private void testNameInput_TextChanged(object sender, EventArgs e)
        {
            (testingsTable.DataSource as DataTable).DefaultView.RowFilter = String.Format("Название LIKE '%{0}%'", testNameInput.Text);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(attemptsInput.Text.Trim()))
            {
                MessageBox.Show("Укажите количество попыток", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string employeeEmail = employeesTable.SelectedRows[0].Cells[5].Value.ToString();
                table = new DataTable();
                command = new SqlCommand($"SELECT id FROM Employee WHERE email = '{employeeEmail}'", database.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);
                int employeeId = Int32.Parse(table.Rows[0].ItemArray[0].ToString());

                string testName = testingsTable.SelectedRows[0].Cells[0].Value.ToString();
                table = new DataTable();
                command = new SqlCommand($"SELECT id FROM Test WHERE name = '{testName}'", database.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);
                int testId = Int32.Parse(table.Rows[0].ItemArray[0].ToString());

                int attemptsCount = Int32.Parse(attemptsInput.Text);
                database.openConnection();
                query = $"INSERT INTO Testing VALUES({employeeId}, {this.examinerId}, {testId}, {attemptsCount}, {1})";
                command = new SqlCommand(query , database.getConnection());
                command.ExecuteNonQuery();
                database.closeConnection();
                MessageBox.Show("Тестирование было успешно создано", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void attemptsInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void CreateTestingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestingsListForm main = this.Owner as TestingsListForm;
            if (main != null)
            {
                main.loadData();
            }
        }
    }
}
