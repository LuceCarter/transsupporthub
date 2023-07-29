namespace TransSupportHub.Views;

public partial class LocationPage : ContentPage
{
	public LocationPage()
	{
		InitializeComponent();
		BindingContext = new LocationViewModel();
	}
}