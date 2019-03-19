namespace CodeFirstSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCoursesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        CourseName = c.String(),
                        Credits = c.Int(),
                    })
                .PrimaryKey(t => t.CourseId);
            
            AddColumn("dbo.Students", "Average", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Average");
            DropTable("dbo.Courses");
        }
    }
}
