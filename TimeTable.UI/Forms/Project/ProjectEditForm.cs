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
    public partial class ProjectEditForm : Form
    {
        private int rowIndex;
        private string projectId;
        public ProjectEditForm(int _rowIndex, string _projectId)
        {
            InitializeComponent();
            rowIndex = _rowIndex;
            projectId = _projectId;
        }

        private void ProjectEditForm_Load(object sender, EventArgs e)
        {
            // fetch info about project or receive Project entity from Main Form
            string name = "Demo Project";
            string description = "Very cool project about ...";

            projectIdTextBox.Text = projectId;
            projectIdTextBox.Enabled = false;
            nameTextBox.Text = name;
            descriptionTextBox.Text = description;
        }

        public delegate void EditDelegate(object sender, EditEventArgs args);
        public event EditDelegate EditEventHandler;

        public class EditEventArgs : EventArgs
        {
            public int RowIndex { get; set; }
            public string[] Data { get; set; }
        }

        private void editProjectBtn_Click(object sender, EventArgs e)
        {
            EditEventArgs args = new EditEventArgs();
            args.RowIndex = rowIndex;
            args.Data = new string[] {
                projectId,
                nameTextBox.Text,
                descriptionTextBox.Text,
                "26.02.2019",
                "23.05.2020",
                "200"
            };

            EditEventHandler?.Invoke(this, args);
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
