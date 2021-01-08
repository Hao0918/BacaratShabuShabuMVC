using BacaratShabuShabu.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacaratShabuShabu.Data.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly BacaratShabuShabuDbContext db;

        public SqlRestaurantData(BacaratShabuShabuDbContext db)
        {
            this.db = db;
        }
        public void Add(Restaurant restaurant)
        {
            db.Restaurants.Add(restaurant);
            db.SaveChanges();
        }

        public void Delete(Restaurant restaurant)
        {
            var entry = db.Entry(restaurant);
            entry.State = EntityState.Deleted;
            db.SaveChanges();
        }

        public Restaurant Get(int id)
        {
            return db.Restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return db.Restaurants.OrderBy(r => r.Name);
        }

        public void Update(Restaurant restaurant)
        {
            var entry = db.Entry(restaurant);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
