using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudyProject
{
    public partial class TestBankForm : Form
    {

        DataBase database = new DataBase();
        User examiner;

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table;
        SqlCommand command;

        public TestBankForm(User examiner)
        {
            InitializeComponent();
            this.examiner = examiner;

        }

        public void loadData(int id = -1)
        {
            if (id == -1)
            {
                command = new SqlCommand($"SELECT Test.name as Название, Test.question_count as 'Количество вопросов', Examiner.login as Автор FROM Test JOIN Examiner ON Test.examiner_id=Examiner.id ORDER BY Test.id", database.getConnection());
            }
            else {
                command = new SqlCommand($"SELECT Test.name as Название, Test.question_count as 'Количество вопросов', Examiner.login as Автор FROM Test JOIN Examiner ON Test.examiner_id=Examiner.id WHERE examiner_id={id} ORDER BY Test.id", database.getConnection());
            }
            table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            testsTable.DataSource = table;
        }

        private void TestBankForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        Test getPickedTest(string name)
        {
            table = new DataTable();
            command = new SqlCommand($"SELECT id FROM Test WHERE name = '{name}'", database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            int id = Int32.Parse(table.Rows[0].ItemArray[0].ToString());

            command = new SqlCommand($"SELECT question_count, examiner_id FROM Test WHERE id = '{id}'", database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            var data = table.Rows[0].ItemArray;

            int questionCount = Int32.Parse(data[0].ToString());
            int examinerId = Int32.Parse(data[0].ToString());

            return new Test(id, examinerId, name, questionCount);
        }

        private void createTestButton_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["CreateTestForm"] as CreateTestForm) == null)
            {
                CreateTestForm createForm = new CreateTestForm(new Test(), examiner.id);
                createForm.Owner = this;
                createForm.Show();
            }
        }

        private void editTestButton_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["CreateTestForm"] as CreateTestForm) == null)
            {
                string pickedTestName = "";
                try
                {
                    pickedTestName = testsTable.SelectedRows[0].Cells[0].Value.ToString();
                }
                catch (ArgumentOutOfRangeException)
                {
                    return;
                }
                Test pickedTest = getPickedTest(pickedTestName);
                CreateTestForm createForm = new CreateTestForm(pickedTest, pickedTest.examiner_id);
                createForm.Owner = this;
                createForm.Show();
            }                       
        }

        private void deleteTestButton_Click(object sender, EventArgs e)
        {
            string pickedTestName = "";
            try
            {
                pickedTestName = testsTable.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch (System.ArgumentOutOfRangeException) 
            {
                return;
            }
            Test pickedTest = getPickedTest(pickedTestName);
            DialogResult dialogResult = MessageBox.Show($"Вы уверены, что хотите удалить тест '{pickedTestName}'?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                table = new DataTable();
                command = new SqlCommand($"SELECT * FROM Testing WHERE test_id={pickedTest.id}", database.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show($"Невозможно удалить данный тест, так как по нему уже проводятся тестирования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    database.openConnection();
                    List<Question> questions = pickedTest.getQuestionsList();
                    foreach (Question q in questions)
                    {
                        List<Answer> answers = q.getAnswersListFromDB();
                        foreach (Answer a in answers)
                        {
                            command = new SqlCommand($"DELETE FROM Answer WHERE id = '{a.id}'", database.getConnection());
                            command.ExecuteNonQuery();
                        }
                        command = new SqlCommand($"DELETE FROM Question WHERE id = '{q.id}'", database.getConnection());
                        command.ExecuteNonQuery();
                    }
                    command = new SqlCommand($"DELETE FROM Test WHERE id = '{pickedTest.id}'", database.getConnection());
                    command.ExecuteNonQuery();
                    database.closeConnection();
                    loadData();
                }                              
            }
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            searchInput.Clear();
            filterCheckBox.Checked = false;
            loadData();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void filterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (filterCheckBox.Checked)
            {
                loadData(examiner.id);
            }
            else
            {
                loadData();
            }
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            (testsTable.DataSource as DataTable).DefaultView.RowFilter = String.Format("Название LIKE '%{0}%'", searchInput.Text);
        }
    }
}
