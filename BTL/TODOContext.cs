using BTL.Models;
using Microsoft.EntityFrameworkCore;

namespace BTL
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TODOContext : DbContext
    {
        // Your context has been configured to use a 'DBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BTL.DBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DBContext' 
        // connection string in the application configuration file.
        public TODOContext()
            : base("Data Source=LAPTOP-DOAK3RIE;Initial Catalog=TODOAPP;Integrated Security=True")
        {
        }

        public DbSet<Board> Boards { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}