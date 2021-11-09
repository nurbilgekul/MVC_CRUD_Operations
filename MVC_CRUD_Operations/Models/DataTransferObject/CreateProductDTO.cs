using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_CRUD_Operations.Models.DataTransferObject
{
    public class CreateProductDTO
    {
        [Required(ErrorMessage = "Must to type into name")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        [MinLength(2, ErrorMessage ="Minumum length is 2")]
        public string ProductName { get; set; }
        
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int Stock { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter valid doubleNumber")]
        public double Price { get; set; }
    }
}