namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class droptablelist : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Lists", "BoardId", "dbo.Boards");
            DropForeignKey("dbo.Cards", "ListId", "dbo.Lists");
            DropIndex("dbo.Lists", new[] { "BoardId" });
            DropIndex("dbo.Cards", new[] { "ListId" });
            AddColumn("dbo.Cards", "BoardId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cards", "BoardId");
            AddForeignKey("dbo.Cards", "BoardId", "dbo.Boards", "Id", cascadeDelete: true);
            DropColumn("dbo.Cards", "ListId");
            DropTable("dbo.Lists");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Lists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                        BoardId = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Cards", "ListId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Cards", "BoardId", "dbo.Boards");
            DropIndex("dbo.Cards", new[] { "BoardId" });
            DropColumn("dbo.Cards", "BoardId");
            CreateIndex("dbo.Cards", "ListId");
            CreateIndex("dbo.Lists", "BoardId");
            AddForeignKey("dbo.Cards", "ListId", "dbo.Lists", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Lists", "BoardId", "dbo.Boards", "Id", cascadeDelete: true);
        }
    }
}
