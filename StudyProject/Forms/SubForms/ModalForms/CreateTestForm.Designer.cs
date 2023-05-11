namespace StudyProject
{
    partial class CreateTestForm
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
            this.headerText = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.Panel();
            this.questionList = new System.Windows.Forms.ListBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.PictureBox();
            this.editButton = new System.Windows.Forms.PictureBox();
            this.addButton = new System.Windows.Forms.PictureBox();
            this.questionsLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            this.content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addButton)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.HotTrack;
            this.header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.header.Controls.Add(this.headerText);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(422, 50);
            this.header.TabIndex = 0;
            // 
            // headerText
            // 
            this.headerText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerText.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.headerText.ForeColor = System.Drawing.Color.White;
            this.headerText.Location = new System.Drawing.Point(0, 0);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(420, 48);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Создание теста";
            this.headerText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // content
            // 
            this.content.Controls.Add(this.questionList);
            this.content.Controls.Add(this.cancelButton);
            this.content.Controls.Add(this.saveButton);
            this.content.Controls.Add(this.deleteButton);
            this.content.Controls.Add(this.editButton);
            this.content.Controls.Add(this.addButton);
            this.content.Controls.Add(this.questionsLabel);
            this.content.Controls.Add(this.nameInput);
            this.content.Controls.Add(this.nameLabel);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 50);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(422, 435);
            this.content.TabIndex = 1;
            // 
            // questionList
            // 
            this.questionList.FormattingEnabled = true;
            this.questionList.ItemHeight = 16;
            this.questionList.Location = new System.Drawing.Point(15, 106);
            this.questionList.Name = "questionList";
            this.questionList.Size = new System.Drawing.Size(295, 180);
            this.questionList.TabIndex = 9;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(38, 332);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(145, 65);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(240, 332);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(145, 65);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Image = global::StudyProject.Properties.Resources.delete_button;
            this.deleteButton.Location = new System.Drawing.Point(345, 240);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(40, 40);
            this.deleteButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deleteButton.TabIndex = 6;
            this.deleteButton.TabStop = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.Image = global::StudyProject.Properties.Resources.edit_button;
            this.editButton.Location = new System.Drawing.Point(345, 171);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(40, 40);
            this.editButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editButton.TabIndex = 5;
            this.editButton.TabStop = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Image = global::StudyProject.Properties.Resources.add_button;
            this.addButton.Location = new System.Drawing.Point(345, 105);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(40, 40);
            this.addButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addButton.TabIndex = 4;
            this.addButton.TabStop = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // questionsLabel
            // 
            this.questionsLabel.AutoSize = true;
            this.questionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionsLabel.Location = new System.Drawing.Point(15, 84);
            this.questionsLabel.Name = "questionsLabel";
            this.questionsLabel.Size = new System.Drawing.Size(135, 18);
            this.questionsLabel.TabIndex = 2;
            this.questionsLabel.Text = "Список вопросов:";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(15, 40);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(295, 22);
            this.nameInput.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(12, 19);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(79, 18);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Название:";
            // 
            // CreateTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 485);
            this.ControlBox = false;
            this.Controls.Add(this.content);
            this.Controls.Add(this.header);
            this.Name = "CreateTestForm";
            this.Text = "Система тестирования знаний кредитных инспекторов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateTestForm_FormClosed);
            this.Load += new System.EventHandler(this.CreateTestForm_Load);
            this.header.ResumeLayout(false);
            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox addButton;
        private System.Windows.Forms.Label questionsLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.PictureBox deleteButton;
        private System.Windows.Forms.PictureBox editButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListBox questionList;
    }
}