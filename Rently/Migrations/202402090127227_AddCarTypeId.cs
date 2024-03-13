namespace Rently.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCarTypeId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cars", "CarType_Id", "dbo.CarTypes");
            DropIndex("dbo.Cars", new[] { "CarType_Id" });
            RenameColumn(table: "dbo.Cars", name: "CarType_Id", newName: "CarTypeId");
            AlterColumn("dbo.Cars", "CarTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Cars", "CarTypeId");
            AddForeignKey("dbo.Cars", "CarTypeId", "dbo.CarTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "CarTypeId", "dbo.CarTypes");
            DropIndex("dbo.Cars", new[] { "CarTypeId" });
            AlterColumn("dbo.Cars", "CarTypeId", c => c.Byte());
            RenameColumn(table: "dbo.Cars", name: "CarTypeId", newName: "CarType_Id");
            CreateIndex("dbo.Cars", "CarType_Id");
            AddForeignKey("dbo.Cars", "CarType_Id", "dbo.CarTypes", "Id");
        }
    }
}
