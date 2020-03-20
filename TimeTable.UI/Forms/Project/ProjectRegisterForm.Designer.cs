namespace TimeTable.UI.Forms.Project
{
    partial class ProjectRegisterForm
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
            this.registerProjectBtn = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.projectIdLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.projectIdTextBox = new System.Windows.Forms.TextBox();
            this.maxWorkingHoursLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registerProjectBtn
            // 
            this.registerProjectBtn.Location = new System.Drawing.Point(334, 317);
            this.registerProjectBtn.Name = "registerProjectBtn";
            this.registerProjectBtn.Size = new System.Drawing.Size(159, 33);
            this.registerProjectBtn.TabIndex = 10;
            this.registerProjectBtn.Text = "Register Project";
            this.registerProjectBtn.UseVisualStyleBackColor = true;
            this.registerProjectBtn.Click += new System.EventHandler(this.registerProjectBtn_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(145, 142);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Name";
            // 
            // projectIdLabel
            // 
            this.projectIdLabel.AutoSize = true;
            this.projectIdLabel.Location = new System.Drawing.Point(145, 67);
            this.projectIdLabel.Name = "projectIdLabel";
            this.projectIdLabel.Size = new System.Drawing.Size(67, 17);
            this.projectIdLabel.TabIndex = 8;
            this.projectIdLabel.Text = "Project Id";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(148, 168);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(213, 22);
            this.passwordTextBox.TabIndex = 7;
            // 
            // projectIdTextBox
            // 
            this.projectIdTextBox.Location = new System.Drawing.Point(148, 92);
            this.projectIdTextBox.Name = "projectIdTextBox";
            this.projectIdTextBox.Size = new System.Drawing.Size(213, 22);
            this.projectIdTextBox.TabIndex = 6;
            // 
            // maxWorkingHoursLabel
            // 
            this.maxWorkingHoursLabel.AutoSize = true;
            this.maxWorkingHoursLabel.Location = new System.Drawing.Point(460, 142);
            this.maxWorkingHoursLabel.Name = "maxWorkingHoursLabel";
            this.maxWorkingHoursLabel.Size = new System.Drawing.Size(131, 17);
            this.maxWorkingHoursLabel.TabIndex = 14;
            this.maxWorkingHoursLabel.Text = "Max Working Hours";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(460, 67);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(79, 17);
            this.descriptionLabel.TabIndex = 13;
            this.descriptionLabel.Text = "Description";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(463, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(213, 22);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(463, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 22);
            this.textBox2.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(148, 245);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 22);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(463, 245);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(213, 22);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(145, 221);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(72, 17);
            this.startDateLabel.TabIndex = 17;
            this.startDateLabel.Text = "Start Date";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(460, 221);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(67, 17);
            this.endDateLabel.TabIndex = 18;
            this.endDateLabel.Text = "End Date";
            // 
            // ProjectRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.maxWorkingHoursLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.registerProjectBtn);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.projectIdLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.projectIdTextBox);
            this.Name = "ProjectRegisterForm";
            this.Text = "ProjectRegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button registerProjectBtn;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label projectIdLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox projectIdTextBox;
        private System.Windows.Forms.Label maxWorkingHoursLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
    }
}