namespace TimeTable.UI.Forms.Employee
{
    partial class EmployeeEditForm
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
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.hireDateLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.egnLabel = new System.Windows.Forms.Label();
            this.egnTextBox = new System.Windows.Forms.TextBox();
            this.editEmployeeBtn = new System.Windows.Forms.Button();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.hireDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(138, 262);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(213, 22);
            this.lastNameTextBox.TabIndex = 45;
            // 
            // hireDateLabel
            // 
            this.hireDateLabel.AutoSize = true;
            this.hireDateLabel.Location = new System.Drawing.Point(450, 238);
            this.hireDateLabel.Name = "hireDateLabel";
            this.hireDateLabel.Size = new System.Drawing.Size(68, 17);
            this.hireDateLabel.TabIndex = 44;
            this.hireDateLabel.Text = "Hire Date";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(135, 238);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(76, 17);
            this.lastNameLabel.TabIndex = 43;
            this.lastNameLabel.Text = "Last Name";
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(450, 159);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(58, 17);
            this.positionLabel.TabIndex = 42;
            this.positionLabel.Text = "Position";
            // 
            // egnLabel
            // 
            this.egnLabel.AutoSize = true;
            this.egnLabel.Location = new System.Drawing.Point(450, 84);
            this.egnLabel.Name = "egnLabel";
            this.egnLabel.Size = new System.Drawing.Size(38, 17);
            this.egnLabel.TabIndex = 41;
            this.egnLabel.Text = "EGN";
            // 
            // egnTextBox
            // 
            this.egnTextBox.Location = new System.Drawing.Point(453, 109);
            this.egnTextBox.Name = "egnTextBox";
            this.egnTextBox.Size = new System.Drawing.Size(213, 22);
            this.egnTextBox.TabIndex = 39;
            // 
            // editEmployeeBtn
            // 
            this.editEmployeeBtn.Location = new System.Drawing.Point(324, 334);
            this.editEmployeeBtn.Name = "editEmployeeBtn";
            this.editEmployeeBtn.Size = new System.Drawing.Size(159, 33);
            this.editEmployeeBtn.TabIndex = 38;
            this.editEmployeeBtn.Text = "Save";
            this.editEmployeeBtn.UseVisualStyleBackColor = true;
            this.editEmployeeBtn.Click += new System.EventHandler(this.editEmployeeBtn_Click);
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(135, 159);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(65, 17);
            this.surnameLabel.TabIndex = 37;
            this.surnameLabel.Text = "Surname";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(135, 84);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 36;
            this.nameLabel.Text = "Name";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(138, 185);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(213, 22);
            this.surnameTextBox.TabIndex = 35;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(138, 109);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(213, 22);
            this.nameTextBox.TabIndex = 34;
            // 
            // hireDateTimePicker
            // 
            this.hireDateTimePicker.Location = new System.Drawing.Point(453, 262);
            this.hireDateTimePicker.Name = "hireDateTimePicker";
            this.hireDateTimePicker.Size = new System.Drawing.Size(213, 22);
            this.hireDateTimePicker.TabIndex = 46;
            // 
            // positionComboBox
            // 
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Location = new System.Drawing.Point(453, 185);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(213, 24);
            this.positionComboBox.TabIndex = 47;
            // 
            // EmployeeEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.positionComboBox);
            this.Controls.Add(this.hireDateTimePicker);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.hireDateLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.egnLabel);
            this.Controls.Add(this.egnTextBox);
            this.Controls.Add(this.editEmployeeBtn);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "EmployeeEditForm";
            this.Text = "Edit Employee";
            this.Load += new System.EventHandler(this.EmployeeEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label hireDateLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label egnLabel;
        private System.Windows.Forms.TextBox egnTextBox;
        private System.Windows.Forms.Button editEmployeeBtn;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DateTimePicker hireDateTimePicker;
        private System.Windows.Forms.ComboBox positionComboBox;
    }
}