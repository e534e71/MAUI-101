namespace Lesson.Model;
public class UserModel
{
  [JsonProperty("results")]
  public IEnumerable<Result> Results { get; set; }

  [JsonProperty("info")]
  public Info Info { get; set; }
}