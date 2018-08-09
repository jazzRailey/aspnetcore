using OdeToFood.Models;
using System.Collections.Generic;

namespace OdeToFood.Services
{
    public interface IRestaurantData
    {
        List<Restaurant> GetAllRestaurants();
        Restaurant Get(int Id);
        Restaurant Add(Restaurant restaurant);
    }
}
