using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCars.Domain.Entities.Calculation
{
    public class CalcDataDays
    {
        public decimal takeDay {  get; set; }
        public decimal returnDay {  get; set; }
        public int price { get; set; }
    }
}
