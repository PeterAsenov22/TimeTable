namespace TimeTable.UI.Forms.Task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using TimeTable.UI.Models;
    public partial class TaskRegisterForm : Form
    {
        private List<string> projectsNames;
        public TaskRegisterForm(List<string> projectsNames)
        {
            InitializeComponent();
            this.projectsNames = projectsNames;
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

            if (IsValidTask(task) && IsValidHours(ref taskHours))
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
