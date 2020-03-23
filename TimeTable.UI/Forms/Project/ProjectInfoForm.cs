using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable.UI.Forms.Project
{
    public partial class ProjectInfoForm : Form
    {
        private string projectId;
        public ProjectInfoForm(string _projectId)
        {
            InitializeComponent();
            this.projectId = _projectId;
        }

        private void ProjectInfoForm_Load(object sender, EventArgs e)
        {
            // fetch the information about the project
            int workingEmployees = 8;
            workingEmployeesLabel.Text = $"Working Employees: {workingEmployees}";
            inProgressRadioButton.Checked = true;
        }
    }
}
