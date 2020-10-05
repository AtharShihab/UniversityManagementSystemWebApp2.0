namespace UniversityManagementSystemWebApp2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSemester : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Semesters (Id, Name) VALUES(1, '1st semester')");
            Sql("INSERT INTO Semesters (Id, Name) VALUES(2, '2nd semester')");
            Sql("INSERT INTO Semesters (Id, Name) VALUES(3, '3rd semester')");
            Sql("INSERT INTO Semesters (Id, Name) VALUES(4, '4th semester')");
            Sql("INSERT INTO Semesters (Id, Name) VALUES(5, '5th semester')");
            Sql("INSERT INTO Semesters (Id, Name) VALUES(6, '6th semester')");
            Sql("INSERT INTO Semesters (Id, Name) VALUES(7, '7th semester')");
            Sql("INSERT INTO Semesters (Id, Name) VALUES(8, '8th semester')");
        }
        
        public override void Down()
        {
        }
    }
}
