namespace TimeTable.UI.Forms.Employee
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using TimeTable.UI.Forms.Task;
    using Models;
    using System.Collections.Generic;
    using TimeTable.UI.Models.Enums;

    public partial class EmployeeInfoForm : Form
    {
        private TimeTableContext db;
        private Employee employee;
        private int employeeTasksCount;
        public EmployeeInfoForm(string employeeEGN)
        {
            InitializeComponent();
            this.db = new TimeTableContext();
            this.employee = this.db.Employees.Include(em => em.ProjectHours).First(em => em.EmployeeEgn == employeeEGN);
            this.employeeTasksCount = employee.ProjectHours.Count;
        }

        private void EmployeeInfoForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text = $"Employee: {this.employee.EmployeeName} {this.employee.EmployeeSurname} {this.employee.EmployeeLastname}";
            tasksCountLabel.Text = $"Number of Tasks: {this.employeeTasksCount}";

            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "allTasks";
            editButtonColumn.HeaderText = "";
            editButtonColumn.Text = "All Tasks";
            editButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(editButtonColumn);

            FillDataGridView();

            int hireYear = this.employee.EmployeeHiredate.GetValueOrDefault().Year;
            var employeeYears = new List<string>();
            for (int year = hireYear; year <= DateTime.Now.Year; year++)
            {
                employeeYears.Add(year.ToString());
            }

            yearComboBox.DataSource = employeeYears;
            yearComboBox.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                TasksForm tasksForm = new TasksForm();
                tasksForm.Show();
            }
        }

        private void addTaskBtn_Click(object sender, EventArgs e)
        {
            var projectsNames = this.db.Projects.Select(p => p.ProjectName).ToList();
            TaskRegisterForm taskRegisterForm = new TaskRegisterForm(projectsNames);
            taskRegisterForm.RegisterEventHandler += TaskRegisterForm_RegisterEventHandler;
            taskRegisterForm.Show();
        }

        private void TaskRegisterForm_RegisterEventHandler(object sender, TaskRegisterForm.RegisterEventArgs args)
        {
            try
            {
                DateTime taskDate = args.ProjectTask.ProjectTaskdate;
                decimal projectId = this.db.Projects.First(p => p.ProjectName == args.ProjectName).ProjectId;
                ProjectMonths projectMonth = this.db.ProjectMonths.Where(pm => pm.ProjectId == projectId
                  && pm.ProjectMonth == taskDate.Month && pm.ProjectYear == taskDate.Year).FirstOrDefault();

                if (projectMonth == null)
                {
                    projectMonth = new ProjectMonths()
                    {
                        ProjectId = projectId,
                        ProjectMonth = taskDate.Month,
                        ProjectYear = taskDate.Year
                    };
                }

                args.ProjectTask.EmployeeId = this.employee.EmployeeId;
                args.ProjectTask.ProjectId = projectId;
                args.ProjectTask.ProjectMonth = projectMonth;

                db.ProjectHours.Add(args.ProjectTask);
                db.SaveChanges();

                this.employeeTasksCount += 1;
                tasksCountLabel.Text = $"Number of Tasks: {this.employeeTasksCount}";

                FillDataGridView();
                monthComboBox_SelectedIndexChanged(null, null);

                MessageBox.Show(
                    $"Task was successfully added to {args.ProjectName}!",
                    "Successful Task Registration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch
            {
                MessageBox.Show("An error occurred while recording the data! Please, try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillDataGridView()
        {
            dataGridView1.Rows.Clear();

            var employeeProjectsIds = this.employee.ProjectHours.Select(ph => ph.ProjectId).Distinct().ToList();
            foreach (var projectId in employeeProjectsIds)
            {
                Project project = this.db.Projects.Find(projectId);
                string projectName = project.ProjectName;
                string projectStatus = project.ProjectStatus == "O"
                    ? "In-Progress"
                    : "Finished";

                string employeeTotalWorkingHours = this.employee.ProjectHours.Where(ph => ph.ProjectId == projectId).Sum(ph => ph.ProjectHours1).ToString();
                dataGridView1.Rows.Add(new string[] { projectName, employeeTotalWorkingHours, projectStatus });
            }
        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedYear = int.Parse(yearComboBox.SelectedItem.ToString());
            UpdateMonths(selectedYear);
        }

        private void UpdateMonths(int selectedYear)
        {
            DateTime hireDate = this.employee.EmployeeHiredate.GetValueOrDefault();
            int firstMonth = selectedYear == hireDate.Year
                ? hireDate.Month
                : 1;

            int lastMonth = selectedYear == DateTime.Now.Year
                ? DateTime.Now.Month
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
            decimal hoursWorked = this.employee.ProjectHours
                .Where(ph => ph.ProjectTaskdate.Year == year && ph.ProjectTaskdate.Month == (int)month).Sum(ph => ph.ProjectHours1);

            workedHoursLabel.Text = $"Hours Worked: {hoursWorked}";
        }
    }
}
