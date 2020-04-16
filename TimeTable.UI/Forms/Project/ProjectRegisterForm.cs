namespace TimeTable.UI.Forms.Project
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    public partial class ProjectRegisterForm : Form
    {
        private HashSet<decimal> currentProjectsIds;
        public ProjectRegisterForm(HashSet<decimal> projectsIds)
        {
            InitializeComponent();
            this.currentProjectsIds = projectsIds;
        }

        public delegate void RegisterDelegate(object sender, RegisterEventArgs args);
        public event RegisterDelegate RegisterEventHandler;

        public class RegisterEventArgs : EventArgs
        {
            public Models.Project Project { get; set; }
        }

        private void registerProjectBtn_Click(object sender, EventArgs e)
        {
            int id = 0;
            int maxHours = 0;
            string name = nameTextBox.Text;
            string description = descriptionTextBox.Text;
            DateTime beginDate = startDateTimePicker.Value;
            DateTime endDate = endDateTimePicker.Value;

            if (IsValidId(ref id)
                && IsValidName(name)
                && IsValidDescription(description)
                && IsValidHours(ref maxHours)
                && IsValidEndDate(beginDate, endDate))
            {
                RegisterEventArgs args = new RegisterEventArgs();
                args.Project = new Models.Project()
                {
                    ProjectId = id,
                    ProjectName = name,
                    ProjectBegin = beginDate,
                    ProjectEnd = endDate,
                    ProjectDescription = description,
                    ProjectStatus = "O",
                    ProjectMaxhours = maxHours
                };

                RegisterEventHandler?.Invoke(this, args);
                ClearData();
            }
        }

        private bool IsValidId(ref int id)
        {
            if (!int.TryParse(projectIdTextBox.Text, out id))
            {
                MessageBox.Show("Please, fill in a whole number for Project Id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(this.currentProjectsIds.Contains(id))
            {
                MessageBox.Show("There is already an existing Project with the provided Id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool IsValidName(string name)
        {
            if (name.Length == 0 || name.Length > 50)
            {
                MessageBox.Show("Please, fill in a name for the Project with no more than 50 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(ContainsUnicodeCharacter(name))
            {
                MessageBox.Show(
                    "The Project Name contains Unicode characters. Please, use only the English alphabet!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }

            return true;
        }

        private bool IsValidDescription(string description)
        {
            if (!string.IsNullOrEmpty(description))
            {
                if (description.Length > 400)
                {
                    MessageBox.Show(
                        $"Please, fill in a description for the Project with no more than 400 characters! Current number of characters: ${description.Length}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return false;
                }
                else if (ContainsUnicodeCharacter(description))
                {
                    MessageBox.Show(
                        "The Project Description contains Unicode characters. Please, use only the English alphabet!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return false;
                }
            }

            return true;
        }

        private bool IsValidHours(ref int maxHours)
        {
            if (!int.TryParse(maxWHTextBox.Text, out maxHours))
            {
                MessageBox.Show("Please, fill in a whole number for Max Working Hours!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool IsValidEndDate(DateTime beginDate, DateTime endDate)
        {
            if (beginDate.CompareTo(endDate) >= 0)
            {
                MessageBox.Show("End Date must be after the Start Date!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool ContainsUnicodeCharacter(string input)
        {
            const int MaxAnsiCode = 255;

            return input.Any(c => c > MaxAnsiCode);
        }

        private void ClearData()
        {
            projectIdTextBox.Text = string.Empty;
            nameTextBox.Text = string.Empty;
            descriptionTextBox.Text = string.Empty;
            maxWHTextBox.Text = string.Empty;
            startDateTimePicker.Value = DateTime.Today;
            endDateTimePicker.Value = DateTime.Today;
        }
    }
}
