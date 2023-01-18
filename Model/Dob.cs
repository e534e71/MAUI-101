namespace Lesson.Model;
public class Dob
{
  [JsonProperty("date")]
  public DateTime? Date { get; set; }

  [JsonProperty("age")]
  public int? Age { get; set; }
}
