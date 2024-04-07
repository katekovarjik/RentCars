﻿using RentCars.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCars.BusinessLogic.DBModel.Seed
{
    public class UserContext: DbContext
    {
        public UserContext() : base(nameOrConnectionString: "name=RentCars")
        {
            
        }


        public virtual DbSet<UDbTable> Users { get; set; }  
    }
}