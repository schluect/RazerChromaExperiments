namespace ClassLibrary1
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Colors", "QueueDateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Colors", "QueueDateTime", c => c.DateTime(nullable: false));
        }
    }
}
