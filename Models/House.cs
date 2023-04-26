
namespace gregslist_cSharp.Models;

public class House
{
  public int beds { get; set; }
  public int baths { get; set; }
  public int year { get; set; }
  public int price { get; set; }
  public int levels { get; set; }
  public bool hasWindows { get; set; }
  public DateTime createdAt { get; set; }
  public DateTime updatedAt { get; set; }
  public string color { get; set; }
}
