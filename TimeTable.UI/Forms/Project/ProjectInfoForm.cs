namespace TimeTable.UI.Forms.Project
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using TimeTable.UI.Models.Enums;

    public partial class ProjectInfoForm : Form
    {
        private Models.Project project;
        public ProjectInfoForm(Models.Project project)
        {
            InitializeComponent();
            this.project = project;
        }

        private void ProjectInfoForm_Load(object sender, EventArgs e)
        {
            var employees = new HashSet<decimal>();
            foreach (var projectHour in project.ProjectHours.ToList())
            {
                employees.Add(projectHour.EmployeeId);
            }

            titleLabel.Text = $"Project Name: {project.ProjectName}";
            workingEmployeesLabel.Text = $"Employees working on the project: {employees.Count}";

            changeStatusBtn.Enabled = false;
            if (project.ProjectStatus == "O")
            {
                inProgressRadioButton.Checked = true;
            }
            else
            {
                finishedRadioButton.Checked = true;
            }

            int projectFirstYear = this.project.ProjectBegin.Year;
            int projectLastYear = Math.Min(DateTime.Now.Year, this.project.ProjectEnd.Year);
            var projectYears = new List<string>();
            for (int year = projectFirstYear; year <= projectLastYear; year++)
            {
                projectYears.Add(year.ToString());
            }

            yearComboBox.DataSource = projectYears;
            yearComboBox.SelectedIndex = 0;
        }

        public delegate void ChangeStatusDelegate(object sender);
        public event ChangeStatusDelegate ChangeStatusEventHandler;

        private void inProgressRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if ((this.project.ProjectStatus == "O" && inProgressRadioButton.Checked)
                || (this.project.ProjectStatus == "C" && !inProgressRadioButton.Checked))
            {
                changeStatusBtn.Enabled = false;            
            }
            else
            {
                changeStatusBtn.Enabled = true;
            }
        }

        private void changeStatusBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to change the status of the project ?",
                "Confirm Project Status Change",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                string newStatus = inProgressRadioButton.Checked
                ? "O"
                : "C";

                this.project.ProjectStatus = newStatus;
                ChangeStatusEventHandler?.Invoke(this);
                this.changeStatusBtn.Enabled = false;
            }
        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedYear = int.Parse(yearComboBox.SelectedItem.ToString());
            UpdateMonths(selectedYear);
            Months selectedMonth = (Months) Enum.Parse(typeof(Months), monthComboBox.SelectedIndex.ToString());
            SetHoursWorked(selectedYear, int.Parse(selectedMonth.ToString()));
        }

        private void UpdateMonths(int selectedYear)
        {
            int firstMonth = selectedYear == this.project.ProjectBegin.Year
                ? this.project.ProjectBegin.Month
                : 1;

            int lastMonth = selectedYear == this.project.ProjectEnd.Year
                ? this.project.ProjectEnd.Month
                : 12;

            var currentMonths = new List<string>();
            for (int month = firstMonth; month <= lastMonth; month++)
            {
                currentMonths.Add(Enum.GetName(typeof(Months), month));
            }

            monthComboBox.DataSource = currentMonths;
            monthComboBox.SelectedIndex = 0;
        }

        private void SetHoursWorked(int year, int month)
        {
            decimal hoursWorked = 0;
            var projectMonth = this.project.ProjectMonths.FirstOrDefault(p => p.ProjectYear == year && p.ProjectMonth == month);
            if (projectMonth != null)
            {
                hoursWorked = projectMonth.ProjectHours.Sum(ph => ph.ProjectHours1);
            }

            workedHoursLabel.Text = $"Hours Worked: {hoursWorked}";
        }
    }
}
