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

            string[] row = {
                "123456",
                "Demo Project",
                "Very cool project about ...",
                "26.02.2019",
                "23.05.2020",
                "120"
            };

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

        private void ProjectEditForm_EditEventHandler(object sender, ProjectEditForm.EditEventArgs args)
        {
            dataGridView1.Rows.Remove(dataGridView1.Rows[args.RowIndex]);
            dataGridView1.Rows.Insert(args.RowIndex, args.Data);
            MessageBox.Show($"Project {args.Data[0]} was successfully edited!", "Successful Project Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 6)
                {
                    ProjectEditForm projectEditForm = new ProjectEditForm(e.RowIndex, dataGridView1[0, e.RowIndex].Value.ToString());
                    projectEditForm.EditEventHandler += ProjectEditForm_EditEventHandler;
                    projectEditForm.Show();
                }
            }
        }
    }
}
