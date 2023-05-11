namespace StudyProject
{
    partial class AddQuestionForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.answer3 = new System.Windows.Forms.TextBox();
            this.answer1 = new System.Windows.Forms.TextBox();
            this.correctLabel = new System.Windows.Forms.Label();
            this.answCorrect4 = new System.Windows.Forms.RadioButton();
            this.answCorrect3 = new System.Windows.Forms.RadioButton();
            this.answCorrect2 = new System.Windows.Forms.RadioButton();
            this.answCorrect1 = new System.Windows.Forms.RadioButton();
            this.answer4 = new System.Windows.Forms.TextBox();
            this.answer2 = new System.Windows.Forms.TextBox();
            this.questionText = new System.Windows.Forms.TextBox();
            this.answersLabel = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            this.content.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.HotTrack;
            this.header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.header.Controls.Add(this.headerLabel);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(523, 50);
            this.header.TabIndex = 0;
            // 
            // headerLabel
            // 
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(0, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(521, 48);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Создание вопроса";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // content
            // 
            this.content.Controls.Add(this.addButton);
            this.content.Controls.Add(this.cancelButton);
            this.content.Controls.Add(this.answer3);
            this.content.Controls.Add(this.answer1);
            this.content.Controls.Add(this.correctLabel);
            this.content.Controls.Add(this.answCorrect4);
            this.content.Controls.Add(this.answCorrect3);
            this.content.Controls.Add(this.answCorrect2);
            this.content.Controls.Add(this.answCorrect1);
            this.content.Controls.Add(this.answer4);
            this.content.Controls.Add(this.answer2);
            this.content.Controls.Add(this.questionText);
            this.content.Controls.Add(this.answersLabel);
            this.content.Controls.Add(this.textLabel);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 50);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(523, 428);
            this.content.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(306, 349);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(170, 45);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(47, 349);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(170, 45);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // answer3
            // 
            this.answer3.Location = new System.Drawing.Point(18, 262);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(356, 22);
            this.answer3.TabIndex = 5;
            // 
            // answer1
            // 
            this.answer1.Location = new System.Drawing.Point(18, 206);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(356, 22);
            this.answer1.TabIndex = 3;
            // 
            // correctLabel
            // 
            this.correctLabel.AutoSize = true;
            this.correctLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.correctLabel.Location = new System.Drawing.Point(379, 181);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(112, 18);
            this.correctLabel.TabIndex = 11;
            this.correctLabel.Text = "Правильность:";
            // 
            // answCorrect4
            // 
            this.answCorrect4.AutoSize = true;
            this.answCorrect4.Location = new System.Drawing.Point(435, 290);
            this.answCorrect4.Name = "answCorrect4";
            this.answCorrect4.Size = new System.Drawing.Size(17, 16);
            this.answCorrect4.TabIndex = 10;
            this.answCorrect4.TabStop = true;
            this.answCorrect4.UseVisualStyleBackColor = true;
            // 
            // answCorrect3
            // 
            this.answCorrect3.AutoSize = true;
            this.answCorrect3.Location = new System.Drawing.Point(435, 262);
            this.answCorrect3.Name = "answCorrect3";
            this.answCorrect3.Size = new System.Drawing.Size(17, 16);
            this.answCorrect3.TabIndex = 9;
            this.answCorrect3.TabStop = true;
            this.answCorrect3.UseVisualStyleBackColor = true;
            // 
            // answCorrect2
            // 
            this.answCorrect2.AutoSize = true;
            this.answCorrect2.Location = new System.Drawing.Point(435, 234);
            this.answCorrect2.Name = "answCorrect2";
            this.answCorrect2.Size = new System.Drawing.Size(17, 16);
            this.answCorrect2.TabIndex = 8;
            this.answCorrect2.TabStop = true;
            this.answCorrect2.UseVisualStyleBackColor = true;
            // 
            // answCorrect1
            // 
            this.answCorrect1.AutoSize = true;
            this.answCorrect1.Location = new System.Drawing.Point(435, 209);
            this.answCorrect1.Name = "answCorrect1";
            this.answCorrect1.Size = new System.Drawing.Size(17, 16);
            this.answCorrect1.TabIndex = 7;
            this.answCorrect1.TabStop = true;
            this.answCorrect1.UseVisualStyleBackColor = true;
            // 
            // answer4
            // 
            this.answer4.Location = new System.Drawing.Point(18, 290);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(356, 22);
            this.answer4.TabIndex = 6;
            // 
            // answer2
            // 
            this.answer2.Location = new System.Drawing.Point(18, 234);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(356, 22);
            this.answer2.TabIndex = 4;
            // 
            // questionText
            // 
            this.questionText.Location = new System.Drawing.Point(18, 40);
            this.questionText.Multiline = true;
            this.questionText.Name = "questionText";
            this.questionText.Size = new System.Drawing.Size(473, 117);
            this.questionText.TabIndex = 2;
            // 
            // answersLabel
            // 
            this.answersLabel.AutoSize = true;
            this.answersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answersLabel.Location = new System.Drawing.Point(15, 181);
            this.answersLabel.Name = "answersLabel";
            this.answersLabel.Size = new System.Drawing.Size(131, 18);
            this.answersLabel.TabIndex = 1;
            this.answersLabel.Text = "Варианты ответа:";
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLabel.Location = new System.Drawing.Point(12, 19);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(114, 18);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "Текст вопроса:";
            // 
            // AddQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 478);
            this.ControlBox = false;
            this.Controls.Add(this.content);
            this.Controls.Add(this.header);
            this.Name = "AddQuestionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Система тестирования знаний кредитных инспекторов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuestionForm_FormClosed);
            this.Load += new System.EventHandler(this.AddQuestionForm_Load);
            this.header.ResumeLayout(false);
            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.RadioButton answCorrect4;
        private System.Windows.Forms.RadioButton answCorrect3;
        private System.Windows.Forms.RadioButton answCorrect2;
        private System.Windows.Forms.RadioButton answCorrect1;
        private System.Windows.Forms.TextBox answer4;
        private System.Windows.Forms.TextBox answer3;
        private System.Windows.Forms.TextBox answer2;
        private System.Windows.Forms.TextBox answer1;
        private System.Windows.Forms.TextBox questionText;
        private System.Windows.Forms.Label answersLabel;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label headerLabel;
    }
}