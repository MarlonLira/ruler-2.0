namespace Ruler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RulerContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 30),
                        RegistryCode = c.String(maxLength: 12),
                        Phone = c.String(maxLength: 12),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 30),
                        RegistryCode = c.String(maxLength: 12),
                        Brand = c.String(maxLength: 30),
                        Price = c.Single(nullable: false),
                        Label = c.String(maxLength: 255),
                        Lot = c.Int(nullable: false),
                        ManufactDate = c.DateTime(nullable: false),
                        ExpiryDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Product");
            DropTable("dbo.Client");
        }
    }
}
