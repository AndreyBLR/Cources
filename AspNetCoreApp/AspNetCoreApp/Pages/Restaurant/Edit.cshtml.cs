using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreApp.Services.Greeter;
using AspNetCoreApp.Services.RestaurantData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreApp.Pages.Restaurant
{
    public class EditModel : PageModel
    {
        private readonly IGreeter _greeter;
        private readonly IRestaurantData _restaurantData;

        public string MessageOfDay => _greeter.GetGreeting();

        [BindProperty]
        public Models.Restaurant Restaurant { get; set; }

        public EditModel(IRestaurantData restaurantData, IGreeter greeter)
        {
            _restaurantData = restaurantData;
            _greeter = greeter;
        }

        public IActionResult OnGet(int id)
        {
            Restaurant = _restaurantData.Get(id);

            if (Restaurant == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _restaurantData.Update(Restaurant);
                return RedirectToAction("Details", "Home", new {id=Restaurant.Id} );
            }

            return Page();
        }
    }
}