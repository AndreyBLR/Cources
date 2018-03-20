using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreApp.Controllers
{
    [Route("company/[controller]/[action]")]
    public class AboutController : Controller
    {
        public string Phone()
        {
            
            return "+375-29-111-24-89";
        }
    }
}
