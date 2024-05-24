using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess;

namespace Business
{
    public class B_WareHouse
    {
        public List<WareHouseEntity> WareHousesList()
        {
            using(var db = new InventaryContext())
            {
                return db.TWareHouse.ToList();
            }
        }


        public void CreateWareHouse(WareHouseEntity oWareHouse)
        {
            using(var db = new InventaryContext())
            {
                db.TWareHouse.Add(oWareHouse);
                db.SaveChanges();
            }
        }


        public void UpdateWareHouse(WareHouseEntity oWareHouse)
        {
            using (var db = new InventaryContext())
            {
                db.TWareHouse.Update(oWareHouse);
                db.SaveChanges();
            }
        }
    }
}
