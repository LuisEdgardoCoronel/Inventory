using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities;

namespace Business
{
    public class B_Category
    {
        public static List<CategoryEntity> CategoryList()
        {
            using (var db = new InventaryContext())
            {
                return db.TCategories.ToList();
            }
        }


        public void CreateCategory(CategoryEntity oCategory)
        {
            using (var db = new InventaryContext())
            {
                db.TCategories.Add(oCategory);
                db.SaveChanges();
            }
        }

        public void UpdateCategory(CategoryEntity oCategory)
        {
            using(var db = new InventaryContext())
            {
                db.TCategories.Update(oCategory); 
                db.SaveChanges();
            }
        }
    }
}
