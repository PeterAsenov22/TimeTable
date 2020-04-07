namespace TimeTable.UI.Forms.Task
{
    partial class TasksForm
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
            this.project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursWorked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.project,
            this.task,
            this.taskDate,
            this.hoursWorked});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1017, 450);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // project
            // 
            this.project.HeaderText = "Project";
            this.project.MinimumWidth = 6;
            this.project.Name = "project";
            this.project.ReadOnly = true;
            this.project.Width = 125;
            // 
            // task
            // 
            this.task.HeaderText = "Task";
            this.task.MinimumWidth = 6;
            this.task.Name = "task";
            this.task.ReadOnly = true;
            this.task.Width = 125;
            // 
            // taskDate
            // 
            this.taskDate.HeaderText = "Task Date";
            this.taskDate.MinimumWidth = 6;
            this.taskDate.Name = "taskDate";
            this.taskDate.ReadOnly = true;
            this.taskDate.Width = 125;
            // 
            // hoursWorked
            // 
            this.hoursWorked.HeaderText = "Hours Worked";
            this.hoursWorked.MinimumWidth = 6;
            this.hoursWorked.Name = "hoursWorked";
            this.hoursWorked.ReadOnly = true;
            this.hoursWorked.Width = 125;
            // 
            // TasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TasksForm";
            this.Text = "TasksForm";
            this.Load += new System.EventHandler(this.TasksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn project;
        private System.Windows.Forms.DataGridViewTextBoxColumn task;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursWorked;
    }
}