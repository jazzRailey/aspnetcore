﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood.Data;
using OdeToFood.Models;

namespace OdeToFood.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly OdeToFoodDbContext _context;

        public SqlRestaurantData(OdeToFoodDbContext context)
        {
            _context = context;
        }

        public Restaurant Add(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant);
            _context.SaveChanges();
            return restaurant;
        }

        public Restaurant Get(int Id)
        {
            return _context.Restaurants.FirstOrDefault(r => r.Id == Id);
        }

        public List<Restaurant> GetAllRestaurants()
        {
            return _context.Restaurants.OrderBy(r => r.Name).ToList();
        }

        
    }
}
