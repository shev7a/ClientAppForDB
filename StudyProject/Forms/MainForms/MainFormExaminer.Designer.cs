namespace StudyProject
{
    partial class MainFormExaminer
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
            this.header = new System.Windows.Forms.Panel();
            this.currentUserName = new System.Windows.Forms.Label();
            this.profileButton = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Panel();
            this.employeesButton = new System.Windows.Forms.Button();
            this.resultsButton = new System.Windows.Forms.Button();
            this.testsButton = new System.Windows.Forms.Button();
            this.testingsButton = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.Panel();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileButton)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.HotTrack;
            this.header.Controls.Add(this.currentUserName);
            this.header.Controls.Add(this.profileButton);
            this.header.Controls.Add(this.exitButton);
            this.header.Controls.Add(this.menuButton);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1200, 75);
            this.header.TabIndex = 0;
            // 
            // currentUserName
            // 
            this.currentUserName.AutoSize = true;
            this.currentUserName.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold);
            this.currentUserName.ForeColor = System.Drawing.Color.White;
            this.currentUserName.Location = new System.Drawing.Point(930, 23);
            this.currentUserName.Name = "currentUserName";
            this.currentUserName.Size = new System.Drawing.Size(119, 25);
            this.currentUserName.TabIndex = 3;
            this.currentUserName.Text = "Иванов И.И.";
            // 
            // profileButton
            // 
            this.profileButton.Image = global::StudyProject.Properties.Resources.profile_white;
            this.profileButton.Location = new System.Drawing.Point(875, 8);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(48, 48);
            this.profileButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileButton.TabIndex = 2;
            this.profileButton.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Image = global::StudyProject.Properties.Resources.exit_white_48px;
            this.exitButton.Location = new System.Drawing.Point(1125, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 75);
            this.exitButton.TabIndex = 1;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Image = global::StudyProject.Properties.Resources.menu_white_48px;
            this.menuButton.Location = new System.Drawing.Point(3, 0);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(75, 75);
            this.menuButton.TabIndex = 0;
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menu.Controls.Add(this.employeesButton);
            this.menu.Controls.Add(this.resultsButton);
            this.menu.Controls.Add(this.testsButton);
            this.menu.Controls.Add(this.testingsButton);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 75);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(245, 525);
            this.menu.TabIndex = 1;
            // 
            // employeesButton
            // 
            this.employeesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeesButton.FlatAppearance.BorderSize = 0;
            this.employeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeesButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold);
            this.employeesButton.ForeColor = System.Drawing.Color.White;
            this.employeesButton.Image = global::StudyProject.Properties.Resources.employees_white_48px;
            this.employeesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeesButton.Location = new System.Drawing.Point(0, 321);
            this.employeesButton.Name = "employeesButton";
            this.employeesButton.Size = new System.Drawing.Size(245, 100);
            this.employeesButton.TabIndex = 3;
            this.employeesButton.Text = "    Сотрудники";
            this.employeesButton.UseVisualStyleBackColor = true;
            this.employeesButton.Click += new System.EventHandler(this.employeesButton_Click);
            // 
            // resultsButton
            // 
            this.resultsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resultsButton.FlatAppearance.BorderSize = 0;
            this.resultsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultsButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold);
            this.resultsButton.ForeColor = System.Drawing.Color.White;
            this.resultsButton.Image = global::StudyProject.Properties.Resources.results_white_48px;
            this.resultsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resultsButton.Location = new System.Drawing.Point(0, 215);
            this.resultsButton.Name = "resultsButton";
            this.resultsButton.Size = new System.Drawing.Size(245, 100);
            this.resultsButton.TabIndex = 2;
            this.resultsButton.Text = "  Результаты";
            this.resultsButton.UseVisualStyleBackColor = true;
            this.resultsButton.Click += new System.EventHandler(this.resultsButton_Click);
            // 
            // testsButton
            // 
            this.testsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testsButton.FlatAppearance.BorderSize = 0;
            this.testsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testsButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold);
            this.testsButton.ForeColor = System.Drawing.Color.White;
            this.testsButton.Image = global::StudyProject.Properties.Resources.folder_white_48px;
            this.testsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.testsButton.Location = new System.Drawing.Point(0, 109);
            this.testsButton.Name = "testsButton";
            this.testsButton.Size = new System.Drawing.Size(245, 100);
            this.testsButton.TabIndex = 1;
            this.testsButton.Text = "  Банк тестов";
            this.testsButton.UseVisualStyleBackColor = true;
            this.testsButton.Click += new System.EventHandler(this.testsButton_Click);
            // 
            // testingsButton
            // 
            this.testingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testingsButton.FlatAppearance.BorderSize = 0;
            this.testingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testingsButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold);
            this.testingsButton.ForeColor = System.Drawing.Color.White;
            this.testingsButton.Image = global::StudyProject.Properties.Resources.testing_white_48px;
            this.testingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.testingsButton.Location = new System.Drawing.Point(0, 3);
            this.testingsButton.Name = "testingsButton";
            this.testingsButton.Size = new System.Drawing.Size(245, 100);
            this.testingsButton.TabIndex = 0;
            this.testingsButton.Text = "    Тестирования";
            this.testingsButton.UseVisualStyleBackColor = true;
            this.testingsButton.Click += new System.EventHandler(this.testingsButton_Click);
            // 
            // content
            // 
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(245, 75);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(955, 525);
            this.content.TabIndex = 2;
            // 
            // MainFormExaminer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.ControlBox = false;
            this.Controls.Add(this.content);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.header);
            this.Name = "MainFormExaminer";
            this.Text = "Система тестирования знаний кредитных инспекторов";
            this.Load += new System.EventHandler(this.MainFormExaminer_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileButton)).EndInit();
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label currentUserName;
        private System.Windows.Forms.PictureBox profileButton;
        private System.Windows.Forms.Button employeesButton;
        private System.Windows.Forms.Button resultsButton;
        private System.Windows.Forms.Button testsButton;
        private System.Windows.Forms.Button testingsButton;
        private System.Windows.Forms.Panel content;
    }
}