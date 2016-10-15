namespace RepoQuiz.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using RepoQuiz.DAL;
    using Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<RepoQuiz.DAL.StudentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RepoQuiz.DAL.StudentContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            NameGenerator newStudents = new NameGenerator(10);
            List<Name> TenStudents = newStudents.names;

            context.Students.AddOrUpdate(
                new Student { FirstName = TenStudents[0].FirstName, LastName = TenStudents[0].LastName, Major = TenStudents[0].Major },
                new Student { FirstName = TenStudents[1].FirstName, LastName = TenStudents[1].LastName, Major = TenStudents[1].Major },
                new Student { FirstName = TenStudents[2].FirstName, LastName = TenStudents[2].LastName, Major = TenStudents[2].Major },
                new Student { FirstName = TenStudents[3].FirstName, LastName = TenStudents[3].LastName, Major = TenStudents[3].Major },
                new Student { FirstName = TenStudents[4].FirstName, LastName = TenStudents[4].LastName, Major = TenStudents[4].Major },
                new Student { FirstName = TenStudents[5].FirstName, LastName = TenStudents[5].LastName, Major = TenStudents[5].Major },
                new Student { FirstName = TenStudents[6].FirstName, LastName = TenStudents[6].LastName, Major = TenStudents[6].Major },
                new Student { FirstName = TenStudents[7].FirstName, LastName = TenStudents[7].LastName, Major = TenStudents[7].Major },
                new Student { FirstName = TenStudents[8].FirstName, LastName = TenStudents[8].LastName, Major = TenStudents[8].Major },
                new Student { FirstName = TenStudents[9].FirstName, LastName = TenStudents[9].LastName, Major = TenStudents[9].Major }
                );
        }
    }
}
