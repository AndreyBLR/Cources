using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }

        public AppDbContext(DbContextOptions options) : base(options){}
    }
}
