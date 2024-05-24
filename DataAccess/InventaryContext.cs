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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //creando entidades
            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId="ASH", CategoryName="Aseo Hogar"},
                new CategoryEntity { CategoryId="ASP", CategoryName="Aseo Personal"},
                new CategoryEntity { CategoryId = "HGR", CategoryName="Hogar"},
                new CategoryEntity { CategoryId="PRF", CategoryName="Perfumeria"}
                );

            modelBuilder.Entity<WareHouseEntity>().HasData(
                new WareHouseEntity
                {
                    WareHouseId = Guid.NewGuid().ToString(),
                    WareHouseName = "Bodega Central",
                    WareHouseAddress = "Sarmiento 345"
                },
                new WareHouseEntity
                {
                    WareHouseId = Guid.NewGuid().ToString(),
                    WareHouseName = "Bodega Norte",
                    WareHouseAddress = "Av. Libertador 1345"
                },
                new WareHouseEntity
                {
                    WareHouseId = Guid.NewGuid().ToString(),
                    WareHouseName = "Bodega Sur",
                    WareHouseAddress = "24 de Septiembre y Ayacucho"
                }
                );
        }
    }
}
