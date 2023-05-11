using System;
using System.Windows.Forms;

namespace StudyProject
{
    public partial class MainFormExaminer : Form
    {

        User user;

        public MainFormExaminer(User user)
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
            menu.Hide();
        }

        private void MainFormExaminer_Load(object sender, EventArgs e)
        {
            currentUserName.Text = user.getFIO();
            showFormOnPanel(new TestingsListForm(this.user.id));
            menu.Show();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            if (!menu.Visible)
            {
                menu.Show();
            }
            else
            {
                menu.Hide();
            }
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
            showFormOnPanel(new TestingsListForm(this.user.id));
        }

        private void testsButton_Click(object sender, EventArgs e)
        {
            showFormOnPanel(new TestBankForm(this.user));
        }

        private void resultsButton_Click(object sender, EventArgs e)
        {
            showFormOnPanel(new ResultsForm(this.user));
        }

        private void employeesButton_Click(object sender, EventArgs e)
        {
            showFormOnPanel(new EmployeesForm());
        }
    }
}
