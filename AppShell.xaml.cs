namespace Lesson;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(AllUsersPage),typeof(AllUsersPage));
	}
}
