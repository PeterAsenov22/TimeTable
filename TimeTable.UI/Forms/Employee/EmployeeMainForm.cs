namespace TimeTable.UI.Forms.Employee
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    public partial class EmployeeMainForm : Form
    {
        private TimeTableContext db;
        private List<Models.Employee> employees;
        public EmployeeMainForm(TimeTableContext db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void EmployeeMainForm_Load(object sender, EventArgs e)
        {
            string[] searchByItems = { "Name", "Surname", "Last Name", "EGN", "Position", "Hire Date" };
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

            this.employees = db.Employees.ToList();
            foreach (var employee in this.employees)
            {
                dataGridView1.Rows.Add(employee.ToDataView());
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
                    EmployeeEditForm employeeEditForm = new EmployeeEditForm();
                    employeeEditForm.Show();
                }
                else if (e.ColumnIndex == 7)
                {
                    EmployeeInfoForm employeeInfoForm = new EmployeeInfoForm();
                    employeeInfoForm.Show();
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            List<Models.Employee> filteredProjects = new List<Models.Employee>();
            string searchBy = searchComboBox.Text;
            string searchTerm = searchTextBox.Text;

            if (string.IsNullOrEmpty(searchTerm) || string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Please, enter a search term!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                switch (searchBy)
                {
                    case "Name":
                        filteredProjects = this.employees.Where(em => em.EmployeeName.Contains(searchTerm)).ToList();
                        break;
                    case "Surname":
                        filteredProjects = this.employees.Where(em => em.EmployeeSurname.Contains(searchTerm)).ToList();
                        break;
                    case "Last Name":
                        filteredProjects = this.employees.Where(em => em.EmployeeLastname.Contains(searchTerm)).ToList();
                        break;
                    case "EGN":
                        filteredProjects = this.employees.Where(em => em.EmployeeEgn.Contains(searchTerm)).ToList();
                        break;
                    case "Position":
                        filteredProjects = this.employees.Where(em => em.EmployeePosition.Contains(searchTerm)).ToList();
                        break;
                    case "Hire Date":
                        filteredProjects = this.employees.Where(em => em.EmployeeHiredate != null
                          && ((DateTime) em.EmployeeHiredate).ToString("dd/MM/yyyy").Contains(searchTerm)).ToList();
                        break;
                    default:
                        break;
                }

                dataGridView1.Rows.Clear();
                foreach (var project in filteredProjects)
                {
                    dataGridView1.Rows.Add(project.ToDataView());
                }
            }
        }

        private void clearSearchBtn_Click(object sender, EventArgs e)
        {
            searchComboBox.SelectedIndex = 0;
            searchTextBox.Text = string.Empty;
            dataGridView1.Rows.Clear();
            foreach (var employee in this.employees)
            {
                dataGridView1.Rows.Add(employee.ToDataView());
            }
        }
    }
}
