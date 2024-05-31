using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Storage
    {
        public static async Task<List<StorageEntity>> StorageList()
        {
            await using (var db = new InventaryContext())
            {
                return await db.TStorages.ToListAsync();
            }
        }

        public static async Task<Boolean> IsProductInWareHouse(string id)
        {
            await using (var db = new InventaryContext())
            {
                var productExists = await db.TStorages
                    .AnyAsync(s => s.StorageId == id);

                return productExists;
            }
        }

        public static async Task<List<StorageEntity>> StorageProductsByWareHouse(string idWareHouse)
        {
            await using (var db = new InventaryContext())
            {
                return await db.TStorages
                    .Include(s => s.Product)
                    .Include(s => s.WareHouse)
                    .Where(s => s.WareHouseId == idWareHouse)
                    .ToListAsync();
            }
        }


        public static async Task CreateStorages(StorageEntity oStorage)
        {
            await using (var db = new InventaryContext())
            {
                db.TStorages.Add(oStorage);
                await db.SaveChangesAsync();
            }
        }


        public static async Task UpdateStorages(StorageEntity oStorage)
        {
            await using (var db =  new InventaryContext())
            {
                db.TStorages.Update(oStorage);
                await db.SaveChangesAsync();
            }
        }
    }
}
