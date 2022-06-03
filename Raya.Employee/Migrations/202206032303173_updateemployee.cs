namespace Raya.Employee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateemployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.employee", "emp_address", c => c.String());
            AddColumn("dbo.employee", "emp_phone", c => c.String());
            AddColumn("dbo.employee", "emp_hire_date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.employee", "emp_hire_date");
            DropColumn("dbo.employee", "emp_phone");
            DropColumn("dbo.employee", "emp_address");
        }
    }
}
