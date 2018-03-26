using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreApp.Models;

namespace AspNetCoreApp.ViewModels.Home
{
    public class RestaurantEditModel
    {
        public string Name { get; set; }
        public CuisineType CuisineType { get; set; }
    }
}
