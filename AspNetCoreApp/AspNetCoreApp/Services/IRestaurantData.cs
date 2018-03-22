using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreApp.Models;

namespace AspNetCoreApp.Services
{
    public interface IRestaurantData
    {
        IList<Restaurant> GetAll();
        Restaurant Get(int id);
    }
}
