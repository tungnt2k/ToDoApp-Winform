namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        ColorId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        Color_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Colors", t => t.Color_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Colors", t => t.ColorId)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.ColorId)
                .Index(t => t.UserId)
                .Index(t => t.Color_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Red = c.Int(nullable: false),
                        Green = c.Int(nullable: false),
                        Blue = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(maxLength: 50, unicode: false),
                        Password = c.String(unicode: false, storeType: "text"),
                        FullName = c.String(maxLength: 100),
                        Address = c.String(maxLength: 100),
                        BirthDay = c.DateTime(nullable: false),
                        Gender = c.Int(nullable: false),
                        Phone = c.String(maxLength: 50, unicode: false),
                        Email = c.String(maxLength: 50, unicode: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 100),
                        Content = c.String(storeType: "ntext"),
                        Status = c.Int(nullable: false),
                        EstimateTime = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        User_Id = c.Int(),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .ForeignKey("dbo.Users", t => t.UserId)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .Index(t => t.UserId)
                .Index(t => t.CategoryId)
                .Index(t => t.User_Id)
                .Index(t => t.Category_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "UserId", "dbo.Users");
            DropForeignKey("dbo.Tasks", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Categories", "ColorId", "dbo.Colors");
            DropForeignKey("dbo.Colors", "UserId", "dbo.Users");
            DropForeignKey("dbo.Tasks", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Tasks", "UserId", "dbo.Users");
            DropForeignKey("dbo.Tasks", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Colors", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Categories", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Categories", "Color_Id", "dbo.Colors");
            DropIndex("dbo.Tasks", new[] { "Category_Id" });
            DropIndex("dbo.Tasks", new[] { "User_Id" });
            DropIndex("dbo.Tasks", new[] { "CategoryId" });
            DropIndex("dbo.Tasks", new[] { "UserId" });
            DropIndex("dbo.Colors", new[] { "User_Id" });
            DropIndex("dbo.Colors", new[] { "UserId" });
            DropIndex("dbo.Categories", new[] { "User_Id" });
            DropIndex("dbo.Categories", new[] { "Color_Id" });
            DropIndex("dbo.Categories", new[] { "UserId" });
            DropIndex("dbo.Categories", new[] { "ColorId" });
            DropTable("dbo.Tasks");
            DropTable("dbo.Users");
            DropTable("dbo.Colors");
            DropTable("dbo.Categories");
        }
    }
}
