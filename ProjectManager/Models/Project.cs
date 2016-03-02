using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManager.Models {
    public class Project {
        public string Projecttitle { get; set; }
        public string Projectreference { get; set; }
        public string Description { get; set; }
        public DateTime AuthorisationDate { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public bool Open { get; set; }

        // parsing required
        public DateTime Startdate { get; set; }
        // parsing required
        public DateTime Enddate { get; set; }
        public Employee Projectlead { get; set; }
        public string Customer { get; set; }
        public double Budget { get; set; }
        public string BudgetUnit { get; set; }
        public ProcessModel ProcessModel { get; set; }

        public double Progress { get; set; }
        public double EstimatedEffort { get; set; }
        public string EstimatedEffortUnit { get; set; }
        public double Effort { get; set; }
        public string EffortUnit { get; set; }
        public double EstimatedCosts { get; set; }
        public string EstimatedCostsUnit { get; set; }
        public double Costs { get; set; }
        public string CostsUnits { get; set; }
        public double EstimatedPrice { get; set; }
        public string EstimatedPriceUnit { get; set; }
        public double EstimatedRevenue { get; set; }
        public string EstimatedRevenueUnit { get; set; }
        public double Revenue { get; set; }
        public string RevenueUnit { get; set; }

        public bool closeProject() {
            1
        }

    }
}