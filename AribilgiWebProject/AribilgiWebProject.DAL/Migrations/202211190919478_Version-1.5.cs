namespace AribilgiWebProject.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version15 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.City",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CityName = c.String(unicode: false),
                        Deleted = c.Boolean(nullable: false),
                        DelUser = c.Int(),
                        DelDate = c.DateTime(),
                        CreUser = c.Int(),
                        CreDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.District",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DistrictName = c.String(unicode: false),
                        CityId = c.Int(nullable: false),
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
            DropTable("dbo.District");
            DropTable("dbo.City");
        }
    }
}
