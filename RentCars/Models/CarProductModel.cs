using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RentCars.Models
{
    public class CarProductModel
    {        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "The ProductName field is required.")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "The ProductPrice field is required.")]
        public int ProductPrice { get; set; }

        [Required(ErrorMessage = "The ProductBrand field is required.")]
        public string ProductBrand {  get; set; }

        [Required(ErrorMessage = "The ProductYear field is required.")]
        public int ProductYear { get; set; }

    }
}