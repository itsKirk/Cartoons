namespace Cartoons.Core.Models
{
  public class Cartoon
  {
    public string title { get; set; }
    public int year { get; set; }
    public string[] creator { get; set; }
    public string rating { get; set; }
    public string[] genre { get; set; }
    public int runtime_in_minutes { get; set; }
    public int episodes { get; set; }
    public string image { get; set; }
    public int id { get; set; }
  }
}
