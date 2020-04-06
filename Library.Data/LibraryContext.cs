namespace Library.Data
{
    using Library.Data.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class LibraryContext : DbContext
    {
        // Your context has been configured to use a 'LibraryContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Library.Data.LibraryContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'LibraryContext' 
        // connection string in the application configuration file.
        public LibraryContext()
            : base("name=LibraryContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public DbSet<Book> Book { get; set; }
        public DbSet<Patron> Patron { get; set; }
        public DbSet<MembershipNo> MembershipNo { get; set; }
        public DbSet<Reserve> Reserve { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Withdrawal> Withdrawal { get; set; }
        public DbSet<WithdrawalHistory> WithdrawalHistory { get; set; }
    }


}

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
