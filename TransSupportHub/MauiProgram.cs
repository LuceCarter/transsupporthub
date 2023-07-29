namespace TransSupportHub;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.UseMauiMaps()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<MenuViewModel>();
        builder.Services.AddSingleton<MenuPage>();

        builder.Services.AddSingleton<WelcomeViewModel>();
        builder.Services.AddSingleton<WelcomePage>();

		builder.Services.AddSingleton<GenderClinicViewModel>();
		builder.Services.AddSingleton<GenderClinicPage>();

		return builder.Build();
	}
}
