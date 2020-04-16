namespace TimeTable.UI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using TimeTable.UI.Forms.Employee;
    using TimeTable.UI.Forms.Project;
    public partial class MainForm : Form
    {
        private TimeTableContext db = new TimeTableContext();
        private ProjectRegisterForm projectRegisterForm;
        private HashSet<decimal> projectsIds;
        public MainForm()
        {
            InitializeComponent();
            this.projectsIds = new HashSet<decimal>();
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

            var projects = db.Projects.ToList();
            foreach (var project in projects)
            {
                dataGridView1.Rows.Add(project.ToDataView());
                this.projectsIds.Add(project.ProjectId);
            }
        }

        private void registerProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            projectRegisterForm = new ProjectRegisterForm(this.projectsIds);
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
            dataGridView1.Rows.Remove(dataGridView1.Rows[args.RowIndex]);
            dataGridView1.Rows.Insert(args.RowIndex, args.Data);
            MessageBox.Show($"Project {args.Data[0]} was successfully edited!", "Successful Project Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 6)
                {
                    ProjectEditForm projectEditForm = new ProjectEditForm(e.RowIndex, dataGridView1[0, e.RowIndex].Value.ToString());
                    projectEditForm.EditEventHandler += ProjectEditForm_EditEventHandler;
                    projectEditForm.Show();
                }
                else if (e.ColumnIndex == 7)
                {
                    ProjectInfoForm projectInfoForm = new ProjectInfoForm(dataGridView1[0, e.RowIndex].Value.ToString());
                    projectInfoForm.Show();
                }
            }
        }

        private void registerEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeRegisterForm employeeRegisterForm = new EmployeeRegisterForm();
            employeeRegisterForm.Show();
        }

        private void searchEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeMainForm employeeMainForm = new EmployeeMainForm();
            employeeMainForm.Show();
        }
    }
}
