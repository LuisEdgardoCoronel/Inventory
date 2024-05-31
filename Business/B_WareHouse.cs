using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class B_WareHouse
    {
        public static async Task<List<WareHouseEntity>> WareHousesList()
        {
            await using(var db = new InventaryContext())
            {
                return await db.TWareHouse.ToListAsync();
            }
        }


        public static async Task<WareHouseEntity> WareHousesById(string Id)
        {
            await using (var db = new InventaryContext())
            {
                return await db.TWareHouse.Where(w=>w.WareHouseId==Id).FirstOrDefaultAsync();
            }
        }


        public static async Task CreateWareHouse(WareHouseEntity oWareHouse)
        {
            await using(var db = new InventaryContext())
            {
                db.TWareHouse.Add(oWareHouse);
                await db.SaveChangesAsync();
            }
        }


        public static async Task UpdateWareHouse(WareHouseEntity oWareHouse)
        {
            using (var db = new InventaryContext())
            {
                db.TWareHouse.Update(oWareHouse);
                await db.SaveChangesAsync();
            }
        }
    }
}
