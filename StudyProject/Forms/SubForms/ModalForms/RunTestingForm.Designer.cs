namespace StudyProject.Forms
{
    partial class RunTestingForm
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
            this.questionNumLabel = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.questionGroupBox = new System.Windows.Forms.GroupBox();
            this.answer4 = new System.Windows.Forms.RadioButton();
            this.answer3 = new System.Windows.Forms.RadioButton();
            this.answer2 = new System.Windows.Forms.RadioButton();
            this.answer1 = new System.Windows.Forms.RadioButton();
            this.question = new System.Windows.Forms.Panel();
            this.header.SuspendLayout();
            this.content.SuspendLayout();
            this.questionGroupBox.SuspendLayout();
            this.question.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.HotTrack;
            this.header.Controls.Add(this.questionNumLabel);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(839, 75);
            this.header.TabIndex = 0;
            // 
            // questionNumLabel
            // 
            this.questionNumLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionNumLabel.Font = new System.Drawing.Font("Comic Sans MS", 17F, System.Drawing.FontStyle.Bold);
            this.questionNumLabel.ForeColor = System.Drawing.Color.White;
            this.questionNumLabel.Location = new System.Drawing.Point(0, 0);
            this.questionNumLabel.Name = "questionNumLabel";
            this.questionNumLabel.Size = new System.Drawing.Size(839, 75);
            this.questionNumLabel.TabIndex = 0;
            this.questionNumLabel.Text = "Вопрос №1";
            this.questionNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // content
            // 
            this.content.Controls.Add(this.question);
            this.content.Controls.Add(this.exitButton);
            this.content.Controls.Add(this.nextButton);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 75);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(839, 385);
            this.content.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(63, 295);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(278, 43);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Завершить тестирование";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(487, 295);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(278, 43);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Следующий вопрос";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // questionGroupBox
            // 
            this.questionGroupBox.Controls.Add(this.answer4);
            this.questionGroupBox.Controls.Add(this.answer3);
            this.questionGroupBox.Controls.Add(this.answer2);
            this.questionGroupBox.Controls.Add(this.answer1);
            this.questionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionGroupBox.Location = new System.Drawing.Point(0, 0);
            this.questionGroupBox.Name = "questionGroupBox";
            this.questionGroupBox.Size = new System.Drawing.Size(839, 235);
            this.questionGroupBox.TabIndex = 0;
            this.questionGroupBox.TabStop = false;
            this.questionGroupBox.Text = "groupBox1";
            // 
            // answer4
            // 
            this.answer4.AutoSize = true;
            this.answer4.Location = new System.Drawing.Point(15, 159);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(103, 20);
            this.answer4.TabIndex = 3;
            this.answer4.TabStop = true;
            this.answer4.Tag = "4";
            this.answer4.Text = "radioButton1";
            this.answer4.UseVisualStyleBackColor = true;
            // 
            // answer3
            // 
            this.answer3.AutoSize = true;
            this.answer3.Location = new System.Drawing.Point(15, 118);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(103, 20);
            this.answer3.TabIndex = 2;
            this.answer3.TabStop = true;
            this.answer3.Tag = "3";
            this.answer3.Text = "radioButton1";
            this.answer3.UseVisualStyleBackColor = true;
            // 
            // answer2
            // 
            this.answer2.AutoSize = true;
            this.answer2.Location = new System.Drawing.Point(15, 78);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(103, 20);
            this.answer2.TabIndex = 1;
            this.answer2.TabStop = true;
            this.answer2.Tag = "2";
            this.answer2.Text = "radioButton1";
            this.answer2.UseVisualStyleBackColor = true;
            // 
            // answer1
            // 
            this.answer1.AutoSize = true;
            this.answer1.Location = new System.Drawing.Point(15, 41);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(103, 20);
            this.answer1.TabIndex = 0;
            this.answer1.TabStop = true;
            this.answer1.Tag = "1";
            this.answer1.Text = "radioButton1";
            this.answer1.UseVisualStyleBackColor = true;
            // 
            // question
            // 
            this.question.Controls.Add(this.questionGroupBox);
            this.question.Dock = System.Windows.Forms.DockStyle.Top;
            this.question.Location = new System.Drawing.Point(0, 0);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(839, 235);
            this.question.TabIndex = 3;
            // 
            // RunTestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 460);
            this.ControlBox = false;
            this.Controls.Add(this.content);
            this.Controls.Add(this.header);
            this.Name = "RunTestingForm";
            this.Text = "Система тестирования знаний кредитных инспекторов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RunTestingForm_FormClosed);
            this.Load += new System.EventHandler(this.RunTestingForm_Load);
            this.header.ResumeLayout(false);
            this.content.ResumeLayout(false);
            this.questionGroupBox.ResumeLayout(false);
            this.questionGroupBox.PerformLayout();
            this.question.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label questionNumLabel;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.GroupBox questionGroupBox;
        private System.Windows.Forms.RadioButton answer4;
        private System.Windows.Forms.RadioButton answer3;
        private System.Windows.Forms.RadioButton answer2;
        private System.Windows.Forms.RadioButton answer1;
        private System.Windows.Forms.Panel question;
    }
}