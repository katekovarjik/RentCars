﻿using RentCars.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCars.Domain.Entities.GeneralResponses
{
    public class RResponseData
    {
        public bool Status {  get; set; }
        public string ResponceMessage { get; set; } // что выведется при ошибке

        public UDbTable CurrentUser { get; set; }
    }
}
