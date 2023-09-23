using TransSupportHub.Helpers;

namespace TransSupportHub;

public partial class App : Application
{
	public static Realms.Sync.App RealmApp;
	public App()
	{
		InitializeComponent();		

        MainPage = new AppShell();

	}
}
