namespace TheCars.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class biiiigChangees : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Makes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Make_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Makes", t => t.Make_Id)
                .Index(t => t.Make_Id);
            
            AddColumn("dbo.Bicycles", "Make_Id", c => c.Guid(nullable: false));
            AddColumn("dbo.Bicycles", "Model_Id", c => c.Guid(nullable: false));
            AddColumn("dbo.Caravans", "Make_Id", c => c.Guid(nullable: false));
            AddColumn("dbo.Caravans", "Model_Id", c => c.Guid(nullable: false));
            AddColumn("dbo.Cars", "Make_Id", c => c.Guid(nullable: false));
            AddColumn("dbo.Cars", "Model_Id", c => c.Guid(nullable: false));
            AddColumn("dbo.Motorcycles", "Make_Id", c => c.Guid(nullable: false));
            AddColumn("dbo.Motorcycles", "Model_Id", c => c.Guid(nullable: false));
            CreateIndex("dbo.Bicycles", "Make_Id");
            CreateIndex("dbo.Bicycles", "Model_Id");
            CreateIndex("dbo.Caravans", "Make_Id");
            CreateIndex("dbo.Caravans", "Model_Id");
            CreateIndex("dbo.Cars", "Make_Id");
            CreateIndex("dbo.Cars", "Model_Id");
            CreateIndex("dbo.Motorcycles", "Make_Id");
            CreateIndex("dbo.Motorcycles", "Model_Id");
            AddForeignKey("dbo.Bicycles", "Make_Id", "dbo.Makes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Bicycles", "Model_Id", "dbo.Models", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Caravans", "Make_Id", "dbo.Makes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Caravans", "Model_Id", "dbo.Models", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Cars", "Make_Id", "dbo.Makes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Cars", "Model_Id", "dbo.Models", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Motorcycles", "Make_Id", "dbo.Makes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Motorcycles", "Model_Id", "dbo.Models", "Id", cascadeDelete: true);
            DropColumn("dbo.Bicycles", "Make");
            DropColumn("dbo.Bicycles", "Model");
            DropColumn("dbo.Caravans", "Make");
            DropColumn("dbo.Caravans", "Model");
            DropColumn("dbo.Cars", "Make");
            DropColumn("dbo.Cars", "Model");
            DropColumn("dbo.Motorcycles", "Make");
            DropColumn("dbo.Motorcycles", "Model");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Motorcycles", "Model", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Motorcycles", "Make", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Cars", "Model", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Cars", "Make", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Caravans", "Model", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Caravans", "Make", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Bicycles", "Model", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Bicycles", "Make", c => c.String(nullable: false, maxLength: 50));
            DropForeignKey("dbo.Motorcycles", "Model_Id", "dbo.Models");
            DropForeignKey("dbo.Motorcycles", "Make_Id", "dbo.Makes");
            DropForeignKey("dbo.Cars", "Model_Id", "dbo.Models");
            DropForeignKey("dbo.Cars", "Make_Id", "dbo.Makes");
            DropForeignKey("dbo.Caravans", "Model_Id", "dbo.Models");
            DropForeignKey("dbo.Caravans", "Make_Id", "dbo.Makes");
            DropForeignKey("dbo.Bicycles", "Model_Id", "dbo.Models");
            DropForeignKey("dbo.Models", "Make_Id", "dbo.Makes");
            DropForeignKey("dbo.Bicycles", "Make_Id", "dbo.Makes");
            DropIndex("dbo.Motorcycles", new[] { "Model_Id" });
            DropIndex("dbo.Motorcycles", new[] { "Make_Id" });
            DropIndex("dbo.Cars", new[] { "Model_Id" });
            DropIndex("dbo.Cars", new[] { "Make_Id" });
            DropIndex("dbo.Caravans", new[] { "Model_Id" });
            DropIndex("dbo.Caravans", new[] { "Make_Id" });
            DropIndex("dbo.Models", new[] { "Make_Id" });
            DropIndex("dbo.Bicycles", new[] { "Model_Id" });
            DropIndex("dbo.Bicycles", new[] { "Make_Id" });
            DropColumn("dbo.Motorcycles", "Model_Id");
            DropColumn("dbo.Motorcycles", "Make_Id");
            DropColumn("dbo.Cars", "Model_Id");
            DropColumn("dbo.Cars", "Make_Id");
            DropColumn("dbo.Caravans", "Model_Id");
            DropColumn("dbo.Caravans", "Make_Id");
            DropColumn("dbo.Bicycles", "Model_Id");
            DropColumn("dbo.Bicycles", "Make_Id");
            DropTable("dbo.Models");
            DropTable("dbo.Makes");
        }
    }
}
