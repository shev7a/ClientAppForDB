using System;
using System.Windows.Forms;

namespace StudyProject
{
    public partial class MainFormEmployee : Form
    {

        User user;

        public MainFormEmployee(User user)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.user = user;

        }

        private void showFormOnPanel(object form)
        {
            if (this.content.Controls.Count > 0)
            {
                this.content.Controls.Clear();
            }
            Form newForm = form as Form;
            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;
            this.content.Controls.Add(newForm);
            newForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            currentUserName.Text = user.getFIO();
            showFormOnPanel(new EmployeeTestingsForm(this.user.id));
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы уверены, что хотите выйти из системы?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                AuthForm authForm = new AuthForm();
                this.Hide();
                authForm.ShowDialog();
            }
        }

        private void testingsButton_Click(object sender, EventArgs e)
        {
            showFormOnPanel(new EmployeeTestingsForm(this.user.id));
        }

        private void resultsButton_Click(object sender, EventArgs e)
        {
            showFormOnPanel(new ResultsForm(this.user));
        }
    }
}
