namespace TimeTable.UI.Forms.Employee
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using Models;
    public partial class EmployeeMainForm : Form
    {
        private TimeTableContext db;
        private List<Employee> employees;
        private HashSet<string> employeesEGNs;
        public EmployeeMainForm(TimeTableContext db)
        {
            InitializeComponent();
            this.db = db;
            this.employeesEGNs = new HashSet<string>();
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
                this.employeesEGNs.Add(employee.EmployeeEgn);
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
                    string employeeEGN = dataGridView1[3, e.RowIndex].Value.ToString();
                    Employee employee = db.Employees.First(em => em.EmployeeEgn == employeeEGN);
                    if (employee != null)
                    {
                        EmployeeEditForm employeeEditForm = new EmployeeEditForm(e.RowIndex, employee, this.employeesEGNs);
                        employeeEditForm.EditEventHandler += EmployeeEditForm_EditEventHandler;
                        employeeEditForm.Show();
                    }
                }
                else if (e.ColumnIndex == 7)
                {
                    string employeeEGN = dataGridView1[3, e.RowIndex].Value.ToString();
                    EmployeeInfoForm employeeInfoForm = new EmployeeInfoForm(employeeEGN);
                    employeeInfoForm.Show();
                }
            }
        }

        private void EmployeeEditForm_EditEventHandler(object sender, EmployeeEditForm.EditEventArgs args)
        {
            try
            {
                db.SaveChanges();
                dataGridView1.Rows.Remove(dataGridView1.Rows[args.RowIndex]);
                dataGridView1.Rows.Insert(args.RowIndex, args.Employee.ToDataView());
                UpdateSets();
                MessageBox.Show(
                    $"{args.Employee.EmployeeName} {args.Employee.EmployeeSurname} {args.Employee.EmployeeLastname}'s account was successfully edited!",
                    "Successful Employee Update",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch
            {
                MessageBox.Show("An error occurred while recording the changes! Please, try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            List<Employee> filteredProjects = new List<Employee>();
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

        private void UpdateSets()
        {
            this.employeesEGNs.Clear();

            foreach (var employee in this.employees)
            {
                this.employeesEGNs.Add(employee.EmployeeEgn);
            }
        }
    }
}
