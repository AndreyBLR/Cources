using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreApp.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Required, MinLength(10), Display(Name = "Restaurant Name")]
        public string Name { get; set; }

        public CuisineType CuisineType { get; set; }
    }
}
