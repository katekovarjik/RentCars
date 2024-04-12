using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCars.Domain.Entities.User.DB
{
    public class ProductDBTable
    {
        [Key]         // уникальный идентификатор каждой записи 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //бд создает уникальное значение
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)] 
        public string Brand { get; set; }

        [Required]
        public decimal Price { get; set; } 

        [Required]
        public string TechnicalSpecifications { get; set; } 

       
        public string Photo { get; set; }


    }
}
