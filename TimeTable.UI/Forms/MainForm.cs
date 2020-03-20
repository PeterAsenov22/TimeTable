using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTable.UI.Forms.Project;

namespace TimeTable.UI
{
    public partial class MainForm : Form
    {
        private ProjectRegisterForm projectRegisterForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] searchByItems = { "Name", "Start Date", "End Date", "Description", "Status" };
            searchComboBox.DataSource = searchByItems;
            searchComboBox.SelectedIndex = 0;

            string[] row = {
                "123456",
                "Demo Project",
                "Very cool project about ...",
                "26.02.2019",
                "23.05.2020",
                "120"
            };

            DataGridViewButtonColumn moreButtonColumn = new DataGridViewButtonColumn();
            moreButtonColumn.Name = "more";
            moreButtonColumn.HeaderText = "";
            moreButtonColumn.Text = "More";
            moreButtonColumn.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(moreButtonColumn);
            dataGridView1.Rows.Add(row);
        }

        private void registerProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            projectRegisterForm = new ProjectRegisterForm();
            projectRegisterForm.RegisterEventHandler += ProjectRegisterForm_RegisterEventHandler;
            projectRegisterForm.Show();
        }

        private void ProjectRegisterForm_RegisterEventHandler(object sender, ProjectRegisterForm.RegisterEventArgs args)
        {
            dataGridView1.Rows.Add(args.Data);
        }
    }
}
