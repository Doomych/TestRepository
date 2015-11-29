using System.Data.Entity;

namespace WebGitAPI.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}