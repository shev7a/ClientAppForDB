using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudyProject
{
    public partial class TestingsListForm : Form
    {
        DataBase database = new DataBase();

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table;
        SqlCommand command;
        string query;

        int examinerId;

        public TestingsListForm(int examinerId)
        {
            InitializeComponent();
            this.examinerId = examinerId;
        }

        public void loadData(bool onlyActive = false)
        {
            if (onlyActive)
            {
                query = $"SELECT Testing.id AS '№ тестирования', Test.name AS 'Название теста', Employee.login AS Cотрудник, Examiner.login AS Эксперт, Testing.attempts_count AS 'Количество попыток', Status.text AS Статус FROM Testing " +
                $"JOIN Employee ON Testing.employee_id=Employee.id JOIN Examiner ON Testing.examiner_id=Examiner.id JOIN Status ON Testing.status_id=Status.id JOIN Test ON Testing.test_id=Test.id WHERE Testing.status_id NOT IN (3,4) ORDER BY '№ тестирования'";
                command = new SqlCommand(query, database.getConnection());
            }
            else
            {
                query = $"SELECT Testing.id AS '№ тестирования', Test.name AS 'Название теста', Employee.login AS Cотрудник, Examiner.login AS Эксперт, Testing.attempts_count AS 'Количество попыток', Status.text AS Статус FROM Testing " +
                $"JOIN Employee ON Testing.employee_id=Employee.id JOIN Examiner ON Testing.examiner_id=Examiner.id JOIN Status ON Testing.status_id=Status.id JOIN Test ON Testing.test_id=Test.id ORDER BY '№ тестирования'";
                command = new SqlCommand(query, database.getConnection());
            }
            
            table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            testingsTable.DataSource = table;
        }

        private void TestingsListForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["CreateTestForm"] as CreateTestForm) == null)
            {
                CreateTestingForm createTestingForm = new CreateTestingForm(this.examinerId);
                createTestingForm.Owner = this;
                createTestingForm.ShowDialog();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int testingId = Int32.Parse(testingsTable.SelectedRows[0].Cells[0].Value.ToString());
            database.openConnection();
            query = $"UPDATE Testing SET status_id=4 WHERE id={testingId}";
            command = new SqlCommand(query, database.getConnection());
            command.ExecuteNonQuery();
            database.closeConnection();
            MessageBox.Show($"Тестирование №{testingId} отменено", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadData();
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            (testingsTable.DataSource as DataTable).DefaultView.RowFilter = String.Format("Cотрудник LIKE '%{0}%'", searchInput.Text);
        }

        private void onlyActiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            loadData(onlyActiveCheckBox.Checked);
        }
    }
}
