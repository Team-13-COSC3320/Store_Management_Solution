using LibraryData.Models;//to access to model folder
using Microsoft.EntityFrameworkCore;

namespace LibraryData
{
    public class StoreManagementContext : DbContext
    {
        public StoreManagementContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
