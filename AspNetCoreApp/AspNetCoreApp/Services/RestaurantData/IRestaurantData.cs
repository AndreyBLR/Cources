using System.Collections.Generic;
using AspNetCoreApp.Models;

namespace AspNetCoreApp.Services.RestaurantData
{
    public interface IRestaurantData
    {
        IList<Restaurant> GetAll();
        Restaurant Get(int id);
        Restaurant Add(Restaurant newRestaurant);
        Restaurant Update(Restaurant restaurant);
    }
}
