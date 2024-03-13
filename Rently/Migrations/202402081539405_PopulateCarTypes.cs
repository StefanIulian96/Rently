namespace Rently.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCarTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CarTypes (Id, Type) VALUES (1, 'Coupe')");
            Sql("INSERT INTO CarTypes (Id, Type) VALUES (2, 'Gran Turismo')");
            Sql("INSERT INTO CarTypes (Id, Type) VALUES (3, 'Sedan')");
            Sql("INSERT INTO CarTypes (Id, Type) VALUES (4, 'Break')");
            Sql("INSERT INTO CarTypes (Id, Type) VALUES (5, 'Hatchback')");
        }
        
        public override void Down()
        {
        }
    }
}
