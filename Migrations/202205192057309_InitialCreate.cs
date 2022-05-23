namespace xnes_hw.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "HebrewName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Customers", "EnglishName", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Customers", "Bank", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Bank", c => c.String());
            AlterColumn("dbo.Customers", "EnglishName", c => c.String());
            AlterColumn("dbo.Customers", "HebrewName", c => c.String());
        }
    }
}
