using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using APILocalBiz.Models;

namespace APILocalBiz.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class RestaurantsController : ControllerBase
  {
    private APILocalBizContext _db;

    public RestaurantsController(APILocalBizContext db)
    {
      _db = db;
    }

    // GET api/restaurants
    [HttpGet]
    public ActionResult<IEnumerable<Restaurant>> Get(string name, string phone, string cuisine, bool recommended)
    {
      var query = _db.Restaurants.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (cuisine != null)
      {
        query = query.Where(entry => entry.Cuisine == cuisine);
      }

      if (recommended == true || false)
      {
        query = query.Where(entry => entry.Recommended == recommended);
      }

      return query.ToList();
    }

    // POST api/restaurants
    [HttpPost]
    public void Post([FromBody] Restaurant restaurant)
    {
      _db.Restaurants.Add(restaurant);
      _db.SaveChanges();
    }

    // GET api/restaurants/3
    [HttpGet("{id}")]
    public ActionResult<Restaurant> Get(int id)
    {
      return _db.Restaurants.FirstOrDefault(entry => entry.RestaurantId == id);
    }

    // PUT api/restaurants/3
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Restaurant restaurant)
    {
      restaurant.RestaurantId = id;
      _db.Entry(restaurant).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/restaurants/3
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var restaurantToDelete = _db.Restaurants.FirstOrDefault(entry => entry.RestaurantId == id);
      _db.Restaurants.Remove(restaurantToDelete);
      _db.SaveChanges();
    }
  }
}