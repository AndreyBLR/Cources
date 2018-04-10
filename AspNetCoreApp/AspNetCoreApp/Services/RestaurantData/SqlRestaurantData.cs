using System.Collections.Generic;
using System.Linq;
using AspNetCoreApp.Data;
using AspNetCoreApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreApp.Services.RestaurantData
{
    public class SqlRestaurantData:IRestaurantData
    {
        private readonly AppDbContext _context;

        public SqlRestaurantData(AppDbContext context)
        {
            _context = context;
        }

        public IList<Restaurant> GetAll()
        {
            return _context.Restaurants.OrderBy(item => item.Name).ToList();
        }

        public Restaurant Get(int id)
        {
            return _context.Restaurants.FirstOrDefault(item => item.Id == id);
        }

        public Restaurant Add(Restaurant newRestaurant)
        {
            _context.Restaurants.Add(newRestaurant);
            _context.SaveChanges();

            return newRestaurant;
        }

        public Restaurant Update(Restaurant restaurant)
        {
            _context.Attach(restaurant).State = EntityState.Modified;
            _context.SaveChanges();

            return restaurant;
        }
    }
}
