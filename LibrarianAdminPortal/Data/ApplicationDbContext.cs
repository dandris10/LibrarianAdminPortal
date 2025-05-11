using LibrarianAdminPortal.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibrarianAdminPortal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<LendBook> LendedBooks { get; set; }


    }
}
