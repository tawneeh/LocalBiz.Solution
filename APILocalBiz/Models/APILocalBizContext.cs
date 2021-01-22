using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;

namespace APILocalBiz.Models
{
  public class APILocalBizContext : DbContext
  {
    public APILocalBizContext(DbContextOptions<APILocalBizContext> options) : base(options)
    {
    }

    public DbSet<Shop> Shops { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Shop>()

          .HasData(
              new Shop { ShopId = 1, Name = "Francesca's", Phone = "425-775-4712", Specialty = "Women's Fashion", Recommended = true },

              new Shop { ShopId = 2, Name = "Central Market", Phone = "425-357-3240", Specialty = "Gourmet Grocery", Recommended = true },

              new Shop { ShopId = 3, Name = "Mill Geek Comics", Phone = "425-415-6666", Specialty = "Comic books", Recommended = true }
          );

      builder.Entity<Restaurant>()

          .HasData(
              new Restaurant { RestaurantId = 1, Name = "El Gaucho", Phone = "206-728-1337", Cuisine = "Steak", Recommended = true },

              new Restaurant { RestaurantId = 2, Name = "Kafe Neo", Phone = "425-375-0512", Cuisine = "Greek", Recommended = true },

              new Restaurant { RestaurantId = 3, Name = "Sushi Spott", Phone = "425-338-4553", Cuisine = "Japanese", Recommended = false }
          );
    }
  }
}