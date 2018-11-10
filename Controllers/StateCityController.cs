using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Relocator.Models;
using Microsoft.EntityFrameworkCore;

namespace Relocator.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class StateCityController : ControllerBase
  {
    [HttpGet]
    public IEnumerable<States> Get()
    {
      var db = new RelocatorContext();
      return db.States.OrderBy(o => o.Id);

    }
    // [HttpGet("{StateName}")]
    // public IEnumerable<States> GetByStateName(string statename)
    // {
    //   var db = new RelocatorContext();
    //   return db.States.Where(w => w.StateName.ToLower() == statename.ToLower());
    // }

  }
}