using Lesson.Model;
using System.Net.Http.Json;

namespace Lesson.Services;

public class UserService
{
     readonly HttpClient httpClient;

  public UserService()
  {
    httpClient = new HttpClient();
  }

  UserModel not = new();
  readonly List<Result> UserList = new();

  public async Task<UserModel> GetAnnouncements()
  {

    var url = "https://randomuser.me/api/?results=20&nat=tr&exc=login";

    var response = await httpClient.GetAsync(url);

    if (response.IsSuccessStatusCode)
    {
      not = await response.Content.ReadFromJsonAsync<UserModel>();
    }
    
    foreach (var datas in not.Results)
    {
      UserList.Add(datas);
    }

    return not;
  }
}
