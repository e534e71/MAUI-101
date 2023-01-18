using CommunityToolkit.Mvvm.ComponentModel;

namespace Lesson.ViewModel;

public partial class BaseViewModel : ObservableObject
{
  public BaseViewModel()
  {

  }

  [ObservableProperty]
  string title;

  [ObservableProperty]
  [NotifyPropertyChangedFor(nameof(IsNotBusy))]
  bool isBusy;

  bool IsNotBusy => !isBusy;
}
