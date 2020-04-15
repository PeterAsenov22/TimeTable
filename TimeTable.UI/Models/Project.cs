namespace TimeTable.UI.Models
{
    using System;
    using System.Collections.Generic;
    public partial class Project
    {
        public Project()
        {
            ProjectHours = new HashSet<ProjectHours>();
            ProjectMonths = new HashSet<ProjectMonths>();
        }

        public decimal ProjectId { get; set; }
        public string ProjectName { get; set; }
        public DateTime ProjectBegin { get; set; }
        public DateTime ProjectEnd { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectStatus { get; set; }
        public decimal? ProjectMaxhours { get; set; }

        public virtual ICollection<ProjectHours> ProjectHours { get; set; }
        public virtual ICollection<ProjectMonths> ProjectMonths { get; set; }

        public string[] ToDataView()
        {
            return new string[]
            {
                ProjectId.ToString(),
                ProjectName.ToString(),
                ProjectDescription.ToString(),
                ProjectBegin.ToString("dd/MM/yyyy"),
                ProjectEnd.ToString("dd/MM/yyyy"),
                ProjectMaxhours.ToString()
            };
        }
    }
}
