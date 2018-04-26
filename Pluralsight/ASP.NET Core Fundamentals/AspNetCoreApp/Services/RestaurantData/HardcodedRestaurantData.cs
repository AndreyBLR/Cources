using System.Collections.Generic;
using System.Linq;
using AspNetCoreApp.Models;

namespace AspNetCoreApp.Services.RestaurantData
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

        public Restaurant Add(Restaurant newRestaurant)
        {
            newRestaurant.Id = _restaurants.Max(item => item.Id) + 1;

            _restaurants.Add(newRestaurant);

            return newRestaurant;
        }

        public Restaurant Update(Restaurant restaurant)
        {
            throw new System.NotImplementedException();
        }
    }
}
