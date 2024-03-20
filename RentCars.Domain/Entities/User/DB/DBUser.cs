using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCars.Domain.Entities.User.DB
{
    public class DBUser
    {
        public string UserName {  get; set; }
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
