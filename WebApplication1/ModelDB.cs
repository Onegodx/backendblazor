namespace WebApplication1
{
    using Microsoft.EntityFrameworkCore;
    using WebApplication1.Models;

    public class ModelDB : DbContext
    {
        public ModelDB(DbContextOptions<ModelDB> options) : base(options) { }

        public DbSet<Property> Properties { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Realtor> Realtors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
