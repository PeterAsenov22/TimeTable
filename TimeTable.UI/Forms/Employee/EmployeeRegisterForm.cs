namespace TimeTable.UI.Forms.Employee
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using Models;
    public partial class EmployeeRegisterForm : Form
    {
        private TimeTableContext db;
        public EmployeeRegisterForm(TimeTableContext db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void registerEmployeeBtn_Click(object sender, EventArgs e)
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
                try
                {
                    var employee = new Employee()
                    {
                        EmployeeId = db.Employees.Count() + 1,
                        EmployeeName = name,
                        EmployeeSurname = surname,
                        EmployeeLastname = lastName,
                        EmployeeEgn = egn,
                        EmployeePosition = position,
                        EmployeeHiredate = hireDate
                    };

                    db.Employees.Add(employee);
                    db.SaveChanges();

                    MessageBox.Show(
                        $"{employee.EmployeeName} {employee.EmployeeSurname} {employee.EmployeeLastname} was successfully registered!",
                        "Successful Employee Registration",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    this.Close();
                }
                catch
                {
                    MessageBox.Show("An error occurred while recording the data! Please, try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            else if (db.Employees.Any(e => e.EmployeeEgn == egn))
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
