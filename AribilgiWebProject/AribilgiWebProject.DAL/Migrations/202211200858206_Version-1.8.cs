namespace AribilgiWebProject.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version18 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderDetail", "OrderId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrderDetail", "OrderId");
        }
    }
}
