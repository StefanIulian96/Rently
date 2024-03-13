namespace Rently.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLoyaltyProgramSubscription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "LoyaltyProgramSubscription", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "LoyaltyProgramSubscription");
        }
    }
}
