namespace Raya.Employee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.department",
                c => new
                    {
                        dept_id = c.Int(nullable: false, identity: true),
                        dept_name = c.String(),
                    })
                .PrimaryKey(t => t.dept_id);
            
            CreateTable(
                "dbo.employee",
                c => new
                    {
                        emp_id = c.Int(nullable: false, identity: true),
                        emp_name = c.String(),
                        emp_birthdate = c.DateTime(),
                        emp_created_date = c.DateTime(),
                        emp_modified_date = c.DateTime(),
                        emp_created_by = c.Int(nullable: false),
                        emp_modified_by = c.Int(nullable: false),
                        departmentId = c.Int(),
                    })
                .PrimaryKey(t => t.emp_id)
                .ForeignKey("dbo.department", t => t.departmentId)
                .Index(t => t.departmentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.employee", "departmentId", "dbo.department");
            DropIndex("dbo.employee", new[] { "departmentId" });
            DropTable("dbo.employee");
            DropTable("dbo.department");
        }
    }
}
