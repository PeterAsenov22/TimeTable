namespace TimeTable.UI.Forms.Employee
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    public partial class EmployeeRegisterForm : Form
    {
        public EmployeeRegisterForm()
        {
            InitializeComponent();
        }

        public delegate void RegisterDelegate(object sender, RegisterEventArgs args);
        public event RegisterDelegate RegisterEventHandler;

        public class RegisterEventArgs : EventArgs
        {
            public Models.Employee Employee { get; set; }
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
                RegisterEventArgs args = new RegisterEventArgs();
                args.Employee = new Models.Employee()
                {
                    EmployeeName = name,
                    EmployeeSurname = surname,
                    EmployeeLastname = lastName,
                    EmployeeEgn = egn,
                    EmployeePosition = position,
                    EmployeeHiredate = hireDate
                };

                RegisterEventHandler?.Invoke(this, args);
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

            return true;
        }

        private bool ContainsUnicodeCharacter(string input)
        {
            const int MaxAnsiCode = 255;

            return input.Any(c => c > MaxAnsiCode);
        }
    }
}
