namespace StudyProject
{
    partial class TestingsListForm
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
            this.menu = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.reloadButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.footer = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.Panel();
            this.testingsTable = new System.Windows.Forms.DataGridView();
            this.onlyActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.header.SuspendLayout();
            this.menu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reloadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.footer.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testingsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
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
            this.headerLabel.Text = "Список тестирований";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menu
            // 
            this.menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menu.Controls.Add(this.onlyActiveCheckBox);
            this.menu.Controls.Add(this.flowLayoutPanel1);
            this.menu.Controls.Add(this.searchInput);
            this.menu.Controls.Add(this.label1);
            this.menu.Controls.Add(this.pictureBox1);
            this.menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu.Location = new System.Drawing.Point(0, 50);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1000, 50);
            this.menu.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.reloadButton);
            this.flowLayoutPanel1.Controls.Add(this.closeButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(912, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(86, 48);
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
            this.reloadButton.TabIndex = 4;
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
            this.closeButton.TabIndex = 3;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(234, 14);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(172, 22);
            this.searchInput.TabIndex = 2;
            this.searchInput.TextChanged += new System.EventHandler(this.searchInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поиск по сотруднику:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudyProject.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(13, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // footer
            // 
            this.footer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.footer.Controls.Add(this.flowLayoutPanel2);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.footer.Location = new System.Drawing.Point(0, 478);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1000, 82);
            this.footer.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.addButton);
            this.flowLayoutPanel2.Controls.Add(this.deleteButton);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(636, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(362, 80);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(181, 65);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Назначить тестирование";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(190, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(165, 65);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Отменить тестирование";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // content
            // 
            this.content.Controls.Add(this.testingsTable);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 100);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1000, 378);
            this.content.TabIndex = 3;
            // 
            // testingsTable
            // 
            this.testingsTable.AllowUserToAddRows = false;
            this.testingsTable.AllowUserToDeleteRows = false;
            this.testingsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.testingsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testingsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testingsTable.Location = new System.Drawing.Point(0, 0);
            this.testingsTable.Name = "testingsTable";
            this.testingsTable.ReadOnly = true;
            this.testingsTable.RowHeadersWidth = 51;
            this.testingsTable.RowTemplate.Height = 24;
            this.testingsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.testingsTable.Size = new System.Drawing.Size(1000, 378);
            this.testingsTable.TabIndex = 0;
            // 
            // onlyActiveCheckBox
            // 
            this.onlyActiveCheckBox.AutoSize = true;
            this.onlyActiveCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.onlyActiveCheckBox.Location = new System.Drawing.Point(439, 15);
            this.onlyActiveCheckBox.Name = "onlyActiveCheckBox";
            this.onlyActiveCheckBox.Size = new System.Drawing.Size(381, 22);
            this.onlyActiveCheckBox.TabIndex = 6;
            this.onlyActiveCheckBox.Text = "Отобразить только незавершенные тестирования";
            this.onlyActiveCheckBox.UseVisualStyleBackColor = true;
            this.onlyActiveCheckBox.CheckedChanged += new System.EventHandler(this.onlyActiveCheckBox_CheckedChanged);
            // 
            // TestingsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 560);
            this.Controls.Add(this.content);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestingsListForm";
            this.Text = "TestingsListForm";
            this.Load += new System.EventHandler(this.TestingsListForm_Load);
            this.header.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reloadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.footer.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testingsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.DataGridView testingsTable;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.PictureBox reloadButton;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox onlyActiveCheckBox;
    }
}