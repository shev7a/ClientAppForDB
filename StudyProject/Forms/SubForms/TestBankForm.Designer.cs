namespace StudyProject
{
    partial class TestBankForm
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
            this.tests = new System.Windows.Forms.Panel();
            this.testsTable = new System.Windows.Forms.DataGridView();
            this.buttons = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.reloadButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.filterCheckBox = new System.Windows.Forms.CheckBox();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteTestButton = new System.Windows.Forms.Button();
            this.editTestButton = new System.Windows.Forms.Button();
            this.createTestButton = new System.Windows.Forms.Button();
            this.header.SuspendLayout();
            this.tests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testsTable)).BeginInit();
            this.buttons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reloadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.Control;
            this.header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.header.Controls.Add(this.headerLabel);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1000, 50);
            this.header.TabIndex = 0;
            // 
            // headerLabel
            // 
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.headerLabel.Location = new System.Drawing.Point(0, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(998, 48);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Список доступных тестов";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tests
            // 
            this.tests.Controls.Add(this.testsTable);
            this.tests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tests.Location = new System.Drawing.Point(0, 100);
            this.tests.Name = "tests";
            this.tests.Size = new System.Drawing.Size(1000, 360);
            this.tests.TabIndex = 1;
            // 
            // testsTable
            // 
            this.testsTable.AllowUserToAddRows = false;
            this.testsTable.AllowUserToDeleteRows = false;
            this.testsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.testsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testsTable.Location = new System.Drawing.Point(0, 0);
            this.testsTable.Name = "testsTable";
            this.testsTable.ReadOnly = true;
            this.testsTable.RowHeadersWidth = 51;
            this.testsTable.RowTemplate.Height = 24;
            this.testsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.testsTable.Size = new System.Drawing.Size(1000, 360);
            this.testsTable.TabIndex = 0;
            // 
            // buttons
            // 
            this.buttons.Controls.Add(this.deleteTestButton);
            this.buttons.Controls.Add(this.editTestButton);
            this.buttons.Controls.Add(this.createTestButton);
            this.buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttons.Location = new System.Drawing.Point(0, 460);
            this.buttons.Name = "buttons";
            this.buttons.Size = new System.Drawing.Size(1000, 120);
            this.buttons.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.filterCheckBox);
            this.panel1.Controls.Add(this.searchInput);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 50);
            this.panel1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.reloadButton);
            this.flowLayoutPanel1.Controls.Add(this.closeButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(910, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(88, 48);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // reloadButton
            // 
            this.reloadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reloadButton.Image = global::StudyProject.Properties.Resources.close_x;
            this.reloadButton.Location = new System.Drawing.Point(3, 3);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(35, 35);
            this.reloadButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reloadButton.TabIndex = 1;
            this.reloadButton.TabStop = false;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = global::StudyProject.Properties.Resources.reload;
            this.closeButton.Location = new System.Drawing.Point(44, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(35, 35);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 2;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // filterCheckBox
            // 
            this.filterCheckBox.AutoSize = true;
            this.filterCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filterCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterCheckBox.Location = new System.Drawing.Point(402, 14);
            this.filterCheckBox.Name = "filterCheckBox";
            this.filterCheckBox.Size = new System.Drawing.Size(334, 22);
            this.filterCheckBox.TabIndex = 4;
            this.filterCheckBox.Text = "Отобразить только созданные мной тесты";
            this.filterCheckBox.UseVisualStyleBackColor = true;
            this.filterCheckBox.CheckedChanged += new System.EventHandler(this.filterCheckBox_CheckedChanged);
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(216, 15);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(141, 22);
            this.searchInput.TabIndex = 2;
            this.searchInput.TextChanged += new System.EventHandler(this.searchInput_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudyProject.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск по названию:";
            // 
            // deleteTestButton
            // 
            this.deleteTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteTestButton.Location = new System.Drawing.Point(690, 26);
            this.deleteTestButton.Name = "deleteTestButton";
            this.deleteTestButton.Size = new System.Drawing.Size(165, 65);
            this.deleteTestButton.TabIndex = 2;
            this.deleteTestButton.Text = "Удалить тест";
            this.deleteTestButton.UseVisualStyleBackColor = true;
            this.deleteTestButton.Click += new System.EventHandler(this.deleteTestButton_Click);
            // 
            // editTestButton
            // 
            this.editTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editTestButton.Location = new System.Drawing.Point(403, 26);
            this.editTestButton.Name = "editTestButton";
            this.editTestButton.Size = new System.Drawing.Size(165, 65);
            this.editTestButton.TabIndex = 1;
            this.editTestButton.Text = "Редактировать тест";
            this.editTestButton.UseVisualStyleBackColor = true;
            this.editTestButton.Click += new System.EventHandler(this.editTestButton_Click);
            // 
            // createTestButton
            // 
            this.createTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createTestButton.Location = new System.Drawing.Point(130, 26);
            this.createTestButton.Name = "createTestButton";
            this.createTestButton.Size = new System.Drawing.Size(165, 65);
            this.createTestButton.TabIndex = 0;
            this.createTestButton.Text = "Создать новый тест";
            this.createTestButton.UseVisualStyleBackColor = true;
            this.createTestButton.Click += new System.EventHandler(this.createTestButton_Click);
            // 
            // TestBankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 580);
            this.Controls.Add(this.tests);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.buttons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestBankForm";
            this.Text = "TestBankForm";
            this.Load += new System.EventHandler(this.TestBankForm_Load);
            this.header.ResumeLayout(false);
            this.tests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testsTable)).EndInit();
            this.buttons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reloadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel tests;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.DataGridView testsTable;
        private System.Windows.Forms.Panel buttons;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox filterCheckBox;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox reloadButton;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Button deleteTestButton;
        private System.Windows.Forms.Button editTestButton;
        private System.Windows.Forms.Button createTestButton;
    }
}