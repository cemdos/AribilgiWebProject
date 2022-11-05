namespace AribilgiWebProject.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version13 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Category", "Deleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Category", "DelUser", c => c.Int());
            AddColumn("dbo.Category", "DelDate", c => c.DateTime());
            AddColumn("dbo.Category", "CreUser", c => c.Int());
            AddColumn("dbo.Category", "CreDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Product", "Deleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Product", "DelUser", c => c.Int());
            AddColumn("dbo.Product", "DelDate", c => c.DateTime());
            AddColumn("dbo.Product", "CreUser", c => c.Int());
            AddColumn("dbo.Product", "CreDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Image", "Deleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Image", "DelUser", c => c.Int());
            AddColumn("dbo.Image", "DelDate", c => c.DateTime());
            AddColumn("dbo.Image", "CreUser", c => c.Int());
            AddColumn("dbo.Image", "CreDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Tag", "Deleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tag", "DelUser", c => c.Int());
            AddColumn("dbo.Tag", "DelDate", c => c.DateTime());
            AddColumn("dbo.Tag", "CreUser", c => c.Int());
            AddColumn("dbo.Tag", "CreDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.User", "Deleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.User", "DelUser", c => c.Int());
            AddColumn("dbo.User", "DelDate", c => c.DateTime());
            AddColumn("dbo.User", "CreUser", c => c.Int());
            AddColumn("dbo.User", "CreDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "CreDate");
            DropColumn("dbo.User", "CreUser");
            DropColumn("dbo.User", "DelDate");
            DropColumn("dbo.User", "DelUser");
            DropColumn("dbo.User", "Deleted");
            DropColumn("dbo.Tag", "CreDate");
            DropColumn("dbo.Tag", "CreUser");
            DropColumn("dbo.Tag", "DelDate");
            DropColumn("dbo.Tag", "DelUser");
            DropColumn("dbo.Tag", "Deleted");
            DropColumn("dbo.Image", "CreDate");
            DropColumn("dbo.Image", "CreUser");
            DropColumn("dbo.Image", "DelDate");
            DropColumn("dbo.Image", "DelUser");
            DropColumn("dbo.Image", "Deleted");
            DropColumn("dbo.Product", "CreDate");
            DropColumn("dbo.Product", "CreUser");
            DropColumn("dbo.Product", "DelDate");
            DropColumn("dbo.Product", "DelUser");
            DropColumn("dbo.Product", "Deleted");
            DropColumn("dbo.Category", "CreDate");
            DropColumn("dbo.Category", "CreUser");
            DropColumn("dbo.Category", "DelDate");
            DropColumn("dbo.Category", "DelUser");
            DropColumn("dbo.Category", "Deleted");
        }
    }
}
