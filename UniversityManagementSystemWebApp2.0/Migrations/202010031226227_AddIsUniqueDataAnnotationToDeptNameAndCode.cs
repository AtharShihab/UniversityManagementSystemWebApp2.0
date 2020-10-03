namespace UniversityManagementSystemWebApp2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsUniqueDataAnnotationToDeptNameAndCode : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Departments", "Name", unique: true);
            CreateIndex("dbo.Departments", "Code", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Departments", new[] { "Code" });
            DropIndex("dbo.Departments", new[] { "Name" });
        }
    }
}
