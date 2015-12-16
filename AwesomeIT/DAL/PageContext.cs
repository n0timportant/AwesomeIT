using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AwesomeIT.Models.Objects;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace AwesomeIT.DAL
{
    public class PageContext : IdentityDbContext<ApplicationUser>
    {
        public PageContext() : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }

        public static PageContext Create()
        {
            return new PageContext();
        }
    }
}