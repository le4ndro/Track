using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Track.Model.Models
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }

        public Project(int projectID, string name, string description, DateTime startDate, DateTime finishDate)
        {
            ProjectID = projectID;
            Name = name;
            Description = description;
            StartDate = startDate;
            FinishDate = finishDate;
        }

        public Project()
        {

        }
    }
}
