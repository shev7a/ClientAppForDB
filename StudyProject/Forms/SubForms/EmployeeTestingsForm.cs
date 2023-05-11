using StudyProject.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudyProject
{
    public partial class EmployeeTestingsForm : Form
    {
        DataBase database = new DataBase();

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table;
        SqlCommand command;
        string query;

        int employeeId;

        public EmployeeTestingsForm(int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
        }

        public void loadData()
        {
            query = $"SELECT Testing.id AS '№ тестирования', Test.name AS 'Название теста', Examiner.login AS Эксперт, Testing.attempts_count AS 'Количество попыток', Status.text AS Статус FROM Testing " +
                    $"JOIN Examiner ON Testing.examiner_id=Examiner.id JOIN Status ON Testing.status_id=Status.id JOIN Test ON Testing.test_id=Test.id WHERE Testing.employee_id={this.employeeId} AND Status.id NOT IN (3, 4) ORDER BY '№ тестирования'";
            command = new SqlCommand(query, database.getConnection());
            table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            testingsTable.DataSource = table;

            if (table.Rows.Count == 0)
            {
                runButton.Enabled = false;
                finishButton.Enabled = false;
            }
        }

        private void EmployeeTestingsForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            int testingId = Int32.Parse(testingsTable.SelectedRows[0].Cells[0].Value.ToString());
            RunTestingForm runTestingForm = new RunTestingForm(testingId, employeeId);
            runTestingForm.Owner = this;
            runTestingForm.ShowDialog();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите завершить тест досрочно?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int testingId = Int32.Parse(testingsTable.SelectedRows[0].Cells[0].Value.ToString());
                database.openConnection();
                query = $"UPDATE Testing SET status_id=3 WHERE id={testingId}";
                command = new SqlCommand(query, database.getConnection());
                command.ExecuteNonQuery();
                database.closeConnection();
                MessageBox.Show($"Тестирование №{testingId} завершено", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
        }
    }
}
