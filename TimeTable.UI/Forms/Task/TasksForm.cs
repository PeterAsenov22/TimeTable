namespace TimeTable.UI.Forms.Task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using Models;
    public partial class TasksForm : Form
    {
        private Employee employee;
        private decimal projectId;
        private string projectName;
        private List<ProjectHours> Tasks;
        public TasksForm(Employee employee, decimal projectId, string projectName)
        {
            InitializeComponent();
            this.employee = employee;
            this.projectId = projectId;
            this.projectName = projectName;
            this.Tasks = new List<ProjectHours>();
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
                this.Tasks.Add(task);
                dataGridView1.Rows.Add(new string[] {
                    projectName,
                    task.ProjectTask,
                    task.ProjectTaskdate.ToString("dd/MM/yyyy"),
                    task.ProjectHours1.ToString()
                });
            }
        }

        public delegate void EditDelegate(object sender, EditEventArgs args);
        public event EditDelegate EditEventHandler;

        public class EditEventArgs : EventArgs
        {
            public int RowIndex { get; set; }
            public Employee Employee { get; set; }
        }

        public delegate void DeleteDelegate(object sender, DeleteEventArgs args);
        public event DeleteDelegate DeleteEventHandler;

        public class DeleteEventArgs : EventArgs
        {
            public ProjectHours Task { get; set; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 4)
                {
                    TaskEditForm taskEditForm = new TaskEditForm();
                    taskEditForm.Show();
                }
                else if (e.ColumnIndex == 5)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this task ?", "Delete Task", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        ProjectHours task = this.Tasks[e.RowIndex];
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
    }
}
