using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable.UI.Forms.Employee
{
    public partial class EmployeeInfoForm : Form
    {
        public EmployeeInfoForm()
        {
            InitializeComponent();
        }

        private void EmployeeInfoForm_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "allTasks";
            editButtonColumn.HeaderText = "";
            editButtonColumn.Text = "All Tasks";
            editButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(editButtonColumn);

            DataGridViewButtonColumn moreButtonColumn = new DataGridViewButtonColumn();
            moreButtonColumn.Name = "addTask";
            moreButtonColumn.HeaderText = "";
            moreButtonColumn.Text = "Add Task";
            moreButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(moreButtonColumn);

            string[] row1 = {
                "Project 1",
                "60",
                "In Progress"
            };

            string[] row2 = {
                "Project 2",
                "120",
                "Finished"
            };

            dataGridView1.Rows.Add(row1);
            dataGridView1.Rows.Add(row2);
        }
    }
}
