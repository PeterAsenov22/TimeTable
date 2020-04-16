namespace TimeTable.UI.Forms.Project
{
    partial class ProjectEditForm
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
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.maxWorkingHoursLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.maxWHTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.editProjectBtn = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.projectIdLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.projectIdTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(450, 238);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(67, 17);
            this.endDateLabel.TabIndex = 31;
            this.endDateLabel.Text = "End Date";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(135, 238);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(72, 17);
            this.startDateLabel.TabIndex = 30;
            this.startDateLabel.Text = "Start Date";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(453, 262);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(213, 22);
            this.endDateTimePicker.TabIndex = 29;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(138, 262);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(213, 22);
            this.startDateTimePicker.TabIndex = 28;
            // 
            // maxWorkingHoursLabel
            // 
            this.maxWorkingHoursLabel.AutoSize = true;
            this.maxWorkingHoursLabel.Location = new System.Drawing.Point(450, 159);
            this.maxWorkingHoursLabel.Name = "maxWorkingHoursLabel";
            this.maxWorkingHoursLabel.Size = new System.Drawing.Size(131, 17);
            this.maxWorkingHoursLabel.TabIndex = 27;
            this.maxWorkingHoursLabel.Text = "Max Working Hours";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(450, 84);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(79, 17);
            this.descriptionLabel.TabIndex = 26;
            this.descriptionLabel.Text = "Description";
            // 
            // maxWHTextBox
            // 
            this.maxWHTextBox.Location = new System.Drawing.Point(453, 185);
            this.maxWHTextBox.Name = "maxWHTextBox";
            this.maxWHTextBox.Size = new System.Drawing.Size(213, 22);
            this.maxWHTextBox.TabIndex = 25;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(453, 109);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(213, 22);
            this.descriptionTextBox.TabIndex = 24;
            // 
            // editProjectBtn
            // 
            this.editProjectBtn.Location = new System.Drawing.Point(324, 335);
            this.editProjectBtn.Name = "editProjectBtn";
            this.editProjectBtn.Size = new System.Drawing.Size(159, 33);
            this.editProjectBtn.TabIndex = 23;
            this.editProjectBtn.Text = "Edit Project";
            this.editProjectBtn.UseVisualStyleBackColor = true;
            this.editProjectBtn.Click += new System.EventHandler(this.editProjectBtn_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(135, 159);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 22;
            this.nameLabel.Text = "Name";
            // 
            // projectIdLabel
            // 
            this.projectIdLabel.AutoSize = true;
            this.projectIdLabel.Location = new System.Drawing.Point(135, 84);
            this.projectIdLabel.Name = "projectIdLabel";
            this.projectIdLabel.Size = new System.Drawing.Size(67, 17);
            this.projectIdLabel.TabIndex = 21;
            this.projectIdLabel.Text = "Project Id";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(138, 185);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(213, 22);
            this.nameTextBox.TabIndex = 20;
            // 
            // projectIdTextBox
            // 
            this.projectIdTextBox.Location = new System.Drawing.Point(138, 109);
            this.projectIdTextBox.Name = "projectIdTextBox";
            this.projectIdTextBox.Size = new System.Drawing.Size(213, 22);
            this.projectIdTextBox.TabIndex = 19;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(334, 33);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(93, 17);
            this.titleLabel.TabIndex = 33;
            this.titleLabel.Text = "Project Name";
            // 
            // ProjectEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.maxWorkingHoursLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.maxWHTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.editProjectBtn);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.projectIdLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.projectIdTextBox);
            this.Name = "ProjectEditForm";
            this.Text = "Edit Project";
            this.Load += new System.EventHandler(this.ProjectEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label maxWorkingHoursLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox maxWHTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button editProjectBtn;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label projectIdLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox projectIdTextBox;
        private System.Windows.Forms.Label titleLabel;
    }
}