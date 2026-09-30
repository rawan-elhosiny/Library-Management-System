using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    public class AppDbContext : DbContext   
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Borrowing> Borrowings { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=.;Database=Library_Db;Trusted_Connection=True;TrustServerCertificate=True;");
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Borrowing>()
            .HasOne(b => b.Customer)       
            .WithMany(c => c.Borrowings)          
            .HasForeignKey(b => b.NationalId);

            modelBuilder.Entity<Borrowing>()
            .HasOne(b => b.Book)          
            .WithMany(bk => bk.Borrowings)     
            .HasForeignKey(b => b.BookId);
        }
        
    }
}
