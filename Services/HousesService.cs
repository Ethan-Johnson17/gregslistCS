using gregslistCS.DB;
using gregslistCS.Models;

namespace gregslistCS.Services
{
  public class HousesService
  {
    internal List<House> Get()
    {
      return FakeDB.Houses;
    }
  }
}