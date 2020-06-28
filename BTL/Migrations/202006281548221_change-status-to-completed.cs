namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changestatustocompleted : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "Completed", c => c.Boolean(nullable: false));
            DropColumn("dbo.Tasks", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tasks", "Status", c => c.Int(nullable: false));
            DropColumn("dbo.Tasks", "Completed");
        }
    }
}
