namespace UniversityManagementSystemWebApp2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedDepartmentIdFromByteToInt : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Departments");
            AlterColumn("dbo.Departments", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Departments", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Departments");
            AlterColumn("dbo.Departments", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Departments", "Id");
        }
    }
}
