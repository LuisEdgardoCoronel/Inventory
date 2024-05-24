using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess;

namespace Business
{
    public class B_Product
    {
        public List<ProductEntity> ProductList()
        {
            using (var db = new InventaryContext())
            {
                return db.TProducts.ToList();
            }
        }



        public void CreateProduct(ProductEntity oProduct)
        {
            using (var db = new InventaryContext())
            {
                db.TProducts.Add(oProduct);
                db.SaveChanges();
            }
        }


        public void UpdateProduct(ProductEntity oProduct)
        {
            using (var db = new InventaryContext())
            {
                db.TProducts.Update(oProduct);
                db.SaveChanges();
            }
        }
    }
}
