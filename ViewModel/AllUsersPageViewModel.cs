
namespace Lesson.ViewModel;

public partial class AllUsersPageViewModel : BaseViewModel
{
  UserModel Not = new();
  public ObservableCollection<Result> UserList { get; } = new();

  private readonly UserService userService;

  public AllUsersPageViewModel(UserService userService)
  {
    
    Title = $"Cukurova\r\nUniversity";
    this.userService = userService;
  }

  [RelayCommand]
  async Task GetUsers()
  {
    if (IsBusy) return;
    try
    {
      IsBusy = true;

      Not = await userService.GetAnnouncements();

      if (UserList.Count != 0) UserList.Clear();


      foreach (var result in Not.Results)
      {
        UserList.Add(result);
      }

    }
    catch (Exception e)
    {
      await Shell.Current.DisplayAlert("alert", e.Message, "OK");
    }
    finally
    {
      IsBusy = false;
    }
  }
}
