using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCars.Domain.Entities.Calculation
{
    public class CalcDataDays
    {
        public DateTime takeDay {  get; set; }
        public DateTime returnDay {  get; set; }
        public int price { get; set; }
    }
}
