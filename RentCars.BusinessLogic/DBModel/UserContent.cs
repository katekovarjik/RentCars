using RentCars.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCars.BusinessLogic.DBModel
{
    public class UserContent : DbContext
    {
        public UserContent() : base("name = RentCars")
        {
        }

        //моедь таблицы (архитектура)
        public virtual DbSet<UDBTable>Users { get; set; }

    }

}
