namespace Library.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class revertingbacktostatus : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Books", "Status_Id");
            RenameColumn(table: "dbo.Books", name: "Status_Id1", newName: "Status_Id");
            RenameIndex(table: "dbo.Books", name: "IX_Status_Id1", newName: "IX_Status_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Books", name: "IX_Status_Id", newName: "IX_Status_Id1");
            RenameColumn(table: "dbo.Books", name: "Status_Id", newName: "Status_Id1");
            AddColumn("dbo.Books", "Status_Id", c => c.Int());
        }
    }
}
