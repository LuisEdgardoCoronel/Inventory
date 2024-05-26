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
    public class B_Product
    {
        public static async Task<List<ProductEntity>> ProductList()
        {
            using (var db = new InventaryContext())
            {
                return await db.TProducts.ToListAsync();
            }
        }



        public static async Task CreateProduct(ProductEntity oProduct)
        {
            await using (var db = new InventaryContext())
            {
                db.TProducts.Add(oProduct);
                await db.SaveChangesAsync();
            }
        }


        public static async Task UpdateProduct(ProductEntity oProduct)
        {
            await using (var db = new InventaryContext())
            {
                db.TProducts.Update(oProduct);
                await db.SaveChangesAsync();
            }
        }
    }
}
