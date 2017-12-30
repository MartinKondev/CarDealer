namespace TheCars.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeCarModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Engines", "FuelType_Id", "dbo.FuelTypes");
            DropForeignKey("dbo.Cars", "Engine_Id", "dbo.Engines");
            DropIndex("dbo.Cars", new[] { "Engine_Id" });
            DropIndex("dbo.Engines", new[] { "FuelType_Id" });
            AddColumn("dbo.Cars", "AutomaticGear", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cars", "Size", c => c.Double(nullable: false));
            AddColumn("dbo.Cars", "Is4x4", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cars", "FuelType_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Cars", "FuelType_Id");
            AddForeignKey("dbo.Cars", "FuelType_Id", "dbo.FuelTypes", "Id", cascadeDelete: true);
            DropColumn("dbo.Cars", "Engine_Id");
            DropColumn("dbo.Engines", "AutomaticGear");
            DropColumn("dbo.Engines", "Size");
            DropColumn("dbo.Engines", "Is4x4");
            DropColumn("dbo.Engines", "FuelType_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Engines", "FuelType_Id", c => c.Int(nullable: false));
            AddColumn("dbo.Engines", "Is4x4", c => c.Boolean(nullable: false));
            AddColumn("dbo.Engines", "Size", c => c.Double(nullable: false));
            AddColumn("dbo.Engines", "AutomaticGear", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cars", "Engine_Id", c => c.Guid());
            DropForeignKey("dbo.Cars", "FuelType_Id", "dbo.FuelTypes");
            DropIndex("dbo.Cars", new[] { "FuelType_Id" });
            DropColumn("dbo.Cars", "FuelType_Id");
            DropColumn("dbo.Cars", "Is4x4");
            DropColumn("dbo.Cars", "Size");
            DropColumn("dbo.Cars", "AutomaticGear");
            CreateIndex("dbo.Engines", "FuelType_Id");
            CreateIndex("dbo.Cars", "Engine_Id");
            AddForeignKey("dbo.Cars", "Engine_Id", "dbo.Engines", "Id");
            AddForeignKey("dbo.Engines", "FuelType_Id", "dbo.FuelTypes", "Id", cascadeDelete: true);
        }
    }
}
