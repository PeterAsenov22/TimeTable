namespace TimeTable.UI.Forms.Task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using Microsoft.EntityFrameworkCore;
    using Models;
    public partial class TasksForm : Form
    {
        private Employee employee;
        private decimal projectId;
        private string projectName;
        private List<ProjectHours> tasks;
        private TimeTableContext db;
        public TasksForm(Employee employee, decimal projectId, string projectName)
        {
            InitializeComponent();
            this.employee = employee;
            this.projectId = projectId;
            this.projectName = projectName;
            this.tasks = new List<ProjectHours>();
            this.db = new TimeTableContext();
        }

        private void TasksForm_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "edit";
            editButtonColumn.HeaderText = "";
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(editButtonColumn);

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "delete";
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deleteButtonColumn);

            foreach (var task in this.employee.ProjectHours.Where(ph => ph.ProjectId == projectId))
            {
                this.tasks.Add(task);
                dataGridView1.Rows.Add(task.ToDataView(projectName));
            }
        }

        public delegate bool EditDelegate(object sender);
        public event EditDelegate EditEventHandler;

        public delegate void DeleteDelegate(object sender, DeleteEventArgs args);
        public event DeleteDelegate DeleteEventHandler;

        public class DeleteEventArgs : EventArgs
        {
            public ProjectHours Task { get; set; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.RowIndex < this.tasks.Count)
            {
                if (e.ColumnIndex == 4)
                {
                    ProjectHours task = this.tasks[e.RowIndex];
                    TaskEditForm taskEditForm = new TaskEditForm(e.RowIndex, task, this.projectName, this.employee);
                    taskEditForm.EditEventHandler += TaskEditForm_EditEventHandler;
                    taskEditForm.Show();
                }
                else if (e.ColumnIndex == 5)
                {
                    Project project = this.db.Projects.Include(p => p.ProjectMonths).First(p => p.ProjectName == this.projectName);
                    if (project.ProjectStatus == "C")
                    {
                        MessageBox.Show($"The project is finished!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    ProjectHours task = this.tasks[e.RowIndex];
                    if (project.ProjectMonths.Any(pm => pm.ProjectMonth == task.ProjectTaskdate.Month && pm.ProjectYear == task.ProjectTaskdate.Year))
                    {
                        ProjectMonths projectMonth = project.ProjectMonths
                            .First(pm => pm.ProjectMonth == task.ProjectTaskdate.Month && pm.ProjectYear == task.ProjectTaskdate.Year);
                        if (projectMonth.ProjectMonthStatus == "C")
                        {
                            MessageBox.Show("This month is finished for the project!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this task ?", "Delete Task", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        var args = new DeleteEventArgs()
                        {
                            Task = task
                        };

                        DeleteEventHandler?.Invoke(this, args);
                        dataGridView1.Rows.RemoveAt(e.RowIndex);

                        MessageBox.Show(
                            $"Task was successfully deleted from {this.projectName}!",
                            "Successful Task Deletion",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                }
            }
        }

        private void TaskEditForm_EditEventHandler(object sender, TaskEditForm.EditEventArgs args)
        {
            try
            {
                if ((bool)EditEventHandler?.Invoke(this))
                {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[args.RowIndex]);
                    dataGridView1.Rows.Insert(args.RowIndex, args.Task.ToDataView(this.projectName));

                    MessageBox.Show(
                        $"Task was successfully edited!",
                        "Successful Task Update",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch
            {
                MessageBox.Show("An error occurred while recording the changes! Please, try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
