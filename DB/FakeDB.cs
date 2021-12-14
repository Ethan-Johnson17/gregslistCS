using gregslistCS.Models;

namespace gregslistCS.DB
{
  public static class FakeDB
  {
    public static List<Car>? Cars { get; set; } = new List<Car>(){
      new Car(2021, 200000, "Ferrari", "458 Italia", "https://ag-spots-2021.o.auroraobjects.eu/2021/01/13/thumbs/ferrari-458-italia-c102313012021132917_1.jpg"),
      new Car(1968, 60000, "Chevy", "Camaro SS", "https://ccmarketplace.azureedge.net/cc-temp/listing/98/7828/7985843-1968-chevrolet-camaro-std.jpg"),
      new Car(1960, 1000, "Mini", "Cooper", "https://i.ebayimg.com/00/s/OTc4WDEwMjQ=/z/jmsAAOSwW8lef0rc/$_86.JPG")
    };
    public static List<House>? Houses { get; set; } = new List<House>(){
      new House(2021, 200000, "3000SqFt"),
      new House(1968, 60000, "3400SqFt"),
      new House(1960, 1000, "700SqFt")
    };
  }
}