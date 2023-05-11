namespace StudyProject
{
    partial class EmployeeTestingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.footer = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.runButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.Panel();
            this.testingsTable = new System.Windows.Forms.DataGridView();
            this.header.SuspendLayout();
            this.footer.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testingsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Controls.Add(this.label1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(800, 50);
            this.header.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тестирования";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // footer
            // 
            this.footer.Controls.Add(this.flowLayoutPanel1);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 380);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(800, 70);
            this.footer.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.runButton);
            this.flowLayoutPanel1.Controls.Add(this.finishButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(434, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(366, 70);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(3, 3);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(177, 57);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "Пройти тестирование";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(186, 3);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(177, 57);
            this.finishButton.TabIndex = 1;
            this.finishButton.Text = "Завершить тестирование";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // content
            // 
            this.content.Controls.Add(this.testingsTable);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 50);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(800, 330);
            this.content.TabIndex = 2;
            // 
            // testingsTable
            // 
            this.testingsTable.AllowUserToAddRows = false;
            this.testingsTable.AllowUserToDeleteRows = false;
            this.testingsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.testingsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.testingsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testingsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testingsTable.Location = new System.Drawing.Point(0, 0);
            this.testingsTable.Name = "testingsTable";
            this.testingsTable.ReadOnly = true;
            this.testingsTable.RowHeadersWidth = 51;
            this.testingsTable.RowTemplate.Height = 24;
            this.testingsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.testingsTable.Size = new System.Drawing.Size(800, 330);
            this.testingsTable.TabIndex = 0;
            // 
            // EmployeeTestingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.content);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeTestingsForm";
            this.Text = "EmployeeTestingsForm";
            this.Load += new System.EventHandler(this.EmployeeTestingsForm_Load);
            this.header.ResumeLayout(false);
            this.footer.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testingsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.DataGridView testingsTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button finishButton;
    }
}