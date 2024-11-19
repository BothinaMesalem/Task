using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class BookContext:DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options) { }

        public DbSet<Book> bookContext { get; set; }

    }
}
