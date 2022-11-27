namespace AribilgiWebProject.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version16 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(unicode: false),
                        CustomerSurname = c.String(unicode: false),
                        DistrictId = c.Int(),
                        ShippedPrice = c.Double(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        DelUser = c.Int(),
                        DelDate = c.DateTime(),
                        CreUser = c.Int(),
                        CreDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OrderDetail",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        DelUser = c.Int(),
                        DelDate = c.DateTime(),
                        CreUser = c.Int(),
                        CreDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OrderDetail");
            DropTable("dbo.Order");
        }
    }
}
