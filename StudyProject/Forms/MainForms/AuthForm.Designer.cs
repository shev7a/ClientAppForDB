using System.Drawing;

namespace StudyProject
{
    partial class AuthForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.isExaminer = new System.Windows.Forms.CheckBox();
            this.registrationLink = new System.Windows.Forms.Label();
            this.noAccountYetLabel = new System.Windows.Forms.Label();
            this.authButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.passwdInput = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginInput = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.isExaminer);
            this.panel1.Controls.Add(this.registrationLink);
            this.panel1.Controls.Add(this.noAccountYetLabel);
            this.panel1.Controls.Add(this.authButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.passwdInput);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.loginInput);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 487);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // isExaminer
            // 
            this.isExaminer.AutoSize = true;
            this.isExaminer.Location = new System.Drawing.Point(45, 304);
            this.isExaminer.Name = "isExaminer";
            this.isExaminer.Size = new System.Drawing.Size(252, 20);
            this.isExaminer.TabIndex = 9;
            this.isExaminer.Text = "Авторизоваться как экзаменатор";
            this.isExaminer.UseVisualStyleBackColor = true;
            // 
            // registrationLink
            // 
            this.registrationLink.AutoSize = true;
            this.registrationLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationLink.ForeColor = System.Drawing.SystemColors.ControlText;
            this.registrationLink.Location = new System.Drawing.Point(192, 428);
            this.registrationLink.Name = "registrationLink";
            this.registrationLink.Size = new System.Drawing.Size(102, 16);
            this.registrationLink.TabIndex = 8;
            this.registrationLink.Text = "Регистрация";
            this.registrationLink.Click += new System.EventHandler(this.registrationLink_Click);
            this.registrationLink.MouseLeave += new System.EventHandler(this.registrationLink_MouseLeave);
            this.registrationLink.MouseHover += new System.EventHandler(this.registrationLink_MouseHover);
            // 
            // noAccountYetLabel
            // 
            this.noAccountYetLabel.AutoSize = true;
            this.noAccountYetLabel.Location = new System.Drawing.Point(178, 412);
            this.noAccountYetLabel.Name = "noAccountYetLabel";
            this.noAccountYetLabel.Size = new System.Drawing.Size(132, 16);
            this.noAccountYetLabel.TabIndex = 7;
            this.noAccountYetLabel.Text = "Еще нет аккаунта?";
            // 
            // authButton
            // 
            this.authButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.authButton.Font = new System.Drawing.Font("Comic Sans MS", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authButton.ForeColor = System.Drawing.SystemColors.Window;
            this.authButton.Location = new System.Drawing.Point(271, 352);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(117, 45);
            this.authButton.TabIndex = 5;
            this.authButton.Text = "Войти";
            this.authButton.UseVisualStyleBackColor = false;
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            this.authButton.MouseHover += new System.EventHandler(this.authButton_MouseHover);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.closeButton.Font = new System.Drawing.Font("Comic Sans MS", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.Window;
            this.closeButton.Location = new System.Drawing.Point(88, 352);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(116, 45);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseHover += new System.EventHandler(this.closeButton_MouseHover);
            // 
            // passwdInput
            // 
            this.passwdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwdInput.Location = new System.Drawing.Point(128, 223);
            this.passwdInput.MaxLength = 50;
            this.passwdInput.Name = "passwdInput";
            this.passwdInput.Size = new System.Drawing.Size(303, 34);
            this.passwdInput.TabIndex = 4;
            this.passwdInput.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StudyProject.Properties.Resources.passwd;
            this.pictureBox2.Location = new System.Drawing.Point(45, 210);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // loginInput
            // 
            this.loginInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginInput.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginInput.Location = new System.Drawing.Point(128, 138);
            this.loginInput.MaxLength = 50;
            this.loginInput.Name = "loginInput";
            this.loginInput.Size = new System.Drawing.Size(303, 34);
            this.loginInput.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudyProject.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(45, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.Window;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 90);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 487);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "AuthForm";
            this.Text = "Система тестирования знаний кредитных инспекторов";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox loginInput;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox passwdInput;
        private System.Windows.Forms.Button authButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label registrationLink;
        private System.Windows.Forms.Label noAccountYetLabel;
        private System.Windows.Forms.CheckBox isExaminer;
    }
}

