namespace Lesson.Model;
public class Name
{
  [JsonProperty("title")]
  public string Title { get; set; }

  [JsonProperty("first")]
  public string First { get; set; }

  [JsonProperty("last")]
  public string Last { get; set; }
}
