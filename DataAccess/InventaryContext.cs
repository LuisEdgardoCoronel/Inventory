using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class InventaryContext : DbContext
    {
        public DbSet<ProductEntity> TProducts { get; set; }
        public DbSet<CategoryEntity> TCategories { get; set; }
        public DbSet<StorageEntity> TStorages { get; set; }
        public DbSet<InputOutputEntity> TInputs { get; set; }
        public DbSet<WareHouseEntity> TWareHouse { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=MI-PC\\SQLEXPRESS; Initial Catalog=InventoryDb; user id= '';password='';TrustServerCertificate=True;Integrated Security=True");
            }
        }
    }
}
