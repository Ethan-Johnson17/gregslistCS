using gregslistCS.DB;
using gregslistCS.Models;


namespace gregslistCS.Services
{
  public class CarsService
  {
    internal List<Car> Get()
    {
      return FakeDB.Cars;
    }

    internal Car Get(string id)
    {
      Car found = FakeDB.Cars.Find(c => c.Id == id);
      if (found == null)
      {
        throw new Exception("Invalid ID");
      }
      return found;
    }

    internal Car Create(Car newCar)
    {
      FakeDB.Cars.Add(newCar);
      return newCar;
    }

    internal void Remove(string id)
    {
      Car car = Get(id);
      FakeDB.Cars.Remove(car);
    }

    internal Car Update(Car updatedCar)
    {
      Car oldCar = Get(updatedCar.Id);
      // NOTE updates will be done like this to prevent accidentally setting values to null if they are not passed by the client
      oldCar.Year = updatedCar.Year != 0 ? updatedCar.Year : oldCar.Year;
      oldCar.Price = updatedCar.Price != 0 ? updatedCar.Price : oldCar.Price;
      oldCar.Make = updatedCar.Make != null ? updatedCar.Make : oldCar.Make;
      oldCar.Model = updatedCar.Model != null ? updatedCar.Model : oldCar.Model;
      // save to DB
      return oldCar;
    }
  }
}
