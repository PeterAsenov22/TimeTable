namespace TimeTable.UI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using TimeTable.UI.Forms.Employee;
    using TimeTable.UI.Forms.Project;
    using TimeTable.UI.Models;

    public partial class MainForm : Form
    {
        private TimeTableContext db;
        private ProjectRegisterForm projectRegisterForm;
        private List<Models.Project> projects;
        private HashSet<decimal> projectsIds;
        private HashSet<string> projectsNames;
        public MainForm()
        {
            InitializeComponent();
            this.db = new TimeTableContext();
            this.projectsIds = new HashSet<decimal>();
            this.projectsNames = new HashSet<string>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] searchByItems = { "Name", "Start Date", "End Date", "Description", "Status" };
            searchComboBox.DataSource = searchByItems;
            searchComboBox.SelectedIndex = 0;

            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "edit";
            editButtonColumn.HeaderText = "";
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(editButtonColumn);

            DataGridViewButtonColumn moreButtonColumn = new DataGridViewButtonColumn();
            moreButtonColumn.Name = "more";
            moreButtonColumn.HeaderText = "";
            moreButtonColumn.Text = "More";
            moreButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(moreButtonColumn);

            this.projects = db.Projects.ToList();
            foreach (var project in this.projects)
            {
                dataGridView1.Rows.Add(project.ToDataView());
                this.projectsIds.Add(project.ProjectId);
                this.projectsNames.Add(project.ProjectName);
            }
        }

        private void registerProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            projectRegisterForm = new ProjectRegisterForm(this.projectsIds, this.projectsNames);
            projectRegisterForm.RegisterEventHandler += ProjectRegisterForm_RegisterEventHandler;
            projectRegisterForm.Show();
        }

        private void ProjectRegisterForm_RegisterEventHandler(object sender, ProjectRegisterForm.RegisterEventArgs args)
        {
            try
            {
                db.Projects.Add(args.Project);
                db.SaveChanges();
                dataGridView1.Rows.Add(args.Project.ToDataView());
                UpdateSets();
                MessageBox.Show(
                    $"Project \"{args.Project.ProjectName}\" was successfully registered!",
                    "Successful Project Registration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch
            {
                MessageBox.Show("An error occurred while recording the data! Please, try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }

        private void ProjectEditForm_EditEventHandler(object sender, ProjectEditForm.EditEventArgs args)
        {
            try
            {
                db.SaveChanges();
                dataGridView1.Rows.Remove(dataGridView1.Rows[args.RowIndex]);
                dataGridView1.Rows.Insert(args.RowIndex, args.Project.ToDataView());
                UpdateSets();
                MessageBox.Show(
                    $"Project {args.Project.ProjectName} was successfully edited!",
                    "Successful Project Update",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch
            {
                MessageBox.Show("An error occurred while recording the changes! Please, try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProjectInfoForm_ChangeStatusEventHandler(object sender)
        {
            try
            {
                db.SaveChanges();
                MessageBox.Show(
                    $"Project Status was successfully updated!",
                    "Successful Status Update",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch
            {
                MessageBox.Show("An error occurred while recording the changes! Please, try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 6)
                {
                    decimal projectId = decimal.Parse(dataGridView1[0, e.RowIndex].Value.ToString());
                    Project project = db.Projects.Find(projectId);
                    if (project != null)
                    {
                        ProjectEditForm projectEditForm = new ProjectEditForm(e.RowIndex, project, this.projectsIds, this.projectsNames);
                        projectEditForm.EditEventHandler += ProjectEditForm_EditEventHandler;
                        projectEditForm.Show();
                    }
                }
                else if (e.ColumnIndex == 7)
                {
                    decimal projectId = decimal.Parse(dataGridView1[0, e.RowIndex].Value.ToString());
                    Project project = db.Projects.Find(projectId);
                    if (project != null)
                    {
                        ProjectInfoForm projectInfoForm = new ProjectInfoForm(project);
                        projectInfoForm.ChangeStatusEventHandler += ProjectInfoForm_ChangeStatusEventHandler;
                        projectInfoForm.Show();
                    }
                }
            }
        }

        private void registerEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeRegisterForm employeeRegisterForm = new EmployeeRegisterForm(db);
            employeeRegisterForm.Show();
        }

        private void searchEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeMainForm employeeMainForm = new EmployeeMainForm(db);
            employeeMainForm.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            List<Project> filteredProjects = new List<Models.Project>();
            string searchBy = searchComboBox.Text;
            string searchTerm = searchTextBox.Text;
            bool error = false;

            if (string.IsNullOrEmpty(searchTerm) || string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Please, enter a search term!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                switch (searchBy)
                {
                    case "Name":
                        filteredProjects = this.projects.Where(p => p.ProjectName.Contains(searchTerm)).ToList();
                        break;
                    case "Description":
                        filteredProjects = this.projects.Where(p => p.ProjectDescription.Contains(searchTerm)).ToList();
                        break;
                    case "Status":
                        if (searchTerm != "In-Progress" && searchTerm != "Finished")
                        {
                            MessageBox.Show("Please, enter \"In-Progress\" OR \"Finished\" when searching by Status!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            error = true;
                            break;
                        }

                        searchTerm = searchTerm == "In-Progress"
                            ? "O"
                            : "C";
                        filteredProjects = this.projects.Where(p => p.ProjectStatus == searchTerm).ToList();
                        break;
                    case "Start Date":
                        filteredProjects = this.projects.Where(p => p.ProjectBegin.ToString("dd/MM/yyyy").Contains(searchTerm)).ToList();
                        break;
                    case "End Date":
                        filteredProjects = this.projects.Where(p => p.ProjectEnd.ToString("dd/MM/yyyy").Contains(searchTerm)).ToList();
                        break;
                    default:
                        break;
                }

                if (!error)
                {
                    dataGridView1.Rows.Clear();
                    foreach (var project in filteredProjects)
                    {
                        dataGridView1.Rows.Add(project.ToDataView());
                    }
                }
            }
        }

        private void clearSearchBtn_Click(object sender, EventArgs e)
        {
            searchComboBox.SelectedIndex = 0;
            searchTextBox.Text = string.Empty;
            dataGridView1.Rows.Clear();
            foreach (var project in this.projects)
            {
                dataGridView1.Rows.Add(project.ToDataView());
            }
        }

        private void UpdateSets()
        {
            this.projectsIds.Clear();
            this.projectsNames.Clear();

            foreach (var project in this.projects)
            {
                this.projectsIds.Add(project.ProjectId);
                this.projectsNames.Add(project.ProjectName);
            }
        }
    }
}
