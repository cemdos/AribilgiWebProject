namespace AribilgiWebProject.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version19 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserInfo",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        InvoiceAddress = c.String(unicode: false),
                        ShippedAddress = c.String(unicode: false),
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
            DropTable("dbo.UserInfo");
        }
    }
}
