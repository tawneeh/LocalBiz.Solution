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
  }
}