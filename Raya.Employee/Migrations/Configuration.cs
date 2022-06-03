namespace Raya.Employee.Migrations
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Raya.Employee.EntityModel;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Raya.Employee.EmployeeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Raya.Employee.EmployeeContext context)
        {
            var departments = new List<Department>() {
                new Department { Name = "DEvelopment" }
               ,new Department { Name = "Sales" } };
            context.Departments.AddRange(departments);
            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
