using Microsoft.AspNetCore.Mvc;
using gregslistCS.Services;
using gregslistCS.Models;

namespace gregslistCS.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CarsController : ControllerBase
  {
    private readonly CarsService _cs;
    public CarsController(CarsService cs)
    {
      _cs = cs;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Car>> Get()
    {
      try
      {
        List<Car> cars = _cs.Get();
        return Ok(cars);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<Car> Get(string id)
    {
      try
      {
        Car car = _cs.Get(id);
        return Ok(car);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Car> Create([FromBody] Car newCar)
    {
      try
      {
        Car car = _cs.Create(newCar);
        return Ok(car);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPut("{id}")]
    // Translation: req.body => [FromBody]
    public ActionResult<Car> Create([FromBody] Car updatedCar, string id)
    {
      try
      {
        updatedCar.Id = id;
        Car car = _cs.Update(updatedCar);
        return Ok(car);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }


    [HttpDelete("{id}")]
    public ActionResult<String> Remove(string id)
    {
      try
      {
        _cs.Remove(id);
        return Ok("Sold");
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

  }
}