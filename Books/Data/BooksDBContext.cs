using Books.Models;
using Microsoft.EntityFrameworkCore;

namespace Books.Data
{
    public class BooksDBContext : DbContext
    {
        public BooksDBContext(DbContextOptions<BooksDBContext> options): base(options)
        {
        }

        public DbSet<BookModel> Books { get; set; }
        public DbSet<User> user { get; set; }

    }
}