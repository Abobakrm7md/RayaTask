using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Raya.Employee.EntityConfigurations;
using Raya.Employee.EntityModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Raya.Employee
{
    public class EmployeeContext : IdentityDbContext<ApplicationUser>
    {
        // Your context has been configured to use a 'EmployeeContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Raya.Employee.EmployeeContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'EmployeeContext' 
        // connection string in the application configuration file.
        public EmployeeContext()
            : base("RayaTask")
        {
        }

        public static EmployeeContext Create()
        {
            return new EmployeeContext();
        }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new EmployeeEntityConfiguration());
            modelBuilder.Configurations.Add(new DepartmentEntityConfiguration());


        }

        public virtual DbSet<EntityModel.Employee>  Employees { get; set; }
        public virtual DbSet<Department>  Departments { get; set; }

    }


}