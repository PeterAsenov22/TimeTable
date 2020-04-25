namespace TimeTable.UI.Forms.Project
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using Models;
    public partial class ProjectEditForm : Form
    {
        private int rowIndex;
        private Project project;
        private HashSet<decimal> projectsIds;
        private HashSet<string> projectsNames;
        public ProjectEditForm(int rowIndex, Project project, HashSet<decimal> projectsIds, HashSet<string> projectsNames)
        {
            InitializeComponent();
            this.rowIndex = rowIndex;
            this.project = project;
            this.projectsIds = projectsIds;
            this.projectsNames = projectsNames;
        }

        private void ProjectEditForm_Load(object sender, EventArgs e)
        {
            titleLabel.Text = $"Project: {this.project.ProjectName.ToString()}";
            projectIdTextBox.Text = this.project.ProjectId.ToString();
            projectIdTextBox.Enabled = false;
            nameTextBox.Text = this.project.ProjectName.ToString();
            descriptionTextBox.Text = this.project.ProjectDescription.ToString();
            maxWHTextBox.Text = this.project.ProjectMaxhours.ToString();
            startDateTimePicker.Value = this.project.ProjectBegin;
            endDateTimePicker.Value = this.project.ProjectEnd;
        }

        public delegate void EditDelegate(object sender, EditEventArgs args);
        public event EditDelegate EditEventHandler;

        public class EditEventArgs : EventArgs
        {
            public int RowIndex { get; set; }
            public Project Project { get; set; }
        }

        private void editProjectBtn_Click(object sender, EventArgs e)
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
                && IsValidHours(ref maxHours, (decimal)project.ProjectMaxhours)
                && IsValidEndDate(beginDate, endDate))
            {
                project.ProjectId = id;
                project.ProjectName = name;
                project.ProjectDescription = description;
                project.ProjectMaxhours = maxHours;
                project.ProjectBegin = beginDate;
                project.ProjectEnd = endDate;

                EditEventArgs args = new EditEventArgs();
                args.RowIndex = rowIndex;
                args.Project = project;

                EditEventHandler?.Invoke(this, args);
                this.Close();
            }
        }

        private bool IsValidId(ref int id)
        {
            if (!int.TryParse(projectIdTextBox.Text, out id))
            {
                MessageBox.Show("Please, fill in a whole number for Project Id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (this.project.ProjectId != id && this.projectsIds.Contains(id))
            {
                MessageBox.Show("There is already an existing Project with the provided Id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool IsValidName(string name)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name) || name.Length > 50)
            {
                MessageBox.Show("Please, fill in a name for the Project with no more than 50 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (ContainsUnicodeCharacter(name))
            {
                MessageBox.Show(
                    "The Project Name contains Unicode characters. Please, use only the English alphabet!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }
            else if (this.project.ProjectName != name && this.projectsNames.Contains(name))
            {
                MessageBox.Show("There is already an existing Project with the provided name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private bool IsValidHours(ref int maxHours, decimal currentMaxHours)
        {
            if (!int.TryParse(maxWHTextBox.Text, out maxHours))
            {
                MessageBox.Show("Please, fill in a whole number for Max Working Hours!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (maxHours < currentMaxHours)
            {
                MessageBox.Show("Max Working Hours per Employee cannot be decreased!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
