namespace Webforms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intalise : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ProductModels", "catagoryId");
            RenameColumn(table: "dbo.ProductModels", name: "cataory_CategoryID", newName: "catagoryId");
            RenameIndex(table: "dbo.ProductModels", name: "IX_cataory_CategoryID", newName: "IX_catagoryId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.ProductModels", name: "IX_catagoryId", newName: "IX_cataory_CategoryID");
            RenameColumn(table: "dbo.ProductModels", name: "catagoryId", newName: "cataory_CategoryID");
            AddColumn("dbo.ProductModels", "catagoryId", c => c.Int());
        }
    }
}
