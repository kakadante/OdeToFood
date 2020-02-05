using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {Id = 1, Name = "Debonairs Pizza", Location = "Machakos", Cuisine = CuisineType.Mexican},
                new Restaurant {Id = 2, Name = "Kuku", Location = "Nairobi", Cuisine = CuisineType.Italian},
                new Restaurant {Id = 3, Name = "Chips", Location = "Naks", Cuisine = CuisineType.Indian},
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                orderby r.Name
                select r;
        }
    }
}
