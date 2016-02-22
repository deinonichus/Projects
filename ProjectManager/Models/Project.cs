using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManager.Models {
    public class Project {
        public int ID { get; set; }
        public string Name { get; set; }
        // prop
        public string Reference { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        // parsing required
        public DateTime Bewilligungsdatum { get; set; }
        public int Priority { get; set; } // has to be mapped to an enum
        public string Status { get; set; }
        // parsing required
        public DateTime StartDate { get; set; }
        // parsing required
        public DateTime EndDate { get; set; }
        public virtual List<Activity> Activities { get; set; }
    }
}