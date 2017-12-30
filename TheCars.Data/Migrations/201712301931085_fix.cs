namespace TheCars.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Cars", newName: "Vehicles");
            RenameTable(name: "dbo.VehicleExtraCars", newName: "VehicleVehicleExtras");
            RenameColumn(table: "dbo.VehicleVehicleExtras", name: "Car_Id", newName: "Vehicle_Id");
            RenameIndex(table: "dbo.VehicleVehicleExtras", name: "IX_Car_Id", newName: "IX_Vehicle_Id");
            DropPrimaryKey("dbo.VehicleVehicleExtras");
            AlterColumn("dbo.Vehicles", "SeatsCount", c => c.Int());
            AlterColumn("dbo.Vehicles", "AutomaticGear", c => c.Boolean());
            AlterColumn("dbo.Vehicles", "Size", c => c.Double());
            AlterColumn("dbo.Vehicles", "Is4x4", c => c.Boolean());
            AddPrimaryKey("dbo.VehicleVehicleExtras", new[] { "Vehicle_Id", "VehicleExtra_Id" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.VehicleVehicleExtras");
            AlterColumn("dbo.Vehicles", "Is4x4", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Vehicles", "Size", c => c.Double(nullable: false));
            AlterColumn("dbo.Vehicles", "AutomaticGear", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Vehicles", "SeatsCount", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.VehicleVehicleExtras", new[] { "VehicleExtra_Id", "Car_Id" });
            RenameIndex(table: "dbo.VehicleVehicleExtras", name: "IX_Vehicle_Id", newName: "IX_Car_Id");
            RenameColumn(table: "dbo.VehicleVehicleExtras", name: "Vehicle_Id", newName: "Car_Id");
            RenameTable(name: "dbo.VehicleVehicleExtras", newName: "VehicleExtraCars");
            RenameTable(name: "dbo.Vehicles", newName: "Cars");
        }
    }
}
