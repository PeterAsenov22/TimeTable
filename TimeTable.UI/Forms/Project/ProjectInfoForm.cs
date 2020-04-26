namespace TimeTable.UI.Forms.Project
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using TimeTable.UI.Models.Enums;
    using Models;
    using Microsoft.EntityFrameworkCore;

    public partial class ProjectInfoForm : Form
    {
        private TimeTableContext db;
        private Project project;
        public ProjectInfoForm(decimal projectId)
        {
            InitializeComponent();
            this.db = new TimeTableContext();
            this.project = this.db.Projects.Include(p => p.ProjectHours).First(p => p.ProjectId == projectId);
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
                db.SaveChanges();
                this.changeStatusBtn.Enabled = false;

                MessageBox.Show(
                    $"Project Status was successfully updated!",
                    "Successful Status Update",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );         
            }
        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedYear = int.Parse(yearComboBox.SelectedItem.ToString());
            UpdateMonths(selectedYear);
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

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = int.Parse(yearComboBox.SelectedItem.ToString());
            Months month = (Months)Enum.Parse(typeof(Months), monthComboBox.Text);
            decimal hoursWorked = this.project.ProjectHours
                .Where(ph => ph.ProjectTaskdate.Month == (int)month && ph.ProjectTaskdate.Year == year).Sum(ph => ph.ProjectHours1);

            workedHoursLabel.Text = $"Hours Worked: {hoursWorked}";

            ProjectMonths projectMonth = this.db.ProjectMonths
                .FirstOrDefault(
                  pm => pm.ProjectId == this.project.ProjectId
                  && pm.ProjectYear == year
                  && pm.ProjectMonth == (int)month
                );

            if (projectMonth != null && projectMonth.ProjectMonthStatus == "C")
            {
                finishMonthBtn.Visible = false;
                finishedMonthLabel.Visible = true;
            }
            else
            {
                finishMonthBtn.Visible = true;
                finishedMonthLabel.Visible = false;
            }
        }

        private void finishMonthBtn_Click(object sender, EventArgs e)
        {
            int year = int.Parse(yearComboBox.SelectedItem.ToString());
            Months month = (Months)Enum.Parse(typeof(Months), monthComboBox.Text);
            ProjectMonths projectMonth = this.db.ProjectMonths
                .FirstOrDefault(
                  pm => pm.ProjectId == this.project.ProjectId
                  && pm.ProjectYear == year
                  && pm.ProjectMonth == (int)month
                );

            if (projectMonth == null)
            {
                projectMonth = new ProjectMonths()
                {
                    ProjectId = this.project.ProjectId,
                    ProjectMonth = (int)month,
                    ProjectYear = year,
                    ProjectMonthStatus = "C"
                };

                this.db.ProjectMonths.Add(projectMonth);
            }
            else
            {
                projectMonth.ProjectMonthStatus = "C";
            }

            this.db.SaveChanges();
            finishMonthBtn.Visible = false;
            finishedMonthLabel.Visible = true;
        }
    }
}
