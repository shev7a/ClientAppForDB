using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudyProject
{
    public partial class AuthForm : Form
    {

        DataBase database = new DataBase();

        public AuthForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            string login = loginInput.Text;
            string passwd = passwdInput.Text;
            bool isUserExaminer = isExaminer.Checked;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = "";
            if (isUserExaminer)
            {
                query = $"SELECT * FROM Examiner WHERE login = '{login}' AND password = '{passwd}'";
            }
            else
            {
                query = $"SELECT * FROM Employee WHERE login = '{login}' AND password = '{passwd}'";
            }

            SqlCommand command = new SqlCommand(query, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                DataRow row = table.Rows[0];

                int id = Convert.ToInt32(row["id"]);
                string surname = row["surname"].ToString();
                string name = row["name"].ToString();
                string patronymic = String.IsNullOrEmpty(row["patronymic"].ToString()) ? "" : row["patronymic"].ToString();
                string phone = row["phone"].ToString();
                string email = row["email"].ToString();
                string gender, job;
                gender = job = "";
                DateTime bday = new DateTime(1, 1, 1);

                if (!isUserExaminer)
                {
                    gender = row["gender"].ToString();
                    bday = Convert.ToDateTime(row["birthday"]);
                    job = row["job"].ToString();
                }

                User currentUser = new User(id, surname, name, patronymic, job, gender, bday, phone, email, login, passwd, isUserExaminer);

                MessageBox.Show("Вы успешно вошли!", "Успешная авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (!isUserExaminer)
                {
                    MainFormEmployee mainForm = new MainFormEmployee(currentUser);
                    this.Hide();
                    mainForm.ShowDialog();
                }
                else
                {
                    MainFormExaminer mainForm = new MainFormExaminer(currentUser);
                    this.Hide();
                    mainForm.ShowDialog();
                }
                
            } 
            else
            {
                MessageBox.Show("Логин и/или пароль указаны неверно. Повторите ввод", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loginInput.Clear();
                passwdInput.Clear();
                isExaminer.Checked = false;
            }

        }

        private void registrationLink_MouseHover(object sender, EventArgs e)
        {
            registrationLink.ForeColor = Color.Red;
        }

        private void registrationLink_MouseLeave(object sender, EventArgs e)
        {
            registrationLink.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void registrationLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void authButton_MouseHover(object sender, EventArgs e)
        {
            authButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            authButton.ForeColor = System.Drawing.SystemColors.Window;
        }

        private void closeButton_MouseHover(object sender, EventArgs e)
        {
            closeButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            closeButton.ForeColor = System.Drawing.SystemColors.Window;
        }
    }
}
