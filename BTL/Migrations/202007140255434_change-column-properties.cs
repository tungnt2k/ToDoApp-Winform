namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changecolumnproperties : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Boards", "Name", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Boards", "Name", c => c.String());
        }
    }
}
