using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectManager.Models {
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> {
        public ApplicationDbContext()
            : base("DefaultConnection") {
        }

        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<Activity> Activity { get; set; }

        // Use OnModelCreating to customize table creation
    }
}