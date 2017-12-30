namespace TheCars.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BasicCarsDbStructure : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SeatsCount = c.Int(nullable: false),
                        Make = c.String(nullable: false),
                        Model = c.String(nullable: false),
                        YearManifactured = c.Int(nullable: false),
                        IsNew = c.Boolean(nullable: false),
                        Weight = c.Double(nullable: false),
                        Engine_Id = c.Guid(),
                        Location_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Engines", t => t.Engine_Id)
                .ForeignKey("dbo.Locations", t => t.Location_Id, cascadeDelete: true)
                .Index(t => t.Engine_Id)
                .Index(t => t.Location_Id);
            
            CreateTable(
                "dbo.Engines",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        AutomaticGear = c.Boolean(nullable: false),
                        Size = c.Double(nullable: false),
                        Is4x4 = c.Boolean(nullable: false),
                        FuelType_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FuelTypes", t => t.FuelType_Id, cascadeDelete: true)
                .Index(t => t.FuelType_Id);
            
            CreateTable(
                "dbo.FuelTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VehicleExtras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Car_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.Car_Id)
                .Index(t => t.Car_Id);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "Location_Id", "dbo.Locations");
            DropForeignKey("dbo.VehicleExtras", "Car_Id", "dbo.Cars");
            DropForeignKey("dbo.Cars", "Engine_Id", "dbo.Engines");
            DropForeignKey("dbo.Engines", "FuelType_Id", "dbo.FuelTypes");
            DropIndex("dbo.VehicleExtras", new[] { "Car_Id" });
            DropIndex("dbo.Engines", new[] { "FuelType_Id" });
            DropIndex("dbo.Cars", new[] { "Location_Id" });
            DropIndex("dbo.Cars", new[] { "Engine_Id" });
            DropTable("dbo.Locations");
            DropTable("dbo.VehicleExtras");
            DropTable("dbo.FuelTypes");
            DropTable("dbo.Engines");
            DropTable("dbo.Cars");
        }
    }
}
