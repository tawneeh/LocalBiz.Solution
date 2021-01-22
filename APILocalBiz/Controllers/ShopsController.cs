using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using APILocalBiz.Models;

namespace APILocalBiz.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ShopsController : ControllerBase
  {
    private APILocalBizContext _db;

    public ShopsController(APILocalBizContext db)
    {
      _db = db;
    }

    // GET api/shops
    [HttpGet]
    public ActionResult<IEnumerable<Shop>> Get(string name, string phone, string specialty, bool recommended)
    {
      var query = _db.Shops.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (specialty != null)
      {
        query = query.Where(entry => entry.Specialty == specialty);
      }

      if (recommended == true || false)
      {
        query = query.Where(entry => entry.Recommended == recommended);
      }

      return query.ToList();
    }

    // POST api/shops
    [HttpPost]
    public void Post([FromBody] Shop shop)
    {
      _db.Shops.Add(shop);
      _db.SaveChanges();
    }

    // GET api/shops/3  
    [HttpGet("{id}")]
    public ActionResult<Shop> Get(int id)
    {
      return _db.Shops.FirstOrDefault(entry => entry.ShopId == id);
    }

    // PUT api/shops/3
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Shop shop)
    {
      shop.ShopId = id;
      _db.Entry(shop).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/shops/3
    [HttpDelete("{id}")]
      public void Delete(int id)
      {
        var shopToDelete = _db.Shops.FirstOrDefault(entry => entry.ShopId == id);
        _db.Shops.Remove(shopToDelete);
        _db.SaveChanges();
      }   
  }
}