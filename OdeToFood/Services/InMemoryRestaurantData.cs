using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood.Models;

namespace OdeToFood.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> _retaurants;

        public Restaurant Add(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        public Restaurant Get(int Id)
        {
            return GetAllRestaurants().FirstOrDefault(r => r.Id == Id);
        }

        public List<Restaurant> GetAllRestaurants()
        {
            _retaurants = new List<Restaurant>
            {
                new Restaurant{ Id= 1, Name="Henry's Restaurant" },
                new Restaurant{ Id= 2, Name="Marites's Restaurant" },
                new Restaurant{ Id= 3, Name="Hannah's Restaurant" }
            };

            return _retaurants;
        }

        
    }
}
