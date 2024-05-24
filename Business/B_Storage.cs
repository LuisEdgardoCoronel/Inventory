using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Storage
    {
        public List<StorageEntity> StorageList()
        {
            using (var db = new InventaryContext())
            {
                return db.TStorages.ToList();
            }
        }


        public void CreateStorages(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.TStorages.Add(oStorage);
                db.SaveChanges();
            }
        }


        public void UpdateStorages(StorageEntity oStorage)
        {
            using (var db =  new InventaryContext())
            {
                db.TStorages.Update(oStorage);
                db.SaveChanges();
            }
        }
    }
}
