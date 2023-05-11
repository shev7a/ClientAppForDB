using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudyProject
{
    public partial class EmployeesForm : Form
    {

        DataBase database = new DataBase();

        public EmployeesForm()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand($"SELECT surname AS Фамилия, name AS Имя, patronymic AS Отчество, gender AS Пол, birthday AS 'Дата рождения', job AS Должность, phone AS 'Номер телефона', email FROM Employee ORDER BY id", database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            employeesTable.DataSource = table;
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            searchInput.Clear();
            loadData();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            (employeesTable.DataSource as DataTable).DefaultView.RowFilter = String.Format("Фамилия LIKE '%{0}%'", searchInput.Text);
        }
    }
}
