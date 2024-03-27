using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCars.Domain.Entities.User
{
    public class UserLoginData   //сущность
    {
        public string Credential { get; set; }
        public string Password { get; set; }
        public string   IP { get; set; }
        public DateTime FirstLoginTime { get; set; }
    }
}
