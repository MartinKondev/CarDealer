namespace TheCars.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addManyToMany : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.VehicleExtras", "Car_Id", "dbo.Cars");
            DropIndex("dbo.VehicleExtras", new[] { "Car_Id" });
            CreateTable(
                "dbo.VehicleExtraCars",
                c => new
                    {
                        VehicleExtra_Id = c.Int(nullable: false),
                        Car_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.VehicleExtra_Id, t.Car_Id })
                .ForeignKey("dbo.VehicleExtras", t => t.VehicleExtra_Id, cascadeDelete: true)
                .ForeignKey("dbo.Cars", t => t.Car_Id, cascadeDelete: true)
                .Index(t => t.VehicleExtra_Id)
                .Index(t => t.Car_Id);
            
            DropColumn("dbo.VehicleExtras", "Car_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VehicleExtras", "Car_Id", c => c.Guid());
            DropForeignKey("dbo.VehicleExtraCars", "Car_Id", "dbo.Cars");
            DropForeignKey("dbo.VehicleExtraCars", "VehicleExtra_Id", "dbo.VehicleExtras");
            DropIndex("dbo.VehicleExtraCars", new[] { "Car_Id" });
            DropIndex("dbo.VehicleExtraCars", new[] { "VehicleExtra_Id" });
            DropTable("dbo.VehicleExtraCars");
            CreateIndex("dbo.VehicleExtras", "Car_Id");
            AddForeignKey("dbo.VehicleExtras", "Car_Id", "dbo.Cars", "Id");
        }
    }
}
