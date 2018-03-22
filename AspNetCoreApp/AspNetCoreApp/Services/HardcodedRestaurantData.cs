using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreApp.Models;

namespace AspNetCoreApp.Services
{
    public class HardcodedRestaurantData:IRestaurantData
    {
        private List<Restaurant> _restaurants;

        public HardcodedRestaurantData()
        {
            _restaurants = new List<Restaurant>()
            {
                new Restaurant() {Id = 1, Name = "Restaurant 1"},
                new Restaurant() {Id = 2, Name = "Restaurant 2"},
                new Restaurant() {Id = 3, Name = "Restaurant 3"}
            };
        }

        public IList<Restaurant> GetAll()
        {
            return _restaurants;
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(item => item.Id == id);
        }
    }
}
