﻿namespace TimeTable.UI.Models
{
    using System;
    public partial class ProjectHours
    {
        public decimal ProjectId { get; set; }
        public decimal EmployeeId { get; set; }
        public DateTime ProjectTaskdate { get; set; }
        public decimal? ProjectMonthId { get; set; }
        public string ProjectTask { get; set; }
        public decimal ProjectHours1 { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Project Project { get; set; }
        public virtual ProjectMonths ProjectMonth { get; set; }

        public string[] ToDataView(string projectName)
        {
            return new string[]
            {
                projectName,
                ProjectTask,
                ProjectTaskdate.ToString("dd/MM/yyyy"),
                ProjectHours1.ToString()
            };
        }
    }
}
