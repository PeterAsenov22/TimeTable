namespace TimeTable.UI.Forms.Employee
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using Models;
    public partial class EmployeeEditForm : Form
    {
        private int rowIndex;
        private Employee employee;
        private HashSet<string> employeesEGNs;
        public EmployeeEditForm(int rowIndex, Employee employee, HashSet<string> employeesEGNs)
        {
            InitializeComponent();
            this.rowIndex = rowIndex;
            this.employee = employee;
            this.employeesEGNs = employeesEGNs;
        }

        private void EmployeeEditForm_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = employee.EmployeeName;
            surnameTextBox.Text = employee.EmployeeSurname;
            lastNameTextBox.Text = employee.EmployeeLastname;
            egnTextBox.Text = employee.EmployeeEgn;
            positionTextBox.Text = employee.EmployeePosition;
            hireDateTimePicker.Value = employee.EmployeeHiredate != null
                ? (DateTime) employee.EmployeeHiredate
                : DateTime.Today;
        }

        public delegate void EditDelegate(object sender, EditEventArgs args);
        public event EditDelegate EditEventHandler;

        public class EditEventArgs : EventArgs
        {
            public int RowIndex { get; set; }
            public Employee Employee { get; set; }
        }

        private void editEmployeeBtn_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string surname = surnameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string egn = egnTextBox.Text;
            string position = positionTextBox.Text;
            DateTime hireDate = hireDateTimePicker.Value;

            if (IsValidName(name, "Name")
                && IsValidName(surname, "Surname")
                && IsValidName(lastName, "Last Name")
                && IsValidEgn(egn)
                && IsValidPosition(position))
            {
                employee.EmployeeName = name;
                employee.EmployeeSurname = surname;
                employee.EmployeeLastname = lastName;
                employee.EmployeeEgn = egn;
                employee.EmployeePosition = position;
                employee.EmployeeHiredate = hireDate;

                EditEventArgs args = new EditEventArgs();
                args.RowIndex = rowIndex;
                args.Employee = employee;

                EditEventHandler?.Invoke(this, args);
                this.Close();
            }
        }

        private bool IsValidName(string name, string propertyName)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name) || name.Length > 50)
            {
                MessageBox.Show($"Please, fill in a {propertyName} with no more than 50 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (ContainsUnicodeCharacter(name))
            {
                MessageBox.Show(
                    $"The {propertyName} contains Unicode characters. Please, use only the English alphabet!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }

            return true;
        }

        private bool IsValidPosition(string position)
        {
            if (!string.IsNullOrEmpty(position))
            {
                if (position.Length > 50)
                {
                    MessageBox.Show(
                        $"Please, fill in a Position with no more than 50 characters!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return false;
                }
                else if (ContainsUnicodeCharacter(position))
                {
                    MessageBox.Show(
                        "The Position contains Unicode characters. Please, use only the English alphabet!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return false;
                }
            }

            return true;
        }

        private bool IsValidEgn(string egn)
        {
            if (string.IsNullOrEmpty(egn) || string.IsNullOrWhiteSpace(egn) || egn.Length != 10)
            {
                MessageBox.Show($"Please, fill in a valid EGN!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (ContainsUnicodeCharacter(egn))
            {
                MessageBox.Show(
                    $"The EGN contains Unicode characters. Please, use only the English alphabet!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }
            else if (egn != employee.EmployeeEgn && employeesEGNs.Contains(egn))
            {
                MessageBox.Show(
                  $"An employee with the same EGN has already been registered!",
                  "Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
                );

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
