namespace Lesson;
public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<BaseViewModel>();

		builder.Services.AddSingleton<AllUsersPage>().AddSingleton<AllUsersPageViewModel>();

		builder.Services.AddSingleton<UserService>();

		return builder.Build();
	}
}
