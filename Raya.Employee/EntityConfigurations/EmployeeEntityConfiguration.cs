using System.Data.Entity.ModelConfiguration;

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
            this.Property(x => x.Address).HasColumnName("emp_address");
            this.Property(x => x.Phone).HasColumnName("emp_phone");
            this.Property(x => x.HireDate).HasColumnName("emp_hire_date");
            this.Property(x => x.Confirmed).HasColumnName("emp_cnfirmed");
            this.HasOptional(x => x.Department).WithMany(x => x.Employees).HasForeignKey(x => x.departmentId).WillCascadeOnDelete();
            this.HasOptional(x => x.User).WithMany().HasForeignKey(x => x.CreatedBy).WillCascadeOnDelete();
            this.HasOptional(x => x.User).WithMany().HasForeignKey(x => x.ModifiedBy);


        }
    }
}