using LibraryData.Models;//to access to model folder
using Microsoft.EntityFrameworkCore;
using Store_Management.LibraryData.Models;

namespace LibraryData
{
    public class StoreManagementContext : DbContext
    {
        public StoreManagementContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Review> Reviews { get; set; }

        public DbSet<Product> Produts { get; set; }

        public StoreManagementContext(DbContextOptions<StoreManagementContext> options)
            : base(options)
        {
        }

        
    }
}
