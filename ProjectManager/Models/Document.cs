using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManager.Models {
    public class Document {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime LinkedOn { get; set; }
        public string Description { get; set; }
    }
}