using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentCars.Models
{
    public class ProductPresentation
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public ProductPresentation()
        {
            Name = string.Empty;
            Price = 0;
        }
    }
}