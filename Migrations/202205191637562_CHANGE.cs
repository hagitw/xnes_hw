namespace xnes_hw.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CHANGE : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HebrewName = c.String(),
                        EnglishName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                        Bank = c.String(),
                        BankBranch = c.String(),
                        BankAccount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "CityId", "dbo.Cities");
            DropIndex("dbo.Customers", new[] { "CityId" });
            DropTable("dbo.Customers");
            DropTable("dbo.Cities");
        }
    }
}
