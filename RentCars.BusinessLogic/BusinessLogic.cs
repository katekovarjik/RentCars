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
        public ICalculation GetCalculationBL()
        {
            return new CalculationBL();
        }

        public IRegister GetRegisterBL()
        {
            return new RegisterBL();
        }

        public IAddCar GetAddCarBL() 
        {
            return new AddCarBL();
        }
        public IPricing GetPricingBL()
        {
            return new PricingBL();
        }
        public ICars GetCarsBL()
        {
            return new CarsBL();
        }
    }

}
