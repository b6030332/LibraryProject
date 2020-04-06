namespace Library.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        Title = c.String(nullable: false),
                        Author = c.String(nullable: false),
                        Year = c.Int(nullable: false),
                        ISBN = c.Long(nullable: false),
                        DeweyClassification = c.String(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Status_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Status", t => t.Status_Id, cascadeDelete: true)
                .Index(t => t.Status_Id);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MembershipNoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fees = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DateAssigned = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Patrons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        TelephoneNumber = c.String(),
                        MembershipNo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MembershipNoes", t => t.MembershipNo_Id)
                .Index(t => t.MembershipNo_Id);
            
            CreateTable(
                "dbo.Reserves",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReservePlaced = c.DateTime(nullable: false),
                        Book_Id = c.Int(),
                        MembershipNo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.Book_Id)
                .ForeignKey("dbo.MembershipNoes", t => t.MembershipNo_Id)
                .Index(t => t.Book_Id)
                .Index(t => t.MembershipNo_Id);
            
            CreateTable(
                "dbo.Withdrawals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        From = c.DateTime(nullable: false),
                        Until = c.DateTime(nullable: false),
                        Book_Id = c.Int(nullable: false),
                        MembershipNo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.Book_Id, cascadeDelete: true)
                .ForeignKey("dbo.MembershipNoes", t => t.MembershipNo_Id)
                .Index(t => t.Book_Id)
                .Index(t => t.MembershipNo_Id);
            
            CreateTable(
                "dbo.WithdrawalHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Withdrawn = c.DateTime(nullable: false),
                        Returned = c.DateTime(),
                        Book_Id = c.Int(nullable: false),
                        MembershipNo_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.Book_Id, cascadeDelete: true)
                .ForeignKey("dbo.MembershipNoes", t => t.MembershipNo_Id, cascadeDelete: true)
                .Index(t => t.Book_Id)
                .Index(t => t.MembershipNo_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WithdrawalHistories", "MembershipNo_Id", "dbo.MembershipNoes");
            DropForeignKey("dbo.WithdrawalHistories", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.Withdrawals", "MembershipNo_Id", "dbo.MembershipNoes");
            DropForeignKey("dbo.Withdrawals", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.Reserves", "MembershipNo_Id", "dbo.MembershipNoes");
            DropForeignKey("dbo.Reserves", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.Patrons", "MembershipNo_Id", "dbo.MembershipNoes");
            DropForeignKey("dbo.Books", "Status_Id", "dbo.Status");
            DropIndex("dbo.WithdrawalHistories", new[] { "MembershipNo_Id" });
            DropIndex("dbo.WithdrawalHistories", new[] { "Book_Id" });
            DropIndex("dbo.Withdrawals", new[] { "MembershipNo_Id" });
            DropIndex("dbo.Withdrawals", new[] { "Book_Id" });
            DropIndex("dbo.Reserves", new[] { "MembershipNo_Id" });
            DropIndex("dbo.Reserves", new[] { "Book_Id" });
            DropIndex("dbo.Patrons", new[] { "MembershipNo_Id" });
            DropIndex("dbo.Books", new[] { "Status_Id" });
            DropTable("dbo.WithdrawalHistories");
            DropTable("dbo.Withdrawals");
            DropTable("dbo.Reserves");
            DropTable("dbo.Patrons");
            DropTable("dbo.MembershipNoes");
            DropTable("dbo.Status");
            DropTable("dbo.Books");
        }
    }
}
