namespace TimeTable.UI.Forms.Task
{
    partial class TaskRegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.taskDateTextBox = new System.Windows.Forms.TextBox();
            this.taskDateLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.addTaskBtn = new System.Windows.Forms.Button();
            this.taskLabel = new System.Windows.Forms.Label();
            this.projectLabel = new System.Windows.Forms.Label();
            this.taskTextBox = new System.Windows.Forms.TextBox();
            this.projectTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // taskDateTextBox
            // 
            this.taskDateTextBox.Location = new System.Drawing.Point(474, 198);
            this.taskDateTextBox.Name = "taskDateTextBox";
            this.taskDateTextBox.PasswordChar = '*';
            this.taskDateTextBox.Size = new System.Drawing.Size(213, 22);
            this.taskDateTextBox.TabIndex = 45;
            // 
            // taskDateLabel
            // 
            this.taskDateLabel.AutoSize = true;
            this.taskDateLabel.Location = new System.Drawing.Point(471, 169);
            this.taskDateLabel.Name = "taskDateLabel";
            this.taskDateLabel.Size = new System.Drawing.Size(73, 17);
            this.taskDateLabel.TabIndex = 43;
            this.taskDateLabel.Text = "Task Date";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(135, 169);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(99, 17);
            this.hoursLabel.TabIndex = 41;
            this.hoursLabel.Text = "Hours Worked";
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Location = new System.Drawing.Point(138, 198);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(213, 22);
            this.hoursTextBox.TabIndex = 39;
            // 
            // addTaskBtn
            // 
            this.addTaskBtn.Location = new System.Drawing.Point(334, 288);
            this.addTaskBtn.Name = "addTaskBtn";
            this.addTaskBtn.Size = new System.Drawing.Size(159, 33);
            this.addTaskBtn.TabIndex = 38;
            this.addTaskBtn.Text = "Add Task";
            this.addTaskBtn.UseVisualStyleBackColor = true;
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.Location = new System.Drawing.Point(471, 84);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(39, 17);
            this.taskLabel.TabIndex = 37;
            this.taskLabel.Text = "Task";
            // 
            // projectLabel
            // 
            this.projectLabel.AutoSize = true;
            this.projectLabel.Location = new System.Drawing.Point(135, 84);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(52, 17);
            this.projectLabel.TabIndex = 36;
            this.projectLabel.Text = "Project";
            // 
            // taskTextBox
            // 
            this.taskTextBox.Location = new System.Drawing.Point(474, 109);
            this.taskTextBox.Name = "taskTextBox";
            this.taskTextBox.PasswordChar = '*';
            this.taskTextBox.Size = new System.Drawing.Size(213, 22);
            this.taskTextBox.TabIndex = 35;
            // 
            // projectTextBox
            // 
            this.projectTextBox.Enabled = false;
            this.projectTextBox.Location = new System.Drawing.Point(138, 109);
            this.projectTextBox.Name = "projectTextBox";
            this.projectTextBox.Size = new System.Drawing.Size(213, 22);
            this.projectTextBox.TabIndex = 34;
            // 
            // TaskRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.taskDateTextBox);
            this.Controls.Add(this.taskDateLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this.addTaskBtn);
            this.Controls.Add(this.taskLabel);
            this.Controls.Add(this.projectLabel);
            this.Controls.Add(this.taskTextBox);
            this.Controls.Add(this.projectTextBox);
            this.Name = "TaskRegisterForm";
            this.Text = "TaskRegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox taskDateTextBox;
        private System.Windows.Forms.Label taskDateLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.Button addTaskBtn;
        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.Label projectLabel;
        private System.Windows.Forms.TextBox taskTextBox;
        private System.Windows.Forms.TextBox projectTextBox;
    }
}