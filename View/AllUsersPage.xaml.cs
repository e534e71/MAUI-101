namespace Lesson.View;

public partial class AllUsersPage : ContentPage
{

  public AllUsersPage(AllUsersPageViewModel viewModel)
	{
    BindingContext = viewModel;
		InitializeComponent();
	}
	

}