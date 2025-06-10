using Microsoft.EntityFrameworkCore;
using MinhaPrimeiraAPI.Models;

namespace MinhaPrimeiraAPI.Data
{
    public class PrimeiraAPIContext: DbContext
    {
        public PrimeiraAPIContext(DbContextOptions<PrimeiraAPIContext> options): base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
            new Book
            {
                Id = 1,
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                YearPublished = 1925
            },
            new Book
            {
                Id = 2,
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                YearPublished = 1925
            }
                );
        }
        public DbSet<Book> Books { get; set; }
    }
}
