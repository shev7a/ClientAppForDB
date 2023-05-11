namespace StudyProject
{
    partial class MainFormEmployee
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
            this.exitButton = new System.Windows.Forms.Button();
            this.resultsButton = new System.Windows.Forms.Button();
            this.testingsButton = new System.Windows.Forms.Button();
            this.currentUserName = new System.Windows.Forms.Label();
            this.profileButton = new System.Windows.Forms.PictureBox();
            this.content = new System.Windows.Forms.Panel();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileButton)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.HotTrack;
            this.header.Controls.Add(this.exitButton);
            this.header.Controls.Add(this.resultsButton);
            this.header.Controls.Add(this.testingsButton);
            this.header.Controls.Add(this.currentUserName);
            this.header.Controls.Add(this.profileButton);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1200, 100);
            this.header.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Image = global::StudyProject.Properties.Resources.exit_white_64px;
            this.exitButton.Location = new System.Drawing.Point(1100, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 100);
            this.exitButton.TabIndex = 6;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
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
            this.resultsButton.Location = new System.Drawing.Point(291, 0);
            this.resultsButton.Name = "resultsButton";
            this.resultsButton.Size = new System.Drawing.Size(285, 100);
            this.resultsButton.TabIndex = 5;
            this.resultsButton.Text = "Результаты";
            this.resultsButton.UseVisualStyleBackColor = true;
            this.resultsButton.Click += new System.EventHandler(this.resultsButton_Click);
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
            this.testingsButton.Location = new System.Drawing.Point(0, 0);
            this.testingsButton.Name = "testingsButton";
            this.testingsButton.Size = new System.Drawing.Size(285, 100);
            this.testingsButton.TabIndex = 0;
            this.testingsButton.Text = "Тестирования";
            this.testingsButton.UseVisualStyleBackColor = true;
            this.testingsButton.Click += new System.EventHandler(this.testingsButton_Click);
            // 
            // currentUserName
            // 
            this.currentUserName.AutoSize = true;
            this.currentUserName.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentUserName.ForeColor = System.Drawing.Color.White;
            this.currentUserName.Location = new System.Drawing.Point(928, 36);
            this.currentUserName.Name = "currentUserName";
            this.currentUserName.Size = new System.Drawing.Size(119, 25);
            this.currentUserName.TabIndex = 4;
            this.currentUserName.Text = "Иванов И.И.";
            // 
            // profileButton
            // 
            this.profileButton.Image = global::StudyProject.Properties.Resources.profile_white;
            this.profileButton.Location = new System.Drawing.Point(862, 19);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(60, 60);
            this.profileButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileButton.TabIndex = 2;
            this.profileButton.TabStop = false;
            // 
            // content
            // 
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 100);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1200, 500);
            this.content.TabIndex = 1;
            // 
            // MainFormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.ControlBox = false;
            this.Controls.Add(this.content);
            this.Controls.Add(this.header);
            this.Name = "MainFormEmployee";
            this.Text = "Система тестирования знаний кредитных инспекторов";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label currentUserName;
        private System.Windows.Forms.PictureBox profileButton;
        private System.Windows.Forms.Button testingsButton;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Button resultsButton;
        private System.Windows.Forms.Button exitButton;
    }
}