namespace TimeTable.UI.Forms.Task
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using Microsoft.EntityFrameworkCore;
    using Models;
    public partial class TaskEditForm : Form
    {
        private int rowIndex;
        private ProjectHours task;
        private string projectName;
        private Employee employee;
        private TimeTableContext db;
        public TaskEditForm(int rowIndex, ProjectHours task, string projectName, Employee employee)
        {
            InitializeComponent();
            this.rowIndex = rowIndex;
            this.task = task;
            this.projectName = projectName;
            this.employee = employee;
            this.db = new TimeTableContext();
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

            Project project = this.db.Projects.Include(p => p.ProjectMonths).First(p => p.ProjectName == projectName);
            if (project.ProjectStatus == "C")
            {
                MessageBox.Show($"This project has finished!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (project.ProjectMonths.Any(pm => pm.ProjectMonth == this.task.ProjectTaskdate.Month && pm.ProjectYear == this.task.ProjectTaskdate.Year))
            {
                ProjectMonths projectMonth = project.ProjectMonths
                    .First(pm => pm.ProjectMonth == this.task.ProjectTaskdate.Month && pm.ProjectYear == this.task.ProjectTaskdate.Year);
                if (projectMonth.ProjectMonthStatus == "C")
                {
                    MessageBox.Show("This month is finished for this project!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            decimal employeeMaxWorkingHoursOnProject = project.ProjectMaxhours != null
            ? (decimal)project.ProjectMaxhours
            : (decimal)int.MaxValue;
            decimal employeeCurrentWorkingHoursOnProject =
                this.employee.ProjectHours.Where(ph => ph.ProjectId == project.ProjectId).Sum(ph => ph.ProjectHours1) - this.task.ProjectHours1;

            if (IsValidTask(task) && IsValidHours(ref taskHours, employeeCurrentWorkingHoursOnProject, employeeMaxWorkingHoursOnProject))
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

        private bool IsValidHours(ref int taskHours, decimal employeeCurrentWorkingHoursOnProject, decimal employeeMaxWorkingHoursOnProject)
        {
            if (!int.TryParse(hoursTextBox.Text, out taskHours))
            {
                MessageBox.Show("Please, fill in a whole number for Hours Worked!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (taskHours > 12 || taskHours < 1)
            {
                MessageBox.Show("Hours Worked must be between 1 and 12 hours!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (employeeCurrentWorkingHoursOnProject + taskHours > employeeMaxWorkingHoursOnProject)
            {
                MessageBox.Show(
                    $"You are exceeding the maximum working hours for an employee on this project! The maximum working hours are {employeeMaxWorkingHoursOnProject} " +
                    $"and the current employee has already worked for {employeeCurrentWorkingHoursOnProject} hours on this project!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
