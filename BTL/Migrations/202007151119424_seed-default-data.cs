namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seeddefaultdata : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO UserSettings values(1,0,0)");
        }
        
        public override void Down()
        {
            Sql("DELETE from UserSettings where Id = 1");
        }
    }
}
