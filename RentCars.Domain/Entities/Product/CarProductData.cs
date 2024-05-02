using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCars.Domain.Entities.Product
{
    public class CarProductData
    {
        public string ProductName { get; set; }

        public int ProductPrice { get; set; }

        public string ProductBrand { get; set; }

        public int ProductYear { get; set; }    
        public string Image { get; set; }
    }
}
