namespace TimeTable.UI.Forms.Employee
{
    partial class EmployeeInfoForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalWorkingHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.workedHoursLabel = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.monthLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addTaskBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tasksCountLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(49, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(880, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Projects";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectName,
            this.totalWorkingHours,
            this.status});
            this.dataGridView1.Location = new System.Drawing.Point(21, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(838, 166);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // projectName
            // 
            this.projectName.HeaderText = "Name";
            this.projectName.MinimumWidth = 6;
            this.projectName.Name = "projectName";
            this.projectName.ReadOnly = true;
            this.projectName.Width = 125;
            // 
            // totalWorkingHours
            // 
            this.totalWorkingHours.HeaderText = "Total Working Hours";
            this.totalWorkingHours.MinimumWidth = 6;
            this.totalWorkingHours.Name = "totalWorkingHours";
            this.totalWorkingHours.ReadOnly = true;
            this.totalWorkingHours.Width = 125;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.workedHoursLabel);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.monthLabel);
            this.groupBox2.Controls.Add(this.yearLabel);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(49, 365);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(880, 212);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Working Hours";
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(180, 89);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 3;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(180, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(61, 33);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(78, 17);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Employee: ";
            // 
            // addTaskBtn
            // 
            this.addTaskBtn.Location = new System.Drawing.Point(696, 25);
            this.addTaskBtn.Name = "addTaskBtn";
            this.addTaskBtn.Size = new System.Drawing.Size(163, 32);
            this.addTaskBtn.TabIndex = 7;
            this.addTaskBtn.Text = "Add a new Task";
            this.addTaskBtn.UseVisualStyleBackColor = true;
            this.addTaskBtn.Click += new System.EventHandler(this.addTaskBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tasksCountLabel);
            this.groupBox3.Controls.Add(this.addTaskBtn);
            this.groupBox3.Controls.Add(this.nameLabel);
            this.groupBox3.Location = new System.Drawing.Point(49, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(883, 75);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info";
            // 
            // tasksCountLabel
            // 
            this.tasksCountLabel.AutoSize = true;
            this.tasksCountLabel.Location = new System.Drawing.Point(374, 33);
            this.tasksCountLabel.Name = "tasksCountLabel";
            this.tasksCountLabel.Size = new System.Drawing.Size(128, 17);
            this.tasksCountLabel.TabIndex = 7;
            this.tasksCountLabel.Text = "Number of Tasks:  ";
            // 
            // EmployeeInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 598);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmployeeInfoForm";
            this.Text = "Employee Info";
            this.Load += new System.EventHandler(this.EmployeeInfoForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label workedHoursLabel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalWorkingHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button addTaskBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label tasksCountLabel;
    }
}