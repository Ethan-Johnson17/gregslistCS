using Microsoft.AspNetCore.Mvc;
using gregslistCS.Services;
using gregslistCS.Models;

namespace gregslistCS.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class HousesController : ControllerBase
  {
    private readonly HousesService _hs;
    public HousesController(HousesService hs)
    {
      _hs = hs;
    }

    [HttpGet]
    public ActionResult<IEnumerable<House>> Get()
    {
      try
      {
        List<House> houses = _hs.Get();
        return Ok(houses);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}