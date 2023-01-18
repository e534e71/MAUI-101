namespace Lesson.Model;
public class Registered
{
  [JsonProperty("date")]
  public DateTime? Date { get; set; }

  [JsonProperty("age")]
  public int? Age { get; set; }
}