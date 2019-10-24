﻿using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using FoodHunter.Web.DataLayer;

namespace FoodHunter.Web.DataLayer
{
    class RestaurantRepository : IRestaurantRepository
    {
        readonly DataContext _context;
        public RestaurantRepository()
        {
            _context = new DataContext();
        }

        public List<Restaurant> GetAll()
        {
            return _context.Restaurants.ToList();
        }

        public Restaurant Get(int id)
        {
            return _context.Restaurants.SingleOrDefault(e => e.RestaurantId == id);
        }

        public int Insert(Restaurant restaurant)
        {
            this._context.Restaurants.Add(restaurant);

            return this._context.SaveChanges();
        }

        public int Update(Restaurant restaurant)
        {
            Restaurant userToUpdate = _context.Restaurants.SingleOrDefault(e => e.RestaurantId == restaurant.RestaurantId);
            foreach (PropertyInfo property in typeof(Restaurant).GetProperties())
            {
                property.SetValue(userToUpdate, property.GetValue(restaurant, null), null);
            }

            return _context.SaveChanges();
        }

        public int Delete(int id)
        {
            Restaurant restaurantToDelete = _context.Restaurants.SingleOrDefault(e => e.RestaurantId == id);
            if (restaurantToDelete != null) _context.Restaurants.Remove(restaurantToDelete);

            return _context.SaveChanges();
        }
    }
}
