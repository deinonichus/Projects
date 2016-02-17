using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManager.Models {
    public class Project {
        public int ID { get; set; }
        public string Name { get; set; }
        // prop
        public virtual List<Activity> Activities { get; set; }
    }
}