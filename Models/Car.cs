using System.ComponentModel.DataAnnotations;

namespace gregslistCS.Models
{
  public class Car
  {
    public Car(int year, int price, string? make, string? model, string? imageUrl)
    {
      Id = Guid.NewGuid().ToString();
      Year = year;
      Price = price;
      Make = make;
      Model = model;
      ImageUrl = imageUrl;
    }

    public string? Id { get; set; }
    [Required]
    public int Year { get; set; }
    [Required]
    public int Price { get; set; }
    [Required]
    public string? Make { get; set; }
    [Required]
    public string? Model { get; set; }
    public string? ImageUrl { get; set; }
  }
}