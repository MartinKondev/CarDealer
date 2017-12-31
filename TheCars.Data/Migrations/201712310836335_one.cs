namespace TheCars.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class one : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Caravans",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        HasCoffeMachine = c.Boolean(nullable: false),
                        Make = c.String(nullable: false, maxLength: 50),
                        Model = c.String(nullable: false, maxLength: 50),
                        YearManifactured = c.Int(nullable: false),
                        IsNew = c.Boolean(nullable: false),
                        Weight = c.Double(nullable: false),
                        Location_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.Location_Id, cascadeDelete: true)
                .Index(t => t.Location_Id);
            
            CreateTable(
                "dbo.VehicleExtras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Caravan_Id = c.Guid(),
                        Car_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Caravans", t => t.Caravan_Id)
                .ForeignKey("dbo.Cars", t => t.Car_Id)
                .Index(t => t.Caravan_Id)
                .Index(t => t.Car_Id);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SeatsCount = c.Int(nullable: false),
                        AutomaticGear = c.Boolean(nullable: false),
                        EngineSize = c.Double(nullable: false),
                        Is4x4 = c.Boolean(nullable: false),
                        Make = c.String(nullable: false, maxLength: 50),
                        Model = c.String(nullable: false, maxLength: 50),
                        YearManifactured = c.Int(nullable: false),
                        IsNew = c.Boolean(nullable: false),
                        Weight = c.Double(nullable: false),
                        FuelType_Id = c.Int(nullable: false),
                        Location_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FuelTypes", t => t.FuelType_Id, cascadeDelete: true)
                .ForeignKey("dbo.Locations", t => t.Location_Id, cascadeDelete: true)
                .Index(t => t.FuelType_Id)
                .Index(t => t.Location_Id);
            
            CreateTable(
                "dbo.FuelTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "Location_Id", "dbo.Locations");
            DropForeignKey("dbo.Cars", "FuelType_Id", "dbo.FuelTypes");
            DropForeignKey("dbo.VehicleExtras", "Car_Id", "dbo.Cars");
            DropForeignKey("dbo.Caravans", "Location_Id", "dbo.Locations");
            DropForeignKey("dbo.VehicleExtras", "Caravan_Id", "dbo.Caravans");
            DropIndex("dbo.Cars", new[] { "Location_Id" });
            DropIndex("dbo.Cars", new[] { "FuelType_Id" });
            DropIndex("dbo.VehicleExtras", new[] { "Car_Id" });
            DropIndex("dbo.VehicleExtras", new[] { "Caravan_Id" });
            DropIndex("dbo.Caravans", new[] { "Location_Id" });
            DropTable("dbo.FuelTypes");
            DropTable("dbo.Cars");
            DropTable("dbo.Locations");
            DropTable("dbo.VehicleExtras");
            DropTable("dbo.Caravans");
        }
    }
}
