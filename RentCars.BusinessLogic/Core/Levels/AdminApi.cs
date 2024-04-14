using RentCars.BusinessLogic.DBModel.Seed;
using RentCars.Domain.Entities.Product;
using RentCars.Domain.Entities.Product.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCars.BusinessLogic.Core.Levels
{
    public class AdminAPI
    {

        public AdminAPI() 
        {
        }


        public void CreateNewProduct(CarProductData NewProduct)
        {

                var newProduct = new ProductDbTable
                {
                    Name = NewProduct.ProductName,
                    Price = NewProduct.ProductPrice,
                    Brand = NewProduct.ProductBrand,
                    Year = NewProduct.ProductYear,

                };

            using (var DbContext = new ProductContext())
            {
                DbContext.Products.Add(newProduct);
                DbContext.SaveChanges();

            }




        }


    }
}
