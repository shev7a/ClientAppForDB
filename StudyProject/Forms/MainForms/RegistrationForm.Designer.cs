namespace StudyProject
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.clearFormButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.authInfoBox = new System.Windows.Forms.GroupBox();
            this.repeatPasswdInput = new System.Windows.Forms.MaskedTextBox();
            this.passwdInput = new System.Windows.Forms.MaskedTextBox();
            this.loginInput = new System.Windows.Forms.MaskedTextBox();
            this.repeatPasswdLabel = new System.Windows.Forms.Label();
            this.passwdLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.personalInfoBox = new System.Windows.Forms.GroupBox();
            this.hintLabel = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.MaskedTextBox();
            this.bdayPicker = new System.Windows.Forms.DateTimePicker();
            this.phoneInput = new System.Windows.Forms.MaskedTextBox();
            this.patronymicInput = new System.Windows.Forms.MaskedTextBox();
            this.jobInput = new System.Windows.Forms.MaskedTextBox();
            this.nameInput = new System.Windows.Forms.MaskedTextBox();
            this.surnameInput = new System.Windows.Forms.MaskedTextBox();
            this.bankLabel = new System.Windows.Forms.Label();
            this.bankList = new System.Windows.Forms.ComboBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.jobLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.genderBox = new System.Windows.Forms.GroupBox();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.patronymicLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.authInfoBox.SuspendLayout();
            this.personalInfoBox.SuspendLayout();
            this.genderBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(935, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.authInfoBox);
            this.panel2.Controls.Add(this.personalInfoBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(935, 350);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.clearFormButton);
            this.panel3.Controls.Add(this.exitButton);
            this.panel3.Controls.Add(this.registerButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(590, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(345, 205);
            this.panel3.TabIndex = 2;
            // 
            // clearFormButton
            // 
            this.clearFormButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.clearFormButton.Font = new System.Drawing.Font("Comic Sans MS", 9.5F, System.Drawing.FontStyle.Bold);
            this.clearFormButton.ForeColor = System.Drawing.SystemColors.Window;
            this.clearFormButton.Location = new System.Drawing.Point(76, 73);
            this.clearFormButton.Name = "clearFormButton";
            this.clearFormButton.Size = new System.Drawing.Size(200, 45);
            this.clearFormButton.TabIndex = 3;
            this.clearFormButton.Text = "Очистить форму";
            this.clearFormButton.UseVisualStyleBackColor = false;
            this.clearFormButton.Click += new System.EventHandler(this.clearFormButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.exitButton.Font = new System.Drawing.Font("Comic Sans MS", 9.5F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.SystemColors.Window;
            this.exitButton.Location = new System.Drawing.Point(76, 128);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(200, 45);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.registerButton.Font = new System.Drawing.Font("Comic Sans MS", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButton.ForeColor = System.Drawing.SystemColors.Window;
            this.registerButton.Location = new System.Drawing.Point(76, 22);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(200, 45);
            this.registerButton.TabIndex = 2;
            this.registerButton.Text = "Зарегистрироваться";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // authInfoBox
            // 
            this.authInfoBox.Controls.Add(this.repeatPasswdInput);
            this.authInfoBox.Controls.Add(this.passwdInput);
            this.authInfoBox.Controls.Add(this.loginInput);
            this.authInfoBox.Controls.Add(this.repeatPasswdLabel);
            this.authInfoBox.Controls.Add(this.passwdLabel);
            this.authInfoBox.Controls.Add(this.loginLabel);
            this.authInfoBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.authInfoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authInfoBox.Location = new System.Drawing.Point(590, 0);
            this.authInfoBox.Name = "authInfoBox";
            this.authInfoBox.Size = new System.Drawing.Size(345, 145);
            this.authInfoBox.TabIndex = 1;
            this.authInfoBox.TabStop = false;
            this.authInfoBox.Text = "Аутентификационные данные";
            // 
            // repeatPasswdInput
            // 
            this.repeatPasswdInput.Location = new System.Drawing.Point(180, 112);
            this.repeatPasswdInput.Name = "repeatPasswdInput";
            this.repeatPasswdInput.Size = new System.Drawing.Size(156, 24);
            this.repeatPasswdInput.TabIndex = 11;
            this.repeatPasswdInput.UseSystemPasswordChar = true;
            this.repeatPasswdInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.repeatPasswdInput_KeyUp);
            // 
            // passwdInput
            // 
            this.passwdInput.Location = new System.Drawing.Point(180, 81);
            this.passwdInput.Name = "passwdInput";
            this.passwdInput.Size = new System.Drawing.Size(156, 24);
            this.passwdInput.TabIndex = 10;
            this.passwdInput.UseSystemPasswordChar = true;
            this.passwdInput.Leave += new System.EventHandler(this.passwdInput_Leave);
            // 
            // loginInput
            // 
            this.loginInput.Location = new System.Drawing.Point(180, 43);
            this.loginInput.Name = "loginInput";
            this.loginInput.Size = new System.Drawing.Size(156, 24);
            this.loginInput.TabIndex = 9;
            this.loginInput.Leave += new System.EventHandler(this.loginInput_Leave);
            // 
            // repeatPasswdLabel
            // 
            this.repeatPasswdLabel.AutoSize = true;
            this.repeatPasswdLabel.Location = new System.Drawing.Point(16, 113);
            this.repeatPasswdLabel.Name = "repeatPasswdLabel";
            this.repeatPasswdLabel.Size = new System.Drawing.Size(143, 18);
            this.repeatPasswdLabel.TabIndex = 2;
            this.repeatPasswdLabel.Text = "Повторите пароль*";
            // 
            // passwdLabel
            // 
            this.passwdLabel.AutoSize = true;
            this.passwdLabel.Location = new System.Drawing.Point(16, 80);
            this.passwdLabel.Name = "passwdLabel";
            this.passwdLabel.Size = new System.Drawing.Size(67, 18);
            this.passwdLabel.TabIndex = 1;
            this.passwdLabel.Text = "Пароль*";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(16, 45);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(56, 18);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Логин*";
            // 
            // personalInfoBox
            // 
            this.personalInfoBox.Controls.Add(this.hintLabel);
            this.personalInfoBox.Controls.Add(this.emailInput);
            this.personalInfoBox.Controls.Add(this.bdayPicker);
            this.personalInfoBox.Controls.Add(this.phoneInput);
            this.personalInfoBox.Controls.Add(this.patronymicInput);
            this.personalInfoBox.Controls.Add(this.jobInput);
            this.personalInfoBox.Controls.Add(this.nameInput);
            this.personalInfoBox.Controls.Add(this.surnameInput);
            this.personalInfoBox.Controls.Add(this.bankLabel);
            this.personalInfoBox.Controls.Add(this.bankList);
            this.personalInfoBox.Controls.Add(this.emailLabel);
            this.personalInfoBox.Controls.Add(this.phoneLabel);
            this.personalInfoBox.Controls.Add(this.jobLabel);
            this.personalInfoBox.Controls.Add(this.birthdayLabel);
            this.personalInfoBox.Controls.Add(this.genderBox);
            this.personalInfoBox.Controls.Add(this.patronymicLabel);
            this.personalInfoBox.Controls.Add(this.nameLabel);
            this.personalInfoBox.Controls.Add(this.surnameLabel);
            this.personalInfoBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.personalInfoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personalInfoBox.Location = new System.Drawing.Point(0, 0);
            this.personalInfoBox.Name = "personalInfoBox";
            this.personalInfoBox.Size = new System.Drawing.Size(590, 350);
            this.personalInfoBox.TabIndex = 0;
            this.personalInfoBox.TabStop = false;
            this.personalInfoBox.Text = "Личные данные";
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.Location = new System.Drawing.Point(404, 323);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(166, 18);
            this.hintLabel.TabIndex = 14;
            this.hintLabel.Text = "* - обязательные поля";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(165, 237);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(168, 24);
            this.emailInput.TabIndex = 5;
            this.emailInput.Leave += new System.EventHandler(this.emailInput_Leave);
            // 
            // bdayPicker
            // 
            this.bdayPicker.Location = new System.Drawing.Point(356, 55);
            this.bdayPicker.Name = "bdayPicker";
            this.bdayPicker.Size = new System.Drawing.Size(179, 24);
            this.bdayPicker.TabIndex = 6;
            this.bdayPicker.Leave += new System.EventHandler(this.bdayPicker_Leave);
            // 
            // phoneInput
            // 
            this.phoneInput.Location = new System.Drawing.Point(165, 199);
            this.phoneInput.Mask = "+7 (999) 000-0000";
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(168, 24);
            this.phoneInput.TabIndex = 4;
            this.phoneInput.Leave += new System.EventHandler(this.phoneInput_Leave);
            // 
            // patronymicInput
            // 
            this.patronymicInput.Location = new System.Drawing.Point(165, 115);
            this.patronymicInput.Name = "patronymicInput";
            this.patronymicInput.Size = new System.Drawing.Size(167, 24);
            this.patronymicInput.TabIndex = 2;
            this.patronymicInput.Leave += new System.EventHandler(this.patronymicInput_Leave);
            // 
            // jobInput
            // 
            this.jobInput.Location = new System.Drawing.Point(165, 157);
            this.jobInput.Name = "jobInput";
            this.jobInput.Size = new System.Drawing.Size(168, 24);
            this.jobInput.TabIndex = 3;
            this.jobInput.Leave += new System.EventHandler(this.jobInput_Leave);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(165, 77);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(167, 24);
            this.nameInput.TabIndex = 1;
            this.nameInput.Leave += new System.EventHandler(this.nameInput_Leave);
            // 
            // surnameInput
            // 
            this.surnameInput.Location = new System.Drawing.Point(165, 43);
            this.surnameInput.Name = "surnameInput";
            this.surnameInput.Size = new System.Drawing.Size(167, 24);
            this.surnameInput.TabIndex = 0;
            this.surnameInput.Leave += new System.EventHandler(this.surnameInput_Leave);
            // 
            // bankLabel
            // 
            this.bankLabel.AutoSize = true;
            this.bankLabel.Location = new System.Drawing.Point(353, 177);
            this.bankLabel.Name = "bankLabel";
            this.bankLabel.Size = new System.Drawing.Size(48, 18);
            this.bankLabel.TabIndex = 9;
            this.bankLabel.Text = "Банк*";
            // 
            // bankList
            // 
            this.bankList.FormattingEnabled = true;
            this.bankList.Location = new System.Drawing.Point(356, 199);
            this.bankList.Name = "bankList";
            this.bankList.Size = new System.Drawing.Size(172, 26);
            this.bankList.TabIndex = 8;
            this.bankList.Leave += new System.EventHandler(this.bankList_Leave);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(12, 237);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(51, 18);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "Email*";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(12, 194);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(135, 18);
            this.phoneLabel.TabIndex = 6;
            this.phoneLabel.Text = "Номер телефона*";
            // 
            // jobLabel
            // 
            this.jobLabel.AutoSize = true;
            this.jobLabel.Location = new System.Drawing.Point(12, 157);
            this.jobLabel.Name = "jobLabel";
            this.jobLabel.Size = new System.Drawing.Size(95, 18);
            this.jobLabel.TabIndex = 5;
            this.jobLabel.Text = "Должность*";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Location = new System.Drawing.Point(353, 34);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(122, 18);
            this.birthdayLabel.TabIndex = 4;
            this.birthdayLabel.Text = "Дата рождения*";
            // 
            // genderBox
            // 
            this.genderBox.Controls.Add(this.femaleRadioButton);
            this.genderBox.Controls.Add(this.maleRadioButton);
            this.genderBox.Location = new System.Drawing.Point(356, 91);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(123, 70);
            this.genderBox.TabIndex = 7;
            this.genderBox.TabStop = false;
            this.genderBox.Text = "Пол";
            this.genderBox.Leave += new System.EventHandler(this.genderBox_Leave);
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(7, 44);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(43, 22);
            this.femaleRadioButton.TabIndex = 1;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Ж";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(7, 19);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(42, 22);
            this.maleRadioButton.TabIndex = 0;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "М";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // patronymicLabel
            // 
            this.patronymicLabel.AutoSize = true;
            this.patronymicLabel.Location = new System.Drawing.Point(13, 118);
            this.patronymicLabel.Name = "patronymicLabel";
            this.patronymicLabel.Size = new System.Drawing.Size(75, 18);
            this.patronymicLabel.TabIndex = 2;
            this.patronymicLabel.Text = "Отчество";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 79);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 18);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Имя*";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(13, 43);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(79, 18);
            this.surnameLabel.TabIndex = 0;
            this.surnameLabel.Text = "Фамилия*";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RegistrationForm";
            this.Text = "Система тестирования знаний кредитных инспекторов";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.authInfoBox.ResumeLayout(false);
            this.authInfoBox.PerformLayout();
            this.personalInfoBox.ResumeLayout(false);
            this.personalInfoBox.PerformLayout();
            this.genderBox.ResumeLayout(false);
            this.genderBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox authInfoBox;
        private System.Windows.Forms.Label repeatPasswdLabel;
        private System.Windows.Forms.Label passwdLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.GroupBox personalInfoBox;
        private System.Windows.Forms.MaskedTextBox patronymicInput;
        private System.Windows.Forms.MaskedTextBox nameInput;
        private System.Windows.Forms.MaskedTextBox surnameInput;
        private System.Windows.Forms.Label bankLabel;
        private System.Windows.Forms.ComboBox bankList;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label jobLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.GroupBox genderBox;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.Label patronymicLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.MaskedTextBox repeatPasswdInput;
        private System.Windows.Forms.MaskedTextBox passwdInput;
        private System.Windows.Forms.MaskedTextBox loginInput;
        private System.Windows.Forms.MaskedTextBox emailInput;
        private System.Windows.Forms.DateTimePicker bdayPicker;
        private System.Windows.Forms.MaskedTextBox phoneInput;
        private System.Windows.Forms.MaskedTextBox jobInput;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label hintLabel;
        private System.Windows.Forms.Button clearFormButton;
    }
}