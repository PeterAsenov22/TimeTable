﻿namespace TimeTable.UI.Models
{
    using System;
    using System.Collections.Generic;
    public partial class Employee
    {
        public Employee()
        {
            ProjectHours = new HashSet<ProjectHours>();
        }

        public decimal EmployeeId { get; set; }
        public string EmployeeEgn { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public string EmployeeLastname { get; set; }
        public string EmployeePosition { get; set; }
        public DateTime? EmployeeHiredate { get; set; }

        public virtual ICollection<ProjectHours> ProjectHours { get; set; }

        public string[] ToDataView()
        {
            return new string[]
            {
                EmployeeName,
                EmployeeSurname,
                EmployeeLastname,
                EmployeeEgn,
                EmployeePosition,
                EmployeeHiredate?.ToString("dd/MM/yyyy")
            };
        }
    }
}
