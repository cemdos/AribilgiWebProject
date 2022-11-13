namespace AribilgiWebProject.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version14 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Coupons",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CouponCode = c.String(unicode: false),
                        DiscountPercent = c.Byte(nullable: false),
                        AvailableCount = c.Int(nullable: false),
                        UsedCount = c.Int(nullable: false),
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
            DropTable("dbo.Coupons");
        }
    }
}
