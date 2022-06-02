using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Raya.Employee.EntityConfigurations
{
    public class DepartmentEntityConfiguration : EntityTypeConfiguration<EntityModel.Department>
    {
        public DepartmentEntityConfiguration()
        {
            this.ToTable("department");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasColumnName("dept_id");
            this.Property(x=>x.Name).HasColumnName("dept_name");
        }
    }
}