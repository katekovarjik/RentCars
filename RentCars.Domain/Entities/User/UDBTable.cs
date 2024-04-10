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
    public class UDBTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 5)] 
        public string UserName { get; set; }
        [Required]
        [StringLength(30)]
        public int Password { get; set; }
        [Required]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime LastLogin {  get; set; }
        public string LastIP { get; set;}
        [Required]
        public URole Level { get; set; }
    }
}
