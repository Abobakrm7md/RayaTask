namespace Raya.Employee.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Raya.Employee.EntityModel;
    using Raya.Employee.Repository;
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
            SaveUser();
            SaveDepartment();
            SaveEmployee();
        }
        private void SaveUser()
        {

            var user = new ApplicationUser()
            {
                Email = "test@test.com",
                PhoneNumber = "032145697",
                FirstName = "test1",
                LastName = "test2",
                UserName = "test",
                IsAdmin = true
            };
            PasswordHasher hasher = new PasswordHasher();
            user.PasswordHash = hasher.HashPassword("taskTest");
            RepositoryBase<ApplicationUser>.Add(user);

        }
        private void SaveDepartment()
        {
            var departments = new List<Department>() {
                new Department { Name = "DEvelopment" }
               ,new Department { Name = "Sales" } };
            RepositoryBase<Department>.AddRange(departments);
        }
        private void SaveEmployee()
        {
           var user = RepositoryBase<EntityModel.ApplicationUser>.Get().FirstOrDefault();
            var dept = RepositoryBase<EntityModel.Department>.Get().FirstOrDefault();
            var emp = new EntityModel.Employee()
            {
                Name = "emp1",
                Address = "cairo",
                Phone = "036975421",
                BirthDate = DateTime.Now,
                HireDate = DateTime.Now,
                departmentId = dept.Id,
                CreatedBy = user.Id,
                CreatedDate = DateTime.Now,
                ModifiedBy = user.Id,
                ModifiedDate = DateTime.Now,
            };
            RepositoryBase<EntityModel.Employee>.Add(emp);
        }

    }
}
