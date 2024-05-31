using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class B_Category
    {
        public static async Task<List<CategoryEntity>> CategoryList()
        {
            using (var db = new InventaryContext())
            {
                return await db.TCategories.ToListAsync();
            }
        }

        public static async Task<CategoryEntity> CategoryById(string id)
        {
            using (var db = new InventaryContext())
            {
                return await db.TCategories.Where(c=>c.CategoryId==id).FirstOrDefaultAsync();
            }
        }


        public static async Task CreateCategory(CategoryEntity oCategory)
        {
            await using (var db = new InventaryContext())
            {
                db.TCategories.Add(oCategory);
                await db.SaveChangesAsync();
            }
        }

        public static async Task UpdateCategory(CategoryEntity oCategory)
        {
            await using(var db = new InventaryContext())
            {
                db.TCategories.Update(oCategory);
                await db.SaveChangesAsync();
            }
        }
    }
}
