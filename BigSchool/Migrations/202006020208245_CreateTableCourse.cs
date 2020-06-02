namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableCourse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LecturerId = c.String(),
                        Place = c.String(),
                        Datetime = c.DateTime(nullable: false),
                        CategoryID = c.Byte(nullable: false),
                        Leturer_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.Leturer_Id)
                .Index(t => t.CategoryID)
                .Index(t => t.Leturer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Leturer_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Courses", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "Leturer_Id" });
            DropIndex("dbo.Courses", new[] { "CategoryID" });
            DropTable("dbo.Courses");
            DropTable("dbo.Categories");
        }
    }
}
