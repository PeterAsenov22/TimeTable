namespace TimeTable.UI.Forms.Task
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using Models;
    public partial class TaskEditForm : Form
    {
        private int rowIndex;
        private ProjectHours task;
        private string projectName;
        public TaskEditForm(int rowIndex, ProjectHours task, string projectName)
        {
            InitializeComponent();
            this.rowIndex = rowIndex;
            this.task = task;
            this.projectName = projectName;
        }

        private void TaskEditForm_Load(object sender, EventArgs e)
        {
            projectTextBox.Text = this.projectName;
            taskTextBox.Text = this.task.ProjectTask;
            hoursTextBox.Text = this.task.ProjectHours1.ToString();
            taskDateTimePicker.Value = this.task.ProjectTaskdate;
        }

        public delegate void EditDelegate(object sender, EditEventArgs args);
        public event EditDelegate EditEventHandler;

        public class EditEventArgs : EventArgs
        {
            public int RowIndex { get; set; }
            public ProjectHours Task { get; set; }
        }

        private void editTaskBtn_Click(object sender, EventArgs e)
        {
            int taskHours = 0;
            string task = taskTextBox.Text;

            if (IsValidTask(task) && IsValidHours(ref taskHours))
            {
                this.task.ProjectTask = task;
                this.task.ProjectHours1 = taskHours;

                var args = new EditEventArgs()
                {
                    RowIndex = this.rowIndex,
                    Task = this.task
                };

                EditEventHandler?.Invoke(this, args);
                this.Close();
            }
        }

        private bool IsValidTask(string task)
        {
            if (string.IsNullOrEmpty(task) || string.IsNullOrWhiteSpace(task) || task.Length > 50)
            {
                MessageBox.Show($"Please, fill in a Task with no more than 50 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (ContainsUnicodeCharacter(task))
            {
                MessageBox.Show(
                    $"The Task contains Unicode characters. Please, use only the English alphabet!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }

            return true;
        }

        private bool IsValidHours(ref int taskHours)
        {
            if (!int.TryParse(hoursTextBox.Text, out taskHours))
            {
                MessageBox.Show("Please, fill in a whole number for Hours Worked!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool ContainsUnicodeCharacter(string input)
        {
            const int MaxAnsiCode = 255;

            return input.Any(c => c > MaxAnsiCode);
        }
    }
}
