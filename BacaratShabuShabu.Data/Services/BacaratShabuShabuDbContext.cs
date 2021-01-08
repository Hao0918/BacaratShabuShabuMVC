using BacaratShabuShabu.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacaratShabuShabu.Data.Services
{
    public class BacaratShabuShabuDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
