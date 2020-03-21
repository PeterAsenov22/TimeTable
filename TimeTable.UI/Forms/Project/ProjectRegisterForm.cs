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
    public partial class ProjectRegisterForm : Form
    {
        public ProjectRegisterForm()
        {
            InitializeComponent();
        }

        public delegate void RegisterDelegate(object sender, RegisterEventArgs args);
        public event RegisterDelegate RegisterEventHandler;

        public class RegisterEventArgs : EventArgs
        {
            public string[] Data { get; set; }
        }

        private void registerProjectBtn_Click(object sender, EventArgs e)
        {
            RegisterEventArgs args = new RegisterEventArgs();
            args.Data = new string[] {
                "987654",
                "Demo Project 2",
                "Very cool project about ...",
                "22.08.2019",
                "23.05.2020",
                "220"
            };

            RegisterEventHandler?.Invoke(this, args);
            MessageBox.Show("Project 987654 was successfully registered!", "Successful Project Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
