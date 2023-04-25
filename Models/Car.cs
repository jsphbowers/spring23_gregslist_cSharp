namespace gregslist_cSharp.Models;

public class Car
{
  public int Id { get; set; }
  public string Make { get; set; }
  public string Model { get; set; }
  public int? Price { get; set; }
  public bool? HasTires { get; set; }
  public int Year { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }

  // [RegularExpression("/^#(?:(?:[\da-f]{3}){1,2}|(?:[\da-f]{4}){1,2})$/i")]
  public string Color { get; set; }
}