namespace TimeTable.UI.Models
{
    using System.Collections.Generic;
    public partial class ProjectMonths
    {
        public ProjectMonths()
        {
            ProjectHours = new HashSet<ProjectHours>();
        }

        public decimal ProjectMonthId { get; set; }
        public decimal ProjectId { get; set; }
        public decimal ProjectYear { get; set; }
        public decimal ProjectMonth { get; set; }
        public string ProjectMonthStatus { get; set; }

        public virtual Project Project { get; set; }
        public virtual ICollection<ProjectHours> ProjectHours { get; set; }
    }
}
