using RentCars.BusinessLogic.Interfaces;
using RentCars.BusinessLogic.MainBL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCars.BusinessLogic
{
    public class BusinessLogic
    {
        public ISession GetSessionBL()
        {
            return new SessionBL();
        }
        public IProduct GetProductBL()
        {
            return new ProductBl();
        }
    }
}
