namespace Library.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingstatus_id : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "Status_Id", "dbo.Status");
            DropIndex("dbo.Books", new[] { "Status_Id" });
            AddColumn("dbo.Books", "Status_Id1", c => c.Int());
            CreateIndex("dbo.Books", "Status_Id1");
            AddForeignKey("dbo.Books", "Status_Id1", "dbo.Status", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Status_Id1", "dbo.Status");
            DropIndex("dbo.Books", new[] { "Status_Id1" });
            DropColumn("dbo.Books", "Status_Id1");
            CreateIndex("dbo.Books", "Status_Id");
            AddForeignKey("dbo.Books", "Status_Id", "dbo.Status", "Id");
        }
    }
}
