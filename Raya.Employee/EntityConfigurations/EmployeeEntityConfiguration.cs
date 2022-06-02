using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Raya.Employee.EntityConfigurations
{
    public class EmployeeEntityConfiguration: EntityTypeConfiguration<EntityModel.Employee>
    {
        public EmployeeEntityConfiguration()
        {
            this.ToTable("employee");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasColumnName("emp_id");
            this.Property(x=>x.Name).HasColumnName("emp_name");
            this.Property(x => x.CreatedBy).HasColumnName("emp_created_by");
            this.Property(x => x.ModifiedBy).HasColumnName("emp_modified_by");
            this.Property(x => x.BirthDate).HasColumnName("emp_birthdate");
            this.Property(x => x.CreatedDate).HasColumnName("emp_created_date");
            this.Property(x => x.ModifiedDate).HasColumnName("emp_modified_date");
            this.HasOptional(x => x.Department).WithMany(x => x.Employees).HasForeignKey(x => x.departmentId);
        }
    }
}