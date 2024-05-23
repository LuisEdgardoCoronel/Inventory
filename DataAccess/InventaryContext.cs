using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class InventaryContext:DbContext
    {
        public DbSet<ProductEntity> TProducts { get; set; }
        public DbSet<CategoryEntity> TCategories { get; set; }
        public DbSet<StorageEntity> TStorages { get; set; }
        public DbSet<InputOutputEntity> TInputs { get; set; }
        public DbSet<WareHouseEntity> TWareHouse { get; set; }
    }
}
