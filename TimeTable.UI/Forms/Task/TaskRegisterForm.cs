namespace TimeTable.UI.Forms.Task
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using TimeTable.UI.Models;
    public partial class TaskRegisterForm : Form
    {
        private TimeTableContext db;
        private Employee employee;
        private List<string> projectsNames;
        public TaskRegisterForm(TimeTableContext db, Employee employee)
        {
            InitializeComponent();
            this.db = db;
            this.employee = employee;
            this.projectsNames = this.db.Projects.Select(p => p.ProjectName).ToList();
        }

        public delegate void RegisterDelegate(object sender, RegisterEventArgs args);
        public event RegisterDelegate RegisterEventHandler;

        public class RegisterEventArgs : EventArgs
        {
            public string ProjectName { get; set; }
            public ProjectHours ProjectTask { get; set; }
        }

        private void TaskRegisterForm_Load(object sender, EventArgs e)
        {
            projectComboBox.DataSource = projectsNames;
            projectComboBox.SelectedIndex = 0;
        }

        private void addTaskBtn_Click(object sender, EventArgs e)
        {
            int taskHours = 0;
            string projectName = projectComboBox.Text;
            string task = taskTextBox.Text;
            DateTime taskDate = taskDateTimePicker.Value;

            Project project = this.db.Projects.Include(p => p.ProjectMonths).First(p => p.ProjectName == projectName);
            if (project.ProjectStatus == "C")
            {
                MessageBox.Show($"Tasks cannot be added to finished project!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal employeeMaxWorkingHoursOnProject = project.ProjectMaxhours != null
            ? (decimal)project.ProjectMaxhours
            : (decimal)int.MaxValue;
            decimal employeeCurrentWorkingHoursOnProject = this.employee.ProjectHours.Where(ph => ph.ProjectId == project.ProjectId).Sum(ph => ph.ProjectHours1);

            if (IsValidTask(task)
                && IsValidHours(ref taskHours, employeeCurrentWorkingHoursOnProject, employeeMaxWorkingHoursOnProject)
                && IsValidDate(taskDate, project))
            {
                var projectTask = new ProjectHours()
                {
                    ProjectTask = task,
                    ProjectHours1 = taskHours,
                    ProjectTaskdate = taskDate
                };

                var args = new RegisterEventArgs()
                {
                    ProjectName = projectName,
                    ProjectTask = projectTask
                };

                RegisterEventHandler?.Invoke(this, args);
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

        private bool IsValidDate(DateTime taskDate, Project project)
        {
            if (taskDate.CompareTo(DateTime.Now) > 0)
            {
                MessageBox.Show("Tasks for future dates cannot be added!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (taskDate.CompareTo(this.employee.EmployeeHiredate) < 0)
            {
                MessageBox.Show("The Task Date is before the hiring of the employee!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (taskDate.CompareTo(project.ProjectBegin) < 0)
            {
                MessageBox.Show("The Task Date is before the begining of the project!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (taskDate.CompareTo(project.ProjectEnd) > 0)
            {
                MessageBox.Show("The Task Date is after the end of the project!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (project.ProjectMonths.Any(pm => pm.ProjectMonth == taskDate.Month && pm.ProjectYear == taskDate.Year))
            {
                ProjectMonths projectMonth = project.ProjectMonths.First(pm => pm.ProjectMonth == taskDate.Month && pm.ProjectYear == taskDate.Year);
                if (projectMonth.ProjectMonthStatus == "C")
                {
                    MessageBox.Show("This month is finished for this project!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
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
