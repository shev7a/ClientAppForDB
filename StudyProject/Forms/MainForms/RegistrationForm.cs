using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace StudyProject
{
    public partial class RegistrationForm : Form
    {
        DataBase database = new DataBase();

        public RegistrationForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        bool IsValidEmail(string eMail)
        {
            bool result = false;

            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(eMail);

                result = (eMail.LastIndexOf(".") > eMail.LastIndexOf("@"));
            }
            catch
            {
                result = false;
            };

            return result;
        }

        bool isUsedEmail(string email)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand($"SELECT id FROM Employee WHERE email = '{email}' UNION SELECT id from Examiner WHERE email = '{email}'", database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table.Rows.Count >= 1;
        }

        bool isUsedPhoneNumber(string phone)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand($"SELECT id FROM Employee WHERE phone = '{phone}' UNION SELECT id FROM Examiner WHERE phone = '{phone}'", database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table.Rows.Count >= 1;
        }

        bool isUsedLogin(string login)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand($"SELECT id FROM Employee WHERE login = '{login}' UNION SELECT id FROM Examiner WHERE login = '{login}'", database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table.Rows.Count >= 1;
        }

        bool isValidTextField(string text)
        {
            Regex textRegex = new Regex(@"^[А-Яа-я]+$");
            return textRegex.IsMatch(text);
        }

        bool isValidPasswordLength(string passwd)
        {
            return passwd.Length >= 8;
        }

        bool checkRequiredFields()
        {
            Regex phoneRegex = new Regex(@"^\+7 \(\d\d\d\) \d\d\d-\d\d\d\d$");

            return (String.IsNullOrEmpty(nameInput.Text.Trim()) || String.IsNullOrEmpty(surnameInput.Text.Trim()) 
                || !phoneRegex.IsMatch(phoneInput.Text.Trim()) || String.IsNullOrEmpty(emailInput.Text.Trim()) 
                || String.IsNullOrEmpty(bankList.Text.Trim()) || String.IsNullOrEmpty(loginInput.Text.Trim())
                || String.IsNullOrEmpty(passwdInput.Text.Trim()) || String.IsNullOrEmpty(repeatPasswdInput.Text.Trim())
                || String.IsNullOrEmpty(jobInput.Text.Trim()));
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вернуться на форму авторизации?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                AuthForm auth = new AuthForm();
                auth.ShowDialog();
            }
            else if (dialogResult == DialogResult.No) 
            {
                Application.Exit();
            }
        }

        private void clearFormButton_Click(object sender, EventArgs e)
        {
            surnameInput.Clear();
            nameInput.Clear();
            patronymicInput.Clear();
            jobInput.Clear();
            phoneInput.Clear();
            emailInput.Clear();
            bdayPicker.Value = new DateTime(1970, 1, 1);
            maleRadioButton.Checked = true;
            femaleRadioButton.Checked = false;
            bankList.SelectedIndex = -1;
            loginInput.Clear();
            passwdInput.Clear();
            repeatPasswdInput.Clear();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            registerButton.Enabled = false;

            // значения по умолчанию
            maleRadioButton.Checked = true;
            bdayPicker.Value = new DateTime(1970, 1, 1);
            bdayPicker.MinDate = new DateTime(1900, 1, 1);
            bdayPicker.MaxDate = DateTime.Today;

            // заполняем список банков
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            database.openConnection();
            SqlCommand command = new SqlCommand($"SELECT id, name FROM Bank ORDER BY name", database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            bankList.DataSource = table;
            bankList.DisplayMember = "name";
            bankList.ValueMember = "id";
            database.closeConnection();

            bankList.SelectedIndex = -1;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (!repeatPasswdInput.Text.Equals(passwdInput.Text))
            {
                MessageBox.Show("Введенные пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwdInput.Clear();
                repeatPasswdInput.Clear();
                registerButton.Enabled = false;
            }
            else
            {
                string name = nameInput.Text.Trim();
                string surname = surnameInput.Text.Trim();
                string patronymic = patronymicInput.Text.Trim();
                string job = jobInput.Text.Trim();
                string phone = phoneInput.Text.Trim();
                string email = emailInput.Text.Trim();
                var bday = bdayPicker.Value;
                string gender = maleRadioButton.Checked ? "М" : "Ж";
                int bank_id = Int32.Parse(bankList.SelectedValue.ToString());
                string login = loginInput.Text.Trim();
                string passwd = passwdInput.Text.Trim();

                string query = $"INSERT INTO Employee VALUES('{surname}', '{name}', '{patronymic}', '{gender}', '{bday}', '{job}', '{phone}', '{email}', '{login}', '{passwd}', {bank_id})";

                database.openConnection();
                SqlCommand command = new SqlCommand(query, database.getConnection());

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт успешно создан!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    AuthForm authForm = new AuthForm();
                    authForm.ShowDialog();
                }

                database.closeConnection();
            }
            
        }

        private void surnameInput_Leave(object sender, EventArgs e)
        {
            if (!checkRequiredFields())
            {
                registerButton.Enabled= true;
            }
        }

        private void nameInput_Leave(object sender, EventArgs e)
        {
            if (!checkRequiredFields())
            {
                registerButton.Enabled = true;
            }
        }

        private void patronymicInput_Leave(object sender, EventArgs e)
        {
            if (!checkRequiredFields())
            {
                registerButton.Enabled = true;
            }
        }

        private void jobInput_Leave(object sender, EventArgs e)
        {
            if (!checkRequiredFields())
            {
                registerButton.Enabled = true;
            }
        }

        private void phoneInput_Leave(object sender, EventArgs e)
        {
            if (!checkRequiredFields())
            {
                registerButton.Enabled = true;
            }

            if (isUsedPhoneNumber(phoneInput.Text))
            {
                MessageBox.Show("Указанный номер телефона уже зарегистрирован", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phoneInput.Clear();
                registerButton.Enabled = false;
            }
        }

        private void emailInput_Leave(object sender, EventArgs e)
        {
            if (!checkRequiredFields())
            {
                registerButton.Enabled = true;
            }

            if (isUsedEmail(emailInput.Text))
            {
                MessageBox.Show("Указанный email уже зарегистрирован", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailInput.Clear();
                registerButton.Enabled = false;
            }
        }

        private void bdayPicker_Leave(object sender, EventArgs e)
        {
            if (!checkRequiredFields())
            {
                registerButton.Enabled = true;
            }
        }

        private void genderBox_Leave(object sender, EventArgs e)
        {
            if (!checkRequiredFields())
            {
                registerButton.Enabled = true;
            }
        }

        private void bankList_Leave(object sender, EventArgs e)
        {
            if (!checkRequiredFields())
            {
                registerButton.Enabled = true;
            }
        }

        private void loginInput_Leave(object sender, EventArgs e)
        {
            if (!checkRequiredFields())
            {
                registerButton.Enabled = true;
            }

            if (isUsedLogin(loginInput.Text))
            {
                MessageBox.Show("Указанный логин уже зарегистрирован", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginInput.Clear();
                registerButton.Enabled = false;
            }
        }

        private void passwdInput_Leave(object sender, EventArgs e)
        {
            if (!checkRequiredFields())
            {
                registerButton.Enabled = true;
            }

            if (passwdInput.Text.Length > 0 && !isValidPasswordLength(passwdInput.Text))
            {
                MessageBox.Show("Длина пароля должна быть не менее 8 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwdInput.Clear();
                registerButton.Enabled = false;
            }
        }

        private void repeatPasswdInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (!checkRequiredFields())
            {
                registerButton.Enabled = true;
            }
        }

    }
}
