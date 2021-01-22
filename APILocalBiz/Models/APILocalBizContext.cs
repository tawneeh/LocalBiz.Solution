using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using Systems.Linq;

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

          .HasData();

      builder.Entity<Restaurant>()

          .HasData();
    }
  }
}