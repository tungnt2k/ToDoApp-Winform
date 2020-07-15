namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addusersetting : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserSettings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: false),
                        Noti = c.Boolean(nullable: false),
                        StartWithWin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserSettings");
        }
    }
}
