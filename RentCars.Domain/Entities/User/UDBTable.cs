using RentCars.Domain.Enum.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCars.Domain.Entities.User
{
    public class UDbTable
    {

        [Key]         // уникальный идентификатор каждой записи 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //бд создает уникальное значение
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string Name { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 8)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime LastLogin { get; set; }

        public string LastIp { get; set; }
        [Required]
        public URole Level { get; set; }



      

    }
}
