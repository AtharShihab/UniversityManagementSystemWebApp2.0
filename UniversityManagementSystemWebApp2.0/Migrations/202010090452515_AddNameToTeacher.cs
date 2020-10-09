namespace UniversityManagementSystemWebApp2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToTeacher : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "Name");
        }
    }
}
