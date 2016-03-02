using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManager.Models {
    public class ProcessModel : Projectmodel {
        public string Name { get; set; }
        public Employee Creator { get; set; }
    }
}