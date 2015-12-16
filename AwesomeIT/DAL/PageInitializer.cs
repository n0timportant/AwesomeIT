using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AwesomeIT.Models.Objects;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AwesomeIT.DAL
{
    public class PageInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PageContext>
    {
        protected override void Seed(PageContext context)
        {
            var students = new List<Student>
            {
            new Student{firstname="Carson",lastname="Alexander",enrollmentdate=DateTime.Parse("2005-09-01")},
            new Student{firstname="Meredith",lastname="Alonso",enrollmentdate=DateTime.Parse("2002-09-01")},
            new Student{firstname="Arturo",lastname="Anand",enrollmentdate=DateTime.Parse("2003-09-01")},
            new Student{firstname="Gytis",lastname="Barzdukas",enrollmentdate=DateTime.Parse("2002-09-01")},
            new Student{firstname="Yan",lastname="Li",enrollmentdate=DateTime.Parse("2002-09-01")},
            new Student{firstname="Peggy",lastname="Justice",enrollmentdate=DateTime.Parse("2001-09-01")},
            new Student{firstname="Laura",lastname="Norman",enrollmentdate=DateTime.Parse("2003-09-01")},
            new Student{firstname="Nino",lastname="Olivetto",enrollmentdate=DateTime.Parse("2005-09-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Course{title="Chemistry",credits="3",},
            new Course{title="Microeconomics",credits="3",},
            new Course{title="Macroeconomics",credits="3",},
            new Course{title="Calculus",credits="4",},
            new Course{title="Trigonometry",credits="4",},
            new Course{title="Composition",credits="3",},
            new Course{title="Literature",credits="4",}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{studentid=1,courseid=1,grade=Grade.A},
            new Enrollment{studentid=1,courseid=3,grade=Grade.C},
            new Enrollment{studentid=1,courseid=2,grade=Grade.B},
            new Enrollment{studentid=2,courseid=4,grade=Grade.B},
            new Enrollment{studentid=2,courseid=2,grade=Grade.F},
            new Enrollment{studentid=2,courseid=5,grade=Grade.F},
            new Enrollment{studentid=3,courseid=1,grade=Grade.B},
            new Enrollment{studentid=4,courseid=6,grade=Grade.C},
            new Enrollment{studentid=4,courseid=7,grade=Grade.F},
            new Enrollment{studentid=5,courseid=7,grade=Grade.C},
            new Enrollment{studentid=6,courseid=6,grade=Grade.B},
            new Enrollment{studentid=7,courseid=5,grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();

            //Role
            var adminRole = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole("admin");
            adminRole.Name = "admin";
            context.Roles.Add(adminRole);

            var userRole = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole("user");
            userRole.Name = "user";
            context.Roles.Add(userRole);

            context.SaveChanges();

            //Użytkownicy
            var admin = new ApplicationUser
            {
                isconfirmed = true,
                Email = "wojtek@awesomeit.pl",
                EmailConfirmed = true,
                PasswordHash = "ANBd9MbUC0mHpCer7BNuVoxo/yV/vII9iSxGZAUcTuiQBWfRfXxzZYR5HsZlWSqoyg==",
                SecurityStamp = "3ee72b22-bdea-41da-8fbe-22958e9fd2f6",
                UserName = "wojtek@awesomeit.pl"
            };
            
            //Powiązanie user -> rola
            var role = context.Roles.SingleOrDefault(item => item.Name == "admin");
            admin.Roles.Add(new IdentityUserRole { RoleId = role.Id });

            context.Users.Add(admin);
            context.SaveChanges();
        }
    }
}