using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreApp.Services.Greeter;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreApp.ViewComponents
{
    public class GreeterViewComponent:ViewComponent
    {
        private readonly IGreeter _greeter;

        public GreeterViewComponent(IGreeter greeter)
        {
            _greeter = greeter;
        }

        public IViewComponentResult Invoke()
        {
            var model = _greeter.GetGreeting();
            return View("Default", model);
        }
    }
}
