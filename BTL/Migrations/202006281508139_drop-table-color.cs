namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class droptablecolor : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Categories", "Color_Id", "dbo.Colors");
            DropForeignKey("dbo.Colors", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Colors", "UserId", "dbo.Users");
            DropForeignKey("dbo.Categories", "ColorId", "dbo.Colors");
            DropIndex("dbo.Categories", new[] { "ColorId" });
            DropIndex("dbo.Categories", new[] { "Color_Id" });
            DropIndex("dbo.Colors", new[] { "UserId" });
            DropIndex("dbo.Colors", new[] { "User_Id" });
            DropColumn("dbo.Categories", "ColorId");
            DropColumn("dbo.Categories", "Color_Id");
            DropTable("dbo.Colors");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Categories", "Color_Id", c => c.Int());
            AddColumn("dbo.Categories", "ColorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Colors", "User_Id");
            CreateIndex("dbo.Colors", "UserId");
            CreateIndex("dbo.Categories", "Color_Id");
            CreateIndex("dbo.Categories", "ColorId");
            AddForeignKey("dbo.Categories", "ColorId", "dbo.Colors", "Id");
            AddForeignKey("dbo.Colors", "UserId", "dbo.Users", "Id");
            AddForeignKey("dbo.Colors", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Categories", "Color_Id", "dbo.Colors", "Id");
        }
    }
}
