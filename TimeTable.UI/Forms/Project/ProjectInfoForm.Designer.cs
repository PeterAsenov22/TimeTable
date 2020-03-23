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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.workedHoursLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // workingEmployeesLabel
            // 
            this.workingEmployeesLabel.AutoSize = true;
            this.workingEmployeesLabel.Location = new System.Drawing.Point(58, 64);
            this.workingEmployeesLabel.Name = "workingEmployeesLabel";
            this.workingEmployeesLabel.Size = new System.Drawing.Size(146, 17);
            this.workingEmployeesLabel.TabIndex = 0;
            this.workingEmployeesLabel.Text = "Working Employees: -";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(507, 64);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(100, 17);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Project Status:";
            // 
            // inProgressRadioButton
            // 
            this.inProgressRadioButton.AutoSize = true;
            this.inProgressRadioButton.Location = new System.Drawing.Point(576, 93);
            this.inProgressRadioButton.Name = "inProgressRadioButton";
            this.inProgressRadioButton.Size = new System.Drawing.Size(101, 21);
            this.inProgressRadioButton.TabIndex = 2;
            this.inProgressRadioButton.TabStop = true;
            this.inProgressRadioButton.Text = "In Progress";
            this.inProgressRadioButton.UseVisualStyleBackColor = true;
            // 
            // finishedRadioButton
            // 
            this.finishedRadioButton.AutoSize = true;
            this.finishedRadioButton.Location = new System.Drawing.Point(576, 120);
            this.finishedRadioButton.Name = "finishedRadioButton";
            this.finishedRadioButton.Size = new System.Drawing.Size(82, 21);
            this.finishedRadioButton.TabIndex = 3;
            this.finishedRadioButton.TabStop = true;
            this.finishedRadioButton.Text = "Finished";
            this.finishedRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.workedHoursLabel);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.monthLabel);
            this.groupBox1.Controls.Add(this.yearLabel);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(61, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 212);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Worked Hours Per Month";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(180, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
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
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(45, 92);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(94, 17);
            this.monthLabel.TabIndex = 2;
            this.monthLabel.Text = "Select Month:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(180, 89);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 3;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Finish Month";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ProjectInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.finishedRadioButton);
            this.Controls.Add(this.inProgressRadioButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.workingEmployeesLabel);
            this.Name = "ProjectInfoForm";
            this.Text = "ProjectInfoForm";
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
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}