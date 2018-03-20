using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreApp.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            var model = new Restaurant() {Id = 1, Name = "Pomidor"};
            return new ObjectResult(model);
        }
    }
}
