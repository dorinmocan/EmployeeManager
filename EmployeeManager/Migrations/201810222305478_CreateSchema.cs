namespace EmployeeManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSchema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FieldId = c.Int(nullable: false),
                        TitleId = c.Int(nullable: false),
                        YearsOfExperience = c.Byte(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Fields", t => t.FieldId, cascadeDelete: true)
                .ForeignKey("dbo.Titles", t => t.TitleId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.FieldId)
                .Index(t => t.TitleId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Fields",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Titles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Skills", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Skills", "TitleId", "dbo.Titles");
            DropForeignKey("dbo.Skills", "FieldId", "dbo.Fields");
            DropIndex("dbo.Skills", new[] { "EmployeeId" });
            DropIndex("dbo.Skills", new[] { "TitleId" });
            DropIndex("dbo.Skills", new[] { "FieldId" });
            DropTable("dbo.Titles");
            DropTable("dbo.Fields");
            DropTable("dbo.Skills");
            DropTable("dbo.Employees");
        }
    }
}
