using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Track.Web.ViewModels
{
    public class ProjectViewModel
    {
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
    }
}