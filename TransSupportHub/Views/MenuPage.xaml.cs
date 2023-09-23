using Realms.Sync;
using TransSupportHub.Helpers;

namespace TransSupportHub.Views;

public partial class MenuPage : ContentPage
{
	public MenuPage(MenuViewModel viewModel)
	{
		InitializeComponent();
		Task.Run(async () =>
		{
			await RealmLogin();
		});

		BindingContext = viewModel;
	}

	private async Task RealmLogin()
	{
		try
		{
			await App.RealmApp.LogInAsync(Credentials.EmailPassword(AppConfig.RealmUsername, AppConfig.RealmPW));
		} catch (Exception ex)
		{
			await App.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
		}
	}
}
