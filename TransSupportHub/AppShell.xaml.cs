namespace TransSupportHub;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(MenuPage), typeof(MenuPage));
		Routing.RegisterRoute(nameof(GenderClinicPage), typeof(GenderClinicPage));
		Routing.RegisterRoute(nameof(LocationPage), typeof(LocationPage));
		Routing.RegisterRoute(nameof(HelpCommunityPage), typeof(HelpCommunityPage));
		Routing.RegisterRoute(nameof(BusinessFormPage), typeof(BusinessFormPage));
		Routing.RegisterRoute(nameof(FeedbackPage), typeof(FeedbackPage));
		Routing.RegisterRoute(nameof(AgePage), typeof(AgePage));
		Routing.RegisterRoute(nameof(EventsPage), typeof(EventsPage));
	}
}
