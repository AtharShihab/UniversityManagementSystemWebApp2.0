namespace UniversityManagementSystemWebApp2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDesignation : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Designations(Name) VALUES('Lecturer')");
            Sql("INSERT INTO Designations(Name) VALUES('Assistant Professor')");
            Sql("INSERT INTO Designations(Name) VALUES('Associate Professor')");
            Sql("INSERT INTO Designations(Name) VALUES('Professor')");
            Sql("INSERT INTO Designations(Name) VALUES('Professor Emeritus')");
        }
        
        public override void Down()
        {
        }
    }
}
