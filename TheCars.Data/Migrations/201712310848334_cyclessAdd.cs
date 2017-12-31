namespace TheCars.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cyclessAdd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bicycles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        IsShoseika = c.Boolean(nullable: false),
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
                "dbo.Motorcycles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        IsHarlyDavidson = c.Boolean(nullable: false),
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
            
            AddColumn("dbo.VehicleExtras", "Bicycle_Id", c => c.Guid());
            AddColumn("dbo.VehicleExtras", "Motorcycle_Id", c => c.Guid());
            CreateIndex("dbo.VehicleExtras", "Bicycle_Id");
            CreateIndex("dbo.VehicleExtras", "Motorcycle_Id");
            AddForeignKey("dbo.VehicleExtras", "Bicycle_Id", "dbo.Bicycles", "Id");
            AddForeignKey("dbo.VehicleExtras", "Motorcycle_Id", "dbo.Motorcycles", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Motorcycles", "Location_Id", "dbo.Locations");
            DropForeignKey("dbo.VehicleExtras", "Motorcycle_Id", "dbo.Motorcycles");
            DropForeignKey("dbo.Bicycles", "Location_Id", "dbo.Locations");
            DropForeignKey("dbo.VehicleExtras", "Bicycle_Id", "dbo.Bicycles");
            DropIndex("dbo.Motorcycles", new[] { "Location_Id" });
            DropIndex("dbo.VehicleExtras", new[] { "Motorcycle_Id" });
            DropIndex("dbo.VehicleExtras", new[] { "Bicycle_Id" });
            DropIndex("dbo.Bicycles", new[] { "Location_Id" });
            DropColumn("dbo.VehicleExtras", "Motorcycle_Id");
            DropColumn("dbo.VehicleExtras", "Bicycle_Id");
            DropTable("dbo.Motorcycles");
            DropTable("dbo.Bicycles");
        }
    }
}
