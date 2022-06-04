namespace Raya.Employee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addconfirmtoemployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.employee", "emp_cnfirmed", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.employee", "emp_cnfirmed");
        }
    }
}
