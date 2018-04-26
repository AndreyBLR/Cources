using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreApp.Models;

namespace AspNetCoreApp.ViewModels.Home
{
    public class RestaurantEditModel
    {
        [Required, MinLength(10), Display(Name = "Restaurant Name")]
        public string Name { get; set; }

        public CuisineType CuisineType { get; set; }
    }
}
