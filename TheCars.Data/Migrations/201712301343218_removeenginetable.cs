namespace TheCars.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeenginetable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Engines");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Engines",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
