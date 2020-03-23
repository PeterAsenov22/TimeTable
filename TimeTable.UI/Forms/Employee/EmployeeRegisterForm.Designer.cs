namespace TimeTable.UI.Forms.Employee
{
    partial class EmployeeRegisterForm
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
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.personalNumberLabel = new System.Windows.Forms.Label();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.employeePersonalNumberTextBox = new System.Windows.Forms.TextBox();
            this.registerEmployeeBtn = new System.Windows.Forms.Button();
            this.secondNameLabel = new System.Windows.Forms.Label();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.endDateTextBox = new System.Windows.Forms.TextBox();
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
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(135, 238);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(76, 17);
            this.lastNameLabel.TabIndex = 30;
            this.lastNameLabel.Text = "Last Name";
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(450, 159);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(58, 17);
            this.positionLabel.TabIndex = 27;
            this.positionLabel.Text = "Position";
            // 
            // personalNumberLabel
            // 
            this.personalNumberLabel.AutoSize = true;
            this.personalNumberLabel.Location = new System.Drawing.Point(450, 84);
            this.personalNumberLabel.Name = "personalNumberLabel";
            this.personalNumberLabel.Size = new System.Drawing.Size(118, 17);
            this.personalNumberLabel.TabIndex = 26;
            this.personalNumberLabel.Text = "Personal Number";
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(453, 185);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.PasswordChar = '*';
            this.positionTextBox.Size = new System.Drawing.Size(213, 22);
            this.positionTextBox.TabIndex = 25;
            // 
            // employeePersonalNumberTextBox
            // 
            this.employeePersonalNumberTextBox.Location = new System.Drawing.Point(453, 109);
            this.employeePersonalNumberTextBox.Name = "employeePersonalNumberTextBox";
            this.employeePersonalNumberTextBox.Size = new System.Drawing.Size(213, 22);
            this.employeePersonalNumberTextBox.TabIndex = 24;
            // 
            // registerEmployeeBtn
            // 
            this.registerEmployeeBtn.Location = new System.Drawing.Point(324, 334);
            this.registerEmployeeBtn.Name = "registerEmployeeBtn";
            this.registerEmployeeBtn.Size = new System.Drawing.Size(159, 33);
            this.registerEmployeeBtn.TabIndex = 23;
            this.registerEmployeeBtn.Text = "Register";
            this.registerEmployeeBtn.UseVisualStyleBackColor = true;
            // 
            // secondNameLabel
            // 
            this.secondNameLabel.AutoSize = true;
            this.secondNameLabel.Location = new System.Drawing.Point(135, 159);
            this.secondNameLabel.Name = "secondNameLabel";
            this.secondNameLabel.Size = new System.Drawing.Size(95, 17);
            this.secondNameLabel.TabIndex = 22;
            this.secondNameLabel.Text = "Second name";
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(135, 84);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(45, 17);
            this.employeeNameLabel.TabIndex = 21;
            this.employeeNameLabel.Text = "Name";
            // 
            // secondNameTextBox
            // 
            this.secondNameTextBox.Location = new System.Drawing.Point(138, 185);
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.PasswordChar = '*';
            this.secondNameTextBox.Size = new System.Drawing.Size(213, 22);
            this.secondNameTextBox.TabIndex = 20;
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(138, 109);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(213, 22);
            this.employeeNameTextBox.TabIndex = 19;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(138, 262);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.PasswordChar = '*';
            this.lastNameTextBox.Size = new System.Drawing.Size(213, 22);
            this.lastNameTextBox.TabIndex = 32;
            // 
            // endDateTextBox
            // 
            this.endDateTextBox.Location = new System.Drawing.Point(453, 262);
            this.endDateTextBox.Name = "endDateTextBox";
            this.endDateTextBox.PasswordChar = '*';
            this.endDateTextBox.Size = new System.Drawing.Size(213, 22);
            this.endDateTextBox.TabIndex = 33;
            // 
            // EmployeeRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.endDateTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.personalNumberLabel);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.employeePersonalNumberTextBox);
            this.Controls.Add(this.registerEmployeeBtn);
            this.Controls.Add(this.secondNameLabel);
            this.Controls.Add(this.employeeNameLabel);
            this.Controls.Add(this.secondNameTextBox);
            this.Controls.Add(this.employeeNameTextBox);
            this.Name = "EmployeeRegisterForm";
            this.Text = "EmployeeRegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label personalNumberLabel;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox employeePersonalNumberTextBox;
        private System.Windows.Forms.Button registerEmployeeBtn;
        private System.Windows.Forms.Label secondNameLabel;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.TextBox secondNameTextBox;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox endDateTextBox;
    }
}