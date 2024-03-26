using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentCars.Models
{
    public class ProductModel
    {
        public ProductPresentation SingleProduct { get; set; }
        public List<ProductPresentation> Products { get; set;}
    }
}