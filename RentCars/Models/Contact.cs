using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace RentCars.Models
{
    public class Contact
    {
        [Display(Name = "Введите Имя")]
        public string UserName {  get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }

    }
}