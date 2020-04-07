namespace Library.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class includedextrabookcolumns : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "Status_Id", "dbo.Status");
            DropIndex("dbo.Books", new[] { "Status_Id" });
            AddColumn("dbo.Books", "Publisher", c => c.String(nullable: false));
            AddColumn("dbo.Books", "Format", c => c.String());
            AddColumn("dbo.Books", "Price", c => c.Double(nullable: false));
            AddColumn("dbo.Books", "Blurb", c => c.String());
            AlterColumn("dbo.Books", "Status_Id", c => c.Int());
            AlterColumn("dbo.MembershipNoes", "Fees", c => c.Double(nullable: false));
            CreateIndex("dbo.Books", "Status_Id");
            AddForeignKey("dbo.Books", "Status_Id", "dbo.Status", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Status_Id", "dbo.Status");
            DropIndex("dbo.Books", new[] { "Status_Id" });
            AlterColumn("dbo.MembershipNoes", "Fees", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Books", "Status_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Books", "Blurb");
            DropColumn("dbo.Books", "Price");
            DropColumn("dbo.Books", "Format");
            DropColumn("dbo.Books", "Publisher");
            CreateIndex("dbo.Books", "Status_Id");
            AddForeignKey("dbo.Books", "Status_Id", "dbo.Status", "Id", cascadeDelete: true);
        }
    }
}
