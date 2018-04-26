using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreApp.Models;

namespace AspNetCoreApp.ViewModels.Home
{
    public class IndexViewModel
    {
        public string MessageOfDay { get; set; }
        public IList<Restaurant> Restaurants { get; set; }
    }
}
