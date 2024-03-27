using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCars.Domain.Entities.Product
{
    public class ProductDataModel
    {
       public DB.Product SingleProduct { get; set; }
       public List<DB.Product> Products { get; set; }
    }
}
