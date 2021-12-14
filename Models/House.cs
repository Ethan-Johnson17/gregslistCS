using System.ComponentModel.DataAnnotations;

namespace gregslistCS.Models
{
  public class House
  {
    public House(int year, int price, string? size)
    {
      Id = Guid.NewGuid().ToString();
      Year = year;
      Price = price;
      Size = size;
    }

    public string? Id { get; set; }
    [Required]
    public int Year { get; set; }
    [Required]
    public int Price { get; set; }
    [Required]
    public string? Size { get; set; }
  }
}