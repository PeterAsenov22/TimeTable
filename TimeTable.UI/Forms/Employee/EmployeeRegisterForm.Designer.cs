﻿namespace TimeTable.UI.Forms.Employee
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
            this.hireDateLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.egnLabel = new System.Windows.Forms.Label();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.egnTextBox = new System.Windows.Forms.TextBox();
            this.registerEmployeeBtn = new System.Windows.Forms.Button();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.hireDateTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // hireDateLabel
            // 
            this.hireDateLabel.AutoSize = true;
            this.hireDateLabel.Location = new System.Drawing.Point(450, 238);
            this.hireDateLabel.Name = "hireDateLabel";
            this.hireDateLabel.Size = new System.Drawing.Size(67, 17);
            this.hireDateLabel.TabIndex = 31;
            this.hireDateLabel.Text = "End Date";
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
            // egnLabel
            // 
            this.egnLabel.AutoSize = true;
            this.egnLabel.Location = new System.Drawing.Point(450, 84);
            this.egnLabel.Name = "egnLabel";
            this.egnLabel.Size = new System.Drawing.Size(38, 17);
            this.egnLabel.TabIndex = 26;
            this.egnLabel.Text = "EGN";
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(453, 185);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.PasswordChar = '*';
            this.positionTextBox.Size = new System.Drawing.Size(213, 22);
            this.positionTextBox.TabIndex = 25;
            // 
            // egnTextBox
            // 
            this.egnTextBox.Location = new System.Drawing.Point(453, 109);
            this.egnTextBox.Name = "egnTextBox";
            this.egnTextBox.Size = new System.Drawing.Size(213, 22);
            this.egnTextBox.TabIndex = 24;
            // 
            // registerEmployeeBtn
            // 
            this.registerEmployeeBtn.Location = new System.Drawing.Point(324, 334);
            this.registerEmployeeBtn.Name = "registerEmployeeBtn";
            this.registerEmployeeBtn.Size = new System.Drawing.Size(159, 33);
            this.registerEmployeeBtn.TabIndex = 23;
            this.registerEmployeeBtn.Text = "Register Employee";
            this.registerEmployeeBtn.UseVisualStyleBackColor = true;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(135, 159);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(65, 17);
            this.surnameLabel.TabIndex = 22;
            this.surnameLabel.Text = "Surname";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(135, 84);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 21;
            this.nameLabel.Text = "Name";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(138, 185);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.PasswordChar = '*';
            this.surnameTextBox.Size = new System.Drawing.Size(213, 22);
            this.surnameTextBox.TabIndex = 20;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(138, 109);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(213, 22);
            this.nameTextBox.TabIndex = 19;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(138, 262);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.PasswordChar = '*';
            this.lastNameTextBox.Size = new System.Drawing.Size(213, 22);
            this.lastNameTextBox.TabIndex = 32;
            // 
            // hireDateTextBox
            // 
            this.hireDateTextBox.Location = new System.Drawing.Point(453, 262);
            this.hireDateTextBox.Name = "hireDateTextBox";
            this.hireDateTextBox.PasswordChar = '*';
            this.hireDateTextBox.Size = new System.Drawing.Size(213, 22);
            this.hireDateTextBox.TabIndex = 33;
            // 
            // EmployeeRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hireDateTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.hireDateLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.egnLabel);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.egnTextBox);
            this.Controls.Add(this.registerEmployeeBtn);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "EmployeeRegisterForm";
            this.Text = "EmployeeRegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hireDateLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label egnLabel;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox egnTextBox;
        private System.Windows.Forms.Button registerEmployeeBtn;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox hireDateTextBox;
    }
}