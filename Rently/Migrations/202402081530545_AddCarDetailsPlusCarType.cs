namespace Rently.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCarDetailsPlusCarType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                        NumberInStock = c.Byte(nullable: false),
                        CarType_Id = c.Byte(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CarTypes", t => t.CarType_Id)
                .Index(t => t.CarType_Id);
            
            CreateTable(
                "dbo.CarTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Type = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "CarType_Id", "dbo.CarTypes");
            DropIndex("dbo.Cars", new[] { "CarType_Id" });
            DropTable("dbo.CarTypes");
            DropTable("dbo.Cars");
        }
    }
}
