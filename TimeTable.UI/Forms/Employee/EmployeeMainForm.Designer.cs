﻿namespace TimeTable.UI.Forms.Employee
{
    partial class EmployeeMainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findEmployeeGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.findEmployeeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.surname,
            this.lastName,
            this.egn,
            this.position,
            this.hireDate});
            this.dataGridView1.Location = new System.Drawing.Point(23, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1343, 300);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // surname
            // 
            this.surname.HeaderText = "Surname";
            this.surname.MinimumWidth = 6;
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            this.surname.Width = 125;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Last Name";
            this.lastName.MinimumWidth = 6;
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            this.lastName.Width = 125;
            // 
            // egn
            // 
            this.egn.HeaderText = "EGN";
            this.egn.MinimumWidth = 6;
            this.egn.Name = "egn";
            this.egn.ReadOnly = true;
            this.egn.Width = 125;
            // 
            // position
            // 
            this.position.HeaderText = "Position";
            this.position.MinimumWidth = 6;
            this.position.Name = "position";
            this.position.ReadOnly = true;
            this.position.Width = 125;
            // 
            // hireDate
            // 
            this.hireDate.HeaderText = "Hire Date";
            this.hireDate.MinimumWidth = 6;
            this.hireDate.Name = "hireDate";
            this.hireDate.ReadOnly = true;
            this.hireDate.Width = 125;
            // 
            // findEmployeeGroupBox
            // 
            this.findEmployeeGroupBox.Controls.Add(this.label1);
            this.findEmployeeGroupBox.Controls.Add(this.searchButton);
            this.findEmployeeGroupBox.Controls.Add(this.searchTextBox);
            this.findEmployeeGroupBox.Controls.Add(this.searchComboBox);
            this.findEmployeeGroupBox.Location = new System.Drawing.Point(23, 40);
            this.findEmployeeGroupBox.Name = "findEmployeeGroupBox";
            this.findEmployeeGroupBox.Size = new System.Drawing.Size(706, 68);
            this.findEmployeeGroupBox.TabIndex = 3;
            this.findEmployeeGroupBox.TabStop = false;
            this.findEmployeeGroupBox.Text = "Find Employee";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Find By:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(588, 19);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(85, 30);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(385, 23);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(168, 22);
            this.searchTextBox.TabIndex = 1;
            // 
            // searchComboBox
            // 
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Location = new System.Drawing.Point(186, 23);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(156, 24);
            this.searchComboBox.TabIndex = 0;
            // 
            // EmployeeMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 616);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.findEmployeeGroupBox);
            this.Name = "EmployeeMainForm";
            this.Text = "EmployeeSearchForm";
            this.Load += new System.EventHandler(this.EmployeeMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.findEmployeeGroupBox.ResumeLayout(false);
            this.findEmployeeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox findEmployeeGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn egn;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn hireDate;
    }
}