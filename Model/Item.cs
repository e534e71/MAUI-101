namespace Lesson.Model;
public class Info
{
  [JsonProperty("seed")]
  public string Seed { get; set; }

  [JsonProperty("results")]
  public int? Results { get; set; }

  [JsonProperty("page")]
  public int? Page { get; set; }

  [JsonProperty("version")]
  public string Version { get; set; }
}
