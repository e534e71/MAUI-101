namespace Lesson.Model;
public class Id
{
  [JsonProperty("name")]
  public string Name { get; set; }

  [JsonProperty("value")]
  public object Value { get; set; }
}
