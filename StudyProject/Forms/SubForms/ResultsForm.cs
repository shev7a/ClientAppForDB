using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudyProject
{
    public partial class ResultsForm : Form
    {
        DataBase database = new DataBase();

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table;
        SqlCommand command;
        string query;

        User user;

        public ResultsForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void loadData()
        {
            if (this.user.isExaminer)
            {
                query = $"SELECT R.testing_id AS '№ тестирования', Employee.login AS 'Сотрудник', Test.name AS Тестирование, R.percentage AS 'Правильные ответы, %', R.result AS 'Результат', R.datetime AS 'Дата' FROM Result AS R JOIN Test ON R.test_id=Test.id JOIN Employee ON R.employee_id=Employee.id ORDER BY R.id";
            }
            else
            {
                query = $"SELECT R.testing_id AS '№ тестирования', Test.name AS Тестирование, R.percentage AS 'Правильные ответы, %', R.result AS 'Результат', R.datetime AS 'Дата' FROM Result AS r JOIN Test ON R.test_id=Test.id WHERE R.employee_id={this.user.id} ORDER BY R.id";
            }
            table = new DataTable();
            command = new SqlCommand(query, database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            resultsTable.DataSource = table;
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            (resultsTable.DataSource as DataTable).DefaultView.RowFilter = String.Format("Тестирование LIKE '%{0}%'", searchInput.Text);
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
