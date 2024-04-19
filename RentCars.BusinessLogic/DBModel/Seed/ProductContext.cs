using RentCars.Domain.Entities.Product.DB;
using RentCars.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCars.BusinessLogic.DBModel.Seed
{


    public class ProductContext : DbContext
    {
        public ProductContext() : base(nameOrConnectionString: "name=RentCars") //конструктор 
        {

        }

        public virtual DbSet<ProductDbTable> Products { get; set; }
    }
}
