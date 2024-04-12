using RentCars.Domain.Enum.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCars.Domain.Entities.Product.DB
{
    public class ProductDbTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }


        [Required]
        public string Brand { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public int Year { get; set; }


    }
}
