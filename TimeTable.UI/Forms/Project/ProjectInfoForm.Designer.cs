namespace TimeTable.UI.Forms.Project
{
    partial class ProjectInfoForm
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
            this.workingEmployeesLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.inProgressRadioButton = new System.Windows.Forms.RadioButton();
            this.finishedRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.finishedMonthLabel = new System.Windows.Forms.Label();
            this.finishMonthBtn = new System.Windows.Forms.Button();
            this.workedHoursLabel = new System.Windows.Forms.Label();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.monthLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.changeStatusBtn = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // workingEmployeesLabel
            // 
            this.workingEmployeesLabel.AutoSize = true;
            this.workingEmployeesLabel.Location = new System.Drawing.Point(58, 97);
            this.workingEmployeesLabel.Name = "workingEmployeesLabel";
            this.workingEmployeesLabel.Size = new System.Drawing.Size(233, 17);
            this.workingEmployeesLabel.TabIndex = 0;
            this.workingEmployeesLabel.Text = "Employees working on the project: -";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(58, 164);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(100, 17);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Project Status:";
            // 
            // inProgressRadioButton
            // 
            this.inProgressRadioButton.AutoSize = true;
            this.inProgressRadioButton.Location = new System.Drawing.Point(90, 193);
            this.inProgressRadioButton.Name = "inProgressRadioButton";
            this.inProgressRadioButton.Size = new System.Drawing.Size(101, 21);
            this.inProgressRadioButton.TabIndex = 2;
            this.inProgressRadioButton.TabStop = true;
            this.inProgressRadioButton.Text = "In Progress";
            this.inProgressRadioButton.UseVisualStyleBackColor = true;
            this.inProgressRadioButton.CheckedChanged += new System.EventHandler(this.inProgressRadioButton_CheckedChanged);
            // 
            // finishedRadioButton
            // 
            this.finishedRadioButton.AutoSize = true;
            this.finishedRadioButton.Location = new System.Drawing.Point(90, 220);
            this.finishedRadioButton.Name = "finishedRadioButton";
            this.finishedRadioButton.Size = new System.Drawing.Size(82, 21);
            this.finishedRadioButton.TabIndex = 3;
            this.finishedRadioButton.TabStop = true;
            this.finishedRadioButton.Text = "Finished";
            this.finishedRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.finishedMonthLabel);
            this.groupBox1.Controls.Add(this.finishMonthBtn);
            this.groupBox1.Controls.Add(this.workedHoursLabel);
            this.groupBox1.Controls.Add(this.monthComboBox);
            this.groupBox1.Controls.Add(this.monthLabel);
            this.groupBox1.Controls.Add(this.yearLabel);
            this.groupBox1.Controls.Add(this.yearComboBox);
            this.groupBox1.Location = new System.Drawing.Point(314, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 215);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Worked Hours Per Month";
            // 
            // finishedMonthLabel
            // 
            this.finishedMonthLabel.AutoSize = true;
            this.finishedMonthLabel.BackColor = System.Drawing.SystemColors.Control;
            this.finishedMonthLabel.ForeColor = System.Drawing.Color.Red;
            this.finishedMonthLabel.Location = new System.Drawing.Point(317, 151);
            this.finishedMonthLabel.Name = "finishedMonthLabel";
            this.finishedMonthLabel.Size = new System.Drawing.Size(146, 17);
            this.finishedMonthLabel.TabIndex = 6;
            this.finishedMonthLabel.Text = "The month is finished!";
            this.finishedMonthLabel.Visible = false;
            // 
            // finishMonthBtn
            // 
            this.finishMonthBtn.Location = new System.Drawing.Point(351, 134);
            this.finishMonthBtn.Name = "finishMonthBtn";
            this.finishMonthBtn.Size = new System.Drawing.Size(112, 50);
            this.finishMonthBtn.TabIndex = 5;
            this.finishMonthBtn.Text = "Finish Month";
            this.finishMonthBtn.UseVisualStyleBackColor = true;
            this.finishMonthBtn.Click += new System.EventHandler(this.finishMonthBtn_Click);
            // 
            // workedHoursLabel
            // 
            this.workedHoursLabel.AutoSize = true;
            this.workedHoursLabel.Location = new System.Drawing.Point(45, 151);
            this.workedHoursLabel.Name = "workedHoursLabel";
            this.workedHoursLabel.Size = new System.Drawing.Size(112, 17);
            this.workedHoursLabel.TabIndex = 4;
            this.workedHoursLabel.Text = "Hours Worked: -";
            // 
            // monthComboBox
            // 
            this.monthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(180, 89);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(121, 24);
            this.monthComboBox.TabIndex = 3;
            this.monthComboBox.SelectedIndexChanged += new System.EventHandler(this.monthComboBox_SelectedIndexChanged);
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(45, 92);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(94, 17);
            this.monthLabel.TabIndex = 2;
            this.monthLabel.Text = "Select Month:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(45, 48);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(85, 17);
            this.yearLabel.TabIndex = 1;
            this.yearLabel.Text = "Select Year:";
            // 
            // yearComboBox
            // 
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(180, 42);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(121, 24);
            this.yearComboBox.TabIndex = 0;
            this.yearComboBox.SelectedIndexChanged += new System.EventHandler(this.yearComboBox_SelectedIndexChanged);
            // 
            // changeStatusBtn
            // 
            this.changeStatusBtn.Location = new System.Drawing.Point(74, 256);
            this.changeStatusBtn.Name = "changeStatusBtn";
            this.changeStatusBtn.Size = new System.Drawing.Size(139, 34);
            this.changeStatusBtn.TabIndex = 5;
            this.changeStatusBtn.Text = "Change Status";
            this.changeStatusBtn.UseVisualStyleBackColor = true;
            this.changeStatusBtn.Click += new System.EventHandler(this.changeStatusBtn_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(58, 58);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(106, 17);
            this.titleLabel.TabIndex = 34;
            this.titleLabel.Text = "Project Name: -";
            // 
            // ProjectInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.changeStatusBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.finishedRadioButton);
            this.Controls.Add(this.inProgressRadioButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.workingEmployeesLabel);
            this.Name = "ProjectInfoForm";
            this.Text = "Project Info";
            this.Load += new System.EventHandler(this.ProjectInfoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label workingEmployeesLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.RadioButton inProgressRadioButton;
        private System.Windows.Forms.RadioButton finishedRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label workedHoursLabel;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.Button finishMonthBtn;
        private System.Windows.Forms.Button changeStatusBtn;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label finishedMonthLabel;
    }
}