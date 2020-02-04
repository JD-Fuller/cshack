using System;
using System.Collections.Generic;
using cshack.Models;
using cshack.DB;
using Microsoft.AspNetCore.Mvc;
using cshack.Services;

namespace cshack.Controllers
{
  [ApiController]  //NOTE Notifies compiler this is to be registered as a controller
  [Route("api/[controller]")] //NOTE RoutePath "Burgers"
  public class BurgersController : ControllerBase
  {
    private readonly BurgersService _bs;
    public BurgersController(BurgersService bs) //DEPENDENCY INJECTION
    {
      _bs = bs;
    }

    [HttpGet] //NOTE this route is 'api/burgers'
    public ActionResult<IEnumerable<Burger>> Get()
    {
      try
      {
        return Ok(_bs.Get());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")] //NOTE this route is 'api/burgers/:id'
    public ActionResult<Burger> Get(int id)
    {
      try
      {
        return Ok(_bs.GetById(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }


    [HttpPost]
    public ActionResult<Burger> Create([FromBody] Burger newData) //NOTE "From the body, create a burger called newBurger")
    {
      try
      {
        return Ok(_bs.Create(newData));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPut("{id}")]
    public ActionResult<Burger> Edit([FromBody] Burger update, int id )
    {
      try
      {
        update.Id = id;
        return Ok(_bs.Edit(update));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<String> Delete(int id)
    {
      try
      {
        return Ok(_bs.Delete(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}