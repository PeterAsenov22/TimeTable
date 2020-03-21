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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.projectIdTextBox = new System.Windows.Forms.TextBox();
            this.maxWorkingHoursLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.maxWHTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
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
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(148, 168);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(213, 22);
            this.nameTextBox.TabIndex = 7;
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
            // maxWHTextBox
            // 
            this.maxWHTextBox.Location = new System.Drawing.Point(463, 168);
            this.maxWHTextBox.Name = "maxWHTextBox";
            this.maxWHTextBox.PasswordChar = '*';
            this.maxWHTextBox.Size = new System.Drawing.Size(213, 22);
            this.maxWHTextBox.TabIndex = 12;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(463, 92);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(213, 22);
            this.descriptionTextBox.TabIndex = 11;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(148, 245);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(213, 22);
            this.startDateTimePicker.TabIndex = 15;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(463, 245);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(213, 22);
            this.endDateTimePicker.TabIndex = 16;
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
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.maxWorkingHoursLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.maxWHTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.registerProjectBtn);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.projectIdLabel);
            this.Controls.Add(this.nameTextBox);
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
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox projectIdTextBox;
        private System.Windows.Forms.Label maxWorkingHoursLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox maxWHTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
    }
}