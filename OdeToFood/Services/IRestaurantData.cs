using OdeToFood.Models;
using System.Collections.Generic;

namespace OdeToFood.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAllRestaurants();
        Restaurant Get(int Id);
        Restaurant Add(Restaurant restaurant);
    }
}
